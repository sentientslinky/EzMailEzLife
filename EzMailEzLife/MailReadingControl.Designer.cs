namespace EzMailEzLife
{
    partial class MailReadingControl
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
            this.messageDisplay = new System.Windows.Forms.RichTextBox();
            this.emailListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // messageDisplay
            // 
            this.messageDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageDisplay.Location = new System.Drawing.Point(0, 227);
            this.messageDisplay.Name = "messageDisplay";
            this.messageDisplay.Size = new System.Drawing.Size(877, 374);
            this.messageDisplay.TabIndex = 0;
            this.messageDisplay.Text = "Test text lol";
            // 
            // emailListFlowPanel
            // 
            this.emailListFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailListFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.emailListFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.emailListFlowPanel.Name = "emailListFlowPanel";
            this.emailListFlowPanel.Size = new System.Drawing.Size(877, 221);
            this.emailListFlowPanel.TabIndex = 1;
            // 
            // MailReadingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.emailListFlowPanel);
            this.Controls.Add(this.messageDisplay);
            this.Name = "MailReadingControl";
            this.Size = new System.Drawing.Size(880, 604);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox messageDisplay;
        private System.Windows.Forms.FlowLayoutPanel emailListFlowPanel;
    }
}
