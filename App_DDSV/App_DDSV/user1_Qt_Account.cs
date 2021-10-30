using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_DDSV
{
    public partial class user1_Qt_Account : UserControl
    {
        public user1_Qt_Account()
        {
            InitializeComponent();
        }

        private void user1_Qt_Account_Load(object sender, EventArgs e)
        {
            conSql.query = @"SELECT * FROM tab_Login";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                try
                {
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_AllUser.DataSource = data.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi !!!!!\nThông Tin Lỗi:\n"
                        + ex.Message, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conSql.conn.Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string role = "";
            if (ra_Admin.Checked == true)
            {
                role = "admin";
            }
            else if (ra_User.Checked == true)
            {
                role = "user";
            }

            if (txt_UserID.Text != "" || role == "" || role == "admin" || role == "user")
            {
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    try
                    {
                        conSql.cmd = new SqlCommand("asp_AllUserVal", conSql.conn);
                        conSql.cmd.CommandType = CommandType.StoredProcedure;
                        conSql.cmd.Parameters.AddWithValue("@user", txt_UserID.Text);
                        conSql.cmd.Parameters.AddWithValue("@role", role);

                        conSql.adapter = new SqlDataAdapter(conSql.cmd);
                        DataSet data = new DataSet();
                        conSql.adapter.Fill(data);

                        dgv_AllUser.DataSource = data.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi !!!!!\nThông Tin Lỗi:\n"
                            + ex.Message, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conSql.conn.Close();
                }
            }
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            string role = ra_Admin.Checked ? "admin" : "user";

            if (txt_UserID.Text != "" && role != "")
            {
                DialogResult result = MessageBox.Show("Xác Nhận Thêm Mới User ID Này ?\nUser ID: "
                    + txt_UserID.Text + "\tQuyền: " + role, "Thông Báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    conSql.cmd = new SqlCommand();
                    conSql.adapter = new SqlDataAdapter();
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand("asp_AllUserVal", conSql.conn);
                        conSql.cmd.CommandType = CommandType.StoredProcedure;
                        conSql.cmd.Parameters.AddWithValue("@user", txt_UserID.Text);
                        conSql.cmd.Parameters.AddWithValue("@role", "");

                        conSql.adapter = new SqlDataAdapter(conSql.cmd);
                        DataSet data = new DataSet();
                        conSql.adapter.Fill(data);

                        if (data.Tables[0].Rows.Count == 0)
                        {
                            try
                            {
                                conSql.cmd = new SqlCommand("asp_AddUser", conSql.conn);
                                conSql.cmd.CommandType = CommandType.StoredProcedure;
                                conSql.cmd.Parameters.AddWithValue("@user", txt_UserID.Text);
                                conSql.cmd.Parameters.AddWithValue("@role", role);
                                conSql.cmd.ExecuteNonQuery();
                                user1_Qt_Account_Load(sender, e);
                                MessageBox.Show("Thêm Thành Công!", "Thông Báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đã Có User ID Này, Không Thể Thêm !", "Thông Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        conSql.conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("User ID Rỗng !", "Lỗi !!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_UserID.Text = "";
            ra_Admin.Checked = false;
            ra_User.Checked = false;
            user1_Qt_Account_Load(sender, e);
        }

        private void dgv_AllUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_AllUser.Rows[e.RowIndex];
                frm01_Qt_AccountEdit f = new frm01_Qt_AccountEdit(row);
                f.ShowDialog();
                user1_Qt_Account_Load(sender, e);
            }
        }

        private void dgv_AllUser_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_AllUser["col_STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }
    }
}
