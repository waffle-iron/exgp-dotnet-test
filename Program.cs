using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

using ExGP.Messages;

using Google.Protobuf;

namespace exgp_dotnet_test
{
    public class Program
    {
        private static IPAddress ip = IPAddress.Parse("127.0.0.1");
        private static int port = 10001;

        public static void Main(string[] args)
        {
            //UseRawSocket();
            UseTcpClient();
        }

        public static void UseRawSocket()
        {
            Console.WriteLine("Creating a TCP socket!");
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine(string.Format("Connecting to {0}:{1}", ip, port));
            socket.Connect(ip, port);

            Console.WriteLine("Creating the login request.");
            var loginRequest = CreateLoginRequest("paul@aol.com", "asdflj4398jfda");

            Console.WriteLine("Encoding the login request.");
            var encoded = EncodeEnvelope(loginRequest);

            Console.WriteLine("Sending the encoded request.");
            socket.Send(encoded);

            Console.WriteLine("Waiting for a response...");
            byte[] receiveBuffer = new byte[1024 * 4];
            socket.Receive(receiveBuffer);

            var printable = Convert.ToBase64String(receiveBuffer);
            Console.WriteLine(string.Format("Response received! Response: {0}", printable));

            Console.WriteLine("Press <enter> to terminate...");
            Console.ReadLine();

            socket.Shutdown(SocketShutdown.Both);
            socket.Dispose();
        }

        public static void UseTcpClient()
        {
            Console.WriteLine("Creating a TCP client!");
            TcpClient client = new TcpClient();

            Console.WriteLine(string.Format("Connecting to {0}:{1}", ip, port));
            client.ConnectAsync(ip, port).Wait();

            Console.WriteLine("Creating the login request.");
            var loginRequest = CreateLoginRequest("paul@aol.com", "asdflj4398jfda");

            Console.WriteLine("Encoding the login request.");
            var encoded = EncodeEnvelope(loginRequest);

            Console.WriteLine("Sending the encoded request: " + Convert.ToBase64String(encoded));
            var stream = client.GetStream();
            stream.Write(encoded, 0, encoded.Length);
            stream.Flush();

            Console.WriteLine("Waiting for a response...");
            byte[] receiveBuffer = new byte[1024 * 4];
            stream.Read(receiveBuffer, 0, client.ReceiveBufferSize);

            Console.WriteLine(string.Format("Response received! Response: {0}", Convert.ToBase64String(receiveBuffer)));

            Console.WriteLine("Press <enter> to terminate...");
            Console.ReadLine();

            client.Dispose();
        }

        public static Envelope CreateLoginRequest(string email, string passHash)
        {
            return new Envelope
            {
                AuthPayload = new AuthPayload
                {
                    LoginRequest = new LoginRequest
                    {
                        Email = email,
                        PassHash = passHash
                    }
                }
            };
        }

        public static byte[] EncodeEnvelope(Envelope envelope)
        {
            using(MemoryStream stream = new MemoryStream())
            {
                envelope.WriteTo(stream);
                return stream.ToArray();
            }
        }
    }
}
