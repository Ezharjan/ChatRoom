namespace Client
{
    partial class Login
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
            this.LabLogin = new System.Windows.Forms.Label();
            this.LabWel = new System.Windows.Forms.Label();
            this.LabAdr = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxAdr = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labCom = new System.Windows.Forms.Label();
            this.textBoxCom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabLogin
            // 
            this.LabLogin.AutoSize = true;
            this.LabLogin.Location = new System.Drawing.Point(123, 46);
            this.LabLogin.Name = "LabLogin";
            this.LabLogin.Size = new System.Drawing.Size(41, 12);
            this.LabLogin.TabIndex = 0;
            this.LabLogin.Text = "请登录";
            // 
            // LabWel
            // 
            this.LabWel.AutoSize = true;
            this.LabWel.Location = new System.Drawing.Point(114, 21);
            this.LabWel.Name = "LabWel";
            this.LabWel.Size = new System.Drawing.Size(59, 12);
            this.LabWel.TabIndex = 1;
            this.LabWel.Text = "欢迎使用";
            // 
            // LabAdr
            // 
            this.LabAdr.AutoSize = true;
            this.LabAdr.Location = new System.Drawing.Point(21, 127);
            this.LabAdr.Name = "LabAdr";
            this.LabAdr.Size = new System.Drawing.Size(77, 12);
            this.LabAdr.TabIndex = 2;
            this.LabAdr.Text = "服务器地址：";
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Location = new System.Drawing.Point(21, 92);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(77, 12);
            this.LabName.TabIndex = 3;
            this.LabName.Text = "用户名    ：";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(104, 89);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(152, 21);
            this.TextBoxName.TabIndex = 4;
            // 
            // TextBoxAdr
            // 
            this.TextBoxAdr.Location = new System.Drawing.Point(104, 124);
            this.TextBoxAdr.Name = "TextBoxAdr";
            this.TextBoxAdr.Size = new System.Drawing.Size(152, 21);
            this.TextBoxAdr.TabIndex = 5;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(181, 157);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labCom
            // 
            this.labCom.AutoSize = true;
            this.labCom.Location = new System.Drawing.Point(21, 160);
            this.labCom.Name = "labCom";
            this.labCom.Size = new System.Drawing.Size(77, 12);
            this.labCom.TabIndex = 7;
            this.labCom.Text = "端口号    ：";
            // 
            // textBoxCom
            // 
            this.textBoxCom.Location = new System.Drawing.Point(104, 157);
            this.textBoxCom.Name = "textBoxCom";
            this.textBoxCom.Size = new System.Drawing.Size(71, 21);
            this.textBoxCom.TabIndex = 8;
            this.textBoxCom.Text = "13000";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 195);
            this.Controls.Add(this.textBoxCom);
            this.Controls.Add(this.labCom);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.TextBoxAdr);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.LabAdr);
            this.Controls.Add(this.LabWel);
            this.Controls.Add(this.LabLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniTalk Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabLogin;
        private System.Windows.Forms.Label LabWel;
        private System.Windows.Forms.Label LabAdr;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxAdr;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labCom;
        private System.Windows.Forms.TextBox textBoxCom;
    }
}

