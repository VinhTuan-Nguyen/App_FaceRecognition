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
        private static string info;
        public frm02_Gv_InfoLecturers(string magv)
        {
            info = magv;
            InitializeComponent();
        }

        private void frm02_Gv_InfoLecturers_Load(object sender, EventArgs e)
        {
            conSql.query = @"SELECT * FROM tab_GiangVien WHERE col_MaGV = @magv";
            using(conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@magv", info);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                if (data.Tables[0].Rows.Count > 0)
                {
                    txt_Email.Text = data.Tables[0].Rows[0].Field<string>("col_Email");
                    txt_HoTen.Text = data.Tables[0].Rows[0].Field<string>("col_HoTen");
                    txt_Khoa.Text = data.Tables[0].Rows[0].Field<string>("col_Khoa");
                    txt_MaGV.Text = data.Tables[0].Rows[0].Field<string>("col_MaGV");
                    if (data.Tables[0].Rows[0].Field<bool>("col_GioiTinh"))
                    {
                        ra_Nam.Checked = true;
                    }
                    else ra_Nu.Checked = true;
                }
                else
                {
                    MessageBox.Show("Không Có Giảng Viên Này",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                conSql.conn.Close();
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool gt = ra_Nam.Checked ? true : false;
            conSql.query = "UPDATE tab_GiangVien SET " +
                "col_HoTen = @ten," +
                "col_Khoa = @khoa," +
                "col_Email = @email," +
                "col_GioiTinh = @gt " +
                "WHERE col_MaGV = @magv";
            using(conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@TEN", txt_HoTen.Text);
                conSql.cmd.Parameters.AddWithValue("@khoa", txt_Khoa.Text);
                conSql.cmd.Parameters.AddWithValue("@email",txt_Email.Text);
                conSql.cmd.Parameters.AddWithValue("@gt", gt);
                conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                conSql.cmd.ExecuteNonQuery();
                conSql.conn.Close();
            }
            MessageBox.Show("Chỉnh Sửa Thành Công",
                "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_MouseHover(object sender, EventArgs e)
        {
            btn_Save.ForeColor = Color.YellowGreen;
        }

        private void btn_Save_MouseLeave(object sender, EventArgs e)
        {
            btn_Save.ForeColor = Color.DarkGreen;
        }

        private void btn_Back_MouseHover(object sender, EventArgs e)
        {
            btn_Back.ForeColor = Color.OrangeRed;
        }

        private void btn_Back_MouseLeave(object sender, EventArgs e)
        {
            btn_Back.ForeColor = Color.Brown;
        }
    }
}
