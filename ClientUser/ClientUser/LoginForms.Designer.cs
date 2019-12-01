namespace ClientUser
{
    partial class LoginForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTowPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswordAgn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTowPasswordAgn = new System.Windows.Forms.TextBox();
            this.rdobtnNan = new System.Windows.Forms.RadioButton();
            this.rdobtnGirl = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(67, 188);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 27);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "性别：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "二级密保：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(67, 8);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(174, 21);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(67, 33);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(174, 21);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 82);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 21);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtTowPassword
            // 
            this.txtTowPassword.Location = new System.Drawing.Point(67, 129);
            this.txtTowPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTowPassword.Name = "txtTowPassword";
            this.txtTowPassword.PasswordChar = '*';
            this.txtTowPassword.Size = new System.Drawing.Size(174, 21);
            this.txtTowPassword.TabIndex = 7;
            this.txtTowPassword.TextChanged += new System.EventHandler(this.txtTowPassword_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(181, 188);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 27);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "确认密码：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPasswordAgn
            // 
            this.txtPasswordAgn.Location = new System.Drawing.Point(67, 57);
            this.txtPasswordAgn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPasswordAgn.Name = "txtPasswordAgn";
            this.txtPasswordAgn.PasswordChar = '*';
            this.txtPasswordAgn.Size = new System.Drawing.Size(174, 21);
            this.txtPasswordAgn.TabIndex = 3;
            this.txtPasswordAgn.TextChanged += new System.EventHandler(this.txtPasswordAgn_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "确认密保：";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTowPasswordAgn
            // 
            this.txtTowPasswordAgn.Location = new System.Drawing.Point(67, 154);
            this.txtTowPasswordAgn.Margin = new System.Windows.Forms.Padding(2);
            this.txtTowPasswordAgn.Name = "txtTowPasswordAgn";
            this.txtTowPasswordAgn.PasswordChar = '*';
            this.txtTowPasswordAgn.Size = new System.Drawing.Size(174, 21);
            this.txtTowPasswordAgn.TabIndex = 8;
            this.txtTowPasswordAgn.TextChanged += new System.EventHandler(this.txtTowPassword_TextChanged);
            // 
            // rdobtnNan
            // 
            this.rdobtnNan.AutoSize = true;
            this.rdobtnNan.Checked = true;
            this.rdobtnNan.Location = new System.Drawing.Point(88, 108);
            this.rdobtnNan.Name = "rdobtnNan";
            this.rdobtnNan.Size = new System.Drawing.Size(35, 16);
            this.rdobtnNan.TabIndex = 5;
            this.rdobtnNan.TabStop = true;
            this.rdobtnNan.Text = "男";
            this.rdobtnNan.UseVisualStyleBackColor = true;
            // 
            // rdobtnGirl
            // 
            this.rdobtnGirl.AutoSize = true;
            this.rdobtnGirl.Location = new System.Drawing.Point(181, 108);
            this.rdobtnGirl.Name = "rdobtnGirl";
            this.rdobtnGirl.Size = new System.Drawing.Size(35, 16);
            this.rdobtnGirl.TabIndex = 6;
            this.rdobtnGirl.Text = "女";
            this.rdobtnGirl.UseVisualStyleBackColor = true;
            // 
            // LoginForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 226);
            this.Controls.Add(this.rdobtnGirl);
            this.Controls.Add(this.rdobtnNan);
            this.Controls.Add(this.txtTowPasswordAgn);
            this.Controls.Add(this.txtTowPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPasswordAgn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Name = "LoginForms";
            this.Text = "用户注册";
            this.Load += new System.EventHandler(this.LoginForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTowPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswordAgn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTowPasswordAgn;
        private System.Windows.Forms.RadioButton rdobtnNan;
        private System.Windows.Forms.RadioButton rdobtnGirl;
    }
}