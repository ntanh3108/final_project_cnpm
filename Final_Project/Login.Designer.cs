
namespace Final_Project
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_login_account = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_login_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_showPass = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // tb_login_account
            // 
            this.tb_login_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login_account.Location = new System.Drawing.Point(420, 185);
            this.tb_login_account.Margin = new System.Windows.Forms.Padding(4);
            this.tb_login_account.Name = "tb_login_account";
            this.tb_login_account.Size = new System.Drawing.Size(319, 27);
            this.tb_login_account.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu:";
            // 
            // tb_login_password
            // 
            this.tb_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login_password.Location = new System.Drawing.Point(420, 248);
            this.tb_login_password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_login_password.Name = "tb_login_password";
            this.tb_login_password.PasswordChar = '*';
            this.tb_login_password.Size = new System.Drawing.Size(319, 27);
            this.tb_login_password.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(619, 358);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(120, 54);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "ĐĂNG NHẬP";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quên Mật Khẩu?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cb_showPass
            // 
            this.cb_showPass.AutoSize = true;
            this.cb_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_showPass.Location = new System.Drawing.Point(420, 313);
            this.cb_showPass.Name = "cb_showPass";
            this.cb_showPass.Size = new System.Drawing.Size(142, 24);
            this.cb_showPass.TabIndex = 7;
            this.cb_showPass.Text = "Hiện Mật Khẩu";
            this.cb_showPass.UseVisualStyleBackColor = true;
            this.cb_showPass.CheckedChanged += new System.EventHandler(this.cb_showPass_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(759, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Designed by Tuan Anh Nguyen";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_showPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_login_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_login_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_login_account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_login_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_showPass;
        private System.Windows.Forms.Label label5;
    }
}

