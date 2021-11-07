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
    public partial class user1_Qt_Lecturers : UserControl
    {
        public user1_Qt_Lecturers()
        {
            InitializeComponent();
        }

        private void user1_Qt_Lecturers_Load(object sender, EventArgs e)
        {
            conSql.query = "SELECT * FROM tab_GiangVien";
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                dgv_GV_View.DataSource = data.Tables[0];
                conSql.conn.Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "" && txt_UserID.Text == "")
            {
                MessageBox.Show("Thông Tin Rỗng !", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_UserID.Text != "" || txt_Name.Text != "")
            {
                conSql.query = "SELECT * FROM tab_GiangVien " +
                "WHERE col_MaGV = @magv or col_HoTen = @tenGV";
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@magv", txt_UserID.Text);
                    conSql.cmd.Parameters.AddWithValue("@tenGV", txt_Name.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_GV_View.DataSource = data.Tables[0];
                    conSql.conn.Close();
                }
            }
            else
            {
                conSql.query = "SELECT * FROM tab_GiangVien " +
                "WNERE col_MaGV = @magv and col_HoTen = @tenGV";
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@magv", txt_UserID.Text);
                    conSql.cmd.Parameters.AddWithValue("@tenGV", txt_Name.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_GV_View.DataSource = data.Tables[0];
                    conSql.conn.Close();
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm01_Qt_LecturersEdit f = new frm01_Qt_LecturersEdit();
            f.ShowDialog();
            user1_Qt_Lecturers_Load(sender, e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_UserID.Text = "";
            txt_Name.Text = "";
            user1_Qt_Lecturers_Load(sender, e);
        }

        private void dgv_GV_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_GV_View.Rows[e.RowIndex];
                frm01_Qt_LecturersEdit f = new frm01_Qt_LecturersEdit(row);
                f.ShowDialog();
                user1_Qt_Lecturers_Load(sender, e);
            }
        }

        private void dgv_GV_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_GV_View["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
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
