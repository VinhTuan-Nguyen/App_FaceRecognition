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
    public partial class user1_Qt_Class : UserControl
    {
        private static user1_Qt_Class _instance;

        public static user1_Qt_Class Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user1_Qt_Class();
                return _instance;
            }
        }

        public user1_Qt_Class()
        {
            InitializeComponent();
        }

        private void user1_Qt_Class_Load(object sender, EventArgs e)
        {
            conSql.query = @"SELECT * FROM tab_LopHP";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                try
                {
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_HP_View.DataSource = data.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Xãy Ra Lỗi: " + ex, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conSql.conn.Close();
            }
        }

        private void btn_SearchDate_Click(object sender, EventArgs e)
        {
            if (pick_End.Value < pick_Star.Value)
            {
                MessageBox.Show("Chọn Ngày không Hợp Lệ", "Truy Vấn Sai Cú Pháp !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand("asp_LHP_LoadVal2", conSql.conn);
                    conSql.cmd.CommandType = CommandType.StoredProcedure;
                    conSql.cmd.Parameters.AddWithValue("@tungay", pick_Star.Value.ToShortDateString());
                    conSql.cmd.Parameters.AddWithValue("@denngay", pick_End.Value.ToShortDateString());
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_HP_View.DataSource = data.Tables[0];
                    conSql.conn.Close();
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_MaHP.Text != "" || txt_TenHP.Text != "" || txt_MaGV.Text != "" || cbb_Thu.Text != "" &&
                (ra_Closed.Checked == false && ra_Opening.Checked == false))
            {
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand("asp_LHP_LoadVal1", conSql.conn);
                    conSql.cmd.CommandType = CommandType.StoredProcedure;
                    conSql.cmd.Parameters.AddWithValue("@maHP", txt_MaHP.Text);
                    conSql.cmd.Parameters.AddWithValue("@tenHP", txt_TenHP.Text);
                    conSql.cmd.Parameters.AddWithValue("@maGV", txt_MaGV.Text);
                    conSql.cmd.Parameters.AddWithValue("@thu", cbb_Thu.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_HP_View.DataSource = data.Tables[0];
                    conSql.conn.Close();
                }
            }
            else if (txt_MaHP.Text != "" || txt_TenHP.Text != "" || txt_MaGV.Text != "" || cbb_Thu.Text != "" ||
                (ra_Closed.Checked == true || ra_Opening.Checked == true))
            {
                bool state = ra_Opening.Checked ? true : false;
                conSql.query = "SELECT * FROM tab_LopHP WHERE " +
                    "col_MaHP = @mahp or " +
                    "col_TenHP = @tenhp or " +
                    "col_MaGV = @magv or " +
                    "col_Thu =  @thu or " +
                    "col_TrangThai = @tt";

                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                    conSql.cmd.Parameters.AddWithValue("@tenhp", txt_TenHP.Text);
                    conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                    conSql.cmd.Parameters.AddWithValue("@thu", cbb_Thu.Text);
                    conSql.cmd.Parameters.AddWithValue("@tt", state);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_HP_View.DataSource = data.Tables[0];
                    conSql.conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Ít Nhất Phải Có Một Thông Tin Nào Đó", "Truy Vấn Rỗng !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MaHP.Text = "";
            txt_MaGV.Text = "";
            txt_TenHP.Text = "";
            cbb_Thu.SelectedIndex = -1;
            ra_Closed.Checked = false;
            ra_Opening.Checked = false;
            user1_Qt_Class_Load(sender, e);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool state = ra_Opening.Checked ? true : false;
            string tt = ra_Opening.Checked ? "Mở Lớp" : "Đã Hoàn Tất";

            if (txt_MaHP.Text != "" && txt_TenHP.Text != "" && txt_MaGV.Text != "" && cbb_Thu.Text != "")
            {
                string checkGV = @"SELECT * FROM tab_GiangVien WHERE col_MaGV = @para";

                if (Check(checkGV, txt_MaGV.Text) == false)
                {
                    MessageBox.Show("Không Có Giảng Viên Này Trong CSDL", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pick_End.Value < pick_Star.Value)
                {
                    MessageBox.Show("Ngày Bắt Đầu Và Kết Thúc không Hợp Lệ", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Xác Nhận Thêm Các Thông Tin Này Vào CSDL:\n" +
                        "\nTên Lớp HP: " + txt_TenHP.Text +
                        "\nMã HP: " + txt_MaHP.Text +
                        "\nMã GV: " + txt_MaGV.Text +
                        "\nTừ Ngày: " + pick_Star.Value.ToShortDateString() +
                        "\nĐến Ngày: " + pick_End.Value.ToShortDateString() +
                        "\nThứ: " + cbb_Thu.SelectedItem +
                        "\nTrạng Thái: " + tt,
                        "Xác Nhận Thêm Lớp Học Phần", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        using (conSql.conn = new SqlConnection(conSql.conString))
                        {
                            conSql.conn.Open();
                            conSql.cmd = new SqlCommand("asp_AddLhp", conSql.conn);
                            conSql.cmd.CommandType = CommandType.StoredProcedure;
                            conSql.cmd.Parameters.AddWithValue("@maHP", txt_MaHP.Text);
                            conSql.cmd.Parameters.AddWithValue("@tenHP", txt_TenHP.Text);
                            conSql.cmd.Parameters.AddWithValue("@ngayBD", pick_Star.Value.ToShortDateString());
                            conSql.cmd.Parameters.AddWithValue("@ngayKT", pick_End.Value.ToShortDateString());
                            conSql.cmd.Parameters.AddWithValue("@thu", cbb_Thu.SelectedItem);
                            conSql.cmd.Parameters.AddWithValue("maGV", txt_MaGV.Text);
                            conSql.cmd.Parameters.AddWithValue("tt", state);
                            conSql.cmd.ExecuteNonQuery();
                            conSql.conn.Close();
                        }
                        MessageBox.Show("Đã Thêm 1 Dòng Mới Vào CSDL", "Thêm Thành Công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        user1_Qt_Class_Load(sender, e);
                        btn_Refresh_Click(sender, e);
                    }

                }
            }
            else
            {
                MessageBox.Show("Thông Tin Không Được Rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_HP_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_HP_View.Rows[e.RowIndex];
            frm01_Qt_ClassEdit f = new frm01_Qt_ClassEdit(row);
            f.ShowDialog();
            user1_Qt_Class_Load(sender, e);
        }

        private bool Check(string query, string parameter)
        {
            bool result = false;
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@para", parameter);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataTable table = new DataTable();
                conSql.adapter.Fill(table);
                if (table.Rows.Count > 0) result = true;
                conSql.conn.Close();
            }
            return result;
        }

        private void dgv_HP_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_HP_View["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
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
    }
}
