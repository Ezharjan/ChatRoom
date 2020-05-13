using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;


namespace Client
{
    public partial class ListFrom : Form
    {

        public List<ChatForm> chatList; 
        public SocketTcp client;
        public string Addbuff;
        public Thread ListenThread;
        public ListFrom()
        {
            InitializeComponent();            
        }

        private void ListFrom_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            labName.Text += client.name;
            labAdr.Text += client.adr;
            client.SendName();
            ListenThread = new Thread(new ThreadStart(client.Receive));
            ListenThread.Start();
            client.listFrom = this;
            chatList = new List<ChatForm>();

            if (Directory.Exists("./" + client.name) == false)
                Directory.CreateDirectory("./" + client.name);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            OnlineList onlineList = new OnlineList();
            onlineList.fatherWind = this;
            onlineList.Show();
            client.SendSerch();
            client.fatherWind = onlineList;
        }

        public void buttonChat_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                bool exsit = false;
                string aim = listOnl.SelectedItem.ToString();
                ChatForm chatForm = null;

                if (aim.EndsWith("*"))
                {
                    flag = true;
                    //chatForm.ricTexReceive.Text += Addbuff + "\n";
                    aim = aim.Substring(0, aim.Length - 1);
                    listOnl.Items[listOnl.Items.IndexOf(listOnl.SelectedItem)] = aim;
                    
                }
                foreach(var temp in chatList)
                {
                    if(temp.chat.aim == aim)
                    {
                            MessageBox.Show("对话框已存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            exsit = true;
                    }                        
                }
                if(exsit == false)
                {
                    chatForm = new ChatForm();
                    chatForm.fatherWind = this;
                    chatList.Add(chatForm);
                    chatForm.chat.startIP = client;
                    chatForm.chat.aim = aim;
                    chatForm.Show();
                }
                if(flag == true)
                {
                    /*
                    foreach (var temp in listOnl.Items)
                    {
                        if (temp.ToString() == aim)
                            ans = n;
                        n++;
                    }
                    listOnl.Items[ans] = aim;
                     */
                    chatForm.ricTexReceive.Text += Addbuff;
                    SocketTcp.SaveLog(client.name, aim, Addbuff);
                    Addbuff = "";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("请选择聊天对象", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void listOnl_DoubleClick(object sender, EventArgs e)
        {
            buttonChat_Click(this, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listOnl.Items.Remove(listOnl.SelectedItem);
        }

        

        private void buttonSendOpen_Click(object sender, EventArgs e)
        {
            string sendbuff = client.name+DateTime.Now.ToShortTimeString()+"\n"+richTexSendOpen.Text.TrimEnd() + "\n";
            client.SendOpen(sendbuff);
            richTexSendOpen.Clear();
        }

        private void richTexSendOpen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                buttonSendOpen_Click(this, e);
            }
        }
        private void ListFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false ;            
            client.SendStop();
            ListenThread.Abort();
            client.stream.Close();
            //MessageBox.Show("谢谢使用", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            client.clientTcp.Close();
        }

    }
}
