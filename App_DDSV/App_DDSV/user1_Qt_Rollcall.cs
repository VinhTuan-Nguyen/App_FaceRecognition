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
            conSql.query = "SELECT " +
                "dd.col_NgayDD, dd.col_GioDD, " +
                "hp.col_Thu, hp.col_MaHP, hp.col_TenHP, " +
                "gv.col_MaGV, gv.col_HoLot + ' ' + gv.col_Ten \"col_TenGV\", " +
                "sv.col_MaSV, sv.col_HoLot + ' ' + sv.col_Ten \"col_TenSV\", sv.col_Lop, " +
                "dd.col_GhiChu " +
                "FROM tab_DiemDanh dd, tab_LopHP hp, tab_SinhVien sv, tab_GiangVien gv " +
                "WHERE " +
                "dd.col_MaHP = hp.col_MaHP and " +
                "hp.col_MaGV = gv.col_MaGV and " +
                "dd.col_MaSV = sv.col_MaSV";
            using(conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                dgv_View.DataSource = data.Tables[0];
            }
        }

        private void dgv_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_View["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }
    }
}
