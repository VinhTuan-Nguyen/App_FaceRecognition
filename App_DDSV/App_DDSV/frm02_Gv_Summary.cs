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
    public partial class frm02_Gv_Summary : Form
    {
        private static string MaHP;
        private static string TenHP;
        private static string Date;
        public frm02_Gv_Summary(string mahp, string tenhp, string date)
        {
            MaHP = mahp;
            TenHP = tenhp;
            Date = date;
            InitializeComponent();
        }

        private void frm02_Gv_Summary_Load(object sender, EventArgs e)
        {
            txt_MaHP.Text = MaHP;
            txt_TenHP.Text = TenHP;
            txt_Date.Text = Date;
            load_Data();
        }

        private void btn_Summary_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác Nhận Kết Thúc Buổi Điểm Danh", " Xác Nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dgv_SummaryNotYet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                /*DataGridViewRow row = dgv_SummaryNotYet.Rows[e.RowIndex];
                string MaSV = row.Cells["col_MaSV_NotYet"].Value.ToString();
                string Note = row.Cells["col_GhiChu_NotYet"].Value.ToString();
                string Time = row.Cells["col_GioDD_NotYet"].Value.ToString();
                frm00_Note f = new frm00_Note(Date, MaHP, MaSV, Note, Time);
                f.ShowDialog();*/
            }
            load_Data();
        }

        private void dgv_SummaryDone_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*DataGridViewRow row = dgv_SummaryDone.Rows[e.RowIndex];
                string MaSV = row.Cells["col_MaSV_Done"].Value.ToString();
                string Note = row.Cells["col_GhiChu_Done"].Value.ToString();
                string Time = row.Cells["col_GioDD_Done"].Value.ToString();
                frm00_Note f = new frm00_Note(Date, MaHP, MaSV, Note, Time);
                f.ShowDialog();*/
            }
            load_Data();
        }

        private void dgv_SummaryNotYet_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_SummaryNotYet["col_Stt_NotYet", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private void dgv_SummaryDone_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_SummaryDone["col_Stt_Done", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }


        private void load_Data()
        {
            DataSet data = new DataSet();
            int co = 0;
            int vang = 0;
            int phep = 0;
            int khac = 0;
            conSql.query = "SELECT sv.col_MaSV, col_HoLot, col_Ten, col_NgayDD, col_GioDD, col_GhiChu " +
                "FROM tab_DiemDanh dd, tab_SinhVien sv WHERE " +
                "dd.col_MaSV = sv.col_maSV and " +
                "col_NgayDD = @date and " +
                "col_MaHP = @mahp and " +
                "col_GhiChu IN (N'Có Mặt', N'Phép')" +
                "SELECT sv.col_MaSV, col_HoLot, col_Ten, col_NgayDD, col_GioDD, col_GhiChu " +
                "FROM tab_DiemDanh dd, tab_SinhVien sv WHERE " +
                "dd.col_MaSV = sv.col_maSV and " +
                "col_NgayDD = @date and " +
                "col_MaHP = @mahp and " +
                "col_GhiChu NOT IN (N'Có Mặt', N'Phép')";
            using(conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@date",txt_Date.Text);
                conSql.cmd.Parameters.AddWithValue("@mahp",txt_MaHP.Text);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                conSql.adapter.Fill(data);
                conSql.conn.Close();
            }
            dgv_SummaryDone.DataSource = data.Tables[0];
            dgv_SummaryNotYet.DataSource = data.Tables[1];
            if (dgv_SummaryDone.Rows.Count > 0 || dgv_SummaryNotYet.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dgv_SummaryDone.Rows)
                {
                    if (item.Cells["col_GhiChu_Done"].Value.ToString() == "Có Mặt") co += 1;
                    else phep += 1;
                }
                foreach (DataGridViewRow item in dgv_SummaryNotYet.Rows)
                {
                    if (item.Cells["col_GhiChu_NotYet"].Value.ToString() == "Vắng") vang += 1;
                    else khac += 1;
                }
                txt_HienDien.Text = co.ToString();
                txt_Khac.Text = khac.ToString();
                txt_Khong.Text = vang.ToString();
                txt_Phep.Text = phep.ToString();
            }
        }
    }
}
