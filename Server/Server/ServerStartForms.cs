using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerStartForms : Form
    {
        private ServerControl m_server = new ServerControl();

        public ServerStartForms()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            m_server.Start();
            txtShow.Text += "服务器启动成功...\n";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {
            m_server.Close();
            txtShow.Text += "服务器已经断开...\n";
        }
    }
}
