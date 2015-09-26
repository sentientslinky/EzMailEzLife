namespace EzMailEzLife
{
    partial class MailSendingControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SenderLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.composeTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toNameLabel = new System.Windows.Forms.Label();
            this.sendButotn = new System.Windows.Forms.Button();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SenderLayoutPanel
            // 
            this.SenderLayoutPanel.AutoScroll = true;
            this.SenderLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.SenderLayoutPanel.Name = "SenderLayoutPanel";
            this.SenderLayoutPanel.Size = new System.Drawing.Size(783, 113);
            this.SenderLayoutPanel.TabIndex = 0;
            // 
            // composeTextBox
            // 
            this.composeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.composeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.composeTextBox.Location = new System.Drawing.Point(3, 153);
            this.composeTextBox.Name = "composeTextBox";
            this.composeTextBox.Size = new System.Drawing.Size(777, 340);
            this.composeTextBox.TabIndex = 0;
            this.composeTextBox.Text = "test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "To:";
            // 
            // toNameLabel
            // 
            this.toNameLabel.AutoSize = true;
            this.toNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toNameLabel.Location = new System.Drawing.Point(46, 128);
            this.toNameLabel.Name = "toNameLabel";
            this.toNameLabel.Size = new System.Drawing.Size(37, 22);
            this.toNameLabel.TabIndex = 2;
            this.toNameLabel.Text = "To:";
            // 
            // sendButotn
            // 
            this.sendButotn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButotn.Location = new System.Drawing.Point(651, 119);
            this.sendButotn.Name = "sendButotn";
            this.sendButotn.Size = new System.Drawing.Size(104, 31);
            this.sendButotn.TabIndex = 3;
            this.sendButotn.Text = "Send!";
            this.sendButotn.UseVisualStyleBackColor = true;
            this.sendButotn.Click += new System.EventHandler(this.sendButotn_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(422, 126);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(213, 20);
            this.subjectTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject";
            // 
            // MailSendingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.sendButotn);
            this.Controls.Add(this.toNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.composeTextBox);
            this.Controls.Add(this.SenderLayoutPanel);
            this.Name = "MailSendingControl";
            this.Size = new System.Drawing.Size(783, 496);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SenderLayoutPanel;
        private System.Windows.Forms.RichTextBox composeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label toNameLabel;
        private System.Windows.Forms.Button sendButotn;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label label2;
    }
}
