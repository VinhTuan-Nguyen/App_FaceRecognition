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
    public partial class frm01_Qt_LecturersEdit : Form
    {
        public frm01_Qt_LecturersEdit()
        {
            InitializeComponent();
            txt_MaGV.Enabled = true;
            btn_Delete.Enabled = false;
        }
        public frm01_Qt_LecturersEdit(DataGridViewRow row)
        {
            InitializeComponent();
            txt_MaGV.Text = row.Cells["col_MaGV"].Value.ToString();
            txt_HoTen.Text = row.Cells["col_HoTen"].Value.ToString();
            txt_Khoa.Text = row.Cells["col_Khoa"].Value.ToString();
            txt_Email.Text = row.Cells["col_Email"].Value.ToString();
            if((bool)row.Cells["col_GioiTinh"].Value == true)
            {
                ra_Nam.Checked = true;
            }
            else
            {
                ra_Nu.Checked = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_MaGV.Enabled == true)
            {
                if (txt_MaGV.Text == "" || txt_HoTen.Text == "" ||
                    txt_Khoa.Text == "" || txt_Email.Text == "" ||
                    (ra_Nam.Checked == false && ra_Nu.Checked == false))
                {
                    MessageBox.Show("Thông Tin Không Được Rỗng !", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    bool sex = ra_Nam.Checked ? true : false;
                    conSql.query = "INSERT INTO tab_GiangVien VALUES(@magv,@khoa,@email,@gt,@ten)";
                    DialogResult result = MessageBox.Show("Xác Nhận Thêm Mới !", "Xác Nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        using (conSql.conn = new SqlConnection(conSql.conString))
                        {
                            conSql.conn.Open();
                            conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                            conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                            conSql.cmd.Parameters.AddWithValue("@ten", txt_HoTen.Text);
                            conSql.cmd.Parameters.AddWithValue("@khoa", txt_Khoa.Text);
                            conSql.cmd.Parameters.AddWithValue("@email ", txt_Email.Text);
                            conSql.cmd.Parameters.AddWithValue("@gt", sex);
                            conSql.cmd.ExecuteNonQuery();
                            conSql.conn.Close();
                        }
                        MessageBox.Show("Thêm Thành Công!", "Thành Công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    btn_CreateAcc_Click(sender,e);
                    txt_Email.Text = "";
                    txt_HoTen.Text = "";
                    txt_Khoa.Text = "";
                    txt_MaGV.Text = "";
                    ra_Nam.Checked = false;
                    ra_Nu.Checked = false;
                }
            }
            else
            {
                if (txt_MaGV.Text == "" || txt_HoTen.Text == "" ||
                    txt_Khoa.Text == "" || txt_Email.Text == "")
                {
                    MessageBox.Show("Thông Tin Không Được Rỗng !", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool sex = ra_Nam.Checked ? true : false;
                    conSql.query = "UPDATE tab_GiangVien SET " +
                        "col_HoTen = @ten," +
                        "col_Khoa = @khoa," +
                        "col_Email = @email," +
                        "col_GioiTinh = @gt " +
                        "WHERE col_MaGV = @magv";
                    DialogResult result = MessageBox.Show("Xác Nhận Chỉnh Sửa !", "Xác Nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        using (conSql.conn = new SqlConnection(conSql.conString))
                        {
                            conSql.conn.Open();
                            conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                            conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                            conSql.cmd.Parameters.AddWithValue("@ten", txt_HoTen.Text);
                            conSql.cmd.Parameters.AddWithValue("@khoa", txt_Khoa.Text);
                            conSql.cmd.Parameters.AddWithValue("@email ", txt_Email.Text);
                            conSql.cmd.Parameters.AddWithValue("@gt", sex);
                            conSql.cmd.ExecuteNonQuery();
                            conSql.conn.Close();
                        }
                        MessageBox.Show("Chỉnh Sửa Thành Công!", "Thành Công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác Nhận Xóa Thông Tin Người Này" +
                "\nChú ý: Tất Cả Thông Tin Của Người Này Sẽ Bị Xóa Vĩnh Viễn !" +
                "\nHãy Cân Nhắc.",
                "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                conSql.query = "DELETE FROM tab_Login WHERE col_User = @magv " +
                    "DELETE FROM tab_LopHP WHERE col_MaGV = @magv " +
                    "DELETE FROM tab_GiangVien WHERE col_MaGV = @magv";

                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();

                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                    conSql.cmd.ExecuteNonQuery();
                    conSql.conn.Close();
                }
                MessageBox.Show("Thông Tin Này Đã Bị Xóa!", "Thành Công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btn_CreateAcc_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (txt_MaGV.Text == "")
            {
                MessageBox.Show("Dữ Liệu Rỗng, Không Thể Tạo", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.query = @"SELECT * FROM tab_Login WHERE col_User = @magv";

                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    conSql.adapter.Fill(table);
                    conSql.conn.Close();
                }
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Tài Khoản Này Đã Được Tạo", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Xác Nhận Tạo Tài Khoản Mới !", "Xác Nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        using (conSql.conn = new SqlConnection(conSql.conString))
                        {
                            conSql.conn.Open();
                            conSql.cmd = new SqlCommand("asp_AddUser", conSql.conn);
                            conSql.cmd.CommandType = CommandType.StoredProcedure;
                            conSql.cmd.Parameters.AddWithValue("@user", txt_MaGV.Text);
                            conSql.cmd.Parameters.AddWithValue("@role", "user");
                            conSql.cmd.ExecuteNonQuery();
                            conSql.conn.Close();
                        }
                        MessageBox.Show("Tạo Tài Khoản Thành Công !", "Thành Công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btn_CreateAcc_MouseHover(object sender, EventArgs e)
        {
            btn_CreateAcc.ForeColor = Color.YellowGreen;
        }

        private void btn_CreateAcc_MouseLeave(object sender, EventArgs e)
        {
            btn_CreateAcc.ForeColor = Color.DarkGreen;
        }

        private void btn_Back_MouseHover(object sender, EventArgs e)
        {
            btn_Back.ForeColor = Color.OrangeRed;
        }

        private void btn_Back_MouseLeave(object sender, EventArgs e)
        {
            btn_Back.ForeColor = Color.Brown;
        }
    }
}
