using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.Net;

namespace Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ram", "Kumar", "Sharma", 81342252575);
            string data = JsonConvert.SerializeObject(person);
            TcpClient client = new TcpClient();
            client.Connect(IPAddress.Parse("127.0.0.1"),545);
            byte[] dataBytes = Encoding.ASCII.GetBytes(data);
            client.GetStream().Write(dataBytes, 0, dataBytes.Length);
            Console.Read();
        }
    }
}
