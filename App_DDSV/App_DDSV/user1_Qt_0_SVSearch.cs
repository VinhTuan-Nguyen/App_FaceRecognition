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
    public partial class user1_Qt_0_SVSearch : UserControl
    {
        public user1_Qt_0_SVSearch()
        {
            InitializeComponent();
        }

        private void user1_Qt_0_SVSearch_Load(object sender, EventArgs e)
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (panel_Search.Visible == false)
            {
                panel_Search.Visible = true;
            }
            else
            {
                panel_Search.Visible = false;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            lb_Info.Visible = false;
            if (txt_Date.Text == "  /  /" && (txt_Ten.Text =="" || txt_MSSV.Text == ""))
            {
                MessageBox.Show("Cần Ít Nhất 2 Thông Tin Để Truy Vấn", "Cảnh Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Date.Text == "  /  /")
            {
                conSql.query = "SELECT col_MaSV, col_HoTen, col_NgaySinh FROM tab_SinhVien WHERE " +
                    "col_MaSV = @masv and " +
                    "col_HoTen = @ten";
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@masv", txt_MSSV.Text);
                    conSql.cmd.Parameters.AddWithValue("@ten", txt_Ten.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    if(data.Tables[0].Rows.Count == 0)
                    {
                        lb_Info.Visible = true;
                    }
                    else
                    {
                        dgv_Search.DataSource = data.Tables[0];
                    }
                    conSql.conn.Close();
                }
            }
            else if(txt_Date.Text != "  /  /" && txt_Ten.Text != "")
            {
                try
                {
                    DateTime dt = DateTime.Parse(txt_Date.Text);
                    conSql.query = "SELECT col_MaSV, col_HoTen, col_NgaySinh FROM tab_SinhVien WHERE " +
                        "col_HoTen = @ten and " +
                        "col_NgaySinh = @ns";
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@ten", txt_Ten.Text);
                        conSql.cmd.Parameters.AddWithValue("@ns", txt_Date.Text);
                        conSql.adapter = new SqlDataAdapter(conSql.cmd);
                        DataSet data = new DataSet();
                        conSql.adapter.Fill(data);
                        if (data.Tables[0].Rows.Count == 0)
                        {
                            lb_Info.Visible = true;
                        }
                        else
                        {
                            dgv_Search.DataSource = data.Tables[0];
                        }
                        conSql.conn.Close();
                    }
                }
                catch
                {
                    txt_Date.Text = "";
                    MessageBox.Show("Định Dạng Ngày Tháng Sai", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(txt_Date.Text != "  /  /" && txt_MSSV.Text != "")
            {
                try
                {
                    DateTime dt = DateTime.Parse(txt_Date.Text);
                    conSql.query = "SELECT col_MaSV, col_HoTen, col_NgaySinh FROM tab_SinhVien WHERE " +
                        "col_MaSV = @masv and " +
                        "col_NgaySinh = @ns";
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@masv", txt_MSSV.Text);
                        conSql.cmd.Parameters.AddWithValue("@ns", txt_Date.Text);
                        conSql.adapter = new SqlDataAdapter(conSql.cmd);
                        DataSet data = new DataSet();
                        conSql.adapter.Fill(data);
                        if (data.Tables[0].Rows.Count == 0)
                        {
                            lb_Info.Visible = true;
                        }
                        else
                        {
                            dgv_Search.DataSource = data.Tables[0];
                        }
                        conSql.conn.Close();
                    }
                }
                catch
                {
                    txt_Date.Text = "";
                    MessageBox.Show("Định Dạng Ngày Tháng Sai", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    DateTime dt = DateTime.Parse(txt_Date.Text);
                    conSql.query = "SELECT col_MaSV, col_HoTen, col_NgaySinh FROM tab_SinhVien WHERE " +
                        "col_MaSV = @masv and " +
                        "col_HoTen = @ten and " +
                        "col_NgaySinh = @ns";
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@masv", txt_MSSV.Text);
                        conSql.cmd.Parameters.AddWithValue("@ten", txt_Ten.Text);
                        conSql.cmd.Parameters.AddWithValue("@ns", txt_Date.Text);
                        conSql.adapter = new SqlDataAdapter(conSql.cmd);
                        DataSet data = new DataSet();
                        conSql.adapter.Fill(data);
                        if (data.Tables[0].Rows.Count == 0)
                        {
                            lb_Info.Visible = true;
                        }
                        else
                        {
                            dgv_Search.DataSource = data.Tables[0];
                        }
                        conSql.conn.Close();
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

        private void dgv_Search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Search.Rows[e.RowIndex];
                txt_MaSV.Text = row.Cells["col_MaSV"].Value.ToString();
                loadMaSV(txt_MaSV.Text);
            }
        }

        private void loadMaSV(string mssv)
        {
            conSql.query = "SELECT hp.* FROM tab_DKHP dk, tab_LopHP hp, tab_SinhVien sv " +
                "WHERE dk.col_MaHP = hp.col_MaHP and dk.col_MaSV = sv.col_MaSV and sv.col_MaSV = @sv";
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@sv", mssv);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                dgv_HP_View.DataSource = data.Tables[0];
                conSql.conn.Close();
            }
        }

        private void dgv_HP_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_HP_View.Rows[e.RowIndex];
                DialogResult result = MessageBox.Show("Xác Nhận Xóa Học Phần Này", "Xác Nhận",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conSql.query = "DELETE FROM tab_DKHP WHERE col_MaHP=@hp and col_MaSV=@sv";
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@hp", row.Cells["col_MaHP"].Value.ToString());
                        conSql.cmd.Parameters.AddWithValue("@sv", txt_MaSV.Text);
                        conSql.cmd.ExecuteNonQuery();
                        conSql.cmd.Clone();
                    }
                    MessageBox.Show("Xóa Học Phần Thành Công", "Thành Công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadMaSV(txt_MaSV.Text);
            }
        }

        private void btn_AddSV_Click(object sender, EventArgs e)
        {
            if (txt_MaSV.Text == "")
            {
                MessageBox.Show("Chưa Chọn Sinh Viên", "Cảnh Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conSql.query = "SELECT * FROM tab_LopHP WHERE col_MaHP = @mahp " +
                    "SELECT * FROM tab_DKHP WHERE col_MaHP=@mahp and col_MaSV = @masv";
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@mahp", cbb_MaHP.Text);
                    conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    if (data.Tables[0].Rows.Count > 0)
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
                            conSql.cmd.Parameters.AddWithValue("@hp", cbb_MaHP.Text);
                            conSql.cmd.Parameters.AddWithValue("@sv", txt_MaSV.Text);
                            conSql.cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm Thành Công", "Thành Công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không Có Học Phần Này", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conSql.conn.Close();
                }
                loadMaSV(txt_MaSV.Text);
            }
        }

        private void dgv_Search_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_Search["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private void dgv_HP_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_HP_View["col_Stt_View", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
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
