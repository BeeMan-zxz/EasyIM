namespace ClientUser
{
    partial class ClientUserForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.libFriend = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(78, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(242, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "性别：";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(78, 39);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(242, 21);
            this.txtSex.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户名：";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(78, 66);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(242, 21);
            this.txtUserID.TabIndex = 1;
            // 
            // libFriend
            // 
            this.libFriend.FormattingEnabled = true;
            this.libFriend.ItemHeight = 12;
            this.libFriend.Location = new System.Drawing.Point(9, 93);
            this.libFriend.Name = "libFriend";
            this.libFriend.Size = new System.Drawing.Size(306, 556);
            this.libFriend.TabIndex = 2;
            this.libFriend.SelectedIndexChanged += new System.EventHandler(this.libFriend_SelectedIndexChanged);
            // 
            // ClientUserForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 654);
            this.Controls.Add(this.libFriend);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Name = "ClientUserForms";
            this.Text = "EasyIM";
            this.Load += new System.EventHandler(this.ClientUserForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.ListBox libFriend;
    }
}