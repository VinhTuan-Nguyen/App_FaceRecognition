
namespace App_DDSV
{
    partial class frm01_Qt_ClassEdit
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
            this.cbb_Thu = new System.Windows.Forms.ComboBox();
            this.pick_End = new System.Windows.Forms.DateTimePicker();
            this.pick_Star = new System.Windows.Forms.DateTimePicker();
            this.txt_MaGV = new System.Windows.Forms.TextBox();
            this.txt_TenHP = new System.Windows.Forms.TextBox();
            this.txt_MaHP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_NienKhoa = new System.Windows.Forms.TextBox();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_Thu
            // 
            this.cbb_Thu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbb_Thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Thu.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Thu.FormattingEnabled = true;
            this.cbb_Thu.Items.AddRange(new object[] {
            "T2",
            "T3",
            "T4",
            "T5",
            "T6",
            "T7",
            "CN"});
            this.cbb_Thu.Location = new System.Drawing.Point(302, 297);
            this.cbb_Thu.Name = "cbb_Thu";
            this.cbb_Thu.Size = new System.Drawing.Size(82, 30);
            this.cbb_Thu.TabIndex = 20;
            // 
            // pick_End
            // 
            this.pick_End.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pick_End.CustomFormat = "dd - MM - yyyy";
            this.pick_End.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_End.Location = new System.Drawing.Point(414, 381);
            this.pick_End.Name = "pick_End";
            this.pick_End.Size = new System.Drawing.Size(266, 30);
            this.pick_End.TabIndex = 18;
            this.pick_End.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // pick_Star
            // 
            this.pick_Star.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pick_Star.CustomFormat = "dd - MM - yyyy";
            this.pick_Star.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_Star.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_Star.Location = new System.Drawing.Point(414, 296);
            this.pick_Star.Name = "pick_Star";
            this.pick_Star.Size = new System.Drawing.Size(266, 30);
            this.pick_Star.TabIndex = 19;
            this.pick_Star.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.pick_Star.ValueChanged += new System.EventHandler(this.pick_Star_ValueChanged);
            // 
            // txt_MaGV
            // 
            this.txt_MaGV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_MaGV.BackColor = System.Drawing.SystemColors.Info;
            this.txt_MaGV.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaGV.Location = new System.Drawing.Point(48, 297);
            this.txt_MaGV.MaxLength = 10;
            this.txt_MaGV.Name = "txt_MaGV";
            this.txt_MaGV.Size = new System.Drawing.Size(230, 30);
            this.txt_MaGV.TabIndex = 15;
            // 
            // txt_TenHP
            // 
            this.txt_TenHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_TenHP.BackColor = System.Drawing.SystemColors.Info;
            this.txt_TenHP.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHP.Location = new System.Drawing.Point(48, 130);
            this.txt_TenHP.MaxLength = 100;
            this.txt_TenHP.Name = "txt_TenHP";
            this.txt_TenHP.Size = new System.Drawing.Size(461, 30);
            this.txt_TenHP.TabIndex = 16;
            // 
            // txt_MaHP
            // 
            this.txt_MaHP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_MaHP.BackColor = System.Drawing.SystemColors.Info;
            this.txt_MaHP.Enabled = false;
            this.txt_MaHP.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHP.Location = new System.Drawing.Point(48, 212);
            this.txt_MaHP.MaxLength = 10;
            this.txt_MaHP.Name = "txt_MaHP";
            this.txt_MaHP.Size = new System.Drawing.Size(336, 30);
            this.txt_MaHP.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(48, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Trạng Thái:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(414, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày Kết Thúc:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(414, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày Bắt Đầu:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(302, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Thứ:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(48, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã Giảng Viên:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(48, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Học Phần:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(48, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã Học Phần:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(414, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Năm Học";
            // 
            // txt_NienKhoa
            // 
            this.txt_NienKhoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_NienKhoa.BackColor = System.Drawing.SystemColors.Info;
            this.txt_NienKhoa.Enabled = false;
            this.txt_NienKhoa.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NienKhoa.Location = new System.Drawing.Point(414, 212);
            this.txt_NienKhoa.MaxLength = 100;
            this.txt_NienKhoa.Name = "txt_NienKhoa";
            this.txt_NienKhoa.Size = new System.Drawing.Size(266, 30);
            this.txt_NienKhoa.TabIndex = 16;
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_TrangThai.BackColor = System.Drawing.SystemColors.Info;
            this.txt_TrangThai.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TrangThai.Location = new System.Drawing.Point(48, 382);
            this.txt_TrangThai.MaxLength = 25;
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(336, 30);
            this.txt_TrangThai.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 70);
            this.panel2.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(212, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(290, 49);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lớp Học Phần";
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Brown;
            this.btn_Back.Location = new System.Drawing.Point(572, 423);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(108, 43);
            this.btn_Back.TabIndex = 25;
            this.btn_Back.Text = "Trở Về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            this.btn_Back.MouseLeave += new System.EventHandler(this.btn_Back_MouseLeave);
            this.btn_Back.MouseHover += new System.EventHandler(this.btn_Back_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Location = new System.Drawing.Point(541, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 55);
            this.panel1.TabIndex = 26;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = global::App_DDSV.Properties.Resources.delete;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(76, 9);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(55, 35);
            this.btn_Delete.TabIndex = 23;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImage = global::App_DDSV.Properties.Resources.tick;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(12, 9);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(55, 35);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // frm01_Qt_ClassEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(714, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbb_Thu);
            this.Controls.Add(this.pick_End);
            this.Controls.Add(this.pick_Star);
            this.Controls.Add(this.txt_TrangThai);
            this.Controls.Add(this.txt_MaGV);
            this.Controls.Add(this.txt_NienKhoa);
            this.Controls.Add(this.txt_TenHP);
            this.Controls.Add(this.txt_MaHP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm01_Qt_ClassEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Lớp Học Phần";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbb_Thu;
        private System.Windows.Forms.DateTimePicker pick_End;
        private System.Windows.Forms.DateTimePicker pick_Star;
        private System.Windows.Forms.TextBox txt_MaGV;
        private System.Windows.Forms.TextBox txt_TenHP;
        private System.Windows.Forms.TextBox txt_MaHP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_NienKhoa;
        private System.Windows.Forms.TextBox txt_TrangThai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel1;
    }
}