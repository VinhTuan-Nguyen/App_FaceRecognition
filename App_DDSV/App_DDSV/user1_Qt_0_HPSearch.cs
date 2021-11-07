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
    public partial class user1_Qt_0_HPSearch : UserControl
    {
        public user1_Qt_0_HPSearch()
        {
            InitializeComponent();
        }

        private void user1_Qt_0_HPSearch_Load(object sender, EventArgs e)
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            lb_Info.Visible = false;
            if(txt_TenHP.Text == "" || (txt_MaHP.Text == "" && cbb_NienKhoa.Text == ""))
            {
                MessageBox.Show("Cần Ít Nhất 2 Thông Tin Để Tìm Kiếm", "Cảnh Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txt_MaHP.Text != "" && txt_TenHP.Text != "")
                {
                    conSql.query = "SELECT col_MaHP, col_TenHP FROM tab_LopHP WHERE col_MaHP=@mahp and col_TenHP=@tenhp";
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                        conSql.cmd.Parameters.AddWithValue("@tenhp", txt_TenHP.Text);
                        conSql.adapter = new SqlDataAdapter(conSql.cmd);
                        DataSet data = new DataSet();
                        conSql.adapter.Fill(data);
                        if (data.Tables[0].Rows.Count == 0)
                        {
                            lb_Info.Visible = true;
                        }
                        else
                        {
                            dgv_View.DataSource = data.Tables[0];
                        }
                        conSql.conn.Close();
                    }
                }
                else if (txt_MaHP.Text != "" && cbb_NienKhoa.Text != "")
                {
                    conSql.query = "SELECT col_MaHP, col_TenHP FROM tab_LopHP WHERE col_MaHP=@hp and col_NienKhoa=@nk";
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@hp", txt_MaHP.Text);
                        conSql.cmd.Parameters.AddWithValue("@nk", cbb_NienKhoa.Text);
                        conSql.adapter = new SqlDataAdapter(conSql.cmd);
                        DataSet data = new DataSet();
                        conSql.adapter.Fill(data);
                        if (data.Tables[0].Rows.Count == 0)
                        {
                            lb_Info.Visible = true;
                        }
                        else
                        {
                            dgv_View.DataSource = data.Tables[0];
                        }
                        conSql.conn.Close();
                    }
                }
                else if (txt_TenHP.Text != "" && cbb_NienKhoa.Text != "")
                {
                    conSql.query = "SELECT col_MaHP, col_TenHP FROM tab_LopHP WHERE col_NienKhoa=@nk and col_TenHP=@tenhp";
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@nk", cbb_NienKhoa.Text);
                        conSql.cmd.Parameters.AddWithValue("@tenhp", txt_TenHP.Text);
                        conSql.adapter = new SqlDataAdapter(conSql.cmd);
                        DataSet data = new DataSet();
                        conSql.adapter.Fill(data);
                        if (data.Tables[0].Rows.Count == 0)
                        {
                            lb_Info.Visible = true;
                        }
                        else
                        {
                            dgv_View.DataSource = data.Tables[0];
                        }
                        conSql.conn.Close();
                    }
                }
                else
                {
                    conSql.query = "SELECT col_MaHP, col_TenHP FROM tab_LopHP " +
                        "WHERE col_MaHP=@hp and col_NienKhoa=@nk and col_TenHP=@tenhp";
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@hp", txt_MaHP.Text);
                        conSql.cmd.Parameters.AddWithValue("@nk", cbb_NienKhoa.Text);
                        conSql.cmd.Parameters.AddWithValue("@tenhp", txt_TenHP.Text);
                        conSql.adapter = new SqlDataAdapter(conSql.cmd);
                        DataSet data = new DataSet();
                        conSql.adapter.Fill(data);
                        if (data.Tables[0].Rows.Count == 0)
                        {
                            lb_Info.Visible = true;
                        }
                        else
                        {
                            dgv_View.DataSource = data.Tables[0];
                        }
                        conSql.conn.Close();
                    }
                }
            }
        }

        private void dgv_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_View.Rows[e.RowIndex];
                txt_MSHP.Text = row.Cells["col_MaHP"].Value.ToString();
                loadMaHP(txt_MSHP.Text);
            }
        }

        private void loadMaHP(string mahp)
        {
            conSql.query = "SELECT sv.* FROM tab_DKHP dk, tab_LopHP hp, tab_SinhVien sv " +
                "WHERE dk.col_MaHP = hp.col_MaHP and dk.col_MaSV = sv.col_MaSV and hp.col_MaHP = @hp";
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@hp", mahp);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                dgv_SV_View.DataSource = data.Tables[0];
                conSql.conn.Close();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (panel_Add.Visible == true)
            {
                panel_Add.Visible = false;
            }
            else
            {
                panel_Add.Visible = true;
            }
        }

        private void btn_AddSV_Click(object sender, EventArgs e)
        {
            if(txt_MSHP.Text == "")
            {
                MessageBox.Show("Chưa Chọn Học Phần", "Cảnh Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conSql.query = "SELECT * FROM tab_SinhVien WHERE col_MaSV = @masv " +
                    "SELECT * FROM tab_DKHP WHERE col_MaHP=@mahp and col_MaSV = @masv";
                using(conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@mahp", txt_MSHP.Text);
                    conSql.cmd.Parameters.AddWithValue("@masv", txt_MSSV.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    if(data.Tables[0].Rows.Count > 0)
                    {
                        if (data.Tables[1].Rows.Count > 0)
                        {
                            MessageBox.Show("Chỉ Được Đăng Kí Một Lần", "Cảnh Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            conSql.query = "INSERT INTO tab_DKHP VALUES(@hp,@sv)";
                            conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                            conSql.cmd.Parameters.AddWithValue("@hp", txt_MSHP.Text);
                            conSql.cmd.Parameters.AddWithValue("@sv", txt_MSSV.Text);
                            conSql.cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm Thành Công", "Thành Công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Số Sinh Viên Sai", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conSql.conn.Close();
                }
                loadMaHP(txt_MSHP.Text);
            }
        }

        private void dgv_SV_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_SV_View.Rows[e.RowIndex];
                DialogResult result = MessageBox.Show("Xác Nhận Xóa Sinh Viên Khỏi Học Phần Này", "Xác Nhận",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conSql.query = "DELETE FROM tab_DKHP WHERE col_MaHP=@hp and col_MaSV=@sv";
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@hp", txt_MSHP.Text);
                        conSql.cmd.Parameters.AddWithValue("@sv", row.Cells["col_MaSV"].Value.ToString());
                        conSql.cmd.ExecuteNonQuery();
                        conSql.cmd.Clone();
                    }
                    MessageBox.Show("Xóa Sinh Viên Thành Công", "Thành Công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadMaHP(txt_MSHP.Text);
            }
        }

        private void dgv_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_View["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private void dgv_SV_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_SV_View["col_Stt_SV", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private void btn_Search_MouseHover(object sender, EventArgs e)
        {
            btn_Search.BackgroundImage = global::App_DDSV.Properties.Resources.search_hover;
        }

        private void btn_Search_MouseLeave(object sender, EventArgs e)
        {
            btn_Search.BackgroundImage = global::App_DDSV.Properties.Resources.search;
        }

        private void btn_Add_MouseHover(object sender, EventArgs e)
        {
            btn_Add.BackgroundImage = global::App_DDSV.Properties.Resources.add_hover;
        }

        private void btn_Add_MouseLeave(object sender, EventArgs e)
        {
            btn_Add.BackgroundImage = global::App_DDSV.Properties.Resources.add;
        }
    }
}
