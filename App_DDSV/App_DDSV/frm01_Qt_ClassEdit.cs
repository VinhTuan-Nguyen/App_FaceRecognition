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
    public partial class frm01_Qt_ClassEdit : Form
    {

        public frm01_Qt_ClassEdit()
        {
            InitializeComponent();
            txt_NienKhoa.Enabled = true;
            txt_MaHP.Enabled = true;
            btn_Delete.Enabled = false;
        }

        public frm01_Qt_ClassEdit(DataGridViewRow row)
        {
            InitializeComponent();
            txt_MaHP.Text = row.Cells["col_MaHP"].Value.ToString();
            txt_TenHP.Text = row.Cells["col_TenHP"].Value.ToString();
            txt_MaGV.Text = row.Cells["col_MaGV"].Value.ToString();
            pick_Star.Value = (DateTime)row.Cells["col_NgayBD"].Value;
            pick_End.Value = (DateTime)row.Cells["col_NgayKT"].Value;
            cbb_Thu.Text = row.Cells["col_Thu"].Value.ToString();
            txt_NienKhoa.Text = row.Cells["col_NienKhoa"].Value.ToString();
            txt_TrangThai.Text = row.Cells["col_TrangThai"].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác Nhận Xóa Học Phần Này ?\n" +
                "Chú Ý: Tất Cả Dữ Liệu Của Học Phần Này Sẽ Bị Xóa Vĩnh Viễn !",
                "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                using(conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.query = "DELETE FROM tab_DKHP WHERE col_MaHP = @mahp " +
                        "DELETE FROM tab_DiemDanh WHERE col_MaHP = @mahp " +
                        "DELETE FROM tab_LopHP WHERE col_MaHP = @mahp";
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@maHP", txt_MaHP.Text);
                    conSql.cmd.ExecuteNonQuery();
                    conSql.conn.Close();
                }
                MessageBox.Show("Học Phần Này Đã Được Xóa Khỏi CSDL", "Thành Công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_MaHP.Enabled == true)
            {
                if (txt_MaHP.Text == "" || txt_TenHP.Text == "" ||
                    txt_MaGV.Text == "" || txt_NienKhoa.Text == "" || txt_TrangThai.Text == "")
                {
                    MessageBox.Show("Thông Tin Không Được Rỗng", "Lỗi !!!!");
                }
                else if (pick_Star.Value > pick_End.Value)
                {
                    MessageBox.Show("Ngày Không Hợp Lệ", "Lỗi");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Xác Nhận Thêm Mới", "Xác Nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(result == DialogResult.OK)
                    {
                        conSql.query = "INSERT INTO tab_LopHP VALUES (@mahp, @tenhp, @star, @end, @thu, @magv, @tt, @nk)";
                        using(conSql.conn = new SqlConnection(conSql.conString))
                        {
                            conSql.conn.Open();
                            conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                            conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                            conSql.cmd.Parameters.AddWithValue("@tenhp", txt_TenHP.Text);
                            conSql.cmd.Parameters.AddWithValue("@star", pick_Star.Value);
                            conSql.cmd.Parameters.AddWithValue("@end", pick_End.Value);
                            conSql.cmd.Parameters.AddWithValue("@thu", cbb_Thu.Text);
                            conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                            conSql.cmd.Parameters.AddWithValue("@tt", txt_TrangThai.Text);
                            conSql.cmd.Parameters.AddWithValue("@nk", txt_NienKhoa.Text);
                            conSql.cmd.ExecuteNonQuery();
                            conSql.conn.Close();
                        }
                        MessageBox.Show("Thêm Mới Thành Công", "Thành CÔng");
                    }
                }
            }
            else
            {
                conSql.query = "UPDATE tab_LopHP SET " +
                    "col_TenHP = @tenhp, " +
                    "col_MaGV = @magv, " +
                    "col_NienKhoa = @nienkhoa, " +
                    "col_NgayBD = @star, " +
                    "col_NgayKT = @end, " +
                    "col_Thu = @thu, " +
                    "col_TrangThai = @tt " +
                    "WHERE col_MaHP = @mahp";

                if (txt_MaHP.Text != "" && txt_TenHP.Text != "" && txt_MaGV.Text != "")
                {
                    DialogResult result = MessageBox.Show("Xác Nhận Chỉnh Sửa Thông Tin Lớp Học Phần", "Xác Nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        using (conSql.conn = new SqlConnection(conSql.conString))
                        {
                            conSql.conn.Open();
                            conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                            conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                            conSql.cmd.Parameters.AddWithValue("@tenhp", txt_TenHP.Text);
                            conSql.cmd.Parameters.AddWithValue("@nienkhoa", txt_NienKhoa.Text);
                            conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                            conSql.cmd.Parameters.AddWithValue("@star", pick_Star.Value);
                            conSql.cmd.Parameters.AddWithValue("@end", pick_End.Value);
                            conSql.cmd.Parameters.AddWithValue("@thu", cbb_Thu.SelectedItem);
                            conSql.cmd.Parameters.AddWithValue("@tt", txt_TrangThai.Text);
                            conSql.cmd.ExecuteNonQuery();
                            conSql.conn.Close();
                        }
                        MessageBox.Show("Thông Tin Đã Được Chỉnh Sửa", "Thành Công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Thông Tin Không Được Để Trống", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pick_Star_ValueChanged(object sender, EventArgs e)
        {
            string thu = pick_Star.Value.DayOfWeek.ToString();
            switch (thu)
            {
                case "Monday":
                    cbb_Thu.SelectedIndex = 0;
                    break;
                case "Tuesday":
                    cbb_Thu.SelectedIndex = 1;
                    break;
                case "Wednesday":
                    cbb_Thu.SelectedIndex = 2;
                    break;
                case "Thursday":
                    cbb_Thu.SelectedIndex = 3;
                    break;
                case "Firday":
                    cbb_Thu.SelectedIndex = 4;
                    break;
                case "Saturday":
                    cbb_Thu.SelectedIndex = 5;
                    break;
                case "Sunday":
                    cbb_Thu.SelectedIndex = 6;
                    break;
            }
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
