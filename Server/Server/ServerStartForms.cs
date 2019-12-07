using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerStartForms : Form
    {
        private ServerControl server = new ServerControl();

        public ServerStartForms()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtShow.Text = "服务器启动成功,等待用户连接...\n";
            server.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("服务器已断开...", "消息");
            server.Close();
        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
