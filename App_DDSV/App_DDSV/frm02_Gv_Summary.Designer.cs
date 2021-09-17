
namespace App_DDSV
{
    partial class frm02_Gv_Summary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_DateTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Khac = new System.Windows.Forms.TextBox();
            this.txt_HienDien = new System.Windows.Forms.TextBox();
            this.txt_Khong = new System.Windows.Forms.TextBox();
            this.txt_Phep = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.txt_TenHP = new System.Windows.Forms.TextBox();
            this.txt_MaHP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Summary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_SummaryNotYet = new System.Windows.Forms.DataGridView();
            this.col_Stt_ChuaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Masv_ChuaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoLot_ChuaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten_ChuaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayDD_ChuaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GhiChu_ChuaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_SummaryDone = new System.Windows.Forms.DataGridView();
            this.col_Stt_DaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Masv_DaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoLot_DaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten_DaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_NgayDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GhiChu_DaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SummaryNotYet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SummaryDone)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 70);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(435, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng Kết Điểm Danh";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Học Phần";
            // 
            // lb_DateTime
            // 
            this.lb_DateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_DateTime.AutoSize = true;
            this.lb_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DateTime.Location = new System.Drawing.Point(25, 235);
            this.lb_DateTime.Name = "lb_DateTime";
            this.lb_DateTime.Size = new System.Drawing.Size(200, 20);
            this.lb_DateTime.TabIndex = 5;
            this.lb_DateTime.Text = "Ngày Giờ Mở Điểm Danh:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Khac);
            this.groupBox2.Controls.Add(this.txt_HienDien);
            this.groupBox2.Controls.Add(this.txt_Khong);
            this.groupBox2.Controls.Add(this.txt_Phep);
            this.groupBox2.Controls.Add(this.txt_Date);
            this.groupBox2.Controls.Add(this.txt_TenHP);
            this.groupBox2.Controls.Add(this.txt_MaHP);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btn_Summary);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lb_DateTime);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F);
            this.groupBox2.Location = new System.Drawing.Point(0, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 752);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng Kết Điểm Danh";
            // 
            // txt_Khac
            // 
            this.txt_Khac.Enabled = false;
            this.txt_Khac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Khac.Location = new System.Drawing.Point(203, 494);
            this.txt_Khac.Name = "txt_Khac";
            this.txt_Khac.Size = new System.Drawing.Size(146, 35);
            this.txt_Khac.TabIndex = 9;
            this.txt_Khac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_HienDien
            // 
            this.txt_HienDien.Enabled = false;
            this.txt_HienDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HienDien.Location = new System.Drawing.Point(12, 494);
            this.txt_HienDien.Name = "txt_HienDien";
            this.txt_HienDien.Size = new System.Drawing.Size(146, 35);
            this.txt_HienDien.TabIndex = 9;
            this.txt_HienDien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Khong
            // 
            this.txt_Khong.Enabled = false;
            this.txt_Khong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Khong.Location = new System.Drawing.Point(203, 387);
            this.txt_Khong.Name = "txt_Khong";
            this.txt_Khong.Size = new System.Drawing.Size(146, 35);
            this.txt_Khong.TabIndex = 9;
            this.txt_Khong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Phep
            // 
            this.txt_Phep.Enabled = false;
            this.txt_Phep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phep.Location = new System.Drawing.Point(12, 387);
            this.txt_Phep.Name = "txt_Phep";
            this.txt_Phep.Size = new System.Drawing.Size(146, 35);
            this.txt_Phep.TabIndex = 9;
            this.txt_Phep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Date
            // 
            this.txt_Date.Enabled = false;
            this.txt_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Date.Location = new System.Drawing.Point(12, 269);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(337, 35);
            this.txt_Date.TabIndex = 9;
            this.txt_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TenHP
            // 
            this.txt_TenHP.Enabled = false;
            this.txt_TenHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHP.Location = new System.Drawing.Point(12, 179);
            this.txt_TenHP.Name = "txt_TenHP";
            this.txt_TenHP.Size = new System.Drawing.Size(337, 35);
            this.txt_TenHP.TabIndex = 9;
            this.txt_TenHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_MaHP
            // 
            this.txt_MaHP.Enabled = false;
            this.txt_MaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHP.Location = new System.Drawing.Point(12, 98);
            this.txt_MaHP.Name = "txt_MaHP";
            this.txt_MaHP.Size = new System.Drawing.Size(337, 35);
            this.txt_MaHP.TabIndex = 9;
            this.txt_MaHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(250, 462);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Khác:";
            // 
            // btn_Summary
            // 
            this.btn_Summary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Summary.Location = new System.Drawing.Point(86, 593);
            this.btn_Summary.Name = "btn_Summary";
            this.btn_Summary.Size = new System.Drawing.Size(183, 100);
            this.btn_Summary.TabIndex = 6;
            this.btn_Summary.Text = "Kết Thúc Buổi Điểm Danh";
            this.btn_Summary.UseVisualStyleBackColor = true;
            this.btn_Summary.Click += new System.EventHandler(this.btn_Summary_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Học Phần:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Hiện Diện:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(203, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Vắng Không Phép:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vắng Có Phép:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.dgv_SummaryNotYet);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(355, 70);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(924, 365);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chưa Điểm Danh";
            // 
            // dgv_SummaryNotYet
            // 
            this.dgv_SummaryNotYet.AllowUserToAddRows = false;
            this.dgv_SummaryNotYet.AllowUserToDeleteRows = false;
            this.dgv_SummaryNotYet.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_SummaryNotYet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_SummaryNotYet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SummaryNotYet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_SummaryNotYet.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SummaryNotYet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_SummaryNotYet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SummaryNotYet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Stt_ChuaDiemDanh,
            this.col_Masv_ChuaDiemDanh,
            this.col_HoLot_ChuaDiemDanh,
            this.col_Ten_ChuaDiemDanh,
            this.col_NgayDD_ChuaDiemDanh,
            this.col_GhiChu_ChuaDiemDanh});
            this.dgv_SummaryNotYet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SummaryNotYet.Location = new System.Drawing.Point(2, 22);
            this.dgv_SummaryNotYet.Name = "dgv_SummaryNotYet";
            this.dgv_SummaryNotYet.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.75F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_SummaryNotYet.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_SummaryNotYet.RowTemplate.Height = 24;
            this.dgv_SummaryNotYet.Size = new System.Drawing.Size(920, 341);
            this.dgv_SummaryNotYet.TabIndex = 1;
            // 
            // col_Stt_ChuaDiemDanh
            // 
            this.col_Stt_ChuaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Stt_ChuaDiemDanh.HeaderText = "STT";
            this.col_Stt_ChuaDiemDanh.Name = "col_Stt_ChuaDiemDanh";
            this.col_Stt_ChuaDiemDanh.Width = 50;
            // 
            // col_Masv_ChuaDiemDanh
            // 
            this.col_Masv_ChuaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Masv_ChuaDiemDanh.HeaderText = "Mã SV";
            this.col_Masv_ChuaDiemDanh.Name = "col_Masv_ChuaDiemDanh";
            this.col_Masv_ChuaDiemDanh.Width = 120;
            // 
            // col_HoLot_ChuaDiemDanh
            // 
            this.col_HoLot_ChuaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_HoLot_ChuaDiemDanh.HeaderText = "Họ lót";
            this.col_HoLot_ChuaDiemDanh.Name = "col_HoLot_ChuaDiemDanh";
            // 
            // col_Ten_ChuaDiemDanh
            // 
            this.col_Ten_ChuaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Ten_ChuaDiemDanh.HeaderText = "Tên SV";
            this.col_Ten_ChuaDiemDanh.Name = "col_Ten_ChuaDiemDanh";
            this.col_Ten_ChuaDiemDanh.Width = 150;
            // 
            // col_NgayDD_ChuaDiemDanh
            // 
            this.col_NgayDD_ChuaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_NgayDD_ChuaDiemDanh.HeaderText = "Ngày Điểm Danh";
            this.col_NgayDD_ChuaDiemDanh.Name = "col_NgayDD_ChuaDiemDanh";
            this.col_NgayDD_ChuaDiemDanh.Width = 400;
            // 
            // col_GhiChu_ChuaDiemDanh
            // 
            this.col_GhiChu_ChuaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GhiChu_ChuaDiemDanh.HeaderText = "Ghi Chú";
            this.col_GhiChu_ChuaDiemDanh.Name = "col_GhiChu_ChuaDiemDanh";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.dgv_SummaryDone);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(355, 435);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(924, 387);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đã Điểm Danh";
            // 
            // dgv_SummaryDone
            // 
            this.dgv_SummaryDone.AllowUserToAddRows = false;
            this.dgv_SummaryDone.AllowUserToDeleteRows = false;
            this.dgv_SummaryDone.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.75F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_SummaryDone.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_SummaryDone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SummaryDone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_SummaryDone.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SummaryDone.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_SummaryDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SummaryDone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Stt_DaDiemDanh,
            this.col_Masv_DaDiemDanh,
            this.col_HoLot_DaDiemDanh,
            this.col_Ten_DaDiemDanh,
            this.Col_NgayDD,
            this.col_GioDD,
            this.col_GhiChu_DaDiemDanh});
            this.dgv_SummaryDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SummaryDone.Location = new System.Drawing.Point(2, 22);
            this.dgv_SummaryDone.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_SummaryDone.Name = "dgv_SummaryDone";
            this.dgv_SummaryDone.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.75F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_SummaryDone.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_SummaryDone.RowTemplate.Height = 24;
            this.dgv_SummaryDone.Size = new System.Drawing.Size(920, 363);
            this.dgv_SummaryDone.TabIndex = 0;
            // 
            // col_Stt_DaDiemDanh
            // 
            this.col_Stt_DaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Stt_DaDiemDanh.HeaderText = "STT";
            this.col_Stt_DaDiemDanh.Name = "col_Stt_DaDiemDanh";
            this.col_Stt_DaDiemDanh.Width = 50;
            // 
            // col_Masv_DaDiemDanh
            // 
            this.col_Masv_DaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Masv_DaDiemDanh.FillWeight = 21F;
            this.col_Masv_DaDiemDanh.HeaderText = "Mã SV";
            this.col_Masv_DaDiemDanh.Name = "col_Masv_DaDiemDanh";
            this.col_Masv_DaDiemDanh.Width = 120;
            // 
            // col_HoLot_DaDiemDanh
            // 
            this.col_HoLot_DaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_HoLot_DaDiemDanh.FillWeight = 19.54171F;
            this.col_HoLot_DaDiemDanh.HeaderText = "Họ lót";
            this.col_HoLot_DaDiemDanh.Name = "col_HoLot_DaDiemDanh";
            // 
            // col_Ten_DaDiemDanh
            // 
            this.col_Ten_DaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Ten_DaDiemDanh.FillWeight = 19.54171F;
            this.col_Ten_DaDiemDanh.HeaderText = "Tên SV";
            this.col_Ten_DaDiemDanh.Name = "col_Ten_DaDiemDanh";
            this.col_Ten_DaDiemDanh.Width = 150;
            // 
            // Col_NgayDD
            // 
            this.Col_NgayDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col_NgayDD.FillWeight = 19.54171F;
            this.Col_NgayDD.HeaderText = "Ngày Điểm Danh";
            this.Col_NgayDD.Name = "Col_NgayDD";
            this.Col_NgayDD.Width = 200;
            // 
            // col_GioDD
            // 
            this.col_GioDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GioDD.FillWeight = 19.54172F;
            this.col_GioDD.HeaderText = "Điểm Danh Lúc";
            this.col_GioDD.Name = "col_GioDD";
            this.col_GioDD.Width = 200;
            // 
            // col_GhiChu_DaDiemDanh
            // 
            this.col_GhiChu_DaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_GhiChu_DaDiemDanh.FillWeight = 19.54171F;
            this.col_GhiChu_DaDiemDanh.HeaderText = "Ghi Chú";
            this.col_GhiChu_DaDiemDanh.Name = "col_GhiChu_DaDiemDanh";
            // 
            // frm02_Gv_Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1279, 822);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "frm02_Gv_Summary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm Danh";
            this.Load += new System.EventHandler(this.frm02_Gv_RollCall_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SummaryNotYet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SummaryDone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_DateTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_SummaryNotYet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_SummaryDone;
        private System.Windows.Forms.Button btn_Summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stt_DaDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Masv_DaDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoLot_DaDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ten_DaDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_NgayDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GhiChu_DaDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stt_ChuaDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Masv_ChuaDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoLot_ChuaDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ten_ChuaDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayDD_ChuaDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GhiChu_ChuaDiemDanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Khac;
        private System.Windows.Forms.TextBox txt_HienDien;
        private System.Windows.Forms.TextBox txt_Khong;
        private System.Windows.Forms.TextBox txt_Phep;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.TextBox txt_TenHP;
        private System.Windows.Forms.TextBox txt_MaHP;
    }
}