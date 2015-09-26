using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzMailEzLife
{
    public partial class MailSendingControl : UserControl
    {
        public MailSendingControl()
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var approvedUsers = UserManager.Instance.GetAllApprovedUsers();
            
            foreach(var user in approvedUsers)
            {
                var btn = new Button();
                btn.Text = user.UserName;
                btn.Size = new Size(SenderLayoutPanel.Height - 20, SenderLayoutPanel.Height - 20);
                btn.Click += btn_Click;
                btn.Font = toNameLabel.Font;
                SenderLayoutPanel.Controls.Add(btn);
            }

            SendButtonClicked(SenderLayoutPanel.Controls[0]);
        }

        void btn_Click(object sender, EventArgs e)
        {
            SendButtonClicked(sender);
        }

        private void SendButtonClicked(object sender)
        {
            var approvedUsers = UserManager.Instance.GetAllApprovedUsers();
            _targetEmailAddress = approvedUsers.First(a => a.UserName == ((Control)sender).Text).UserEmail;
            toNameLabel.Text = ((Control)sender).Text;
        }

        private void sendButotn_Click(object sender, EventArgs e)
        {
            var msg = ServiceManager.Instance.SendEmail(_targetEmailAddress, composeTextBox.Text, subjectTextBox.Text);

            Controls.Clear();
            Label label = new Label();
            label.Text = "Your email has been sent!";
            label.Font = new Font(DefaultFont.FontFamily, 30, FontStyle.Bold);
            label.Size = this.Size;
            Controls.Add(label);


        }

        private string _targetEmailAddress;
    }
}
