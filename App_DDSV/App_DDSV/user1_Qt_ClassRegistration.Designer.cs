
namespace App_DDSV
{
    partial class user1_Qt_ClassRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_SV_View = new System.Windows.Forms.DataGridView();
            this.col_SV_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HoSV = new System.Windows.Forms.TextBox();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.btn_ViewStudent = new System.Windows.Forms.Button();
            this.btn_SearchStudent = new System.Windows.Forms.Button();
            this.txt_MaSV_Search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenHP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaHP_Search = new System.Windows.Forms.TextBox();
            this.btn_ViewClass = new System.Windows.Forms.Button();
            this.btn_SearchClass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_AddStudent = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_HP_View = new System.Windows.Forms.DataGridView();
            this.col_HP_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV_View)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HP_View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 70);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(690, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Đăng Ký Học Phần";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dgv_SV_View);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(963, 856);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sinh Viên";
            // 
            // dgv_SV_View
            // 
            this.dgv_SV_View.AllowUserToAddRows = false;
            this.dgv_SV_View.AllowUserToDeleteRows = false;
            this.dgv_SV_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_SV_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SV_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SV_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_SV_View.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SV_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SV_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SV_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SV_Stt,
            this.col_MaSV,
            this.col_HoLot,
            this.col_Ten,
            this.col_Lop,
            this.col_Email,
            this.col_GioiTinh});
            this.dgv_SV_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SV_View.Location = new System.Drawing.Point(3, 27);
            this.dgv_SV_View.MultiSelect = false;
            this.dgv_SV_View.Name = "dgv_SV_View";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SV_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_SV_View.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_SV_View.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_SV_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_SV_View.Size = new System.Drawing.Size(957, 826);
            this.dgv_SV_View.TabIndex = 0;
            this.dgv_SV_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SV_View_CellClick);
            this.dgv_SV_View.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SV_View_CellDoubleClick);
            this.dgv_SV_View.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_SV_View_RowPrePaint);
            // 
            // col_SV_Stt
            // 
            this.col_SV_Stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_SV_Stt.HeaderText = "STT";
            this.col_SV_Stt.Name = "col_SV_Stt";
            this.col_SV_Stt.Width = 50;
            // 
            // col_MaSV
            // 
            this.col_MaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_MaSV.DataPropertyName = "col_MaSV";
            this.col_MaSV.HeaderText = "Mã SV";
            this.col_MaSV.Name = "col_MaSV";
            this.col_MaSV.Width = 120;
            // 
            // col_HoLot
            // 
            this.col_HoLot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_HoLot.DataPropertyName = "col_HoLot";
            this.col_HoLot.HeaderText = "Họ Lót";
            this.col_HoLot.Name = "col_HoLot";
            this.col_HoLot.Width = 170;
            // 
            // col_Ten
            // 
            this.col_Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Ten.DataPropertyName = "col_Ten";
            this.col_Ten.HeaderText = "Tên SV";
            this.col_Ten.Name = "col_Ten";
            this.col_Ten.Width = 120;
            // 
            // col_Lop
            // 
            this.col_Lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Lop.DataPropertyName = "col_Lop";
            this.col_Lop.HeaderText = "Lớp";
            this.col_Lop.Name = "col_Lop";
            this.col_Lop.Width = 150;
            // 
            // col_Email
            // 
            this.col_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Email.DataPropertyName = "col_Email";
            this.col_Email.HeaderText = "Email";
            this.col_Email.Name = "col_Email";
            this.col_Email.Width = 350;
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Số Sinh VIên:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Họ Lót:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên SV:";
            // 
            // txt_HoSV
            // 
            this.txt_HoSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HoSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoSV.Location = new System.Drawing.Point(227, 57);
            this.txt_HoSV.MaxLength = 30;
            this.txt_HoSV.Name = "txt_HoSV";
            this.txt_HoSV.Size = new System.Drawing.Size(150, 27);
            this.txt_HoSV.TabIndex = 3;
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSV.Location = new System.Drawing.Point(406, 57);
            this.txt_TenSV.MaxLength = 30;
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.Size = new System.Drawing.Size(122, 27);
            this.txt_TenSV.TabIndex = 3;
            // 
            // btn_ViewStudent
            // 
            this.btn_ViewStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ViewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_ViewStudent.Location = new System.Drawing.Point(557, 57);
            this.btn_ViewStudent.Name = "btn_ViewStudent";
            this.btn_ViewStudent.Size = new System.Drawing.Size(170, 36);
            this.btn_ViewStudent.TabIndex = 4;
            this.btn_ViewStudent.Text = "Xem Tất Cả SV";
            this.btn_ViewStudent.UseVisualStyleBackColor = true;
            this.btn_ViewStudent.Click += new System.EventHandler(this.btn_ViewStudent_Click);
            // 
            // btn_SearchStudent
            // 
            this.btn_SearchStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_SearchStudent.Location = new System.Drawing.Point(557, 15);
            this.btn_SearchStudent.Name = "btn_SearchStudent";
            this.btn_SearchStudent.Size = new System.Drawing.Size(170, 36);
            this.btn_SearchStudent.TabIndex = 4;
            this.btn_SearchStudent.Text = "Tìm Kiếm SV";
            this.btn_SearchStudent.UseVisualStyleBackColor = true;
            this.btn_SearchStudent.Click += new System.EventHandler(this.btn_SearchStudent_Click);
            // 
            // txt_MaSV_Search
            // 
            this.txt_MaSV_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaSV_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSV_Search.Location = new System.Drawing.Point(48, 57);
            this.txt_MaSV_Search.MaxLength = 10;
            this.txt_MaSV_Search.Name = "txt_MaSV_Search";
            this.txt_MaSV_Search.Size = new System.Drawing.Size(150, 27);
            this.txt_MaSV_Search.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1235, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã Học Phần:";
            // 
            // txt_TenHP
            // 
            this.txt_TenHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHP.Location = new System.Drawing.Point(1418, 57);
            this.txt_TenHP.MaxLength = 100;
            this.txt_TenHP.Name = "txt_TenHP";
            this.txt_TenHP.Size = new System.Drawing.Size(217, 27);
            this.txt_TenHP.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1449, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên Lớp Học Phần:";
            // 
            // txt_MaHP_Search
            // 
            this.txt_MaHP_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaHP_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHP_Search.Location = new System.Drawing.Point(1218, 57);
            this.txt_MaHP_Search.MaxLength = 10;
            this.txt_MaHP_Search.Name = "txt_MaHP_Search";
            this.txt_MaHP_Search.Size = new System.Drawing.Size(150, 27);
            this.txt_MaHP_Search.TabIndex = 3;
            // 
            // btn_ViewClass
            // 
            this.btn_ViewClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ViewClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_ViewClass.Location = new System.Drawing.Point(1685, 57);
            this.btn_ViewClass.Name = "btn_ViewClass";
            this.btn_ViewClass.Size = new System.Drawing.Size(170, 36);
            this.btn_ViewClass.TabIndex = 4;
            this.btn_ViewClass.Text = "Xem Tất Cả HP";
            this.btn_ViewClass.UseVisualStyleBackColor = true;
            this.btn_ViewClass.Click += new System.EventHandler(this.btn_ViewClass_Click);
            // 
            // btn_SearchClass
            // 
            this.btn_SearchClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SearchClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_SearchClass.Location = new System.Drawing.Point(1685, 15);
            this.btn_SearchClass.Name = "btn_SearchClass";
            this.btn_SearchClass.Size = new System.Drawing.Size(170, 36);
            this.btn_SearchClass.TabIndex = 4;
            this.btn_SearchClass.Text = "Tìm Kiếm HP";
            this.btn_SearchClass.UseVisualStyleBackColor = true;
            this.btn_SearchClass.Click += new System.EventHandler(this.btn_SearchClass_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Controls.Add(this.btn_AddStudent);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_ViewStudent);
            this.panel2.Controls.Add(this.txt_TenHP);
            this.panel2.Controls.Add(this.txt_MaSV_Search);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_MaHP_Search);
            this.panel2.Controls.Add(this.btn_SearchStudent);
            this.panel2.Controls.Add(this.btn_ViewClass);
            this.panel2.Controls.Add(this.btn_SearchClass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_TenSV);
            this.panel2.Controls.Add(this.txt_HoSV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 108);
            this.panel2.TabIndex = 5;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(977, 15);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(174, 78);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "&Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddStudent.Location = new System.Drawing.Point(775, 15);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(174, 78);
            this.btn_AddStudent.TabIndex = 8;
            this.btn_AddStudent.Text = "Đăng Kí Mới";
            this.btn_AddStudent.UseVisualStyleBackColor = true;
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1924, 856);
            this.panel3.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.dgv_HP_View);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.groupBox1.Location = new System.Drawing.Point(963, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 856);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Lớp Học Phần";
            // 
            // dgv_HP_View
            // 
            this.dgv_HP_View.AllowUserToAddRows = false;
            this.dgv_HP_View.AllowUserToDeleteRows = false;
            this.dgv_HP_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_HP_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_HP_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HP_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_HP_View.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HP_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_HP_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HP_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_HP_Stt,
            this.col_MaHP,
            this.col_TenHP,
            this.col_NgayBD,
            this.col_NgayKT,
            this.col_Thu,
            this.col_MaGV,
            this.col_TrangThai});
            this.dgv_HP_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HP_View.Location = new System.Drawing.Point(3, 27);
            this.dgv_HP_View.MultiSelect = false;
            this.dgv_HP_View.Name = "dgv_HP_View";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HP_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_HP_View.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_HP_View.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_HP_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_HP_View.Size = new System.Drawing.Size(955, 826);
            this.dgv_HP_View.TabIndex = 0;
            this.dgv_HP_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HP_View_CellClick);
            this.dgv_HP_View.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HP_View_CellDoubleClick);
            this.dgv_HP_View.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_HP_View_RowPrePaint);
            // 
            // col_HP_Stt
            // 
            this.col_HP_Stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_HP_Stt.HeaderText = "STT";
            this.col_HP_Stt.MinimumWidth = 50;
            this.col_HP_Stt.Name = "col_HP_Stt";
            this.col_HP_Stt.Width = 50;
            // 
            // col_MaHP
            // 
            this.col_MaHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_MaHP.DataPropertyName = "col_MaHP";
            this.col_MaHP.HeaderText = "Mã HP";
            this.col_MaHP.Name = "col_MaHP";
            this.col_MaHP.Width = 120;
            // 
            // col_TenHP
            // 
            this.col_TenHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_TenHP.DataPropertyName = "col_TenHP";
            this.col_TenHP.HeaderText = "Tên Học Phần";
            this.col_TenHP.Name = "col_TenHP";
            this.col_TenHP.Width = 350;
            // 
            // col_NgayBD
            // 
            this.col_NgayBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_NgayBD.DataPropertyName = "col_NgayBD";
            this.col_NgayBD.HeaderText = "Ngày BĐ";
            this.col_NgayBD.Name = "col_NgayBD";
            this.col_NgayBD.Width = 130;
            // 
            // col_NgayKT
            // 
            this.col_NgayKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_NgayKT.DataPropertyName = "col_NgayKT";
            this.col_NgayKT.HeaderText = "Ngày KT";
            this.col_NgayKT.Name = "col_NgayKT";
            this.col_NgayKT.Width = 130;
            // 
            // col_Thu
            // 
            this.col_Thu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Thu.DataPropertyName = "col_Thu";
            this.col_Thu.HeaderText = "Thứ";
            this.col_Thu.Name = "col_Thu";
            this.col_Thu.Width = 80;
            // 
            // col_MaGV
            // 
            this.col_MaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_MaGV.DataPropertyName = "col_MaGV";
            this.col_MaGV.HeaderText = "Mã GV";
            this.col_MaGV.Name = "col_MaGV";
            this.col_MaGV.Width = 120;
            // 
            // col_TrangThai
            // 
            this.col_TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_TrangThai.DataPropertyName = "col_TrangThai";
            this.col_TrangThai.HeaderText = "Mở Lớp";
            this.col_TrangThai.Name = "col_TrangThai";
            this.col_TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_TrangThai.Width = 120;
            // 
            // user1_Qt_ClassRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "user1_Qt_ClassRegistration";
            this.Size = new System.Drawing.Size(1924, 1034);
            this.Load += new System.EventHandler(this.user1_Qt_ClassRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV_View)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HP_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_SV_View;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_HoSV;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.Button btn_ViewStudent;
        private System.Windows.Forms.Button btn_SearchStudent;
        private System.Windows.Forms.TextBox txt_MaSV_Search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TenHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaHP_Search;
        private System.Windows.Forms.Button btn_ViewClass;
        private System.Windows.Forms.Button btn_SearchClass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_AddStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_HP_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SV_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HP_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_TrangThai;
    }
}
