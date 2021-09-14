
namespace App_DDSV
{
    partial class frm02_Gv_RollCall
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
            this.lb_DateTime = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_MaHP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_DateTime
            // 
            this.lb_DateTime.AutoSize = true;
            this.lb_DateTime.Location = new System.Drawing.Point(379, 69);
            this.lb_DateTime.Name = "lb_DateTime";
            this.lb_DateTime.Size = new System.Drawing.Size(51, 13);
            this.lb_DateTime.TabIndex = 0;
            this.lb_DateTime.Text = "Ngày Giờ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(287, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 453);
            this.dataGridView1.TabIndex = 1;
            // 
            // lb_MaHP
            // 
            this.lb_MaHP.AutoSize = true;
            this.lb_MaHP.Location = new System.Drawing.Point(571, 69);
            this.lb_MaHP.Name = "lb_MaHP";
            this.lb_MaHP.Size = new System.Drawing.Size(73, 13);
            this.lb_MaHP.TabIndex = 0;
            this.lb_MaHP.Text = "Mã Học Phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(859, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // frm02_Gv_RollCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1415, 843);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_MaHP);
            this.Controls.Add(this.lb_DateTime);
            this.Name = "frm02_Gv_RollCall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm Danh";
            this.Load += new System.EventHandler(this.frm02_Gv_RollCall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DateTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_MaHP;
        private System.Windows.Forms.Label label3;
    }
}