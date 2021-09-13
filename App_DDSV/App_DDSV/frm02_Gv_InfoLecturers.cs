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
    public partial class frm02_Gv_InfoLecturers : Form
    {
        private static DataRow info;
        public frm02_Gv_InfoLecturers(DataRow row)
        {
            info = row;
            InitializeComponent();
        }

        private void frm02_Gv_InfoLecturers_Load(object sender, EventArgs e)
        {
            txt_Email.Text = info.Field<string>("col_Email");
            txt_HoLot.Text = info.Field<string>("col_HoLot");
            txt_Khoa.Text = info.Field<string>("col_Khoa");
            txt_MaGV.Text = info.Field<string>("col_MaGV");
            txt_TenGV.Text = info.Field<string>("col_Ten");
            if (info.Field<bool>("col_GioiTinh"))
            {
                ra_Nam.Checked = true;
            }
            else ra_Nu.Checked = true;

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            bool gt = ra_Nam.Checked ? true : false;
            conSql.query = "UPDATE tab_GiangVien SET " +
                "col_HoLot = @ho," +
                "col_Ten = @ten," +
                "col_Khoa = @khoa," +
                "col_Email = @email," +
                "col_GioiTinh = @gt " +
                "WHERE col_MaGV = @magv";
            using(conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@ho", txt_HoLot.Text);
                conSql.cmd.Parameters.AddWithValue("@ten", txt_TenGV.Text);
                conSql.cmd.Parameters.AddWithValue("@khoa", txt_Khoa.Text);
                conSql.cmd.Parameters.AddWithValue("@email",txt_Email.Text);
                conSql.cmd.Parameters.AddWithValue("@gt", gt);
                conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                conSql.cmd.ExecuteNonQuery();
                conSql.conn.Close();
            }
            MessageBox.Show("Chỉnh Sửa Thành Công, Thông Tin Thay Đổi Sẽ\nĐược Cập Nhật Ở Lần Đăng Nhập Tiếp Theo",
                "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
