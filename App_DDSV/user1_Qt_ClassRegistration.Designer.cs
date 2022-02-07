
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Tools = new System.Windows.Forms.Panel();
            this.panel_Choose = new System.Windows.Forms.Panel();
            this.btn_HP_Search = new System.Windows.Forms.Button();
            this.btn_SV_Search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_Choose.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel_Choose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 86);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(496, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(486, 64);
            this.label9.TabIndex = 3;
            this.label9.Text = "Đăng Kí Học Phần";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.panel_Tools);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1479, 809);
            this.panel2.TabIndex = 1;
            // 
            // panel_Tools
            // 
            this.panel_Tools.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Tools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Tools.Location = new System.Drawing.Point(0, 0);
            this.panel_Tools.Name = "panel_Tools";
            this.panel_Tools.Size = new System.Drawing.Size(1479, 809);
            this.panel_Tools.TabIndex = 35;
            // 
            // panel_Choose
            // 
            this.panel_Choose.Controls.Add(this.btn_HP_Search);
            this.panel_Choose.Controls.Add(this.btn_SV_Search);
            this.panel_Choose.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Choose.Location = new System.Drawing.Point(1136, 0);
            this.panel_Choose.Name = "panel_Choose";
            this.panel_Choose.Size = new System.Drawing.Size(343, 86);
            this.panel_Choose.TabIndex = 45;
            // 
            // btn_HP_Search
            // 
            this.btn_HP_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_HP_Search.BackColor = System.Drawing.SystemColors.Info;
            this.btn_HP_Search.FlatAppearance.BorderSize = 0;
            this.btn_HP_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HP_Search.Font = new System.Drawing.Font("Constantia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HP_Search.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_HP_Search.Location = new System.Drawing.Point(188, 24);
            this.btn_HP_Search.Name = "btn_HP_Search";
            this.btn_HP_Search.Size = new System.Drawing.Size(133, 37);
            this.btn_HP_Search.TabIndex = 1;
            this.btn_HP_Search.Text = "Học Phần";
            this.btn_HP_Search.UseVisualStyleBackColor = false;
            this.btn_HP_Search.Click += new System.EventHandler(this.btn_HP_Search_Click);
            // 
            // btn_SV_Search
            // 
            this.btn_SV_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_SV_Search.BackColor = System.Drawing.SystemColors.Info;
            this.btn_SV_Search.FlatAppearance.BorderSize = 0;
            this.btn_SV_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SV_Search.Font = new System.Drawing.Font("Constantia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SV_Search.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_SV_Search.Location = new System.Drawing.Point(21, 24);
            this.btn_SV_Search.Name = "btn_SV_Search";
            this.btn_SV_Search.Size = new System.Drawing.Size(133, 37);
            this.btn_SV_Search.TabIndex = 0;
            this.btn_SV_Search.Text = "Sinh Viên";
            this.btn_SV_Search.UseVisualStyleBackColor = false;
            this.btn_SV_Search.Click += new System.EventHandler(this.btn_SV_Search_Click);
            // 
            // user1_Qt_ClassRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "user1_Qt_ClassRegistration";
            this.Size = new System.Drawing.Size(1479, 895);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel_Choose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel_Tools;
        private System.Windows.Forms.Panel panel_Choose;
        private System.Windows.Forms.Button btn_HP_Search;
        private System.Windows.Forms.Button btn_SV_Search;
    }
}
