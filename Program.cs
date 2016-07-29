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
        public static void Main(string[] args)
        {
            Console.WriteLine("Creating a TCP socket!");
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            var ip = IPAddress.Parse("127.0.0.1");
            var port = 10001;

            Console.WriteLine(string.Format("Connecting to {0}:{1}", ip, port));
            socket.Connect(ip, port);

            Console.WriteLine("Creating the login request.");
            var loginRequest = CreateLoginRequest("paul@aol.com", "asdflj4398jfda");

            Console.WriteLine("Encoding the login request.");
            var encoded = EncodeEnvelope(loginRequest);

            Console.WriteLine("Sending the encoded request.");
            socket.Send(encoded);

            Console.ReadLine();

            socket.Shutdown(SocketShutdown.Both);
            socket.Dispose();
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
