namespace App_DDSV
{
    partial class frm02_Gv_Note
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.ra_Co = new System.Windows.Forms.RadioButton();
            this.ra_Vang = new System.Windows.Forms.RadioButton();
            this.ra_Phep = new System.Windows.Forms.RadioButton();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.ra_Khac = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label6.Location = new System.Drawing.Point(222, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ghi Chú:";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txt_GhiChu.Location = new System.Drawing.Point(15, 146);
            this.txt_GhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GhiChu.MaxLength = 150;
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(501, 127);
            this.txt_GhiChu.TabIndex = 1;
            // 
            // ra_Co
            // 
            this.ra_Co.AutoSize = true;
            this.ra_Co.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.ra_Co.Location = new System.Drawing.Point(15, 106);
            this.ra_Co.Margin = new System.Windows.Forms.Padding(2);
            this.ra_Co.Name = "ra_Co";
            this.ra_Co.Size = new System.Drawing.Size(81, 24);
            this.ra_Co.TabIndex = 17;
            this.ra_Co.Text = "Có Mặt";
            this.ra_Co.UseVisualStyleBackColor = true;
            // 
            // ra_Vang
            // 
            this.ra_Vang.AutoSize = true;
            this.ra_Vang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.ra_Vang.Location = new System.Drawing.Point(162, 106);
            this.ra_Vang.Margin = new System.Windows.Forms.Padding(2);
            this.ra_Vang.Name = "ra_Vang";
            this.ra_Vang.Size = new System.Drawing.Size(65, 24);
            this.ra_Vang.TabIndex = 17;
            this.ra_Vang.Text = "Vắng";
            this.ra_Vang.UseVisualStyleBackColor = true;
            // 
            // ra_Phep
            // 
            this.ra_Phep.AutoSize = true;
            this.ra_Phep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.ra_Phep.Location = new System.Drawing.Point(293, 106);
            this.ra_Phep.Margin = new System.Windows.Forms.Padding(2);
            this.ra_Phep.Name = "ra_Phep";
            this.ra_Phep.Size = new System.Drawing.Size(91, 24);
            this.ra_Phep.TabIndex = 17;
            this.ra_Phep.Text = "Có Phép";
            this.ra_Phep.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(350, 287);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(166, 53);
            this.btn_Exit.TabIndex = 18;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(151, 287);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(166, 53);
            this.btn_Update.TabIndex = 18;
            this.btn_Update.Text = "Lưu";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // ra_Khac
            // 
            this.ra_Khac.AutoSize = true;
            this.ra_Khac.Checked = true;
            this.ra_Khac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.ra_Khac.Location = new System.Drawing.Point(450, 106);
            this.ra_Khac.Margin = new System.Windows.Forms.Padding(2);
            this.ra_Khac.Name = "ra_Khac";
            this.ra_Khac.Size = new System.Drawing.Size(65, 24);
            this.ra_Khac.TabIndex = 17;
            this.ra_Khac.TabStop = true;
            this.ra_Khac.Text = "Khác";
            this.ra_Khac.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm02_Gv_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 352);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.ra_Phep);
            this.Controls.Add(this.ra_Vang);
            this.Controls.Add(this.ra_Khac);
            this.Controls.Add(this.ra_Co);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm02_Gv_Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Đổi Ghi Chú";
            this.TransparencyKey = System.Drawing.Color.Lavender;
            this.Load += new System.EventHandler(this.frm02_Gv_Note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.RadioButton ra_Co;
        private System.Windows.Forms.RadioButton ra_Vang;
        private System.Windows.Forms.RadioButton ra_Phep;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.RadioButton ra_Khac;
        private System.Windows.Forms.Timer timer1;
    }
}