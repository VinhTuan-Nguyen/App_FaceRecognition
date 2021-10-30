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

        private static DataRow info;

        public user2_Gv_ClassInfo(DataRow row)
        {
            info = row;
            InitializeComponent();
        }

        private void user2_Gv_ClassInfo_Load(object sender, EventArgs e)
        {
            lb_MaGV.Text = info.Field<string>("col_MaGV");
            lb_TevGV.Text = info.Field<string>("col_HoLot") + " " + info.Field<string>("col_Ten");
            lb_Khoa.Text = info.Field<string>("col_Khoa");
            txt_EmailGV.Text = info.Field<string>("col_Email");
            if (info.Field<bool>("col_GioiTinh"))
            {
                lb_Sex.Text = "Nam";
            }
            else
            {
                lb_Sex.Text = "Nữ";
            }
            load_ClassList();
        }

        private void btn_DiemDanh_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            btn_DiemDanh.Enabled = false;

            if (txt_MaHP.Text == "")
            {
                MessageBox.Show("Thông Tin Lớp Rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txt_TrangThai.Text == "Đã Hoàn Tất")
            {
                MessageBox.Show("Không Ở Trạng Thái Mở Lớp\nKhông Thể Điểm Danh", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process process = new Process();
                process.StartInfo.FileName = @"UI_Camera.exe";
                process.StartInfo.Arguments =
                    txt_MaHP.Text + " " + "\"" +
                    txt_TenHP.Text + "\"" + " " +
                    lb_MaGV.Text + " " + "\"" +
                    now.ToString("yyyy-MM-dd HH:mm") + "\"";
                process.Start();
                process.WaitForExit();
                frm02_Gv_Summary f = new frm02_Gv_Summary(txt_MaHP.Text, txt_TenHP.Text, now.ToString("yyyy-MM-dd HH:mm"));
                f.ShowDialog();
            }

            btn_DiemDanh.Enabled = true;
        }

        private void btn_ViewClass_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            int CPhep = 0;
            int KPhep = 0;
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand("asp_GV_Data", conSql.conn);
                conSql.cmd.CommandType = CommandType.StoredProcedure;
                conSql.cmd.Parameters.AddWithValue("@maHP", cbb_MaHP.Text);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                conSql.adapter.Fill(data);
                dgv_LoadData.DataSource = data.Tables[0];
                conSql.conn.Close();
            }
            txt_TenHP.Text = data.Tables[1].Rows[0].Field<string>("col_TenHP");
            txt_MaHP.Text = data.Tables[1].Rows[0].Field<string>("col_MaHP");
            pick_BD.Value = data.Tables[1].Rows[0].Field<DateTime>("col_NgayBD");
            pick_KT.Value = data.Tables[1].Rows[0].Field<DateTime>("col_NgayKT");
            txt_Thu.Text = data.Tables[1].Rows[0].Field<string>("col_Thu");
            bool tt = data.Tables[1].Rows[0].Field<bool>("col_TrangThai");
            if (tt == true)
            {
                txt_TrangThai.Text = "Mở Lớp";
            }
            else txt_TrangThai.Text = "Đã Hoàn Tất";

            foreach (DataRow item in data.Tables[2].Rows)
            {
                if (item.Field<string>("col_GhiChu") == "C.Phép")
                {
                    CPhep += 1;
                }
                else if (item.Field<string>("col_GhiChu") == "Vắng") KPhep += 1;
            }
            txt_TongSV.Text = dgv_LoadData.Rows.Count.ToString();
            txt_CP.Text = CPhep.ToString();
            txt_KP.Text = KPhep.ToString();
        }

        private void dgv_LoadData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_LoadData.Rows[e.RowIndex];

                string mssv = row.Cells["col_MaSV"].Value.ToString();
                string tenSV = row.Cells["col_HoLot"].Value.ToString() + " " +
                    row.Cells["col_Ten"].Value.ToString();
                frm02_Gv_History f = new frm02_Gv_History(mssv, tenSV, cbb_MaHP.Text);
                f.ShowDialog();
            }
        }

        private void dgv_LoadData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_LoadData["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private void cbb_ClassList_TextChanged(object sender, EventArgs e)
        {
            conSql.query = "SELECT col_MaHP " +
                "FROM tab_LopHP " +
                "WHERE col_TenHP = @tenhp";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();

                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@tenhp", cbb_ClassList.Text.ToString());
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                cbb_MaHP.DataSource = data.Tables[0];

                cbb_MaHP.DisplayMember = "col_MaHP";

                conSql.conn.Close();
            }
        }

        private void load_ClassList()
        {
            conSql.query = "SELECT DISTINCT col_TenHP" +
                " FROM tab_LopHP" +
                " WHERE col_MaGV = @magv";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@magv", lb_MaGV.Text);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                cbb_ClassList.DataSource = data.Tables[0];
                cbb_ClassList.DisplayMember = "col_TenHP";
                conSql.conn.Close();
            }
        }
    }
}
