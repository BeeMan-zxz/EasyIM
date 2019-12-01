using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientUser.Database;
using ClientUser.Model;

namespace ClientUser
{
    public partial class LoginForms : Form
    {

        public LoginForms()
        {
            InitializeComponent();
        }

        //public LoginForms(User m_User)
        //{
        //    this.m_User = m_User;
        //}

        //private User m_User { get; set; }
        public User m_User = new User();

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
            if (txtID.Text == null || txtName.Text == null || txtTowPassword.Text == null || txtTowPassword.Text == null)
            {
                MessageBox.Show("请您继续完善信息。", "消息");
            }
            m_User.ID = int.Parse(txtID.Text);
            m_User.Name = txtName.Text;
            if (txtPassword.Text == txtPasswordAgn.Text)
            {
                m_User.Password = txtPassword.Text;
            }
            else
            {
                MessageBox.Show("您两次输入的密码不符，请确认!", "消息");
            }
            if (rdobtnNan.Checked)
            {
                m_User.Sex = BitConverter.GetBytes(1);
            }
            else if (rdobtnGirl.Checked)
            {
                m_User.Sex = BitConverter.GetBytes(0);
            }
            else
            {
                m_User.Sex = null;
            }
            if (txtTowPassword.Text == txtTowPasswordAgn.Text)
            {
                m_User.PasswordTow = txtTowPassword.Text;
            }
            else
            {
                MessageBox.Show("您两次输入的密保不符，请确认!", "消息");
            }
            User user1 = DB.Context.From<User>().First();
            MessageBox.Show(user1.ID.ToString(), "消息");
            if (DB.Context.From<User>().Select(d => d.ID == m_User.ID) == null)
            {
                DB.Context.Insert<User>(m_User);
            }
            else
            {
                MessageBox.Show("此ID已经被占用请换一个", "消息");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
