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
    public partial class user1_Qt_Student : UserControl
    {
        public user1_Qt_Student()
        {
            InitializeComponent();
        }

        private void user1_Qt_Student_Load(object sender, EventArgs e)
        {
            conSql.query = @"SELECT * FROM tab_SinhVien";
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                dgv_SV_View.DataSource = data.Tables[0];
                conSql.conn.Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_Date.Text == "  /  /")
            {
                conSql.query = "SELECT * FROM tab_SinhVien WHERE " +
                    "col_MaSV = @masv or " +
                    "col_HoTen = @ten";
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@masv", txt_MSSV.Text);
                    conSql.cmd.Parameters.AddWithValue("@ten", txt_Name.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_SV_View.DataSource = data.Tables[0];
                    conSql.conn.Close();
                }
            }
            else
            {
                try
                {
                    DateTime dt = DateTime.Parse(txt_Date.Text);
                    conSql.query = "SELECT * FROM tab_SinhVien WHERE " +
                        "col_MaSV = @masv or " +
                        "col_HoTen = @ten or " +
                        "col_NgaySinh = @ns";
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@masv", txt_MSSV.Text);
                        conSql.cmd.Parameters.AddWithValue("@ten", txt_Name.Text);
                        conSql.cmd.Parameters.AddWithValue("@ns", txt_Date.Text);
                        conSql.adapter = new SqlDataAdapter(conSql.cmd);
                        DataSet data = new DataSet();
                        conSql.adapter.Fill(data);
                        dgv_SV_View.DataSource = data.Tables[0];
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm01_Qt_StudentEdit f = new frm01_Qt_StudentEdit();
            f.ShowDialog();
            user1_Qt_Student_Load(sender, e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            user1_Qt_Student_Load(sender, e);
        }

        private void dgv_SV_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_SV_View.Rows[e.RowIndex];
                frm01_Qt_StudentEdit f = new frm01_Qt_StudentEdit(row,"");
                f.ShowDialog();
                user1_Qt_Student_Load(sender, e);
            }
        }

        private void dgv_SV_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_SV_View[0, e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private void btn_Refresh_MouseHover(object sender, EventArgs e)
        {
            btn_Refresh.BackgroundImage = global::App_DDSV.Properties.Resources.refresh_hover;
        }

        private void btn_Refresh_MouseLeave(object sender, EventArgs e)
        {
            btn_Refresh.BackgroundImage = global::App_DDSV.Properties.Resources.refresh;
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
