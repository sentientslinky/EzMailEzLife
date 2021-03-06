﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.ComponentModel;

namespace EzMailEzLife
{
    public class ServiceManager
    {
        static string[] Scopes = { GmailService.Scope.MailGoogleCom, GmailService.Scope.GmailSend };
        static string ApplicationName = "Gmail API Quickstart";

        private static ServiceManager _instance;

        public GmailService GmailSer
        {
            get;
            private set;
        }

        private ServiceManager(GmailService gmailSer)
        {
            GmailSer = gmailSer;
        }
        public static ServiceManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    UserCredential credential;

                    using (var stream =
                        new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
                    {
                        string credPath = System.Environment.GetFolderPath(
                            System.Environment.SpecialFolder.Personal);
                        credPath = Path.Combine(credPath, ".credentials");

                        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                            GoogleClientSecrets.Load(stream).Secrets,
                            Scopes,
                            "user",
                            CancellationToken.None,
                            new FileDataStore(credPath, true)).Result;
                        Console.WriteLine("Credential file saved to: " + credPath);

                        var gmailS = new GmailService(new BaseClientService.Initializer()
                        {
                            HttpClientInitializer = credential,
                            ApplicationName = ApplicationName,
                        });
                        _instance = new ServiceManager(gmailS);
                    }
                }
                return _instance;
            }
        }

        public ListMessagesResponse TestFunction()
        {
            UsersResource.MessagesResource.ListRequest request = GmailSer.Users.Messages.List("me");
            request.MaxResults = 10;
            request.LabelIds = new string[] { "UNREAD", "CATEGORY_UPDATES" };
            ListLabelsResponse response = GmailSer.Users.Labels.List("me").Execute();
            
            foreach (Label label in response.Labels)
            {
                Console.WriteLine(label.Id + " - " + label.Name);
            }
            return request.Execute();
        }

        private ListMessagesResponse GetEmails(string[] labels, int limit)
        {
            UsersResource.MessagesResource.ListRequest request = GmailSer.Users.Messages.List("me");
            request.MaxResults = limit;
            request.LabelIds = labels; //= new string[] { "UNREAD", "CATEGORY_UPDATES" };
            return request.Execute();
        }

        public Message GetEmailInformation(string messageId)
        {
            UsersResource.MessagesResource.GetRequest request = GmailSer.Users.Messages.Get("me", messageId);
            return request.Execute();
        }

        public int GetUnreadEmails()
        {
            var emails = ServiceManager.Instance.GetEmailsFromSelectedSenders( UserManager.Instance.GetAllApprovedUsers(), true);
            if (emails.Messages == null)
                return 0;

            return emails.Messages.Count;
        }

        public ListMessagesResponse GetEmailsFromSelectedSenders(List<ApprovedUser> sendersList = null, bool unreadOnly = true, int limit = 10, int dayLimit = 30)
        {
            UsersResource.MessagesResource.ListRequest request = GmailSer.Users.Messages.List("me");
            request.MaxResults = 10;
            List<string> labelList = new List<string>();
            labelList.Add(NormalInboxLabel);
            if(unreadOnly)
                labelList.Add(UnreadLabel);

            request.Fields = "messages";
            //request.LabelIds = labelList.ToArray();
            request.Q = "(";
            if (sendersList != null)
            {
                foreach (var email in sendersList)
                {
                    if (request.Q != "(")
                    {
                        request.Q += " OR ";
                    }
                    request.Q += "from: " + email.UserEmail;
                }
            }

            request.Q += ") ";
            if(dayLimit != -1)
            {
                request.Q += "after:"+( DateTime.Now.Subtract(TimeSpan.FromDays(dayLimit))).ToString("yyyy/MM/dd");
            }

            if(unreadOnly)
                request.Q += " label:" + UnreadLabel;

            request.Q += " label:" + NormalInboxLabel;
            return request.Execute();
        }

        public ListThreadsResponse GetThreadsFromSelectedSenders(List<ApprovedUser> sendersList = null, bool unreadOnly = true, int limit = 10)
        {
            UsersResource.ThreadsResource.ListRequest request = GmailSer.Users.Threads.List("me");
            request.MaxResults = 10;
            List<string> labelList = new List<string>();
            labelList.Add(NormalInboxLabel);
            if (unreadOnly)
                labelList.Add(UnreadLabel);

            request.Q = "";
            
            return request.Execute();
        }

        public Message SendEmail(string targetEmailAddress, string emailContent, string subject)
        {
            var draftsList = GmailSer.Users.Drafts.List("me");
            var respDrafts = draftsList.Execute();
            var getDraft = GmailSer.Users.Drafts.Get("me", respDrafts.Drafts.First().Id);
            var singleDraft = getDraft.Execute();
            Message m = new Message();
            string finalRaw = "To: " + targetEmailAddress+"\n";
            finalRaw += "From: " + "tenseiga12@gmail.com" + "\n";
            finalRaw += "Subject: " + subject + "\n\n";
            finalRaw += emailContent;
            var test = Convert.ToBase64String(Encoding.ASCII.GetBytes(finalRaw));//.Replace('+', '-').Replace('/', '_');
            m.Raw = test.Replace('+', '-').Replace('/', '_');

            UsersResource.MessagesResource.SendRequest request = GmailSer.Users.Messages.Send(m, "me");
            
            return request.Execute();
        }

        public void SetMessageAsRead(Message message)
        {
            BackgroundWorker bgworker = new BackgroundWorker();
            bgworker.DoWork += (s, e) =>
            {
                ModifyMessageRequest mods = new ModifyMessageRequest();
                mods.RemoveLabelIds = new List<string>() { UnreadLabel };
                var modifyReq = GmailSer.Users.Messages.Modify(mods, "me", message.Id);
                modifyReq.Execute();
            };
            bgworker.RunWorkerAsync();
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private const string NormalInboxLabel = "Inbox";
        private const string UnreadLabel = "UNREAD";
    }
}
