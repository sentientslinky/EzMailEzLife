namespace EzMailEzLife
{
    partial class ReadMailSingleBlockControl
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
            this.senderNameLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // senderNameLabel
            // 
            this.senderNameLabel.AutoSize = true;
            this.senderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderNameLabel.Location = new System.Drawing.Point(3, 0);
            this.senderNameLabel.Name = "senderNameLabel";
            this.senderNameLabel.Size = new System.Drawing.Size(84, 31);
            this.senderNameLabel.TabIndex = 0;
            this.senderNameLabel.Text = "Dylan";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(667, 0);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(84, 31);
            this.dateTimeLabel.TabIndex = 1;
            this.dateTimeLabel.Text = "Dylan";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(378, 0);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(84, 31);
            this.subjectLabel.TabIndex = 2;
            this.subjectLabel.Text = "Dylan";
            // 
            // ReadMailSingleBlockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.senderNameLabel);
            this.Name = "ReadMailSingleBlockControl";
            this.Size = new System.Drawing.Size(847, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label senderNameLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label subjectLabel;
    }
}
