
namespace App_DDSV
{
    partial class frm01_Qt_ClassReg_EditStudent
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_SV_View = new System.Windows.Forms.DataGridView();
            this.col_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV_View)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(984, 44);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(147, 53);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(790, 44);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(147, 53);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Xóa Sinh Viên";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(596, 44);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(147, 53);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Thêm Sinh Viên";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSV.Location = new System.Drawing.Point(309, 70);
            this.txt_MaSV.MaxLength = 10;
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(240, 27);
            this.txt_MaSV.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Sinh Viên:";
            // 
            // txt_MaHP
            // 
            this.txt_MaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHP.Location = new System.Drawing.Point(42, 70);
            this.txt_MaHP.Name = "txt_MaHP";
            this.txt_MaHP.ReadOnly = true;
            this.txt_MaHP.Size = new System.Drawing.Size(220, 27);
            this.txt_MaHP.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Học Phần:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SV_View);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.groupBox1.Location = new System.Drawing.Point(0, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1177, 624);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sinh Viên";
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
            this.col_Stt,
            this.col_MaSV,
            this.col_HoLot,
            this.col_Ten,
            this.col_Lop,
            this.col_Email,
            this.col_GioiTinh});
            this.dgv_SV_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SV_View.Location = new System.Drawing.Point(3, 27);
            this.dgv_SV_View.Name = "dgv_SV_View";
            this.dgv_SV_View.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_SV_View.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_SV_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SV_View.Size = new System.Drawing.Size(1171, 594);
            this.dgv_SV_View.TabIndex = 1;
            this.dgv_SV_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SV_View_CellClick);
            this.dgv_SV_View.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_SV_View_RowPrePaint);
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
            this.col_Ten.HeaderText = "Tên";
            this.col_Ten.Name = "col_Ten";
            this.col_Ten.Width = 80;
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
            this.col_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Email.DataPropertyName = "col_Email";
            this.col_Email.HeaderText = "Email";
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
            // frm01_Qt_ClassReg_EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1177, 750);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_MaSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm01_Qt_ClassReg_EditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh Sửa Sinh Viên";
            this.Load += new System.EventHandler(this.frm01_Qt_ClassReg_EditStudent_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_SV_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_GioiTinh;
    }
}