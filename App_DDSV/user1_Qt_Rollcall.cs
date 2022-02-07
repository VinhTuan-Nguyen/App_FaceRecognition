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
    public partial class user1_Qt_Rollcall : UserControl
    {
        public user1_Qt_Rollcall()
        {
            InitializeComponent();
        }

        private void user1_Qt_Rollcall_Load(object sender, EventArgs e)
        {
            conSql.query = "SELECT DISTINCT col_NienKhoa FROM tab_LopHP";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                try
                {
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    cbb_NienKhoa.DataSource = data.Tables[0];
                    cbb_NienKhoa.DisplayMember = "col_NienKhoa";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Xãy Ra Lỗi: " + ex, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conSql.conn.Close();
            }
        }

        private void cbb_NienKhoa_TextChanged(object sender, EventArgs e)
        {
            conSql.query = "SELECT DISTINCT col_TenHP FROM tab_LopHP WHERE col_NienKhoa=@nk";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                try
                {
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@nk", cbb_NienKhoa.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    cbb_TenHP.DataSource = data.Tables[0];
                    cbb_TenHP.DisplayMember = "col_TenHP";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Xãy Ra Lỗi: " + ex, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conSql.conn.Close();
            }
        }

        private void cbb_TenHP_TextChanged(object sender, EventArgs e)
        {
            conSql.query = "SELECT DISTINCT col_MaHP FROM tab_LopHP WHERE col_NienKhoa=@nk and col_TenHP=@hp";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                try
                {
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@nk", cbb_NienKhoa.Text);
                    conSql.cmd.Parameters.AddWithValue("@hp", cbb_TenHP.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    cbb_MaHP.DataSource = data.Tables[0];
                    cbb_MaHP.DisplayMember = "col_MaHP";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Xãy Ra Lỗi: " + ex, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conSql.conn.Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(cbb_MaHP.Text == "")
            {
                MessageBox.Show("Mã Học Phần Rỗng", "Cảnh Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conSql.query = "SELECT dd.*, gv.col_MaGV, gv.col_HoTen col_TenGV, sv.col_HoTen col_TenSV, sv.col_Lop, hp.col_TenHP, hp.col_Thu " +
                    "FROM tab_DiemDanh dd, tab_GiangVien gv, tab_SinhVien sv, tab_LopHP hp " +
                    "WHERE dd.col_MaHP = hp.col_MaHP and dd.col_MaSV = sv.col_MaSV and hp.col_MaGV = gv.col_MaGV and " +
                    "hp.col_MaHP=@hp";

                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@hp", cbb_MaHP.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    if (data.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Không Tìm Thấy Danh Sách", "Thông Tin");
                    }
                    else
                    {
                        dgv_View.DataSource = data.Tables[0];
                    }
                    conSql.conn.Close();
                }
            }
        }

        private void dgv_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_View.Rows[e.RowIndex];
                string Date = row.Cells["col_NgayDD"].Value.ToString();
                string MaHP = row.Cells["col_MaHP"].Value.ToString();
                string MaSV = row.Cells["col_MaSV"].Value.ToString();
                string Note = row.Cells["col_GhiChu"].Value.ToString();
                string Time = row.Cells["col_GioDD"].Value.ToString();
                string Name = row.Cells["col_TenSV"].Value.ToString();
                frm00_Note f = new frm00_Note(Date, MaHP, MaSV, Note, Time, Name);
                f.ShowDialog();
                btn_Search_Click(sender, e);
            }
        }

        private void cbb_MaHP_TextChanged(object sender, EventArgs e)
        {
            conSql.query = "SELECT DISTINCT col_NgayDD FROM tab_DiemDanh WHERE col_MaHP=@hp";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                try
                {
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@hp", cbb_MaHP.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    if(data.Tables[0].Rows.Count > 0)
                    {
                        cbb_NgayDD.DataSource = data.Tables[0];
                        cbb_NgayDD.DisplayMember = "col_NgayDD";
                    }
                    else
                    {
                        cbb_NgayDD.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Xãy Ra Lỗi: " + ex, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conSql.conn.Close();
            }
        }

        private void cbb_NgayDD_TextChanged(object sender, EventArgs e)
        {
            if(cbb_NgayDD.Text == "")
            {
                btn_Filter.Visible = false;
            }
            else
            {
                btn_Filter.Visible = true;
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            conSql.query = "SELECT dd.*, gv.col_MaGV, gv.col_HoTen col_TenGV, sv.col_HoTen col_TenSV, sv.col_Lop, hp.col_TenHP, hp.col_Thu " +
                "FROM tab_DiemDanh dd, tab_GiangVien gv, tab_SinhVien sv, tab_LopHP hp " +
                "WHERE dd.col_MaHP = hp.col_MaHP and dd.col_MaSV = sv.col_MaSV and hp.col_MaGV = gv.col_MaGV and " +
                "hp.col_MaHP = @hp and " +
                "dd.col_NgayDD = @date";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@hp", cbb_MaHP.Text);
                conSql.cmd.Parameters.AddWithValue("@date", DateTime.Parse(cbb_NgayDD.Text));
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                if (data.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không Tìm Thấy Danh Sách", "Thông Tin");
                }
                else
                {
                    dgv_View.DataSource = data.Tables[0];
                }
                conSql.conn.Close();
            }
        }

        private void dgv_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_View["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private void btn_Search_MouseHover(object sender, EventArgs e)
        {
            btn_Search.BackgroundImage = global::App_DDSV.Properties.Resources.search_hover;
        }

        private void btn_Search_MouseLeave(object sender, EventArgs e)
        {
            btn_Search.BackgroundImage = global::App_DDSV.Properties.Resources.search;
        }
    }
}
