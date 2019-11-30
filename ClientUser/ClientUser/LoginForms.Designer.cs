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
            this.ckbBoy = new System.Windows.Forms.CheckBox();
            this.ckbGirl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(115, 197);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "性别：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "二级密保：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(86, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(231, 25);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(86, 42);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(231, 25);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 25);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtTowPassword
            // 
            this.txtTowPassword.Location = new System.Drawing.Point(86, 166);
            this.txtTowPassword.Name = "txtTowPassword";
            this.txtTowPassword.Size = new System.Drawing.Size(231, 25);
            this.txtTowPassword.TabIndex = 7;
            this.txtTowPassword.TextChanged += new System.EventHandler(this.txtTowPassword_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(242, 197);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "确认密码：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPasswordAgn
            // 
            this.txtPasswordAgn.Location = new System.Drawing.Point(86, 73);
            this.txtPasswordAgn.Name = "txtPasswordAgn";
            this.txtPasswordAgn.Size = new System.Drawing.Size(231, 25);
            this.txtPasswordAgn.TabIndex = 3;
            this.txtPasswordAgn.TextChanged += new System.EventHandler(this.txtPasswordAgn_TextChanged);
            // 
            // ckbBoy
            // 
            this.ckbBoy.AutoSize = true;
            this.ckbBoy.Location = new System.Drawing.Point(86, 137);
            this.ckbBoy.Name = "ckbBoy";
            this.ckbBoy.Size = new System.Drawing.Size(44, 19);
            this.ckbBoy.TabIndex = 5;
            this.ckbBoy.Text = "男";
            this.ckbBoy.UseVisualStyleBackColor = true;
            // 
            // ckbGirl
            // 
            this.ckbGirl.AutoSize = true;
            this.ckbGirl.Location = new System.Drawing.Point(216, 138);
            this.ckbGirl.Name = "ckbGirl";
            this.ckbGirl.Size = new System.Drawing.Size(44, 19);
            this.ckbGirl.TabIndex = 6;
            this.ckbGirl.Text = "女";
            this.ckbGirl.UseVisualStyleBackColor = true;
            // 
            // LoginForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 232);
            this.Controls.Add(this.ckbGirl);
            this.Controls.Add(this.ckbBoy);
            this.Controls.Add(this.txtTowPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPasswordAgn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.CheckBox ckbBoy;
        private System.Windows.Forms.CheckBox ckbGirl;
    }
}