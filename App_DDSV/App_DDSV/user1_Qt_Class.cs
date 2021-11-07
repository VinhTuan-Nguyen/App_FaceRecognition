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
        public user1_Qt_Class()
        {
            InitializeComponent();
        }

        private void user1_Qt_Class_Load(object sender, EventArgs e)
        {
            conSql.query = "SELECT * FROM tab_LopHP " +
                "SELECT DISTINCT col_NienKhoa FROM tab_LopHP";

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
                    cbb_NienKhoa.DataSource = data.Tables[1];
                    cbb_NienKhoa.DisplayMember = "col_NienKhoa";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Xãy Ra Lỗi: " + ex, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conSql.conn.Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cbb_NienKhoa.Text != "" && txt_TenHP.Text != "" && txt_MaHP.Text != "")
            {
                conSql.query = "SELECT * FROM tab_LopHP WHERE col_NienKhoa=@nienkhoa and col_TenHP=@tenhp and col_MaHP=@mahp";
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    try
                    {
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@nienkhoa", cbb_NienKhoa.Text);
                        conSql.cmd.Parameters.AddWithValue("@tenhp", txt_TenHP.Text);
                        conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                        conSql.adapter = new SqlDataAdapter(conSql.cmd);
                        DataSet set = new DataSet();
                        conSql.adapter.Fill(set);
                        dgv_HP_View.DataSource = set.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã Xãy Ra Lỗi: " + ex, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    conSql.conn.Close();
                }
            }
            else
            {
                conSql.query = "SELECT * FROM tab_LopHP WHERE col_NienKhoa=@nienkhoa or col_TenHP=@tenhp or col_MaHP=@mahp";
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    try
                    {
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@nienkhoa",cbb_NienKhoa.Text);
                        conSql.cmd.Parameters.AddWithValue("@tenhp", txt_TenHP.Text);
                        conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
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
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cbb_NienKhoa.Text = "";
            txt_TenHP.Text = "";
            user1_Qt_Class_Load(sender, e);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm01_Qt_ClassEdit f = new frm01_Qt_ClassEdit();
            f.ShowDialog();
            user1_Qt_Class_Load(sender, e);
        }

        private void dgv_HP_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_HP_View.Rows[e.RowIndex];
                frm01_Qt_ClassEdit f = new frm01_Qt_ClassEdit(row);
                f.ShowDialog();
                user1_Qt_Class_Load(sender, e);
            }
        }

        private void dgv_HP_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_HP_View["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
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
