using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
                m_User.Sex = 1;
            }
            else if (rdobtnGirl.Checked)
            {
                m_User.Sex = 0;
            }
            if (txtTowPassword.Text == txtTowPasswordAgn.Text)
            {
                m_User.PasswordTow = txtTowPassword.Text;
            }
            else
            {
                MessageBox.Show("您两次输入的密保不符，请确认!", "消息");
                this.Close();
            }
            m_User.Data = System.DateTime.Now.ToString("yyyy-MM-dd");
            var us = DB.Context.From<User>().Where(d => d.ID == m_User.ID).ToList();

            if (us.Count == 0)
            {
                if (m_User.Password == null || m_User.PasswordTow == null)
                {
                    MessageBox.Show("请输入标准密码和标准密保且保证两次输入的一致！", "消息");
                }
                DB.Context.Insert<User>(m_User);
                MessageBox.Show("恭喜您，已经注册成功！", "消息");
                this.Close();
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
