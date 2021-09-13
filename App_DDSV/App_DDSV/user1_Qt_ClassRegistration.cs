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
    public partial class user1_Qt_ClassRegistration : UserControl
    {
        private static user1_Qt_ClassRegistration _instance;
        public static user1_Qt_ClassRegistration Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user1_Qt_ClassRegistration();
                return _instance;
            }
        }
        public user1_Qt_ClassRegistration()
        {
            InitializeComponent();
        }

        private void user1_Qt_ClassRegistration_Load(object sender, EventArgs e)
        {
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand("asp_DKHP_AllData", conSql.conn);
                conSql.cmd.CommandType = CommandType.StoredProcedure;
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                dgv_HP_View.DataSource = data.Tables[0];
                dgv_SV_View.DataSource = data.Tables[1];
                conSql.conn.Close();
            }
        }

        private void btn_SearchStudent_Click(object sender, EventArgs e)
        {
            conSql.query = @"SELECT * FROM tab_SinhVien WHERE col_MaSV = @masv or col_HoLot = @ho or col_Ten = @ten";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                try
                {
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV_Search.Text);
                    conSql.cmd.Parameters.AddWithValue("@ho", txt_HoSV.Text);
                    conSql.cmd.Parameters.AddWithValue("@ten", txt_TenSV.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_SV_View.DataSource = data.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Xãy Ra Lỗi: " + ex.Message, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conSql.conn.Close();
            }
        }

        private void btn_SearchClass_Click(object sender, EventArgs e)
        {
            conSql.query = @"SELECT * FROM tab_LopHP WHERE col_MaHP = @mahp or col_TenHP = @ten";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                try
                {
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP_Search.Text);
                    conSql.cmd.Parameters.AddWithValue("@ten", txt_TenHP.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_HP_View.DataSource = data.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Xãy Ra Lỗi: " + ex.Message, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conSql.conn.Close();
            }
        }

        private void btn_ViewStudent_Click(object sender, EventArgs e)
        {
            conSql.query = "SELECT * FROM tab_SinhVien";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                try
                {
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_SV_View.DataSource = data.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Xãy Ra Lỗi: " + ex.Message, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conSql.conn.Close();
            }
        }

        private void btn_ViewClass_Click(object sender, EventArgs e)
        {
            conSql.query = @"SELECT * FROM tab_LopHP";

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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Xãy Ra Lỗi: " + ex.Message, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conSql.conn.Close();
            }
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            frm01_Qt_ClassReg_Add f = new frm01_Qt_ClassReg_Add();
            f.ShowDialog();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MaSV_Search.Text = "";
            txt_HoSV.Text = "";
            txt_TenSV.Text = "";
            txt_MaHP_Search.Text = "";
            txt_TenHP.Text = "";
            user1_Qt_ClassRegistration_Load(sender, e);
        }

        private void dgv_SV_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conSql.query = "SELECT hp.* " +
                "FROM tab_DKHP dk, tab_LopHP hp " +
                "WHERE dk.col_MaHP = hp.col_MaHP and col_MaSV = @masv";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgv_SV_View.Rows[e.RowIndex];
                    string masv = row.Cells["col_MaSV"].Value.ToString();

                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@masv", masv);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_HP_View.DataSource = data.Tables[0];
                }
                conSql.conn.Close();
            }   
        }

        private void dgv_SV_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_SV_View.Rows[e.RowIndex];
                string masv = row.Cells["col_MaSV"].Value.ToString();
                frm01_Qt_ClassReg_EditClass f = new frm01_Qt_ClassReg_EditClass(masv);
                f.ShowDialog();
            }
        }

        private void dgv_SV_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_SV_View["col_SV_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private void dgv_HP_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conSql.query = "SELECT sv.* " +
                "FROM tab_DKHP dk, tab_SinhVien sv " +
                "WHERE dk.col_MaSV = sv.col_MaSV and col_MaHP = @mahp";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgv_HP_View.Rows[e.RowIndex];
                    string mahp = row.Cells["col_MaHP"].Value.ToString();

                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@mahp", mahp);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_SV_View.DataSource = data.Tables[0];
                }
                conSql.conn.Close();
            }
        }

        private void dgv_HP_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_HP_View.Rows[e.RowIndex];
                string mahp = row.Cells["col_MaHP"].Value.ToString();
                frm01_Qt_ClassReg_EditStudent f = new frm01_Qt_ClassReg_EditStudent(mahp);
                f.ShowDialog();
            }
        }

        private void dgv_HP_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_HP_View["col_HP_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }
    }
}
