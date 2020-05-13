namespace Server
{
    partial class OpenWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAdr = new System.Windows.Forms.TextBox();
            this.labAdr = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labCom = new System.Windows.Forms.Label();
            this.textBoxCom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.Location = new System.Drawing.Point(127, 81);
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(170, 21);
            this.textBoxAdr.TabIndex = 0;
            // 
            // labAdr
            // 
            this.labAdr.AutoSize = true;
            this.labAdr.Location = new System.Drawing.Point(44, 84);
            this.labAdr.Name = "labAdr";
            this.labAdr.Size = new System.Drawing.Size(77, 12);
            this.labAdr.TabIndex = 1;
            this.labAdr.Text = "本地服务器：";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(167, 158);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "开启";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labCom
            // 
            this.labCom.AutoSize = true;
            this.labCom.Location = new System.Drawing.Point(44, 118);
            this.labCom.Name = "labCom";
            this.labCom.Size = new System.Drawing.Size(77, 12);
            this.labCom.TabIndex = 3;
            this.labCom.Text = "端口号    ：";
            // 
            // textBoxCom
            // 
            this.textBoxCom.Location = new System.Drawing.Point(127, 115);
            this.textBoxCom.Name = "textBoxCom";
            this.textBoxCom.Size = new System.Drawing.Size(170, 21);
            this.textBoxCom.TabIndex = 4;
            this.textBoxCom.Text = "199704";
            // 
            // OpenWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 218);
            this.Controls.Add(this.textBoxCom);
            this.Controls.Add(this.labCom);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.labAdr);
            this.Controls.Add(this.textBoxAdr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OpenWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.OpenWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAdr;
        private System.Windows.Forms.Label labAdr;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labCom;
        private System.Windows.Forms.TextBox textBoxCom;
    }
}

