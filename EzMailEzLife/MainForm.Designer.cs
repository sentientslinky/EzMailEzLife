namespace EzMailEzLife
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SendMessagesButton = new System.Windows.Forms.Button();
            this.ReadMessagesButton = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainPanel.Controls.Add(this.SendMessagesButton);
            this.MainPanel.Controls.Add(this.ReadMessagesButton);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(200, 611);
            this.MainPanel.TabIndex = 0;
            // 
            // SendMessagesButton
            // 
            this.SendMessagesButton.Location = new System.Drawing.Point(12, 228);
            this.SendMessagesButton.Name = "SendMessagesButton";
            this.SendMessagesButton.Size = new System.Drawing.Size(185, 210);
            this.SendMessagesButton.TabIndex = 1;
            this.SendMessagesButton.Text = "Send Mail";
            this.SendMessagesButton.UseVisualStyleBackColor = true;
            this.SendMessagesButton.Click += new System.EventHandler(this.SendMessagesButton_Click);
            // 
            // ReadMessagesButton
            // 
            this.ReadMessagesButton.Location = new System.Drawing.Point(12, 12);
            this.ReadMessagesButton.Name = "ReadMessagesButton";
            this.ReadMessagesButton.Size = new System.Drawing.Size(185, 210);
            this.ReadMessagesButton.TabIndex = 0;
            this.ReadMessagesButton.Text = "Read Mail";
            this.ReadMessagesButton.UseVisualStyleBackColor = true;
            this.ReadMessagesButton.Click += new System.EventHandler(this.ReadMessagesButton_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightPanel.Location = new System.Drawing.Point(206, 12);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(785, 599);
            this.RightPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 615);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button SendMessagesButton;
        private System.Windows.Forms.Button ReadMessagesButton;
        private System.Windows.Forms.Panel RightPanel;

    }
}

