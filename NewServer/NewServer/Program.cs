using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace NewServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.StartServer();
            server.AcceptClient();
           string data= server.GetData();
            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}
