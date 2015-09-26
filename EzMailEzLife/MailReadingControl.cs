using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = Google.Apis.Gmail.v1.Data.Message;
using System.Net.Mail;

namespace EzMailEzLife
{
    public partial class MailReadingControl : UserControl
    {
        public MailReadingControl()
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var approvedUsers = UserManager.Instance.GetAllApprovedUsers();
            var emails = ServiceManager.Instance.GetEmailsFromSelectedSenders(UserManager.Instance.GetAllApprovedUsers(), false);

            foreach(var email in emails.Messages)
            {
                emailListFlowPanel.Controls.Add(new ReadMailSingleBlockControl(email, this));
            }
            emailListFlowPanel.Resize += emailListFlowPanel_Resize;
        }

        void emailListFlowPanel_Resize(object sender, EventArgs e)
        {
            foreach (var v in emailListFlowPanel.Controls)
            {
                ((Control)v).Size = new Size(this.Width, ((Control)v).Size.Height);
            }
            base.OnResize(e);
            
        }

        public void DisplayMessage(string _messageId, Message message)
        {
            var byteArr = Attachment.CreateAttachmentFromString("", message.Payload.Parts[0].Body.Data);
            var converted = Convert.FromBase64String(byteArr.Name.Replace('-', '+').Replace('_', '/'));
            messageDisplay.Text = System.Text.Encoding.UTF8.GetString(converted);
        }
    }
}
