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
    public partial class frm01_Qt_StudentEdit : Form
    {
        public frm01_Qt_StudentEdit()
        {
            InitializeComponent();
            txt_MaSV.Enabled = true;
            btn_Delete.Enabled = false;
        }
        public frm01_Qt_StudentEdit(DataGridViewRow row)
        {
            InitializeComponent();
            txt_MaSV.Text = row.Cells["col_MaSV"].Value.ToString();
            txt_TenSV.Text = row.Cells["col_HoTen"].Value.ToString();
            txt_Lop.Text = row.Cells["col_Lop"].Value.ToString();
            txt_Date.Text = row.Cells["col_NgaySinh"].Value.ToString();
            txt_Email.Text = row.Cells["col_Email"].Value.ToString();
            bool sex = (bool)row.Cells["col_GioiTinh"].Value;
            if(sex == true)
            {
                ra_Nam.Checked = true;
            }
            else
            {
                ra_Nu.Checked = true;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác Nhận Xóa Sinh Viên Này !\n" +
                "Chú ý: Tất Cả Dữ Liệu Của Sinh Viên Này Sẽ Bị Xóa Vĩnh Viễn\nHãy Cân Nhắc",
                "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                conSql.query = "DELETE FROM tab_DKHP WHERE col_MaSV = @masv " +
                    "DELETE FROM tab_DiemDanh WHERE col_MaSV = @masv " +
                    "DELETE FROM tab_SinhVien WHERE col_MaSV = @masv";
                using(conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                    conSql.cmd.ExecuteNonQuery();
                    conSql.conn.Close();
                }
                MessageBox.Show("Xóa Sinh Viên Thành Công", "Thành Công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(txt_MaSV.Enabled == true)
            {
                if (txt_Date.Text == "  /  /" || txt_Email.Text == "" ||
                    txt_Lop.Text == "" || txt_MaSV.Text=="" || txt_TenSV.Text == "" ||
                    (ra_Nam.Checked == false && ra_Nu.Checked == false))
                {
                    MessageBox.Show("Thông Tin Không Được Rỗng", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        DateTime dt = DateTime.Parse(txt_Date.Text);
                        DialogResult result = MessageBox.Show("Xác Nhận Thêm Mới", "Xác Nhận",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            bool sex = ra_Nam.Checked ? true : false;

                            conSql.query = @"INSERT INTO tab_SinhVien VALUES(@mssv,@lop,@mail,@gt,@ten,@ns)";

                            using (conSql.conn = new SqlConnection(conSql.conString))
                            {
                                conSql.conn.Open();
                                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                                conSql.cmd.Parameters.AddWithValue("@ten", txt_TenSV.Text);
                                conSql.cmd.Parameters.AddWithValue("@lop", txt_Lop.Text.ToUpper());
                                conSql.cmd.Parameters.AddWithValue("@mail", txt_Email.Text);
                                conSql.cmd.Parameters.AddWithValue("@gt", sex);
                                conSql.cmd.Parameters.AddWithValue("@mssv", txt_MaSV.Text.ToUpper());
                                conSql.cmd.Parameters.AddWithValue("@ns", dt.ToShortDateString());
                                conSql.cmd.ExecuteNonQuery();
                                conSql.conn.Close();
                            }
                            MessageBox.Show("Chỉnh Sửa Thành Công", "Thành Công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        txt_Date.Text = "";
                        MessageBox.Show("Định Dạng Ngày Tháng Sai", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                try
                {
                    DateTime dt = DateTime.Parse(txt_Date.Text);
                    bool sex = ra_Nam.Checked ? true : false;

                    conSql.query = @"UPDATE tab_SinhVien SET " +
                        "col_HoTen = @ten," +
                        "col_NgaySinh = @ns," +
                        "col_Lop = @lop," +
                        "col_Email= @email," +
                        "col_GioiTinh = @gt " +
                        "WHERE col_MaSV = @masv";

                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@ten", txt_TenSV.Text);
                        conSql.cmd.Parameters.AddWithValue("@lop", txt_Lop.Text.ToUpper());
                        conSql.cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                        conSql.cmd.Parameters.AddWithValue("ns", dt.ToShortDateString());
                        conSql.cmd.Parameters.AddWithValue("@gt", sex);
                        conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                        conSql.cmd.ExecuteNonQuery();
                        MessageBox.Show("Chỉnh Sửa Thành Công", "Thành Công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conSql.conn.Close();
                    }
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Định Dạng Ngày Tháng Sai", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
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
