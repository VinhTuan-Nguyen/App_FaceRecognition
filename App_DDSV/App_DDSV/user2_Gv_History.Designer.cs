
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cbb_MaHP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_TenHP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_NienKhoa = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_DataView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_View = new System.Windows.Forms.Button();
            this.cbb_List = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.col_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_GioDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_Search.Location = new System.Drawing.Point(709, 21);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(151, 81);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cbb_MaHP
            // 
            this.cbb_MaHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_MaHP.BackColor = System.Drawing.SystemColors.Info;
            this.cbb_MaHP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbb_MaHP.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_MaHP.FormattingEnabled = true;
            this.cbb_MaHP.Location = new System.Drawing.Point(516, 21);
            this.cbb_MaHP.Name = "cbb_MaHP";
            this.cbb_MaHP.Size = new System.Drawing.Size(172, 30);
            this.cbb_MaHP.TabIndex = 2;
            this.cbb_MaHP.TextChanged += new System.EventHandler(this.cbb_TenHP_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(16, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên Học Phần:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(377, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Học Phần:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1513, 86);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(497, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lịch Sử Điểm Danh";
            // 
            // cbb_TenHP
            // 
            this.cbb_TenHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_TenHP.BackColor = System.Drawing.SystemColors.Info;
            this.cbb_TenHP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbb_TenHP.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TenHP.FormattingEnabled = true;
            this.cbb_TenHP.Location = new System.Drawing.Point(160, 72);
            this.cbb_TenHP.Name = "cbb_TenHP";
            this.cbb_TenHP.Size = new System.Drawing.Size(528, 30);
            this.cbb_TenHP.TabIndex = 2;
            this.cbb_TenHP.TextChanged += new System.EventHandler(this.cbb_TenHP_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(58, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Năm Học:";
            // 
            // cbb_NienKhoa
            // 
            this.cbb_NienKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_NienKhoa.BackColor = System.Drawing.SystemColors.Info;
            this.cbb_NienKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbb_NienKhoa.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_NienKhoa.FormattingEnabled = true;
            this.cbb_NienKhoa.Location = new System.Drawing.Point(160, 21);
            this.cbb_NienKhoa.Name = "cbb_NienKhoa";
            this.cbb_NienKhoa.Size = new System.Drawing.Size(211, 30);
            this.cbb_NienKhoa.TabIndex = 2;
            this.cbb_NienKhoa.TextChanged += new System.EventHandler(this.cbb_NienKhoa_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1513, 812);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhật Kí Điểm Danh";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_DataView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(3, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1507, 653);
            this.panel4.TabIndex = 4;
            // 
            // dgv_DataView
            // 
            this.dgv_DataView.AllowUserToAddRows = false;
            this.dgv_DataView.AllowUserToDeleteRows = false;
            this.dgv_DataView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DataView.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Stt,
            this.col_NgayDD,
            this.col_MaHP,
            this.col_MaSV,
            this.col_HoTen,
            this.col_NgaySinh,
            this.col_Lop,
            this.col_Email,
            this.col_GioiTinh,
            this.col_GioDD,
            this.col_GhiChu});
            this.dgv_DataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DataView.Location = new System.Drawing.Point(0, 0);
            this.dgv_DataView.Name = "dgv_DataView";
            this.dgv_DataView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DataView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DataView.Size = new System.Drawing.Size(1507, 653);
            this.dgv_DataView.TabIndex = 1;
            this.dgv_DataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DataView_CellDoubleClick);
            this.dgv_DataView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_DataView_RowPrePaint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbb_NienKhoa);
            this.panel3.Controls.Add(this.btn_View);
            this.panel3.Controls.Add(this.cbb_TenHP);
            this.panel3.Controls.Add(this.cbb_List);
            this.panel3.Controls.Add(this.cbb_MaHP);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btn_Search);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1507, 120);
            this.panel3.TabIndex = 4;
            // 
            // btn_View
            // 
            this.btn_View.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_View.FlatAppearance.BorderSize = 0;
            this.btn_View.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_View.Location = new System.Drawing.Point(1346, 28);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(125, 66);
            this.btn_View.TabIndex = 3;
            this.btn_View.Text = "Lọc";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // cbb_List
            // 
            this.cbb_List.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbb_List.BackColor = System.Drawing.SystemColors.Info;
            this.cbb_List.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbb_List.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_List.FormatString = "yyyy-MM-dd HH:mm";
            this.cbb_List.FormattingEnabled = true;
            this.cbb_List.Location = new System.Drawing.Point(911, 64);
            this.cbb_List.Name = "cbb_List";
            this.cbb_List.Size = new System.Drawing.Size(414, 30);
            this.cbb_List.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(911, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Danh Sách Các Buổi Điểm Danh:";
            // 
            // col_Stt
            // 
            this.col_Stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Stt.HeaderText = "STT";
            this.col_Stt.Name = "col_Stt";
            this.col_Stt.Width = 50;
            // 
            // col_NgayDD
            // 
            this.col_NgayDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_NgayDD.DataPropertyName = "col_NgayDD";
            this.col_NgayDD.HeaderText = "Ngày ĐD";
            this.col_NgayDD.Name = "col_NgayDD";
            this.col_NgayDD.Width = 170;
            // 
            // col_MaHP
            // 
            this.col_MaHP.DataPropertyName = "col_MaHP";
            this.col_MaHP.HeaderText = "Mã HP";
            this.col_MaHP.Name = "col_MaHP";
            this.col_MaHP.Width = 150;
            // 
            // col_MaSV
            // 
            this.col_MaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_MaSV.DataPropertyName = "col_MaSV";
            this.col_MaSV.HeaderText = "MSSV";
            this.col_MaSV.Name = "col_MaSV";
            this.col_MaSV.Width = 150;
            // 
            // col_HoTen
            // 
            this.col_HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_HoTen.DataPropertyName = "col_HoTen";
            this.col_HoTen.HeaderText = "Họ Tên";
            this.col_HoTen.Name = "col_HoTen";
            this.col_HoTen.Width = 250;
            // 
            // col_NgaySinh
            // 
            this.col_NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_NgaySinh.DataPropertyName = "col_NgaySinh";
            this.col_NgaySinh.HeaderText = "Ngày Sinh";
            this.col_NgaySinh.Name = "col_NgaySinh";
            this.col_NgaySinh.Width = 150;
            // 
            // col_Lop
            // 
            this.col_Lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Lop.DataPropertyName = "col_Lop";
            this.col_Lop.HeaderText = "Lớp";
            this.col_Lop.Name = "col_Lop";
            this.col_Lop.Width = 120;
            // 
            // col_Email
            // 
            this.col_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Email.DataPropertyName = "col_Email";
            this.col_Email.HeaderText = "Email";
            this.col_Email.MinimumWidth = 350;
            this.col_Email.Name = "col_Email";
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GioiTinh.DataPropertyName = "col_GioiTinh";
            this.col_GioiTinh.HeaderText = "Nam";
            this.col_GioiTinh.Name = "col_GioiTinh";
            this.col_GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_GioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_GioiTinh.Width = 80;
            // 
            // col_GioDD
            // 
            this.col_GioDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GioDD.DataPropertyName = "col_GioDD";
            this.col_GioDD.HeaderText = "Điểm Danh Lúc";
            this.col_GioDD.Name = "col_GioDD";
            this.col_GioDD.Width = 200;
            // 
            // col_GhiChu
            // 
            this.col_GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GhiChu.DataPropertyName = "col_GhiChu";
            this.col_GhiChu.HeaderText = "Ghi Chú";
            this.col_GhiChu.Name = "col_GhiChu";
            this.col_GhiChu.Width = 200;
            // 
            // user2_Gv_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "user2_Gv_History";
            this.Size = new System.Drawing.Size(1513, 898);
            this.Load += new System.EventHandler(this.user2_Gv_History_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cbb_MaHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_TenHP;
        private System.Windows.Forms.ComboBox cbb_NienKhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_DataView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.ComboBox cbb_List;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GhiChu;
    }
}
