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
    public partial class user2_Gv_History : UserControl
    {
        private static string info;


        public user2_Gv_History(string magv)
        {
            info = magv;
            InitializeComponent();
        }

        private void user2_Gv_History_Load(object sender, EventArgs e)
        {
            conSql.query = "SELECT DISTINCT col_NienKhoa FROM tab_LopHP";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                cbb_NienKhoa.DataSource = data.Tables[0];
                cbb_NienKhoa.DisplayMember = "col_NienKhoa";
                conSql.conn.Close();
            }
        }

        private void cbb_NienKhoa_TextChanged(object sender, EventArgs e)
        {
            conSql.query = "SELECT DISTINCT col_TenHP FROM tab_LopHP WHERE col_NienKhoa=@nk and col_MaGV = @gv";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@nk", cbb_NienKhoa.Text);
                conSql.cmd.Parameters.AddWithValue("@gv", info);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                if (data.Tables[0].Rows.Count > 0)
                {
                    cbb_TenHP.DataSource = data.Tables[0];
                    cbb_TenHP.DisplayMember = "col_TenHP";
                }
                else
                {
                    cbb_TenHP.DataSource = null;
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
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@nk", cbb_NienKhoa.Text);
                conSql.cmd.Parameters.AddWithValue("@hp", cbb_TenHP.Text);
                conSql.cmd.Parameters.AddWithValue("@gv", info);
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
                conSql.conn.Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            conSql.query = "SELECT DISTINCT col_NgayDD FROM tab_DiemDanh " +
                "WHERE col_MaHP = @mahp";
            using(conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@mahp",cbb_MaHP.Text);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                cbb_List.DataSource = data.Tables[0];
                cbb_List.DisplayMember = "col_NgayDD";
                conSql.conn.Close();
            }
            btn_View_Click(sender, e);
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            conSql.query = "SELECT sv.*, col_MaHP, col_NgayDD, col_GioDD, col_GhiChu FROM tab_DiemDanh dd, tab_SinhVien sv " +
                "WHERE dd.col_MaSV = sv.col_MaSV and " +
                "col_NgayDD = @date and " +
                "col_MaHP = @mahp";

            using(conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@date", cbb_List.Text);
                conSql.cmd.Parameters.AddWithValue("@mahp", cbb_MaHP.Text);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                dgv_DataView.DataSource = data.Tables[0];
                conSql.conn.Close();
            }
        }

        private void dgv_DataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DataView.Rows[e.RowIndex];
                string Date = row.Cells["col_NgayDD"].Value.ToString();
                string MaHP = row.Cells["col_MaHP"].Value.ToString();
                string MaSV = row.Cells["col_MaSV"].Value.ToString();
                string Note = row.Cells["col_GhiChu"].Value.ToString();
                string Time = row.Cells["col_GioDD"].Value.ToString();
                string Name = row.Cells["col_HoTen"].Value.ToString();
                frm00_Note f = new frm00_Note(Date, MaHP, MaSV, Note, Time, Name);
                f.ShowDialog();
            }
            btn_View_Click(sender, e);
        }

        private void dgv_DataView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_DataView["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }
    }
}
