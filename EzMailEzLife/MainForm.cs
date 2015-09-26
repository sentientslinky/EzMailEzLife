using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Discovery;
using Google.Apis.Services;


namespace EzMailEzLife
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Define parameters of request.
            var resp = ServiceManager.Instance.TestFunction();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetReadingLayout();

            CalculateUnreadMessages();
        }

        private void CalculateUnreadMessages()
        {
            BackgroundWorker unreadCountWorker = new BackgroundWorker();
            unreadCountWorker.DoWork += unreadCountWorker_DoWork;
            unreadCountWorker.RunWorkerCompleted += unreadCountWorker_RunWorkerCompleted;
            unreadCountWorker.RunWorkerAsync();
        }

        void unreadCountWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ReadMessagesButton.Text = "Read Mail (" + _lastUnreadMessageCount + " Unread)";
        }

        void unreadCountWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _lastUnreadMessageCount = ServiceManager.Instance.GetUnreadEmails();
        }

        private void ReadMessagesButton_Click(object sender, EventArgs e)
        {
            SetReadingLayout();
        }

        private void SetReadingLayout()
        {
            RightPanel.Controls.Clear();
            RightPanel.Controls.Add(new MailReadingControl());
        }

        private void SendMessagesButton_Click(object sender, EventArgs e)
        {
            RightPanel.Controls.Clear();
            RightPanel.Controls.Add(new MailSendingControl());
        }

        private int _lastUnreadMessageCount = 0;
    }
}
