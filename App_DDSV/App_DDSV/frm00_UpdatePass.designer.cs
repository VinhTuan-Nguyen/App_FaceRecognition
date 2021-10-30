
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
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Messenger = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ch_ShowPass = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(151, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(71, 173);
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
            this.label3.Location = new System.Drawing.Point(39, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập Lại Mật Khẩu Mới:";
            // 
            // txt_OldPass
            // 
            this.txt_OldPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_OldPass.BackColor = System.Drawing.SystemColors.Info;
            this.txt_OldPass.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OldPass.Location = new System.Drawing.Point(274, 120);
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
            this.txt_NewPass.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPass.Location = new System.Drawing.Point(274, 169);
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
            this.txt_AutPass.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AutPass.Location = new System.Drawing.Point(274, 204);
            this.txt_AutPass.Name = "txt_AutPass";
            this.txt_AutPass.PasswordChar = '*';
            this.txt_AutPass.Size = new System.Drawing.Size(258, 30);
            this.txt_AutPass.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(84, 124);
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
            this.lb_Messenger.Location = new System.Drawing.Point(84, 95);
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
            this.ch_ShowPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ch_ShowPass.AutoSize = true;
            this.ch_ShowPass.FlatAppearance.BorderSize = 0;
            this.ch_ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_ShowPass.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic);
            this.ch_ShowPass.ForeColor = System.Drawing.Color.Navy;
            this.ch_ShowPass.Location = new System.Drawing.Point(274, 237);
            this.ch_ShowPass.Name = "ch_ShowPass";
            this.ch_ShowPass.Size = new System.Drawing.Size(178, 23);
            this.ch_ShowPass.TabIndex = 12;
            this.ch_ShowPass.Text = "Hiển Thị Mật Khẩu";
            this.ch_ShowPass.UseVisualStyleBackColor = true;
            this.ch_ShowPass.CheckedChanged += new System.EventHandler(this.ch_ShowPass_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.btn_OK);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ch_ShowPass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lb_Messenger);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_AutPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_NewPass);
            this.panel1.Controls.Add(this.txt_OldPass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 358);
            this.panel1.TabIndex = 13;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Brown;
            this.btn_Back.Location = new System.Drawing.Point(421, 284);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(111, 45);
            this.btn_Back.TabIndex = 15;
            this.btn_Back.Text = "Trở Về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            this.btn_Back.MouseLeave += new System.EventHandler(this.btn_Back_MouseLeave);
            this.btn_Back.MouseHover += new System.EventHandler(this.btn_Back_MouseHover);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_OK.Location = new System.Drawing.Point(273, 284);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(145, 45);
            this.btn_OK.TabIndex = 14;
            this.btn_OK.Text = "Xác Nhận";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            this.btn_OK.MouseLeave += new System.EventHandler(this.btn_OK_MouseLeave);
            this.btn_OK.MouseHover += new System.EventHandler(this.btn_OK_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 70);
            this.panel2.TabIndex = 13;
            // 
            // frm00_UpdatePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(587, 358);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Lavender;
            this.Name = "frm00_UpdatePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_OldPass;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.TextBox txt_AutPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Messenger;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox ch_ShowPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_OK;
    }
}