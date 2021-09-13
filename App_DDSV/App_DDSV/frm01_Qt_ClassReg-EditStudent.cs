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
    public partial class frm01_Qt_ClassReg_EditStudent : Form
    {
        public frm01_Qt_ClassReg_EditStudent(string mahp)
        {
            InitializeComponent();
            txt_MaHP.Text = mahp;
        }

        private void frm01_Qt_ClassReg_EditStudent_Load(object sender, EventArgs e)
        {
            conSql.query = "SELECT DISTINCT sv.* " +
                "FROM tab_DKHP dk, tab_SinhVien sv " +
                "WHERE dk.col_MaSV = sv.col_MaSV and col_MaHP = @mahp";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();

                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                dgv_SV_View.DataSource = data.Tables[0];
                conSql.conn.Close();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkSV(txt_MaSV.Text) == false)
            {
                MessageBox.Show("Chưa Có Sinh Viên Này Trong CSDL", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conSql.query = @"SELECT * FROM tab_DKHP WHERE col_MaHP = @mahp and col_MaSV = @masv";
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                    conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataTable table = new DataTable();
                    conSql.adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Không Thể Thêm, Dữ Liệu Này Đã Tồn Tại", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        conSql.query = @"INSERT INTO tab_DKHP VALUES(@mahp, @masv)";
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                        conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                        conSql.cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã Thêm 1 Sinh viên Vào Lớp Học Phần !", "Thành Công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    conSql.conn.Close();
                }
                frm01_Qt_ClassReg_EditStudent_Load(sender, e);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (checkSV(txt_MaSV.Text) == false)
            {
                MessageBox.Show("Không Có Sinh Viên Này Trong CSDL", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Xác Nhận Xóa Sinh Viên Khỏi Học Phần Này", "Xác Nhận",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conSql.query = @"DELETE FROM tab_DKHP WHERE col_MaHP = @mahp and col_MaSV = @masv";
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                        conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                        conSql.cmd.ExecuteNonQuery();
                        conSql.conn.Close();
                    }
                    MessageBox.Show("Đã Xóa Sinh Viên Thành Công !", "Thành Công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frm01_Qt_ClassReg_EditStudent_Load(sender, e);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_SV_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_SV_View.Rows[e.RowIndex];
                txt_MaSV.Text = row.Cells["col_MaSV"].Value.ToString();
            }
        }

        private void dgv_SV_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_SV_View["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private bool checkSV(string masv)
        {
            bool result = false;
            conSql.query = @"SELECT * FROM tab_SinhVien WHERE col_MaSV = @masv";
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@masv", masv);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataTable table = new DataTable();
                conSql.adapter.Fill(table);
                if (table.Rows.Count > 0) result = true;
                conSql.conn.Close();
            }
            return result;
        }
    }
}
