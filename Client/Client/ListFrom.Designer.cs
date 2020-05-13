namespace Client
{
    partial class ListFrom
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.labAdr = new System.Windows.Forms.Label();
            this.buttonChat = new System.Windows.Forms.Button();
            this.listOnl = new System.Windows.Forms.ListBox();
            this.richlist = new System.Windows.Forms.RichTextBox();
            this.labStanger = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.richTexOpen = new System.Windows.Forms.RichTextBox();
            this.labelOpen = new System.Windows.Forms.Label();
            this.richTexSendOpen = new System.Windows.Forms.RichTextBox();
            this.buttonSendOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(96, 462);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "查找在线";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(12, 9);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(47, 12);
            this.labName.TabIndex = 1;
            this.labName.Text = "Name ：";
            // 
            // labAdr
            // 
            this.labAdr.AutoSize = true;
            this.labAdr.Location = new System.Drawing.Point(12, 31);
            this.labAdr.Name = "labAdr";
            this.labAdr.Size = new System.Drawing.Size(47, 12);
            this.labAdr.TabIndex = 2;
            this.labAdr.Text = "IP   ：";
            // 
            // buttonChat
            // 
            this.buttonChat.Location = new System.Drawing.Point(12, 462);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(75, 23);
            this.buttonChat.TabIndex = 3;
            this.buttonChat.Text = "聊天";
            this.buttonChat.UseVisualStyleBackColor = true;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
            // 
            // listOnl
            // 
            this.listOnl.FormattingEnabled = true;
            this.listOnl.ItemHeight = 12;
            this.listOnl.Location = new System.Drawing.Point(12, 59);
            this.listOnl.Name = "listOnl";
            this.listOnl.Size = new System.Drawing.Size(164, 388);
            this.listOnl.TabIndex = 4;
            this.listOnl.DoubleClick += new System.EventHandler(this.listOnl_DoubleClick);
            // 
            // richlist
            // 
            this.richlist.Location = new System.Drawing.Point(228, 59);
            this.richlist.Name = "richlist";
            this.richlist.ReadOnly = true;
            this.richlist.Size = new System.Drawing.Size(203, 387);
            this.richlist.TabIndex = 5;
            this.richlist.Text = "";
            // 
            // labStanger
            // 
            this.labStanger.AutoSize = true;
            this.labStanger.Location = new System.Drawing.Point(226, 44);
            this.labStanger.Name = "labStanger";
            this.labStanger.Size = new System.Drawing.Size(53, 12);
            this.labStanger.TabIndex = 6;
            this.labStanger.Text = "陌生人：";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(185, 462);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "删除好友";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // richTexOpen
            // 
            this.richTexOpen.Location = new System.Drawing.Point(446, 59);
            this.richTexOpen.Name = "richTexOpen";
            this.richTexOpen.ReadOnly = true;
            this.richTexOpen.Size = new System.Drawing.Size(203, 235);
            this.richTexOpen.TabIndex = 8;
            this.richTexOpen.Text = "";
            // 
            // labelOpen
            // 
            this.labelOpen.AutoSize = true;
            this.labelOpen.Location = new System.Drawing.Point(444, 44);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(77, 12);
            this.labelOpen.TabIndex = 9;
            this.labelOpen.Text = "公共聊天室：";
            // 
            // richTexSendOpen
            // 
            this.richTexSendOpen.Location = new System.Drawing.Point(446, 300);
            this.richTexSendOpen.Name = "richTexSendOpen";
            this.richTexSendOpen.Size = new System.Drawing.Size(203, 146);
            this.richTexSendOpen.TabIndex = 10;
            this.richTexSendOpen.Text = "";
            this.richTexSendOpen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTexSendOpen_KeyPress);
            // 
            // buttonSendOpen
            // 
            this.buttonSendOpen.Location = new System.Drawing.Point(574, 462);
            this.buttonSendOpen.Name = "buttonSendOpen";
            this.buttonSendOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonSendOpen.TabIndex = 11;
            this.buttonSendOpen.Text = "发送";
            this.buttonSendOpen.UseVisualStyleBackColor = true;
            this.buttonSendOpen.Click += new System.EventHandler(this.buttonSendOpen_Click);
            // 
            // ListFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 501);
            this.Controls.Add(this.buttonSendOpen);
            this.Controls.Add(this.richTexSendOpen);
            this.Controls.Add(this.labelOpen);
            this.Controls.Add(this.richTexOpen);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labStanger);
            this.Controls.Add(this.richlist);
            this.Controls.Add(this.listOnl);
            this.Controls.Add(this.buttonChat);
            this.Controls.Add(this.labAdr);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.buttonSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListFrom";
            this.Text = "ListFrom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListFrom_FormClosing);
            this.Load += new System.EventHandler(this.ListFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labAdr;
        private System.Windows.Forms.Button buttonChat;
        public System.Windows.Forms.ListBox listOnl;
        public System.Windows.Forms.RichTextBox richlist;
        private System.Windows.Forms.Label labStanger;
        private System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.RichTextBox richTexOpen;
        private System.Windows.Forms.Label labelOpen;
        public System.Windows.Forms.RichTextBox richTexSendOpen;
        private System.Windows.Forms.Button buttonSendOpen;
    }
}