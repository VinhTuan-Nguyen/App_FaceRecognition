namespace App_DDSV
{
    partial class frm01_Qt_AccountEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.ra_User = new System.Windows.Forms.RadioButton();
            this.ra_Admin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_ResetPass = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // txt_UserID
            // 
            this.txt_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.Location = new System.Drawing.Point(144, 85);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.ReadOnly = true;
            this.txt_UserID.Size = new System.Drawing.Size(234, 27);
            this.txt_UserID.TabIndex = 1;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(46, 249);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(153, 65);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Chỉnh Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // ra_User
            // 
            this.ra_User.AutoSize = true;
            this.ra_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ra_User.Location = new System.Drawing.Point(296, 182);
            this.ra_User.Name = "ra_User";
            this.ra_User.Size = new System.Drawing.Size(63, 24);
            this.ra_User.TabIndex = 3;
            this.ra_User.TabStop = true;
            this.ra_User.Text = "User";
            this.ra_User.UseVisualStyleBackColor = true;
            // 
            // ra_Admin
            // 
            this.ra_Admin.AutoSize = true;
            this.ra_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ra_Admin.Location = new System.Drawing.Point(169, 182);
            this.ra_Admin.Name = "ra_Admin";
            this.ra_Admin.Size = new System.Drawing.Size(74, 24);
            this.ra_Admin.TabIndex = 3;
            this.ra_Admin.TabStop = true;
            this.ra_Admin.Text = "Admin";
            this.ra_Admin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quyền:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(225, 249);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(153, 65);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa User";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_ResetPass
            // 
            this.btn_ResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetPass.Location = new System.Drawing.Point(46, 329);
            this.btn_ResetPass.Name = "btn_ResetPass";
            this.btn_ResetPass.Size = new System.Drawing.Size(153, 65);
            this.btn_ResetPass.TabIndex = 2;
            this.btn_ResetPass.Text = "Reset Password";
            this.btn_ResetPass.UseVisualStyleBackColor = true;
            this.btn_ResetPass.Click += new System.EventHandler(this.btn_ResetPass_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(225, 329);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(153, 65);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(144, 133);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.ReadOnly = true;
            this.txt_Pass.Size = new System.Drawing.Size(234, 27);
            this.txt_Pass.TabIndex = 1;
            // 
            // frm01_Qt_AccountEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(422, 436);
            this.Controls.Add(this.ra_Admin);
            this.Controls.Add(this.ra_User);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ResetPass);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frm01_Qt_AccountEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin User ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.RadioButton ra_User;
        private System.Windows.Forms.RadioButton ra_Admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_ResetPass;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Pass;
    }
}