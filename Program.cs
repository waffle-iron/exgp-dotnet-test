using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

using ExGP.Message;


namespace exgp_dotnet_test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Creating a TCP socket!");

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            var ip = IPAddress.Parse("127.0.0.1");
            var port = 10001;

            socket.Connect(ip, port);

            Envelope envelope = new Envelope();

            Console.ReadLine();
        }
    }
}
