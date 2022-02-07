using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_DDSV
{
    public partial class frm02_Gv_History : Form
    {
        public frm02_Gv_History(string mssv, string ten, string mahp)
        {
            InitializeComponent();
            txt_MaSV.Text = mssv;
            txt_MaHP.Text = mahp;
            txt_TenSV.Text = ten;
        }

        private void frm02_Gv_History_Load(object sender, EventArgs e)
        {
            conSql.query = "SELECT col_NgayDD, col_GioDD, col_GhiChu FROM tab_DiemDanh WHERE col_MaSV = @mssv and col_MaHP = @mahp";
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                try
                {
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@mssv", txt_MaSV.Text);
                    conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_History.DataSource = data.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thông Tin Lỗi: \n" + ex, "Lỗi Kết Nối",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conSql.conn.Close();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_History_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_History["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
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
