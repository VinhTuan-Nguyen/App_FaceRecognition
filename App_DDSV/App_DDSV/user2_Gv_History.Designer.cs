﻿
namespace App_DDSV
{
    partial class user2_Gv_History
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TenHP = new System.Windows.Forms.TextBox();
            this.btn_View = new System.Windows.Forms.Button();
            this.btn_GetList = new System.Windows.Forms.Button();
            this.cbb_List = new System.Windows.Forms.ComboBox();
            this.cbb_MaHP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_Start = new System.Windows.Forms.DateTimePicker();
            this.date_End = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(772, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lịch Sử Điểm Danh";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.txt_TenHP);
            this.groupBox2.Controls.Add(this.btn_View);
            this.groupBox2.Controls.Add(this.btn_GetList);
            this.groupBox2.Controls.Add(this.cbb_List);
            this.groupBox2.Controls.Add(this.cbb_MaHP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.date_Start);
            this.groupBox2.Controls.Add(this.date_End);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1924, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Công Cụ";
            // 
            // txt_TenHP
            // 
            this.txt_TenHP.Enabled = false;
            this.txt_TenHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHP.Location = new System.Drawing.Point(720, 66);
            this.txt_TenHP.Name = "txt_TenHP";
            this.txt_TenHP.Size = new System.Drawing.Size(362, 27);
            this.txt_TenHP.TabIndex = 4;
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.Location = new System.Drawing.Point(1731, 19);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(127, 74);
            this.btn_View.TabIndex = 3;
            this.btn_View.Text = "Xem";
            this.btn_View.UseVisualStyleBackColor = true;
            // 
            // btn_GetList
            // 
            this.btn_GetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetList.Location = new System.Drawing.Point(1118, 19);
            this.btn_GetList.Name = "btn_GetList";
            this.btn_GetList.Size = new System.Drawing.Size(127, 74);
            this.btn_GetList.TabIndex = 3;
            this.btn_GetList.Text = "Lấy Danh Sách Lớp";
            this.btn_GetList.UseVisualStyleBackColor = true;
            // 
            // cbb_List
            // 
            this.cbb_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_List.FormattingEnabled = true;
            this.cbb_List.Location = new System.Drawing.Point(1281, 65);
            this.cbb_List.Name = "cbb_List";
            this.cbb_List.Size = new System.Drawing.Size(414, 28);
            this.cbb_List.TabIndex = 2;
            // 
            // cbb_MaHP
            // 
            this.cbb_MaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_MaHP.FormattingEnabled = true;
            this.cbb_MaHP.Location = new System.Drawing.Point(720, 19);
            this.cbb_MaHP.Name = "cbb_MaHP";
            this.cbb_MaHP.Size = new System.Drawing.Size(181, 28);
            this.cbb_MaHP.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1281, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Danh Sách Các Buổi Điểm Danh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên Học Phần:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Học Phần:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến Ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ Ngày:";
            // 
            // date_Start
            // 
            this.date_Start.CustomFormat = "dd - mm - yyyy";
            this.date_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Start.Location = new System.Drawing.Point(59, 66);
            this.date_Start.Name = "date_Start";
            this.date_Start.Size = new System.Drawing.Size(231, 27);
            this.date_Start.TabIndex = 0;
            this.date_Start.Value = new System.DateTime(2021, 9, 12, 10, 7, 0, 0);
            // 
            // date_End
            // 
            this.date_End.CustomFormat = "dd - mm - yyyy";
            this.date_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_End.Location = new System.Drawing.Point(326, 66);
            this.date_End.Name = "date_End";
            this.date_End.Size = new System.Drawing.Size(231, 27);
            this.date_End.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1924, 851);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Điểm Danh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Stt,
            this.col_MaSV,
            this.col_HoLot,
            this.col_Ten,
            this.col_Lop,
            this.col_Email,
            this.col_GioiTinh,
            this.col_GhiChu});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1918, 832);
            this.dataGridView1.TabIndex = 1;
            // 
            // col_Stt
            // 
            this.col_Stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Stt.HeaderText = "STT";
            this.col_Stt.Name = "col_Stt";
            this.col_Stt.Width = 50;
            // 
            // col_MaSV
            // 
            this.col_MaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_MaSV.HeaderText = "Mã Số Sinh Viên";
            this.col_MaSV.Name = "col_MaSV";
            this.col_MaSV.Width = 200;
            // 
            // col_HoLot
            // 
            this.col_HoLot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_HoLot.HeaderText = "Họ Đệm";
            this.col_HoLot.Name = "col_HoLot";
            this.col_HoLot.Width = 200;
            // 
            // col_Ten
            // 
            this.col_Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Ten.HeaderText = "Tên SV";
            this.col_Ten.Name = "col_Ten";
            this.col_Ten.Width = 120;
            // 
            // col_Lop
            // 
            this.col_Lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Lop.HeaderText = "Lớp";
            this.col_Lop.Name = "col_Lop";
            this.col_Lop.Width = 120;
            // 
            // col_Email
            // 
            this.col_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Email.HeaderText = "Email";
            this.col_Email.Name = "col_Email";
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GioiTinh.HeaderText = "Nam";
            this.col_GioiTinh.Name = "col_GioiTinh";
            this.col_GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_GioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_GioiTinh.Width = 80;
            // 
            // col_GhiChu
            // 
            this.col_GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GhiChu.HeaderText = "Ghi Chú";
            this.col_GhiChu.Name = "col_GhiChu";
            this.col_GhiChu.Width = 200;
            // 
            // user2_Gv_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "user2_Gv_History";
            this.Size = new System.Drawing.Size(1924, 1034);
            this.Load += new System.EventHandler(this.user2_Gv_History_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker date_End;
        private System.Windows.Forms.TextBox txt_TenHP;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button btn_GetList;
        private System.Windows.Forms.ComboBox cbb_List;
        private System.Windows.Forms.ComboBox cbb_MaHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GhiChu;
    }
}