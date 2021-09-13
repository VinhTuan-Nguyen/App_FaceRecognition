
namespace App_DDSV
{
    partial class frm01_Qt_ClassReg_EditClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_HP_View = new System.Windows.Forms.DataGridView();
            this.col_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaHP = new System.Windows.Forms.TextBox();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HP_View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_HP_View);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.groupBox1.Location = new System.Drawing.Point(0, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1177, 624);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Đăng Kí Học Phần";
            // 
            // dgv_HP_View
            // 
            this.dgv_HP_View.AllowUserToAddRows = false;
            this.dgv_HP_View.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_HP_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HP_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HP_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_HP_View.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HP_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_HP_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HP_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Stt,
            this.col_MaHP,
            this.col_TenHP,
            this.col_NgayBD,
            this.col_NgayKT,
            this.col_Thu,
            this.col_MaGV,
            this.col_TrangThai});
            this.dgv_HP_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HP_View.Location = new System.Drawing.Point(3, 27);
            this.dgv_HP_View.Name = "dgv_HP_View";
            this.dgv_HP_View.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_HP_View.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_HP_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HP_View.Size = new System.Drawing.Size(1171, 594);
            this.dgv_HP_View.TabIndex = 1;
            this.dgv_HP_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HP_View_CellClick);
            this.dgv_HP_View.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_HP_View_RowPrePaint);
            // 
            // col_Stt
            // 
            this.col_Stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Stt.HeaderText = "STT";
            this.col_Stt.Name = "col_Stt";
            this.col_Stt.Width = 50;
            // 
            // col_MaHP
            // 
            this.col_MaHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_MaHP.DataPropertyName = "col_MaHP";
            this.col_MaHP.HeaderText = "Mã HP";
            this.col_MaHP.Name = "col_MaHP";
            // 
            // col_TenHP
            // 
            this.col_TenHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TenHP.DataPropertyName = "col_TenHP";
            this.col_TenHP.HeaderText = "Tên Học Phần";
            this.col_TenHP.Name = "col_TenHP";
            // 
            // col_NgayBD
            // 
            this.col_NgayBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_NgayBD.DataPropertyName = "col_NgayBD";
            this.col_NgayBD.HeaderText = "Ngày BĐ";
            this.col_NgayBD.Name = "col_NgayBD";
            this.col_NgayBD.Width = 120;
            // 
            // col_NgayKT
            // 
            this.col_NgayKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_NgayKT.DataPropertyName = "col_NgayKT";
            this.col_NgayKT.HeaderText = "Ngày KT";
            this.col_NgayKT.Name = "col_NgayKT";
            this.col_NgayKT.Width = 120;
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
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(1003, 33);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(135, 63);
            this.btn_Exit.TabIndex = 19;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(845, 33);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(135, 63);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.Text = "Đăng Kí Học Phần";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(529, 33);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(135, 63);
            this.btn_Edit.TabIndex = 21;
            this.btn_Edit.Text = "Thay Đổi Học Phần";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(687, 33);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(135, 63);
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.Text = "Bỏ Đăng Kí";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Học Phần:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Số Sinh Viên";
            // 
            // txt_MaHP
            // 
            this.txt_MaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHP.Location = new System.Drawing.Point(283, 69);
            this.txt_MaHP.MaxLength = 10;
            this.txt_MaHP.Name = "txt_MaHP";
            this.txt_MaHP.Size = new System.Drawing.Size(223, 27);
            this.txt_MaHP.TabIndex = 15;
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSV.Location = new System.Drawing.Point(37, 69);
            this.txt_MaSV.MaxLength = 10;
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.ReadOnly = true;
            this.txt_MaSV.Size = new System.Drawing.Size(223, 27);
            this.txt_MaSV.TabIndex = 16;
            // 
            // frm01_Qt_ClassReg_EditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1177, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaHP);
            this.Controls.Add(this.txt_MaSV);
            this.Name = "frm01_Qt_ClassReg_EditClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh Sửa Học Phần";
            this.Load += new System.EventHandler(this.frm01_Qt_ClassReg_EditClass_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HP_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_HP_View;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaHP;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_TrangThai;
    }
}