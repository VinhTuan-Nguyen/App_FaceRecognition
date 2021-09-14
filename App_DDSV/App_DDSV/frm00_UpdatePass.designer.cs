
namespace App_DDSV
{
    partial class frm00_UpdatePass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_OldPass = new System.Windows.Forms.TextBox();
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.txt_AutPass = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Messenger = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ch_ShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(152, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(60, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập Mật Khẩu Mới:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(28, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập Lại Mật Khẩu Mới:";
            // 
            // txt_OldPass
            // 
            this.txt_OldPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_OldPass.BackColor = System.Drawing.SystemColors.Info;
            this.txt_OldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OldPass.Location = new System.Drawing.Point(263, 99);
            this.txt_OldPass.Multiline = true;
            this.txt_OldPass.Name = "txt_OldPass";
            this.txt_OldPass.PasswordChar = '*';
            this.txt_OldPass.Size = new System.Drawing.Size(258, 30);
            this.txt_OldPass.TabIndex = 0;
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NewPass.BackColor = System.Drawing.SystemColors.Info;
            this.txt_NewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPass.Location = new System.Drawing.Point(263, 148);
            this.txt_NewPass.Multiline = true;
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.PasswordChar = '*';
            this.txt_NewPass.Size = new System.Drawing.Size(258, 30);
            this.txt_NewPass.TabIndex = 1;
            // 
            // txt_AutPass
            // 
            this.txt_AutPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_AutPass.BackColor = System.Drawing.SystemColors.Info;
            this.txt_AutPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AutPass.Location = new System.Drawing.Point(263, 183);
            this.txt_AutPass.Name = "txt_AutPass";
            this.txt_AutPass.PasswordChar = '*';
            this.txt_AutPass.Size = new System.Drawing.Size(258, 27);
            this.txt_AutPass.TabIndex = 2;
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OK.Font = new System.Drawing.Font("Constantia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_OK.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_OK.Location = new System.Drawing.Point(99, 249);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(148, 47);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "Xác Nhận";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back.Font = new System.Drawing.Font("Constantia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Back.ForeColor = System.Drawing.Color.Brown;
            this.btn_Back.Location = new System.Drawing.Point(312, 249);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(148, 47);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Trở Về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(73, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập Mật Khẩu Cũ:";
            // 
            // lb_Messenger
            // 
            this.lb_Messenger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Messenger.AutoSize = true;
            this.lb_Messenger.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Messenger.ForeColor = System.Drawing.Color.Red;
            this.lb_Messenger.Location = new System.Drawing.Point(73, 74);
            this.lb_Messenger.Name = "lb_Messenger";
            this.lb_Messenger.Size = new System.Drawing.Size(56, 15);
            this.lb_Messenger.TabIndex = 10;
            this.lb_Messenger.Text = "Message";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ch_ShowPass
            // 
            this.ch_ShowPass.AutoSize = true;
            this.ch_ShowPass.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic);
            this.ch_ShowPass.ForeColor = System.Drawing.Color.Navy;
            this.ch_ShowPass.Location = new System.Drawing.Point(263, 216);
            this.ch_ShowPass.Name = "ch_ShowPass";
            this.ch_ShowPass.Size = new System.Drawing.Size(181, 23);
            this.ch_ShowPass.TabIndex = 12;
            this.ch_ShowPass.Text = "Hiển Thị Mật Khẩu";
            this.ch_ShowPass.UseVisualStyleBackColor = true;
            this.ch_ShowPass.CheckedChanged += new System.EventHandler(this.ch_ShowPass_CheckedChanged);
            // 
            // frm00_UpdatePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(561, 334);
            this.Controls.Add(this.ch_ShowPass);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_AutPass);
            this.Controls.Add(this.txt_NewPass);
            this.Controls.Add(this.txt_OldPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Messenger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Lavender;
            this.Name = "frm00_UpdatePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_OldPass;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.TextBox txt_AutPass;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Messenger;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox ch_ShowPass;
    }
}