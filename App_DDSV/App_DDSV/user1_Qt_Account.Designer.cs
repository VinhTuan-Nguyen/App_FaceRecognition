
namespace App_DDSV
{
    partial class user1_Qt_Account
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ra_User = new System.Windows.Forms.RadioButton();
            this.ra_Admin = new System.Windows.Forms.RadioButton();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_AllUser = new System.Windows.Forms.DataGridView();
            this.col_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 70);
            this.panel1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(773, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(379, 46);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quản Lý Tài Khoản";
            // 
            // ra_User
            // 
            this.ra_User.AutoSize = true;
            this.ra_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ra_User.Location = new System.Drawing.Point(853, 39);
            this.ra_User.Name = "ra_User";
            this.ra_User.Size = new System.Drawing.Size(63, 24);
            this.ra_User.TabIndex = 12;
            this.ra_User.Text = "User";
            this.ra_User.UseVisualStyleBackColor = true;
            // 
            // ra_Admin
            // 
            this.ra_Admin.AutoSize = true;
            this.ra_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ra_Admin.Location = new System.Drawing.Point(747, 39);
            this.ra_Admin.Name = "ra_Admin";
            this.ra_Admin.Size = new System.Drawing.Size(74, 24);
            this.ra_Admin.TabIndex = 13;
            this.ra_Admin.Text = "Admin";
            this.ra_Admin.UseVisualStyleBackColor = true;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUser.Location = new System.Drawing.Point(1240, 27);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(182, 48);
            this.btn_AddUser.TabIndex = 9;
            this.btn_AddUser.Text = "Thêm Mới";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1480, 27);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(182, 48);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Làm Mới";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1000, 27);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(182, 48);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(671, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quyền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "User ID:";
            // 
            // txt_UserID
            // 
            this.txt_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.Location = new System.Drawing.Point(349, 38);
            this.txt_UserID.MaxLength = 10;
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(196, 27);
            this.txt_UserID.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.txt_UserID);
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ra_User);
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Controls.Add(this.ra_Admin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_AddUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 100);
            this.panel2.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dgv_AllUser);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.groupBox2.Location = new System.Drawing.Point(0, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1924, 864);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dach Sách User ID";
            // 
            // dgv_AllUser
            // 
            this.dgv_AllUser.AllowUserToAddRows = false;
            this.dgv_AllUser.AllowUserToDeleteRows = false;
            this.dgv_AllUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_AllUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_AllUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AllUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_AllUser.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AllUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_AllUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_STT,
            this.col_User,
            this.col_Role,
            this.col_Password});
            this.dgv_AllUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_AllUser.Location = new System.Drawing.Point(3, 27);
            this.dgv_AllUser.Name = "dgv_AllUser";
            this.dgv_AllUser.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgv_AllUser.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_AllUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AllUser.Size = new System.Drawing.Size(1918, 834);
            this.dgv_AllUser.TabIndex = 0;
            this.dgv_AllUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AllUser_CellDoubleClick);
            this.dgv_AllUser.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_AllUser_RowPrePaint);
            // 
            // col_STT
            // 
            this.col_STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_STT.HeaderText = "STT";
            this.col_STT.Name = "col_STT";
            this.col_STT.Width = 50;
            // 
            // col_User
            // 
            this.col_User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_User.DataPropertyName = "col_User";
            this.col_User.HeaderText = "User ID";
            this.col_User.Name = "col_User";
            this.col_User.Width = 150;
            // 
            // col_Role
            // 
            this.col_Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Role.DataPropertyName = "col_Role";
            this.col_Role.HeaderText = "Quyền";
            this.col_Role.Name = "col_Role";
            // 
            // col_Password
            // 
            this.col_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Password.DataPropertyName = "col_Password";
            this.col_Password.HeaderText = "Password";
            this.col_Password.Name = "col_Password";
            // 
            // user1_Qt_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "user1_Qt_Account";
            this.Size = new System.Drawing.Size(1924, 1034);
            this.Load += new System.EventHandler(this.user1_Qt_Account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton ra_User;
        private System.Windows.Forms.RadioButton ra_Admin;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_AllUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Password;
    }
}
