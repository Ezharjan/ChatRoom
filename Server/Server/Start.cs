using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace Server
{
    public partial class OpenWindow : Form
    {

        SocketTcp server;
        public OpenWindow()
        {
            InitializeComponent();
            IPHostEntry here = Dns.GetHostByName(Dns.GetHostName());
            IPAddress localaddress = here.AddressList[0];
            textBoxAdr.Text = localaddress.ToString();
        }

        private void OpenWindow_Load(object sender, EventArgs e)
        {
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {            
            if(textBoxAdr.Text == "" || textBoxCom.Text == "")
            {
                MessageBox.Show("请输入正确参数", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }            
            else
            {   
                try
                {                    
                    server = new SocketTcp(textBoxAdr.Text, int.Parse(textBoxCom.Text));
                    server.Start();                    
                    MainWindows mainWin = new MainWindows();
                    mainWin.server = server;
                    this.Hide();
                    mainWin.ShowDialog();
                    this.Close();

                }
                catch(SocketException)
                {
                    MessageBox.Show("服务器开启失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }             
            }
        }
    }
}
