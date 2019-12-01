using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientUser.Model;

namespace ClientUser
{
    public partial class EnterForms : Form
    {
        public EnterForms()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForms form = new LoginForms();
            form.ShowDialog();
        }
    }
}
