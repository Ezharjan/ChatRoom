namespace Client
{
    partial class Log
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
            this.richTexLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTexLog
            // 
            this.richTexLog.Location = new System.Drawing.Point(12, 12);
            this.richTexLog.Name = "richTexLog";
            this.richTexLog.ReadOnly = true;
            this.richTexLog.Size = new System.Drawing.Size(387, 323);
            this.richTexLog.TabIndex = 0;
            this.richTexLog.Text = "";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 347);
            this.Controls.Add(this.richTexLog);
            this.Name = "Log";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTexLog;
    }
}