namespace Server
{
    partial class MainWindows
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
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.labAdr = new System.Windows.Forms.Label();
            this.richList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.ItemHeight = 12;
            this.listBoxClient.Location = new System.Drawing.Point(12, 63);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(216, 244);
            this.listBoxClient.TabIndex = 0;
            // 
            // labAdr
            // 
            this.labAdr.AutoSize = true;
            this.labAdr.Location = new System.Drawing.Point(12, 18);
            this.labAdr.Name = "labAdr";
            this.labAdr.Size = new System.Drawing.Size(65, 12);
            this.labAdr.TabIndex = 1;
            this.labAdr.Text = "服务器地址";
            // 
            // richList
            // 
            this.richList.Location = new System.Drawing.Point(258, 63);
            this.richList.Name = "richList";
            this.richList.ReadOnly = true;
            this.richList.Size = new System.Drawing.Size(186, 244);
            this.richList.TabIndex = 2;
            this.richList.Text = "";
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 345);
            this.Controls.Add(this.richList);
            this.Controls.Add(this.labAdr);
            this.Controls.Add(this.listBoxClient);
            this.Name = "MainWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindows_FormClosing);
            this.Load += new System.EventHandler(this.MainWindows_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.Label labAdr;
        public System.Windows.Forms.RichTextBox richList;

    }
}