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
    public partial class frm01_Qt_ClassRegMesageText : Form
    {
        private static string SV;
        public frm01_Qt_ClassRegMesageText(string hpOld, string masv)
        {
            InitializeComponent();
            lb_hpOld.Text = hpOld;
            SV = masv;
        }

        private void frm01_Qt_ClassRegMesageText_Load(object sender, EventArgs e)
        {
            conSql.query = "SELECT col_MaHP FROM tab_LopHP";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                cbb_MaHP.DataSource = data.Tables[0];
                cbb_MaHP.DisplayMember = "col_MaHP";
                conSql.conn.Close();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác Nhận Thay Đổi", "Xác Nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                conSql.query = "UPDATE tab_DKHP SET col_MaHP = @hpNew WHERE " +
                    "col_MaSV = @masv and " +
                    "col_MaHP = @hpOld";

                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@hpOld", lb_hpOld.Text);
                    conSql.cmd.Parameters.AddWithValue("@hpNew",cbb_MaHP.Text);
                    conSql.cmd.Parameters.AddWithValue("@masv", SV);
                    conSql.cmd.ExecuteNonQuery();
                    conSql.conn.Close();
                }
                MessageBox.Show("Đã Thay Đổi Học Phần Thành Công", "Thành Công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbb_MaHP_TextChanged(object sender, EventArgs e)
        {
            conSql.query = "SELECT col_TenHP FROM tab_LopHP WHERE col_MaHP = @mahp";
            using(conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@mahp", cbb_MaHP.Text);
                string tenHP = (string)conSql.cmd.ExecuteScalar();
                txt_hpNew.Text = tenHP;
                conSql.conn.Close();
            }
        }
    }
}
