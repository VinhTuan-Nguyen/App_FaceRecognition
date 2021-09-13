
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
            this.ra_Closed = new System.Windows.Forms.RadioButton();
            this.ra_Opening = new System.Windows.Forms.RadioButton();
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ra_Closed
            // 
            this.ra_Closed.AutoSize = true;
            this.ra_Closed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.ra_Closed.Location = new System.Drawing.Point(495, 205);
            this.ra_Closed.Name = "ra_Closed";
            this.ra_Closed.Size = new System.Drawing.Size(122, 24);
            this.ra_Closed.TabIndex = 21;
            this.ra_Closed.TabStop = true;
            this.ra_Closed.Text = "Đã Hoàn Tất";
            this.ra_Closed.UseVisualStyleBackColor = true;
            // 
            // ra_Opening
            // 
            this.ra_Opening.AutoSize = true;
            this.ra_Opening.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.ra_Opening.Location = new System.Drawing.Point(374, 205);
            this.ra_Opening.Name = "ra_Opening";
            this.ra_Opening.Size = new System.Drawing.Size(83, 24);
            this.ra_Opening.TabIndex = 22;
            this.ra_Opening.TabStop = true;
            this.ra_Opening.Text = "Mở Lớp";
            this.ra_Opening.UseVisualStyleBackColor = true;
            // 
            // cbb_Thu
            // 
            this.cbb_Thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Thu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Thu.FormattingEnabled = true;
            this.cbb_Thu.Items.AddRange(new object[] {
            "T2",
            "T3",
            "T4",
            "T5",
            "T6",
            "T7",
            "CN"});
            this.cbb_Thu.Location = new System.Drawing.Point(264, 201);
            this.cbb_Thu.Name = "cbb_Thu";
            this.cbb_Thu.Size = new System.Drawing.Size(82, 28);
            this.cbb_Thu.TabIndex = 20;
            // 
            // pick_End
            // 
            this.pick_End.CustomFormat = "dd - MM - yyyy";
            this.pick_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_End.Location = new System.Drawing.Point(374, 122);
            this.pick_End.Name = "pick_End";
            this.pick_End.Size = new System.Drawing.Size(243, 29);
            this.pick_End.TabIndex = 18;
            this.pick_End.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // pick_Star
            // 
            this.pick_Star.CustomFormat = "dd - MM - yyyy";
            this.pick_Star.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pick_Star.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pick_Star.Location = new System.Drawing.Point(374, 43);
            this.pick_Star.Name = "pick_Star";
            this.pick_Star.Size = new System.Drawing.Size(243, 29);
            this.pick_Star.TabIndex = 19;
            this.pick_Star.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.pick_Star.ValueChanged += new System.EventHandler(this.pick_Star_ValueChanged);
            // 
            // txt_MaGV
            // 
            this.txt_MaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaGV.Location = new System.Drawing.Point(42, 202);
            this.txt_MaGV.MaxLength = 10;
            this.txt_MaGV.Name = "txt_MaGV";
            this.txt_MaGV.Size = new System.Drawing.Size(194, 27);
            this.txt_MaGV.TabIndex = 15;
            // 
            // txt_TenHP
            // 
            this.txt_TenHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHP.Location = new System.Drawing.Point(42, 123);
            this.txt_TenHP.MaxLength = 100;
            this.txt_TenHP.Name = "txt_TenHP";
            this.txt_TenHP.Size = new System.Drawing.Size(304, 27);
            this.txt_TenHP.TabIndex = 16;
            // 
            // txt_MaHP
            // 
            this.txt_MaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHP.Location = new System.Drawing.Point(42, 44);
            this.txt_MaHP.Name = "txt_MaHP";
            this.txt_MaHP.ReadOnly = true;
            this.txt_MaHP.Size = new System.Drawing.Size(304, 27);
            this.txt_MaHP.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label7.Location = new System.Drawing.Point(374, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Trạng Thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label6.Location = new System.Drawing.Point(374, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày Kết Thúc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label5.Location = new System.Drawing.Point(374, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày Bắt Đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label4.Location = new System.Drawing.Point(264, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Thứ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label3.Location = new System.Drawing.Point(42, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã Giảng Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label2.Location = new System.Drawing.Point(42, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Học Phần:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã Học Phần:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(263, 258);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(126, 41);
            this.btn_Delete.TabIndex = 23;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(110, 258);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(126, 41);
            this.btn_Edit.TabIndex = 23;
            this.btn_Edit.Text = "Chỉnh Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(416, 258);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(126, 41);
            this.btn_Exit.TabIndex = 23;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frm01_Qt_ClassEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(659, 344);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.ra_Closed);
            this.Controls.Add(this.ra_Opening);
            this.Controls.Add(this.cbb_Thu);
            this.Controls.Add(this.pick_End);
            this.Controls.Add(this.pick_Star);
            this.Controls.Add(this.txt_MaGV);
            this.Controls.Add(this.txt_TenHP);
            this.Controls.Add(this.txt_MaHP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm01_Qt_ClassEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Lớp Học Phần";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ra_Closed;
        private System.Windows.Forms.RadioButton ra_Opening;
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
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Exit;
    }
}