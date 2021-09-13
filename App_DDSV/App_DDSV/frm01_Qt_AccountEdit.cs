using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_DDSV
{
    public partial class frm01_Qt_AccountEdit : Form
    {
        public frm01_Qt_AccountEdit(DataGridViewRow row)
        {
            InitializeComponent();
            txt_UserID.Text = row.Cells["col_User"].Value.ToString();
            txt_Pass.Text = row.Cells["col_Password"].Value.ToString();
            if (txt_UserID.Text == "root")
            {
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
                btn_ResetPass.Enabled = false;
            }
            if (row.Cells["col_Role"].Value.ToString() == "admin")
            {
                ra_Admin.Checked = true;
            }
            else
            {
                ra_User.Checked = true;
            }
        }

        private void btn_ResetPass_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE tab_Login SET col_Password = '781e5e245d69b566979b86e28d23f2c7' WHERE col_User = @user";

            DialogResult result = MessageBox.Show("Xác Nhận Reset Password !", "Reset Password",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@user", txt_UserID.Text);
                    conSql.cmd.ExecuteNonQuery();
                    MessageBox.Show("Reset Password Thành Công !", "Thành Công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    conSql.conn.Close();
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string role = ra_Admin.Checked ? "admin" : "user";
            conSql.query = @"UPDATE tab_Login SET col_Role = @role WHERE col_User = @user";

            DialogResult result = MessageBox.Show("Xác Nhận Chỉnh Sửa !", "Chỉnh Sửa",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@user", txt_UserID.Text);
                    conSql.cmd.Parameters.AddWithValue("@role", role);
                    conSql.cmd.ExecuteNonQuery();
                    MessageBox.Show("Hoàn Tất Chỉnh Sửa !", "Thành Công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    conSql.conn.Close();
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM tab_Login WHERE col_User = @user";

            DialogResult result = MessageBox.Show("Xác Nhận Xóa User Này !\nLưu Ý: User ID Này Sẽ Bị Xóa Vĩnh Viễn",
                "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            if(result == DialogResult.OK)
            {
                using(conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@user", txt_UserID.Text);
                    conSql.cmd.ExecuteNonQuery();
                    conSql.conn.Close();
                }
                MessageBox.Show("Xóa User ID Thành Công", "Thành Công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
