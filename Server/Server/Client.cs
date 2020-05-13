using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Server;
using System.Windows.Forms;


namespace Server
{
    public class Client
    {
        public NetworkStream stream;//公共网络流
        public TcpClient client;
        public string clientAdr;
        public string Name;
        public MainWindows fatherWind;
        public bool enable = true;
        public string NameAdr;
        public Thread listenThread;
        //public List<string> aimList = new List<string>();
        
        
        public Client ( TcpClient c, MainWindows win )
        {
            client = c;
            //获得客户端IP
            IPEndPoint ip = (IPEndPoint)client.Client.RemoteEndPoint;
            clientAdr = ip.Address.ToString();
            //获得网络数据流
            stream = client.GetStream();
            fatherWind = win;
        }
        public  void  Receive()
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
                    ReceiveStr = ReceiveStr.TrimEnd();
                    //判断发过来的是否为发送客户端名
                    if (ReceiveStr.StartsWith("+++"))
                    {                            
                        int length = ReceiveStr.Length;
                        ReceiveStr = ReceiveStr.Substring(3, length -3 );
                        NameAdr = ReceiveStr + "  ：" + clientAdr;
                        fatherWind.AddClientList(NameAdr);
                        fatherWind.richList.Text += NameAdr + "\n";
                    }                    
                    //判断是否为搜索局域网在线用户
                    if(ReceiveStr.StartsWith("++-"))
                    {
                        SendClientList();
                    }
                    
                    //判断是否要开启聊天模式
                    if(ReceiveStr.StartsWith("+--"))
                    {
                        BuildChat(ReceiveStr);
                    }

                    //判断是否接收到发送的聊天信息
                    if(ReceiveStr.StartsWith("---"))
                    {
                        SendChat(ReceiveStr);
                    }
                    //用户下线
                    if(ReceiveStr.StartsWith("+-+"))
                    {
                        enable = false;
                    }
                    if(ReceiveStr.StartsWith("-++"))
                    {
                        SendOpen(ReceiveStr);
                    }
                }
            }
        }
        public static void Send(string str , NetworkStream stream )
        {
            byte[] SendBytes = new byte[2048];
            SendBytes = Encoding.BigEndianUnicode.GetBytes(str);
            stream.Write(SendBytes, 0, SendBytes.Length);
        }
        public void SendClientList()
        {
            string ans;
            int index = 0;
            ans = "++-";

            foreach( var str in fatherWind.listBoxClient.Items)
            {
                //要确定客户端链接是否断开了
                if (fatherWind.ClientList[index].enable == true)
                {
                    ans += str.ToString();
                    ans += "*";
                }
            }
            Send(ans, stream);
        }

        public void BuildChat(string rec)
        {
            rec = rec.Substring(3, rec.Length - 3);
            /*aimList.Add(rec);
            int index = 0;
            foreach(string temp in aimList )
            {
                if (temp == rec)
                    Send("+--" + index.ToString(), stream);
                index++;
            }*/
            int index = 0;
            foreach(var temp in fatherWind.ClientList)
            {
                if(temp.NameAdr == rec)
                {
                    Send("+--" +rec+"/"+index.ToString(), stream);
                }
                index++;
            }
        }

        public void SendChat(string str)
        {
            str = str.Substring(3, str.Length-3);
            int chatNum;
            string[] StrArray;
            string sendBuff;
            Client connectAim = null;
            StrArray = str.Split('/');
            chatNum = int.Parse(StrArray[0]);
            sendBuff = StrArray[1];
            connectAim = fatherWind.ClientList[chatNum];
            fatherWind.richList.Text += "To" + chatNum.ToString() + "\n";
            Send("---" +  NameAdr + "/" +sendBuff, connectAim.stream);

        }
        public void SendOpen(string str)
        {
            str = str.Substring(3,str.Length-3);
            foreach(var temp in fatherWind.ClientList)
            {
                Send("-++" + str,temp.stream);
            }
        }

        public void SendEnd()
        {
            Send("-+-", stream);
        }
        
    }
    
}
