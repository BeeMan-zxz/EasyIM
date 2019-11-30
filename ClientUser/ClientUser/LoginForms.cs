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
    public partial class LoginForms : Form
    {

        public LoginForms()
        {
            InitializeComponent();
        }

        public LoginForms(User user)
        {
            this.user = user;
        }

        private User user { get; set; }

        private void LoginForms_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPasswordAgn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            user.ID = int.Parse(txtID.Text);
            user.Name = txtName.Text;
            user.Password = txtPassword.Text;
            if (ckbBoy.Checked)
            {
                user.Sex = BitConverter.GetBytes(1);
            }
            else if (ckbGirl.Checked)
            {
                user.Sex = BitConverter.GetBytes(0);
            }
            else
            {
                user.Sex = null;
            }
            user.PasswordTow = txtTowPassword.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void txtTowPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSex_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
