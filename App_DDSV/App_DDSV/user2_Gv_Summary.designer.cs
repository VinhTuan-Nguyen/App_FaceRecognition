namespace App_DDSV
{
    partial class user2_Gv_Summary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_TenHP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaHP = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_TongKet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Summary_DaDiemDanh = new System.Windows.Forms.DataGridView();
            this.col_Stt_DaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Masv_DaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoLot_DaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten_DaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_NgayDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GhiChu_DaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Summary_ChuaDiemDanh = new System.Windows.Forms.DataGridView();
            this.col_Stt_ChuaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Masv_ChuaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoLot_ChuaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten_ChuaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GhiChu_ChuaDiemDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Summary_DaDiemDanh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Summary_ChuaDiemDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2405, 88);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(862, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng Kết Điểm Danh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.txt_TenHP);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_MaHP);
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Controls.Add(this.btn_TongKet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2405, 135);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_TenHP
            // 
            this.txt_TenHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHP.Location = new System.Drawing.Point(992, 50);
            this.txt_TenHP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenHP.MaxLength = 100;
            this.txt_TenHP.Name = "txt_TenHP";
            this.txt_TenHP.Size = new System.Drawing.Size(209, 32);
            this.txt_TenHP.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(763, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tên Lớp Học Phần:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd - MM - yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1420, 49);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 34);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1208, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày Điểm Danh:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã Học Phần:";
            // 
            // txt_MaHP
            // 
            this.txt_MaHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHP.Location = new System.Drawing.Point(547, 50);
            this.txt_MaHP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaHP.MaxLength = 10;
            this.txt_MaHP.Name = "txt_MaHP";
            this.txt_MaHP.Size = new System.Drawing.Size(209, 32);
            this.txt_MaHP.TabIndex = 14;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1995, 18);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(218, 98);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "&Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_TongKet
            // 
            this.btn_TongKet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TongKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TongKet.Location = new System.Drawing.Point(1753, 18);
            this.btn_TongKet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TongKet.Name = "btn_TongKet";
            this.btn_TongKet.Size = new System.Drawing.Size(218, 98);
            this.btn_TongKet.TabIndex = 8;
            this.btn_TongKet.Text = "Tổng Kết ";
            this.btn_TongKet.UseVisualStyleBackColor = true;
            this.btn_TongKet.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.dgv_Summary_DaDiemDanh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1473, 1069);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đã Điểm Danh";
            // 
            // dgv_Summary_DaDiemDanh
            // 
            this.dgv_Summary_DaDiemDanh.AllowUserToAddRows = false;
            this.dgv_Summary_DaDiemDanh.AllowUserToDeleteRows = false;
            this.dgv_Summary_DaDiemDanh.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_Summary_DaDiemDanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Summary_DaDiemDanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Summary_DaDiemDanh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Summary_DaDiemDanh.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Summary_DaDiemDanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Summary_DaDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Summary_DaDiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Stt_DaDiemDanh,
            this.col_Masv_DaDiemDanh,
            this.col_HoLot_DaDiemDanh,
            this.col_Ten_DaDiemDanh,
            this.Col_NgayDD,
            this.col_GioDD,
            this.col_GhiChu_DaDiemDanh});
            this.dgv_Summary_DaDiemDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Summary_DaDiemDanh.Location = new System.Drawing.Point(3, 28);
            this.dgv_Summary_DaDiemDanh.Name = "dgv_Summary_DaDiemDanh";
            this.dgv_Summary_DaDiemDanh.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_Summary_DaDiemDanh.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Summary_DaDiemDanh.RowTemplate.Height = 24;
            this.dgv_Summary_DaDiemDanh.Size = new System.Drawing.Size(1467, 1038);
            this.dgv_Summary_DaDiemDanh.TabIndex = 0;
            this.dgv_Summary_DaDiemDanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Summary_CellContentClick);
            // 
            // col_Stt_DaDiemDanh
            // 
            this.col_Stt_DaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Stt_DaDiemDanh.HeaderText = "STT";
            this.col_Stt_DaDiemDanh.Name = "col_Stt_DaDiemDanh";
            this.col_Stt_DaDiemDanh.Width = 60;
            // 
            // col_Masv_DaDiemDanh
            // 
            this.col_Masv_DaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Masv_DaDiemDanh.FillWeight = 21F;
            this.col_Masv_DaDiemDanh.HeaderText = "Mã SV";
            this.col_Masv_DaDiemDanh.Name = "col_Masv_DaDiemDanh";
            this.col_Masv_DaDiemDanh.Width = 150;
            // 
            // col_HoLot_DaDiemDanh
            // 
            this.col_HoLot_DaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_HoLot_DaDiemDanh.FillWeight = 19.54171F;
            this.col_HoLot_DaDiemDanh.HeaderText = "Họ lót";
            this.col_HoLot_DaDiemDanh.Name = "col_HoLot_DaDiemDanh";
            this.col_HoLot_DaDiemDanh.Width = 250;
            // 
            // col_Ten_DaDiemDanh
            // 
            this.col_Ten_DaDiemDanh.FillWeight = 19.54171F;
            this.col_Ten_DaDiemDanh.HeaderText = "Tên SV";
            this.col_Ten_DaDiemDanh.Name = "col_Ten_DaDiemDanh";
            // 
            // Col_NgayDD
            // 
            this.Col_NgayDD.FillWeight = 19.54171F;
            this.Col_NgayDD.HeaderText = "Ngày Điểm Danh";
            this.Col_NgayDD.Name = "Col_NgayDD";
            // 
            // col_GioDD
            // 
            this.col_GioDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_GioDD.FillWeight = 19.54172F;
            this.col_GioDD.HeaderText = "Điểm Danh Lúc";
            this.col_GioDD.Name = "col_GioDD";
            // 
            // col_GhiChu_DaDiemDanh
            // 
            this.col_GhiChu_DaDiemDanh.FillWeight = 19.54171F;
            this.col_GhiChu_DaDiemDanh.HeaderText = "Ghi Chú";
            this.col_GhiChu_DaDiemDanh.Name = "col_GhiChu_DaDiemDanh";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dgv_Summary_ChuaDiemDanh);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1473, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 1069);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chưa Điểm Danh";
            // 
            // dgv_Summary_ChuaDiemDanh
            // 
            this.dgv_Summary_ChuaDiemDanh.AllowUserToAddRows = false;
            this.dgv_Summary_ChuaDiemDanh.AllowUserToDeleteRows = false;
            this.dgv_Summary_ChuaDiemDanh.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_Summary_ChuaDiemDanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Summary_ChuaDiemDanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Summary_ChuaDiemDanh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Summary_ChuaDiemDanh.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgv_Summary_ChuaDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Summary_ChuaDiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Stt_ChuaDiemDanh,
            this.col_Masv_ChuaDiemDanh,
            this.col_HoLot_ChuaDiemDanh,
            this.col_Ten_ChuaDiemDanh,
            this.col_GhiChu_ChuaDiemDanh});
            this.dgv_Summary_ChuaDiemDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Summary_ChuaDiemDanh.Location = new System.Drawing.Point(3, 28);
            this.dgv_Summary_ChuaDiemDanh.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Summary_ChuaDiemDanh.Name = "dgv_Summary_ChuaDiemDanh";
            this.dgv_Summary_ChuaDiemDanh.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_Summary_ChuaDiemDanh.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Summary_ChuaDiemDanh.RowTemplate.Height = 24;
            this.dgv_Summary_ChuaDiemDanh.Size = new System.Drawing.Size(926, 1038);
            this.dgv_Summary_ChuaDiemDanh.TabIndex = 1;
            // 
            // col_Stt_ChuaDiemDanh
            // 
            this.col_Stt_ChuaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Stt_ChuaDiemDanh.HeaderText = "STT";
            this.col_Stt_ChuaDiemDanh.Name = "col_Stt_ChuaDiemDanh";
            this.col_Stt_ChuaDiemDanh.Width = 60;
            // 
            // col_Masv_ChuaDiemDanh
            // 
            this.col_Masv_ChuaDiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Masv_ChuaDiemDanh.HeaderText = "Mã SV";
            this.col_Masv_ChuaDiemDanh.Name = "col_Masv_ChuaDiemDanh";
            this.col_Masv_ChuaDiemDanh.Width = 150;
            // 
            // col_HoLot_ChuaDiemDanh
            // 
            this.col_HoLot_ChuaDiemDanh.HeaderText = "Họ lót";
            this.col_HoLot_ChuaDiemDanh.Name = "col_HoLot_ChuaDiemDanh";
            // 
            // col_Ten_ChuaDiemDanh
            // 
            this.col_Ten_ChuaDiemDanh.HeaderText = "Tên SV";
            this.col_Ten_ChuaDiemDanh.Name = "col_Ten_ChuaDiemDanh";
            // 
            // col_GhiChu_ChuaDiemDanh
            // 
            this.col_GhiChu_ChuaDiemDanh.HeaderText = "Ghi Chú";
            this.col_GhiChu_ChuaDiemDanh.Name = "col_GhiChu_ChuaDiemDanh";
            // 
            // user2_GV_Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "user2_GV_Summary";
            this.Size = new System.Drawing.Size(2405, 1292);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Summary_DaDiemDanh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Summary_ChuaDiemDanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_TongKet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Summary_DaDiemDanh;
        private System.Windows.Forms.DataGridView dgv_Summary_ChuaDiemDanh;
        private System.Windows.Forms.TextBox txt_TenHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MaHP;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GhiChu_ChuaDiemDanh;
    }
}
