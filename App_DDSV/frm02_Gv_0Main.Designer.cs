
namespace App_DDSV
{
    partial class frm02_Gv_0Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.item_Main = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinĐiểmDanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item_ClassInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.item_History = new System.Windows.Forms.ToolStripMenuItem();
            this.item_CreateStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item_InfoLecturers = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Upass = new System.Windows.Forms.ToolStripMenuItem();
            this.item_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Font = new System.Drawing.Font("Constantia", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_Main,
            this.thôngTinĐiểmDanhToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1479, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // item_Main
            // 
            this.item_Main.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_Main.ForeColor = System.Drawing.Color.MediumBlue;
            this.item_Main.Name = "item_Main";
            this.item_Main.Size = new System.Drawing.Size(136, 27);
            this.item_Main.Text = "Về Trang Chủ";
            this.item_Main.Click += new System.EventHandler(this.item_Main_Click);
            // 
            // thôngTinĐiểmDanhToolStripMenuItem
            // 
            this.thôngTinĐiểmDanhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_ClassInfo,
            this.item_History,
            this.item_CreateStudent});
            this.thôngTinĐiểmDanhToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinĐiểmDanhToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue;
            this.thôngTinĐiểmDanhToolStripMenuItem.Name = "thôngTinĐiểmDanhToolStripMenuItem";
            this.thôngTinĐiểmDanhToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.thôngTinĐiểmDanhToolStripMenuItem.Text = "Lớp Học";
            // 
            // item_ClassInfo
            // 
            this.item_ClassInfo.Name = "item_ClassInfo";
            this.item_ClassInfo.Size = new System.Drawing.Size(242, 28);
            this.item_ClassInfo.Text = "Điểm Danh";
            this.item_ClassInfo.Click += new System.EventHandler(this.item_ClassInfo_Click);
            // 
            // item_History
            // 
            this.item_History.Name = "item_History";
            this.item_History.Size = new System.Drawing.Size(242, 28);
            this.item_History.Text = "Lịch Sử Điểm Danh";
            this.item_History.Click += new System.EventHandler(this.item_History_Click);
            // 
            // item_CreateStudent
            // 
            this.item_CreateStudent.Name = "item_CreateStudent";
            this.item_CreateStudent.Size = new System.Drawing.Size(242, 28);
            this.item_CreateStudent.Text = "Tạo Sinh Viên Mới";
            this.item_CreateStudent.Click += new System.EventHandler(this.item_CreateStudent_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_InfoLecturers,
            this.item_Upass,
            this.item_LogOut});
            this.thôngTinCáNhânToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinCáNhânToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue;
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.thôngTinCáNhânToolStripMenuItem.Text = " Cá Nhân";
            // 
            // item_InfoLecturers
            // 
            this.item_InfoLecturers.Name = "item_InfoLecturers";
            this.item_InfoLecturers.Size = new System.Drawing.Size(243, 28);
            this.item_InfoLecturers.Text = "Thông Tin Cá Nhân";
            this.item_InfoLecturers.Click += new System.EventHandler(this.item_InfoLecturers_Click);
            // 
            // item_Upass
            // 
            this.item_Upass.Name = "item_Upass";
            this.item_Upass.Size = new System.Drawing.Size(243, 28);
            this.item_Upass.Text = "Đổi Mật Khẩu";
            this.item_Upass.Click += new System.EventHandler(this.item_Upass_Click);
            // 
            // item_LogOut
            // 
            this.item_LogOut.Name = "item_LogOut";
            this.item_LogOut.Size = new System.Drawing.Size(243, 28);
            this.item_LogOut.Text = "Đăng Xuất";
            this.item_LogOut.Click += new System.EventHandler(this.item_Logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 834);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::App_DDSV.Properties.Resources.logo_CTUT;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(490, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(569, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 47);
            this.label7.TabIndex = 16;
            this.label7.Text = "Trang Điểm Danh";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(654, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 36);
            this.label4.TabIndex = 19;
            this.label4.Text = "HỆ THỐNG";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(468, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(542, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "TRƯỜNG ĐẠI HỌC KĨ THUẬT - CÔNG NGHỆ CẦN THƠ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(455, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(568, 59);
            this.label5.TabIndex = 18;
            this.label5.Text = "ĐIỂM DANH SINH VIÊN";
            // 
            // frm02_Gv_0Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1479, 865);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm02_Gv_0Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item_InfoLecturers;
        private System.Windows.Forms.ToolStripMenuItem item_Upass;
        private System.Windows.Forms.ToolStripMenuItem thôngTinĐiểmDanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item_ClassInfo;
        private System.Windows.Forms.ToolStripMenuItem item_History;
        private System.Windows.Forms.ToolStripMenuItem item_Main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem item_LogOut;
        private System.Windows.Forms.ToolStripMenuItem item_CreateStudent;
    }
}