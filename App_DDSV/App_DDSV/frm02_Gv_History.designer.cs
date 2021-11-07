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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_History = new System.Windows.Forms.DataGridView();
            this.col_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số SV:";
            // 
            // txt_MaHP
            // 
            this.txt_MaHP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaHP.BackColor = System.Drawing.SystemColors.Info;
            this.txt_MaHP.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHP.Location = new System.Drawing.Point(854, 25);
            this.txt_MaHP.Name = "txt_MaHP";
            this.txt_MaHP.ReadOnly = true;
            this.txt_MaHP.Size = new System.Drawing.Size(137, 30);
            this.txt_MaHP.TabIndex = 10;
            this.txt_MaHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(318, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên:";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaSV.BackColor = System.Drawing.SystemColors.Info;
            this.txt_MaSV.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSV.Location = new System.Drawing.Point(135, 25);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.ReadOnly = true;
            this.txt_MaSV.Size = new System.Drawing.Size(136, 30);
            this.txt_MaSV.TabIndex = 10;
            this.txt_MaSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(717, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Học Phần:";
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenSV.BackColor = System.Drawing.SystemColors.Info;
            this.txt_TenSV.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSV.Location = new System.Drawing.Point(368, 25);
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.ReadOnly = true;
            this.txt_TenSV.Size = new System.Drawing.Size(309, 30);
            this.txt_TenSV.TabIndex = 10;
            this.txt_TenSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 70);
            this.panel2.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(317, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(396, 49);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nhật Ký Điểm Danh";
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Brown;
            this.btn_Back.Location = new System.Drawing.Point(885, 8);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(107, 43);
            this.btn_Back.TabIndex = 29;
            this.btn_Back.Text = "Trở Về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            this.btn_Back.MouseLeave += new System.EventHandler(this.btn_Back_MouseLeave);
            this.btn_Back.MouseHover += new System.EventHandler(this.btn_Back_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 635);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 59);
            this.panel1.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_MaHP);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_TenSV);
            this.panel3.Controls.Add(this.txt_MaSV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 79);
            this.panel3.TabIndex = 32;
            // 
            // dgv_History
            // 
            this.dgv_History.AllowUserToAddRows = false;
            this.dgv_History.AllowUserToDeleteRows = false;
            this.dgv_History.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_History.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_History.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_History.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_History.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgv_History.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.dgv_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_History.Location = new System.Drawing.Point(0, 149);
            this.dgv_History.Name = "dgv_History";
            this.dgv_History.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_History.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_History.Size = new System.Drawing.Size(1030, 486);
            this.dgv_History.TabIndex = 33;
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
            this.col_NgayDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_NgayDD.DataPropertyName = "col_NgayDD";
            this.col_NgayDD.HeaderText = "Ngày Điểm Danh";
            this.col_NgayDD.Name = "col_NgayDD";
            this.col_NgayDD.Width = 300;
            // 
            // col_GioDD
            // 
            this.col_GioDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_GioDD.DataPropertyName = "col_GioDD";
            this.col_GioDD.HeaderText = "Điểm Danh Lúc";
            this.col_GioDD.MinimumWidth = 350;
            this.col_GioDD.Name = "col_GioDD";
            // 
            // col_GhiChu
            // 
            this.col_GhiChu.DataPropertyName = "col_GhiChu";
            this.col_GhiChu.HeaderText = "Ghi Chú";
            this.col_GhiChu.Name = "col_GhiChu";
            // 
            // frm02_Gv_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1030, 694);
            this.Controls.Add(this.dgv_History);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frm02_Gv_History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhật Ký Điểm Danh";
            this.Load += new System.EventHandler(this.frm02_Gv_History_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_History)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_History;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GhiChu;
    }
}