using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Client;
using System.IO;

namespace Client
{
    public class SocketTcp
    {
        public string adr;
        public int comNum;
        public string name;
        public TcpClient clientTcp;
        public NetworkStream stream;
        public OnlineList fatherWind;
        public ListFrom listFrom;
        public ChatForm chatForm;

        public SocketTcp(string Name, string Adr, int ComNum )
        {
            adr = Adr;
            name = Name;
            comNum = ComNum;
            clientTcp = new TcpClient();
            clientTcp.Connect(adr, comNum);
            stream = clientTcp.GetStream();
        }

        //接收数据
        public  void Receive()
        {
            int getSize;
            byte[] ReceiveBytes = new byte[1024];
            string ReceiveStr = null;
            while( true )
            {
                while (true)
                {
                    getSize = stream.Read(ReceiveBytes, 0, 1024);
                    if (getSize == 0)
                        break;
                    ReceiveStr = Encoding.BigEndianUnicode.GetString(ReceiveBytes, 0, getSize);
                    ReceiveStr.TrimEnd();
                    if(ReceiveStr.StartsWith("++-"))
                    {
                        ReceiveOnline(ReceiveStr);
                    }

                    if(ReceiveStr.StartsWith("+--"))
                    {
                        ReceiveChatNum(ReceiveStr);
                    }
                    if(ReceiveStr.StartsWith("---"))
                    {
                        ReceiveChatMsg(ReceiveStr);
                    }
                    if(ReceiveStr.StartsWith("-++"))
                    {
                        ReceiveOpen(ReceiveStr);
                    }
                    if(ReceiveStr.StartsWith("-+-"))
                    {
                        ReceiveEnd();
                    }

                }
            }
        }

        //发送数据
        public static void Send(string str, NetworkStream stream)
        {
            byte[] SendBytes = new byte[1024];
                SendBytes = Encoding.BigEndianUnicode.GetBytes(str);
                stream.Write(SendBytes, 0, SendBytes.Length);
        }


        public void SendName()
        {            
            SocketTcp.Send("+++" + name,stream);
        }
        public void SendSerch()
        {
            SocketTcp.Send("++-",stream);
        }

        public void ReceiveOnline(string ReceiveStr)
        {
            string[] StrArray;
            ReceiveStr = ReceiveStr.Substring(3, ReceiveStr.Length - 3);
            StrArray = ReceiveStr.Split('*');
            foreach (string str in StrArray)
            {
                fatherWind.listBoxName.Items.Add(str);
            }
        }
        public void ChatConnect(string aim)
        {
            
            SocketTcp.Send("+--"+aim, stream);
            //listFrom.richlist.Text += aim + "\n";
            
        }
        public void ReceiveChatNum(string rec)
        {
            rec = rec.Substring(3, rec.Length - 3);
            string[] strArry;
            strArry = rec.Split('/');
            string aimStr = strArry[0];
            int aimNum = int.Parse(strArry[1]);
            ChatForm aimChat = null;
            foreach(var temp in listFrom.chatList)
            {
                if (temp.chat.aim == aimStr)
                    aimChat = temp;
            }
            aimChat.aimNum = aimNum;
            //chatForm.labAimNum.Text = chatForm.aimNum.ToString();   
            chatForm.labAimNum.Text = aimNum.ToString();
            //MessageBox.Show(rec, "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);    
        }

        public void SendChat(string msg,ChatForm chatf)
        {
            string sendStr = "---";
            sendStr += chatf.aimNum.ToString();        
            sendStr += "/";            
            sendStr += msg;
            Send(sendStr, stream);
        }

        public void ReceiveChatMsg(string str)
        {
            string aim ;
            string [] strArray;
            string rec;
            str = str.Substring(3, str.Length - 3);
            strArray = str.Split('/');
            aim = strArray[0];
            rec = strArray[1];

            ChatForm aimForm = null ;
            foreach (var temp in listFrom.chatList)
            {
                if (temp.chat.aim == aim)
                {
                    aimForm = temp;
                }
            }
            if(aimForm == null)
            {
                int n =0;
                int ans = -1 ;
                foreach(var temp in listFrom.listOnl.Items)
                {
                    if (temp.ToString() == aim || temp.ToString() == aim + "*")
                        ans = n;
                    n++;
                }

                if(ans == -1)
                {
                    listFrom.richlist.Text += rec + "\n";     
                }
                else
                {
                    listFrom.listOnl.Items[ans] = aim + "*";
                    listFrom.Addbuff += rec + "\n";
                }            
            }
            else
            {
                    aimForm.ricTexReceive.Text += rec + "\n";
                    SocketTcp.SaveLog(name, aimForm.chat.aim, rec);
                    //让文本框获取焦点 
                    aimForm.ricTexReceive.Focus();
                    //设置光标的位置到文本尾 
                    aimForm.ricTexReceive.Select(aimForm.ricTexReceive.TextLength, 0);
                    //滚动到控件光标处 
                    aimForm.ricTexReceive.ScrollToCaret();
                    aimForm.ricTexSend.Focus();
            }
        }

        public void SendStop()
        {
            Send("+-+",stream);
        }
        public void SendOpen(string str)
        {
            Send("-++" + str, stream);
        }
        public void ReceiveOpen(string str)
        {
            str = str.Substring(3, str.Length - 3);
            listFrom.richTexOpen.Text += str+"\n";
            SaveLog(name,"公共聊天",str);
            //让文本框获取焦点 
            listFrom.richTexOpen.Focus();
            //设置光标的位置到文本尾 
            listFrom.richTexOpen.Select(listFrom.richTexOpen.TextLength, 0);
            //滚动到控件光标处 
            listFrom.richTexOpen.ScrollToCaret();
            listFrom.richTexSendOpen.Focus();
        }


        public static void SaveLog(string ClientName,string ChatName,string str)
        {
            string fileName = "./" + ClientName + "/" + ChatName+".txt";

            StreamWriter sr = new StreamWriter(fileName,true,Encoding.BigEndianUnicode);
            sr.WriteLine(str.TrimEnd());
            sr.Close();

        }

        public void ReceiveEnd()
        {
            MessageBox.Show("服务器已下线", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            listFrom.Close();
        }
    }
}
