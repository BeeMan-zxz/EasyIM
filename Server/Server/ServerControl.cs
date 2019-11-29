using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ServerControl
    {
        private Socket serverSocket;

        public ServerControl()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            serverSocket.Bind(new IPEndPoint(IPAddress.Any,11161));
            serverSocket.Listen(10);
        }

        public void Close()
        {
            serverSocket.Close();
        }
    }
}
