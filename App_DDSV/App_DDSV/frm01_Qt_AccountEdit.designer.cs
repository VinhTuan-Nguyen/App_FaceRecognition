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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_ResetPass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ra_Admin = new System.Windows.Forms.RadioButton();
            this.ra_User = new System.Windows.Forms.RadioButton();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.btn_ResetPass);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ra_Admin);
            this.panel1.Controls.Add(this.ra_User);
            this.panel1.Controls.Add(this.txt_Pass);
            this.panel1.Controls.Add(this.txt_UserID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 358);
            this.panel1.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Brown;
            this.btn_Back.Location = new System.Drawing.Point(403, 271);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(113, 43);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Trở Về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            this.btn_Back.MouseLeave += new System.EventHandler(this.btn_Back_MouseLeave);
            this.btn_Back.MouseHover += new System.EventHandler(this.btn_Back_MouseHover);
            // 
            // btn_ResetPass
            // 
            this.btn_ResetPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ResetPass.FlatAppearance.BorderSize = 0;
            this.btn_ResetPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn_ResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetPass.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetPass.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_ResetPass.Location = new System.Drawing.Point(181, 271);
            this.btn_ResetPass.Name = "btn_ResetPass";
            this.btn_ResetPass.Size = new System.Drawing.Size(219, 43);
            this.btn_ResetPass.TabIndex = 4;
            this.btn_ResetPass.Text = "Reset Password";
            this.btn_ResetPass.UseVisualStyleBackColor = true;
            this.btn_ResetPass.Click += new System.EventHandler(this.btn_ResetPass_Click);
            this.btn_ResetPass.MouseLeave += new System.EventHandler(this.btn_ResetPass_MouseLeave);
            this.btn_ResetPass.MouseHover += new System.EventHandler(this.btn_ResetPass_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 70);
            this.panel2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(210, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 49);
            this.label4.TabIndex = 7;
            this.label4.Text = "User ID";
            // 
            // ra_Admin
            // 
            this.ra_Admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ra_Admin.AutoSize = true;
            this.ra_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ra_Admin.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ra_Admin.ForeColor = System.Drawing.Color.MediumBlue;
            this.ra_Admin.Location = new System.Drawing.Point(178, 222);
            this.ra_Admin.Name = "ra_Admin";
            this.ra_Admin.Size = new System.Drawing.Size(82, 27);
            this.ra_Admin.TabIndex = 2;
            this.ra_Admin.TabStop = true;
            this.ra_Admin.Text = "Admin";
            this.ra_Admin.UseVisualStyleBackColor = true;
            // 
            // ra_User
            // 
            this.ra_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ra_User.AutoSize = true;
            this.ra_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ra_User.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ra_User.ForeColor = System.Drawing.Color.MediumBlue;
            this.ra_User.Location = new System.Drawing.Point(305, 222);
            this.ra_User.Name = "ra_User";
            this.ra_User.Size = new System.Drawing.Size(65, 27);
            this.ra_User.TabIndex = 3;
            this.ra_User.TabStop = true;
            this.ra_User.Text = "User";
            this.ra_User.UseVisualStyleBackColor = true;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Pass.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Pass.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(178, 164);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.ReadOnly = true;
            this.txt_Pass.Size = new System.Drawing.Size(338, 30);
            this.txt_Pass.TabIndex = 1;
            // 
            // txt_UserID
            // 
            this.txt_UserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_UserID.BackColor = System.Drawing.SystemColors.Info;
            this.txt_UserID.Enabled = false;
            this.txt_UserID.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.Location = new System.Drawing.Point(178, 108);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(192, 30);
            this.txt_UserID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(60, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(60, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quyền:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(60, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "User ID:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.btn_Save);
            this.panel3.Location = new System.Drawing.Point(377, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 55);
            this.panel3.TabIndex = 27;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = global::App_DDSV.Properties.Resources.delete;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(76, 9);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(55, 35);
            this.btn_Delete.TabIndex = 23;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImage = global::App_DDSV.Properties.Resources.tick;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(12, 9);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(55, 35);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm01_Qt_AccountEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(587, 358);
            this.Controls.Add(this.panel1);
            this.Name = "frm01_Qt_AccountEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User ID";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton ra_Admin;
        private System.Windows.Forms.RadioButton ra_User;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_ResetPass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
    }
}