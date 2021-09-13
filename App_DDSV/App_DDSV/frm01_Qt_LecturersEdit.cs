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
        public frm01_Qt_LecturersEdit(DataGridViewRow row)
        {
            InitializeComponent();
            txt_MaGV.Text = row.Cells["col_MaGV"].Value.ToString();
            txt_HoLot.Text = row.Cells["col_HoLot"].Value.ToString();
            txt_Ten.Text = row.Cells["col_Ten"].Value.ToString();
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_MaGV.Text == "" || txt_HoLot.Text == "" || txt_Ten.Text == "" ||
                txt_Khoa.Text == "" || txt_Email.Text == "")
            {
                MessageBox.Show("Chưa Nhập Đầy Đủ Các Thông Tin !", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool sex = ra_Nam.Checked ? true : false;
                conSql.query = "UPDATE tab_GiangVien SET " +
                    "col_HoLot = @holot," +
                    "col_Ten = @ten," +
                    "col_Khoa = @khoa," +
                    "col_Email = @email," +
                    "col_GioiTinh = @gt " +
                    "WHERE col_MaGV = @magv";
                DialogResult result = MessageBox.Show("Xác Nhận Thay Đổi Thông Tin Người Này !",
                    "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                        conSql.cmd.Parameters.AddWithValue("@holot", txt_HoLot.Text);
                        conSql.cmd.Parameters.AddWithValue("@ten", txt_Ten.Text);
                        conSql.cmd.Parameters.AddWithValue("@khoa", txt_Khoa.Text);
                        conSql.cmd.Parameters.AddWithValue("@email ", txt_Email.Text);
                        conSql.cmd.Parameters.AddWithValue("@gt", sex);
                        conSql.cmd.ExecuteNonQuery();
                        conSql.conn.Close();
                    }
                    MessageBox.Show("Đã Thay Đổi Một Trường Thông Tin!", "Thành Công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
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

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.query = @"SELECT * FROM tab_Login WHERE col_User = @magv";

                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@magv",txt_MaGV.Text);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                conSql.adapter.Fill(table);
                conSql.conn.Close();
            }
            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Tài Khoản Này Đã Được Tạo Trước Đó", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Tài Khoản Khả Dụng\nXác Nhận Tạo Tài Khoản Mới !", "Xác Nhận",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
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
                    MessageBox.Show("Tạo Tài Khoản Thành Công !", "Hoàn Tất",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
