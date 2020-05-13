namespace Client
{
    partial class ChatForm
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
            this.ricTexReceive = new System.Windows.Forms.RichTextBox();
            this.ricTexSend = new System.Windows.Forms.RichTextBox();
            this.buttonChatSend = new System.Windows.Forms.Button();
            this.labMyAdr = new System.Windows.Forms.Label();
            this.labAimAdr = new System.Windows.Forms.Label();
            this.labAimNum = new System.Windows.Forms.Label();
            this.buttonLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ricTexReceive
            // 
            this.ricTexReceive.Location = new System.Drawing.Point(12, 25);
            this.ricTexReceive.Name = "ricTexReceive";
            this.ricTexReceive.ReadOnly = true;
            this.ricTexReceive.Size = new System.Drawing.Size(397, 263);
            this.ricTexReceive.TabIndex = 0;
            this.ricTexReceive.Text = "";
            // 
            // ricTexSend
            // 
            this.ricTexSend.Location = new System.Drawing.Point(12, 303);
            this.ricTexSend.Name = "ricTexSend";
            this.ricTexSend.Size = new System.Drawing.Size(397, 114);
            this.ricTexSend.TabIndex = 1;
            this.ricTexSend.Text = "";
            this.ricTexSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ricTexSend_KeyPress);
            // 
            // buttonChatSend
            // 
            this.buttonChatSend.Location = new System.Drawing.Point(417, 370);
            this.buttonChatSend.Name = "buttonChatSend";
            this.buttonChatSend.Size = new System.Drawing.Size(75, 23);
            this.buttonChatSend.TabIndex = 3;
            this.buttonChatSend.Text = "发送";
            this.buttonChatSend.UseVisualStyleBackColor = true;
            this.buttonChatSend.Click += new System.EventHandler(this.buttonChatSend_Click);
            // 
            // labMyAdr
            // 
            this.labMyAdr.AutoSize = true;
            this.labMyAdr.Location = new System.Drawing.Point(415, 331);
            this.labMyAdr.Name = "labMyAdr";
            this.labMyAdr.Size = new System.Drawing.Size(41, 12);
            this.labMyAdr.TabIndex = 4;
            this.labMyAdr.Text = "我的ID";
            // 
            // labAimAdr
            // 
            this.labAimAdr.AutoSize = true;
            this.labAimAdr.Location = new System.Drawing.Point(12, 9);
            this.labAimAdr.Name = "labAimAdr";
            this.labAimAdr.Size = new System.Drawing.Size(41, 12);
            this.labAimAdr.TabIndex = 5;
            this.labAimAdr.Text = "对方ID";
            // 
            // labAimNum
            // 
            this.labAimNum.AutoSize = true;
            this.labAimNum.Location = new System.Drawing.Point(437, 77);
            this.labAimNum.Name = "labAimNum";
            this.labAimNum.Size = new System.Drawing.Size(41, 12);
            this.labAimNum.TabIndex = 6;
            this.labAimNum.Text = "label1";
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(417, 236);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 23);
            this.buttonLog.TabIndex = 7;
            this.buttonLog.Text = "聊天记录";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 448);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.labAimNum);
            this.Controls.Add(this.labAimAdr);
            this.Controls.Add(this.labMyAdr);
            this.Controls.Add(this.buttonChatSend);
            this.Controls.Add(this.ricTexSend);
            this.Controls.Add(this.ricTexReceive);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox ricTexReceive;
        public System.Windows.Forms.RichTextBox ricTexSend;
        private System.Windows.Forms.Button buttonChatSend;
        private System.Windows.Forms.Label labMyAdr;
        private System.Windows.Forms.Label labAimAdr;
        public System.Windows.Forms.Label labAimNum;
        private System.Windows.Forms.Button buttonLog;
    }
}