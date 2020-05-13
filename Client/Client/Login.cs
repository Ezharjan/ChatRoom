using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client;
using System.Net.Sockets;


namespace Client
{
    
    public partial class Login : Form
    {


        SocketTcp client;        
        public Login()
        {
            InitializeComponent();
        }



        private void buttonLogin_Click(object sender, EventArgs e)
        {

            //参数判断
            if(TextBoxAdr.Text == "" || TextBoxName.Text=="" || textBoxCom.Text == "")
                MessageBox.Show("请输入正确参数", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
            {
                try
                {
                    LabLogin.Text = "正在连接到服务器……";             
                    //切换窗口
                    ListFrom listFrom = new ListFrom();
                    client = new SocketTcp(TextBoxName.Text, TextBoxAdr.Text, int.Parse(textBoxCom.Text));       
                    listFrom.client = client;
                    this.Hide();
                    listFrom.ShowDialog();
                    this.Close();
                }
                catch (SocketException)
                {
                    LabLogin.Text = "请登录";
                    MessageBox.Show("无法连接到服务器……", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }    
            }
        }
    }
}
