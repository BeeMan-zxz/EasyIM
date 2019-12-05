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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            User user1 = new User();
            user1 = DB.Context.From<User>().Where(d => d.UserId == int.Parse(txtUserID.Text)).First();
            if (user1 != null && user1.Password == txtPassword.Text)
            {
                //登录聊天界面
                ClientUserForms form = new ClientUserForms();
                form.ShowDialog();
            }
            else 
            {
                MessageBox.Show("您输入的用户名或密码不正确！","消息");
            }
        }
    }
}
