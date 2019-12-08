using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Server
{
    class ServerControl
    {
        private Socket serverSocket;
        private List<Socket> sockets;
        public ServerControl()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
            sockets  = new List<Socket>();
        }
        /// <summary>
        /// 服务器启动方法
        /// </summary>
        public void Start()
        {
            IPEndPoint localEP = new IPEndPoint(IPAddress.Any, 10);
            serverSocket.Bind(localEP);
            serverSocket.Listen(10);
            ClientCondationForms form = new ClientCondationForms(serverSocket);
            form.ShowDialog();
        }
        /// <summary>
        /// 服务器断开
        /// </summary>
        public void Close()
        {
            serverSocket.Close();
            //serverSocket.Close();
            //this.Close();   //只是关闭当前窗口，若不是主窗体的话，是无法退出程序的，另外若有托管线程（非主线程），也无法干净地退出；
            //Application.Exit();  //强制所有消息中止，退出所有的窗体，但是若有托管线程（非主线程），也无法干净地退出；
            //Application.ExitThread(); //强制中止调用线程上的所有消息，同样面临其它线程无法正确退出的问题；
            System.Environment.Exit(0);   //这是最彻底的退出方式，不管什么线程都被强制退出，把程序结束的很干净。
        }

        //public void Accept()
        //{
        //    Socket client = serverSocket.Accept();
        //    IPEndPoint point = client.RemoteEndPoint as IPEndPoint;
        //    string s = point.Address + "【" + point.Port + "】" + DateTime.Now.ToString() + "\n";
        //    //form.SetMyTextBoxValue(point.Address + "【" + point.Port + "】" + DateTime.Now.ToString() + "\n");
        //    MessageBox.Show(s, "消息");
        //    sockets.Add(client);
        //    Accept();
        //}
    }
}
