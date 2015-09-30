using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Google.Apis.Gmail.v1.Data;
using Message = Google.Apis.Gmail.v1.Data.Message;
namespace EzMailEzLife
{
    public partial class ReadMailSingleBlockControl : UserControl
    {
        private bool _hasFullyLoaded = false;
        public ReadMailSingleBlockControl(Message message, MailReadingControl mailControl)
        {
            InitializeComponent();
            _mainControl = mailControl;
            _message = message;//ServiceManager.Instance.GetEmailInformation(message.Id);
            _messageId = message.Id;
            //LoadMessage();

            //setReadness(!_message.LabelIds.Contains("UNREAD"));
            var bgWorker = new BackgroundWorker();
            bgWorker.DoWork += bgWorker_DoWork;
            bgWorker.RunWorkerCompleted += bgWorker_RunWorkerCompleted;
            bgWorker.RunWorkerAsync();
        }

        void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoadMessage();
            setReadness(!_message.LabelIds.Contains("UNREAD"));
            _hasFullyLoaded = true;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            e.Control.Click += Control_Click;
            base.OnControlAdded(e);
        }

        void Control_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _message = ServiceManager.Instance.GetEmailInformation(_message.Id);
            
        }

        private void LoadMessage()
        {
            senderNameLabel.Text = _message.Payload.Headers.First(a => a.Name == "From").Value.Split(' ')[0];//Everythign before hte first space.
            subjectLabel.Text = _message.Snippet;
            dateTimeLabel.Text = new DateTime(_message.InternalDate.Value).ToLongDateString();
            var offset = senderNameLabel.Text.Length * senderNameLabel.Font.Size;
            subjectLabel.Location = new Point((int)offset + 3, subjectLabel.Location.Y) ;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            _mainControl.DisplayMessage(_messageId, _message);
            setReadness(true);
            ServiceManager.Instance.SetMessageAsRead(_message);
            ((MailReadingControl)Parent.Parent).DeselectAllMails();
            BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void setReadness(bool isRead)
        {
            if (isRead)
            {
                BackColor = Color.LightBlue;
            }
            else
            {
                BackColor = Color.LightPink;
            }
        }
        Message _message;
        string _messageId;
        MailReadingControl _mainControl;
    }
}
