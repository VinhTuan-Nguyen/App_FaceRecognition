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
    public partial class frm01_Qt_ClassReg_EditClass : Form
    {
        public frm01_Qt_ClassReg_EditClass(string masv)
        {
            InitializeComponent();
            txt_MaSV.Text = masv;
        }

        private void frm01_Qt_ClassReg_EditClass_Load(object sender, EventArgs e)
        {
            conSql.query = "SELECT DISTINCT hp.* " +
                "FROM tab_DKHP dk, tab_LopHP hp " +
                "WHERE dk.col_MaHP = hp.col_MaHP and col_MaSV = @masv";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();

                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                dgv_HP_View.DataSource = data.Tables[0];
                conSql.conn.Close();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (checkHP(txt_MaHP.Text) == false)
            {
                MessageBox.Show("Không Có Học Phần Này Trong CSDL", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frm01_Qt_ClassRegMesageText f = new frm01_Qt_ClassRegMesageText(txt_MaHP.Text, txt_MaSV.Text);
                f.ShowDialog();
                frm01_Qt_ClassReg_EditClass_Load(sender, e);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (checkHP(txt_MaHP.Text) == false)
            {
                MessageBox.Show("Không Có Học Phần Này Trong CSDL", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Xác Nhận Bỏ Đăng Kí Học Phần Này", "Xác Nhận",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conSql.query = @"DELETE FROM tab_DKHP WHERE col_MaHP = @mahp and col_MaSV = @masv";
                    Command(conSql.query, txt_MaHP.Text);
                    MessageBox.Show("Bỏ Đăng Kí Học Phần Thành Công", "Thành Công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm01_Qt_ClassReg_EditClass_Load(sender, e);
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkHP(txt_MaHP.Text) == false)
            {
                MessageBox.Show("Không Có Học Phần Này Trong CSDL", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conSql.query = @"SELECT * FROM tab_DKHP WHERE col_MaHP = @mahp and col_MaSV = @masv";
                DataSet data = new DataSet();
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                    conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    conSql.adapter.Fill(data);
                    conSql.conn.Close();
                }
                if (data.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Học Phần Này Đã Được Đăng Ký Trước Đó !", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Xác Nhận Đăng Kí Học Phần Này ?", "Xác Nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        conSql.query = @"INSERT INTO tab_DKHP VALUES(@mahp, @masv)";
                        Command(conSql.query, txt_MaHP.Text);
                        MessageBox.Show("Đăng Kí Học Phần Thành Công !", "Thành Công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm01_Qt_ClassReg_EditClass_Load(sender, e);
                    }
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_HP_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_HP_View.Rows[e.RowIndex];
                txt_MaHP.Text = row.Cells["col_MaHP"].Value.ToString();
            }
        }

        private void dgv_HP_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_HP_View["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private bool checkHP(string mahp)
        {
            bool result = false;
            conSql.query = @"SELECT * FROM tab_LopHP WHERE col_MaHP = @mahp";
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@mahp", mahp);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataTable table = new DataTable();
                conSql.adapter.Fill(table);
                if (table.Rows.Count > 0) result = true;
                conSql.conn.Close();
            }
            return result;
        }

        private void Command(string query, string mahp)
        {
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@mahp", mahp);
                conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                conSql.cmd.ExecuteNonQuery();
                conSql.conn.Close();
            }
        }
    }
}
