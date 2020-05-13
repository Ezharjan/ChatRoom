using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public class SocketTcp
    {
        public string adr;
        public int comNum;
        public TcpListener server;
        public int connections;

        public SocketTcp (string Adr , int ComNum)
        {
            adr = Adr;
            comNum = ComNum;
            connections = 0;
        }

        public void Start()
        {            
            server = new TcpListener(IPAddress.Parse(adr), comNum);
            server.Start();
        }
    }
}
