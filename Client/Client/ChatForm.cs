using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Client
{
    public partial class ChatForm : Form
    {
        public Chat chat = new Chat();
        public int aimNum;
        public string SendBuff;
        public ListFrom fatherWind;
        public bool open;

        public ChatForm()
        {
            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            chat.startIP.ChatConnect(chat.aim);
            chat.startIP.chatForm = this;
            labAimAdr.Text = chat.aim;
            labMyAdr.Text = chat.startIP.name;
            open = true;
        }

        private void buttonChatSend_Click(object sender, EventArgs e)
        {
            string front = chat.startIP.name + "\t"+ DateTime.Now.ToShortTimeString()+"\n";
            SendBuff = ricTexSend.Text.TrimEnd();
            SendBuff = front + SendBuff + "\n";
            ricTexSend.Clear();
            ricTexReceive.Text += SendBuff;
            SocketTcp.SaveLog(chat.startIP.name, chat.aim, SendBuff);
            //让文本框获取焦点 
            ricTexReceive.Focus();
            //设置光标的位置到文本尾 
            ricTexReceive.Select(ricTexReceive.TextLength, 0);
            //滚动到控件光标处 
            ricTexReceive.ScrollToCaret();
            ricTexSend.Focus();
            chat.startIP.SendChat(SendBuff,this);
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            open = false;
            fatherWind.chatList.Remove(this);
        }

        private void ricTexSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                buttonChatSend_Click(this, e);
            }
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            Log logForm = new Log();
            string path = "./"+ chat.startIP.name + "/" + chat.aim+".txt";
            StreamReader sr = new StreamReader(path, Encoding.BigEndianUnicode);
            logForm.richTexLog.Text = sr.ReadToEnd();
            sr.Close();
            logForm.Show();
        }
    }
}
