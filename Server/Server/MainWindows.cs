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

namespace Server
{
    public partial class MainWindows : Form
    {
        public SocketTcp server;
        public List<Client> ClientList;
        public Thread countClientThread;
        public MainWindows()
        {
            InitializeComponent();
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {
            //跨线程调用Windows控件。
            Control.CheckForIllegalCrossThreadCalls = false;
            countClientThread = new Thread(new ThreadStart(this.Wait));
            ClientList = new List<Client>();
            countClientThread.Start();
            labAdr.Text = "IP: "+server.adr;
        }

        void Wait()
        {
            while(true)
            {
                int n = server.connections;
                Client temp = new Client(server.server.AcceptTcpClient(), this);
                ClientList.Add(temp);
                temp.listenThread  = new Thread(new ThreadStart(ClientList[n].Receive));
                temp.listenThread.Start();
                server.connections++;
            }
        }

        public void AddClientList(string str)
        {
            listBoxClient.Items.Add(str);
        }

        private void MainWindows_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            foreach(var temp in ClientList)
            {
                temp.SendEnd();
                temp.listenThread.Abort();
                temp.client.Close();
            }
            
            server.server.Stop();
            countClientThread.Abort();

        }
    }
}
