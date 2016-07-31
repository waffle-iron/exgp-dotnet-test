using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

using ExGP.Messages;

using Google.Protobuf;

namespace exgp_dotnet_test
{

  public class MessageReceivedEventArgs : EventArgs
  {
    public Envelope Message { get; set; }
  }

  public delegate void MessageReceivedHandler(object sender, MessageReceivedEventArgs eventArgs);

  public class SocketWrapper
  {
    #region Fields

    Socket _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

    private object _socketLock = new object();

    private bool _connected;

    private object _connectionLock = new object();

    private Task _listenerTask;

    private bool _listening;

    private int _listenerPollingIntervalMs = 10;

    private byte[] _receiveBuffer = new byte[4 * 1024];

    private object _listenerLock = new object();

    #endregion

    #region Properties

    public IPAddress IPAddress { get; private set; }

    public int Port { get; private set; }

    public bool IsListening { get { return _listening; }}

    #endregion

    #region Events

    public event MessageReceivedHandler OnMessageReceived = delegate{};

    #endregion

    #region Methods

    public void Connect(IPAddress ip, int port) {
      lock (_connectionLock) {
        if (_connected) {
          return;
        }

        _socket.Connect(ip, port);
        IPAddress = ip;
        Port = port;
        _connected = true;
      }
    }

    public void SendMessage(Envelope message) {
      _socket.Send(SerializeEnvelope(message));
    }

    public void StartListener() {
      Console.WriteLine("Starting the socket listener");
      lock (_listenerLock) {
        if (_listening) {
          return;
        }

        _listenerTask = Task.Run(() => Listen());
        _listening = true;
      }
    }

    public void StopListener() {
      lock (_listenerLock) {
        _listenerTask = null;
        _listening = false;
      }
    }

    private void Listen() {
      while (_listening) {
        try {
          int size = _socket.Receive(_receiveBuffer);

          if (size > 0) {
            Console.WriteLine("Received a message, deserializing the message");

            // TODO: Is there a better way to accomplish this than making a copy?
            byte[] serialized = new byte[size];
            Array.Copy(_receiveBuffer, serialized, size);
            var message = DeserializeEnvelope(serialized);

            Console.WriteLine("Firing the OnMessageReceived event");
            OnMessageReceived(this, new MessageReceivedEventArgs { Message = message });
          }

        } catch (Exception ex) {
          Console.WriteLine("The socket listener encountered an error while listening for messages. Error: " + ex);
        }

        Task.Delay(_listenerPollingIntervalMs).Wait();
      }
    }

    private static Envelope DeserializeEnvelope(byte[] serialized) {
      return Envelope.Parser.ParseFrom(serialized);
    }

    private static byte[] SerializeEnvelope(Envelope deserialized)
    {
      using(MemoryStream stream = new MemoryStream()) {
         deserialized.WriteTo(stream);
         return stream.ToArray();
      }
    }

    #endregion
  }
}
