namespace App_DDSV
{
    partial class frm00_LOGIN
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
            this.components = new System.ComponentModel.Container();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Pasword = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.ch_ShowPass = new System.Windows.Forms.CheckBox();
            this.lb_Messenger = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.Font = new System.Drawing.Font("Constantia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Login.Location = new System.Drawing.Point(78, 265);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(151, 43);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Xác Nhận";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(74, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật Khẩu";
            // 
            // txt_User
            // 
            this.txt_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_User.BackColor = System.Drawing.SystemColors.Info;
            this.txt_User.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(195, 116);
            this.txt_User.MaxLength = 10;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(284, 29);
            this.txt_User.TabIndex = 0;
            this.txt_User.Text = "Nhập User ID";
            this.txt_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_User_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(74, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(175, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "ĐĂNG NHẬP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Pasword
            // 
            this.txt_Pasword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Pasword.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Pasword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pasword.Location = new System.Drawing.Point(195, 176);
            this.txt_Pasword.Name = "txt_Pasword";
            this.txt_Pasword.PasswordChar = '*';
            this.txt_Pasword.Size = new System.Drawing.Size(284, 29);
            this.txt_Pasword.TabIndex = 1;
            this.txt_Pasword.Text = "12345";
            this.txt_Pasword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Pasword_KeyDown);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Exit.Font = new System.Drawing.Font("Constantia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Brown;
            this.btn_Exit.Location = new System.Drawing.Point(328, 265);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(151, 43);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ch_ShowPass
            // 
            this.ch_ShowPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ch_ShowPass.AutoSize = true;
            this.ch_ShowPass.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_ShowPass.ForeColor = System.Drawing.Color.Navy;
            this.ch_ShowPass.Location = new System.Drawing.Point(195, 216);
            this.ch_ShowPass.Name = "ch_ShowPass";
            this.ch_ShowPass.Size = new System.Drawing.Size(181, 23);
            this.ch_ShowPass.TabIndex = 2;
            this.ch_ShowPass.Text = "Hiển thị mật khẩu";
            this.ch_ShowPass.UseVisualStyleBackColor = true;
            this.ch_ShowPass.CheckedChanged += new System.EventHandler(this.ch_ShowPass_CheckedChanged);
            // 
            // lb_Messenger
            // 
            this.lb_Messenger.AutoSize = true;
            this.lb_Messenger.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Messenger.ForeColor = System.Drawing.Color.Red;
            this.lb_Messenger.Location = new System.Drawing.Point(192, 98);
            this.lb_Messenger.Name = "lb_Messenger";
            this.lb_Messenger.Size = new System.Drawing.Size(56, 15);
            this.lb_Messenger.TabIndex = 5;
            this.lb_Messenger.Text = "Message";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_LOGIN
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(561, 334);
            this.Controls.Add(this.lb_Messenger);
            this.Controls.Add(this.ch_ShowPass);
            this.Controls.Add(this.txt_Pasword);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Name = "frm_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Pasword;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.CheckBox ch_ShowPass;
        private System.Windows.Forms.Label lb_Messenger;
        private System.Windows.Forms.Timer timer1;
    }
}