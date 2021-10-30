namespace App_DDSV
{
    partial class frm02_Gv_History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaHP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.dgv_History = new System.Windows.Forms.DataGridView();
            this.col_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pick_Search = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(8, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số SV:";
            // 
            // txt_MaHP
            // 
            this.txt_MaHP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaHP.BackColor = System.Drawing.SystemColors.Info;
            this.txt_MaHP.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHP.Location = new System.Drawing.Point(772, 124);
            this.txt_MaHP.Name = "txt_MaHP";
            this.txt_MaHP.ReadOnly = true;
            this.txt_MaHP.Size = new System.Drawing.Size(137, 28);
            this.txt_MaHP.TabIndex = 10;
            this.txt_MaHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(268, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên:";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaSV.BackColor = System.Drawing.SystemColors.Info;
            this.txt_MaSV.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSV.Location = new System.Drawing.Point(97, 124);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.ReadOnly = true;
            this.txt_MaSV.Size = new System.Drawing.Size(136, 28);
            this.txt_MaSV.TabIndex = 10;
            this.txt_MaSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(281, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "LỊCH SỬ ĐIỂM DANH";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(648, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Học Phần:";
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenSV.BackColor = System.Drawing.SystemColors.Info;
            this.txt_TenSV.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSV.Location = new System.Drawing.Point(315, 124);
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.ReadOnly = true;
            this.txt_TenSV.Size = new System.Drawing.Size(309, 28);
            this.txt_TenSV.TabIndex = 10;
            this.txt_TenSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_History
            // 
            this.dgv_History.AllowUserToAddRows = false;
            this.dgv_History.AllowUserToDeleteRows = false;
            this.dgv_History.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_History.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_History.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_History.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_History.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_History.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_History.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Stt,
            this.col_NgayDD,
            this.col_GioDD,
            this.col_GhiChu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_History.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_History.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_History.Location = new System.Drawing.Point(0, 186);
            this.dgv_History.Name = "dgv_History";
            this.dgv_History.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_History.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_History.Size = new System.Drawing.Size(922, 435);
            this.dgv_History.TabIndex = 2;
            this.dgv_History.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_History_RowPrePaint);
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
            this.col_NgayDD.DataPropertyName = "col_NgayDD";
            this.col_NgayDD.HeaderText = "Ngày Điểm Danh";
            this.col_NgayDD.Name = "col_NgayDD";
            // 
            // col_GioDD
            // 
            this.col_GioDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_GioDD.DataPropertyName = "col_GioDD";
            this.col_GioDD.HeaderText = "Điểm Danh Lúc";
            this.col_GioDD.Name = "col_GioDD";
            // 
            // col_GhiChu
            // 
            this.col_GhiChu.DataPropertyName = "col_GhiChu";
            this.col_GhiChu.HeaderText = "Ghi Chú";
            this.col_GhiChu.Name = "col_GhiChu";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Search.Font = new System.Drawing.Font("Constantia", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Search.Location = new System.Drawing.Point(483, 65);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(141, 36);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // pick_Search
            // 
            this.pick_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pick_Search.CustomFormat = "dd - MM -yyyy HH:mm";
            this.pick_Search.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.pick_Search.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_Search.Location = new System.Drawing.Point(251, 69);
            this.pick_Search.Name = "pick_Search";
            this.pick_Search.Size = new System.Drawing.Size(214, 28);
            this.pick_Search.TabIndex = 14;
            this.pick_Search.Value = new System.DateTime(2021, 1, 1, 12, 0, 0, 0);
            // 
            // frm02_Gv_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(922, 621);
            this.Controls.Add(this.pick_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_History);
            this.Controls.Add(this.txt_TenSV);
            this.Controls.Add(this.txt_MaSV);
            this.Controls.Add(this.txt_MaHP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm02_Gv_History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Sử Điểm Danh";
            this.Load += new System.EventHandler(this.frm02_Gv_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.DataGridView dgv_History;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker pick_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GhiChu;
    }
}