using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace NewServer
{
    class Server
    {
        TcpClient client;
        TcpListener tcplistn; 
        public void StartServer()
        {
            tcplistn =new TcpListener(IPAddress.Parse("127.0.0.1"), 545); 
            tcplistn.Start();

        }
        public void AcceptClient()
        {
            client = tcplistn.AcceptTcpClient();
           
        }
        public string GetData()
        {
            byte[] dataRead = new byte[10000];
            client.GetStream().Read(dataRead, 0, dataRead.Length);
            string recieved = Encoding.ASCII.GetString(dataRead);
            return recieved;

        }


    }
}
