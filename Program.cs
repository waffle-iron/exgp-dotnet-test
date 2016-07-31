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

    public static void Main(string[] args) {
      SocketWrapper socketWrapper = new SocketWrapper();
      socketWrapper.Connect(ip, port);

      socketWrapper.OnMessageReceived += MessageReceived;
      socketWrapper.StartListener();

      var loginRequest = CreateLoginRequest("paul@aol.com", "sdiojg0924g");
      socketWrapper.SendMessage(loginRequest);

      Console.ReadLine();
    }

    public static void MessageReceived(object sender, MessageReceivedEventArgs eventArgs) {
      Console.WriteLine("Handling the message: " + eventArgs.Message.ToString());
    }

    public static Envelope CreateLoginRequest(string email, string passHash)
    {
      return new Envelope {
        AuthPayload = new AuthPayload {
          LoginRequest = new LoginRequest {
            Email = email,
            PassHash = passHash
          }
        }
      };
    }
  }
}
