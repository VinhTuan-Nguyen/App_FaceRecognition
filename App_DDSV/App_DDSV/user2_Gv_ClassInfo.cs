using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_DDSV
{
    public partial class user2_Gv_ClassInfo : UserControl
    {

        private static string info;

        public user2_Gv_ClassInfo(string magv)
        {
            info = magv;
            InitializeComponent();
        }

        private void user2_Gv_ClassInfo_Load(object sender, EventArgs e)
        {
            conSql.query = "SELECT * FROM tab_GiangVien WHERE col_MaGV = @magv " +
                "SELECT DISTINCT col_NienKhoa FROM tab_LopHP";
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@magv", info);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                txt_EmailGV.Text = data.Tables[0].Rows[0].Field<string>("col_Email");
                lb_TevGV.Text = data.Tables[0].Rows[0].Field<string>("col_HoTen");
                lb_Khoa.Text = data.Tables[0].Rows[0].Field<string>("col_Khoa");
                lb_MaGV.Text = data.Tables[0].Rows[0].Field<string>("col_MaGV");
                if (data.Tables[0].Rows[0].Field<bool>("col_GioiTinh"))
                {
                    lb_Sex.Text = "Nam";
                }
                else lb_Sex.Text = "Nữ";
                cbb_NienKhoa.DataSource = data.Tables[1];
                cbb_NienKhoa.DisplayMember = "col_NienKhoa";
                conSql.conn.Close();
            }
        }

        private void btn_DiemDanh_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Process process = new Process();
            process.StartInfo.FileName = @"UI_Camera.exe";
            process.StartInfo.Arguments =
                txt_MaHP.Text + " " +
                "\"" + txt_TenHP.Text + "\" " +
                lb_MaGV.Text + " " +
                "\"" + now.ToString("dd-MM-yyyy HH:mm") + "\" " +
                conSql.db_Name + " " +
                conSql.server_Name;
            process.Start();
            process.WaitForExit();
            frm02_Gv_Summary f = new frm02_Gv_Summary(txt_MaHP.Text, txt_TenHP.Text, now.ToString("dd-MM-yyyy HH:mm"));
            f.ShowDialog();
        }

        private void btn_ViewClass_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            int CPhep = 0;
            int KPhep = 0;
            int Khac = 0;
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand("asp_GV_Data", conSql.conn);
                conSql.cmd.CommandType = CommandType.StoredProcedure;
                conSql.cmd.Parameters.AddWithValue("@mahp", cbb_MaHP.Text);
                conSql.cmd.Parameters.AddWithValue("@tenhp", cbb_TenHP.Text);
                conSql.cmd.Parameters.AddWithValue("@magv", lb_MaGV.Text);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                conSql.adapter.Fill(data);
                conSql.conn.Close();
            }
            if(data.Tables[0].Rows.Count > 0)
            {
                dgv_LoadData.DataSource = data.Tables[0];
                txt_TenHP.Text = data.Tables[1].Rows[0].Field<string>("col_TenHP");
                txt_MaHP.Text = data.Tables[1].Rows[0].Field<string>("col_MaHP");
                txt_Start.Text = data.Tables[1].Rows[0].Field<DateTime>("col_NgayBD").ToShortDateString();
                txt_End.Text = data.Tables[1].Rows[0].Field<DateTime>("col_NgayKT").ToShortDateString();
                txt_Thu.Text = data.Tables[1].Rows[0].Field<string>("col_Thu");
                txt_TrangThai.Text = data.Tables[1].Rows[0].Field<string>("col_TrangThai");

                foreach (DataRow item in data.Tables[2].Rows)
                {
                    if (item.Field<string>("col_GhiChu") == "Có Phép")
                    {
                        CPhep += 1;
                    }
                    else if (item.Field<string>("col_GhiChu") == "Không Phép")
                    {
                        KPhep += 1;
                    }
                    else
                    {
                        Khac += 1;
                    }
                }
                lb_Sum.Text = dgv_LoadData.Rows.Count.ToString();
                lb_CoP.Text = CPhep.ToString();
                lb_KhongP.Text = KPhep.ToString();
            }
            else
            {
                MessageBox.Show("Không Thể Xem Lớp Này", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_LoadData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_LoadData.Rows[e.RowIndex];

                string mssv = row.Cells["col_MaSV"].Value.ToString();
                string tenSV = row.Cells["col_HoTen"].Value.ToString();
                frm02_Gv_History f = new frm02_Gv_History(mssv, tenSV, txt_MaHP.Text);
                f.ShowDialog();
            }
        }

        private void cbb_NienKhoa_TextChanged(object sender, EventArgs e)
        {
            conSql.query = "SELECT DISTINCT col_TenHP FROM tab_LopHP WHERE col_NienKhoa=@nk and col_MaGV = @gv";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                try
                {
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@nk", cbb_NienKhoa.Text);
                    conSql.cmd.Parameters.AddWithValue("@gv", lb_MaGV.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    if(data.Tables[0].Rows.Count > 0)
                    {
                        cbb_TenHP.DataSource = data.Tables[0];
                        cbb_TenHP.DisplayMember = "col_TenHP";
                    }
                    else
                    {
                        cbb_TenHP.DataSource = null;
                    }
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
            conSql.query = "SELECT DISTINCT col_MaHP FROM tab_LopHP WHERE col_NienKhoa=@nk and col_TenHP=@hp and col_MaGV = @gv";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                try
                {
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@nk", cbb_NienKhoa.Text);
                    conSql.cmd.Parameters.AddWithValue("@hp", cbb_TenHP.Text);
                    conSql.cmd.Parameters.AddWithValue("@gv", lb_MaGV.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    if (data.Tables[0].Rows.Count > 0)
                    {
                        cbb_MaHP.DataSource = data.Tables[0];
                        cbb_MaHP.DisplayMember = "col_MaHP";
                    }
                    else
                    {
                        cbb_MaHP.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Xãy Ra Lỗi: " + ex, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conSql.conn.Close();
            }
        }

        private void txt_MaHP_TextChanged(object sender, EventArgs e)
        {
            if(txt_MaHP.Text != "")
            {
                btn_DiemDanh.Enabled = true;
            }
            else
            {
                btn_DiemDanh.Enabled = false;
            }
        }

        private void dgv_LoadData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_LoadData["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }
    }
}
