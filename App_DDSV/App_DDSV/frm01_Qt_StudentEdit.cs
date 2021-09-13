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
        public frm01_Qt_StudentEdit(DataGridViewRow row)
        {
            InitializeComponent();
            txt_MaSV.Text = row.Cells[1].Value.ToString();
            txt_HoLot.Text = row.Cells[2].Value.ToString();
            txt_TenSV.Text = row.Cells[3].Value.ToString();
            txt_Lop.Text = row.Cells[4].Value.ToString();
            txt_Email.Text = row.Cells[5].Value.ToString();
            bool sex = (bool)row.Cells[6].Value;
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            bool sex = ra_Nam.Checked ? true : false;

            conSql.query = @"UPDATE tab_SinhVien SET " +
                "col_HoLot = @ho," +
                "col_Ten = @ten," +
                "col_Lop = @lop," +
                "col_Email= @email," +
                "col_GioiTinh = @gt " +
                "WHERE col_MaSV = @masv";

            using(conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@ho",txt_HoLot.Text);
                conSql.cmd.Parameters.AddWithValue("@ten",txt_TenSV.Text);
                conSql.cmd.Parameters.AddWithValue("@lop",txt_Lop.Text.ToUpper());
                conSql.cmd.Parameters.AddWithValue("@email",txt_Email.Text);
                conSql.cmd.Parameters.AddWithValue("@gt",sex);
                conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                conSql.cmd.ExecuteNonQuery();
                MessageBox.Show("Chỉnh Sửa THành Công", "Thành Công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                conSql.conn.Close();
            }
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
