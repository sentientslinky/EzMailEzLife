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
    }
}
