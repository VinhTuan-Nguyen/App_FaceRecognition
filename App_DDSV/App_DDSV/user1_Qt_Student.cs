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
        private static user1_Qt_Student _instance;
        public static user1_Qt_Student Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user1_Qt_Student();
                return _instance;
            }
        }
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
            if (txt_MaSV.Text == "" && txt_TenSV.Text == "" && txt_HoLot.Text == "" &&
                txt_Lop.Text == "" && txt_Email.Text == "" &&
                ra_Nam.Checked == false && ra_Nu.Checked == false)
            {
                MessageBox.Show("Không Có Dữ Liệu Nào Được Truy Vấn", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_MaSV.Text != "" || txt_TenSV.Text != "" || txt_HoLot.Text != "" ||
                txt_Lop.Text != "" || txt_Email.Text != "" &&
                (ra_Nam.Checked == false && ra_Nu.Checked == false))
            {
                conSql.query = "SELECT * FROM tab_SinhVien WHERE " +
                    "col_MaSV = @masv or " +
                    "col_HoLot = @ho or " +
                    "col_Ten = @ten or " +
                    "col_Lop = @lop or " +
                    "col_Email = @email";
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                    conSql.cmd.Parameters.AddWithValue("@ho", txt_HoLot.Text);
                    conSql.cmd.Parameters.AddWithValue("@ten", txt_TenSV.Text);
                    conSql.cmd.Parameters.AddWithValue("@lop", txt_Lop.Text);
                    conSql.cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_SV_View.DataSource = data.Tables[0];
                    conSql.conn.Close();
                }
            }
            else if (ra_Nam.Checked == true || ra_Nu.Checked == true)
            {
                bool sex = ra_Nam.Checked ? true : false;
                conSql.query = @"SELECT * FROM tab_SinhVien WHERE col_GioiTinh = @gt";
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@gt", sex);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_SV_View.DataSource = data.Tables[0];
                    conSql.conn.Close();
                }
            }
            else
            {
                bool sex = ra_Nam.Checked ? true : false;
                conSql.query = "SELECT * FROM tab_SinhVien WHERE " +
                    "col_MaSV = @masv or " +
                    "col_HoLot = @ho or " +
                    "col_Ten = @ten or " +
                    "col_Lop = @lop or " +
                    "col_Email = @email or " +
                    "col_GioiTinh = @gt";
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                    conSql.cmd.Parameters.AddWithValue("@ho", txt_HoLot.Text);
                    conSql.cmd.Parameters.AddWithValue("@ten", txt_TenSV.Text);
                    conSql.cmd.Parameters.AddWithValue("@lop", txt_Lop.Text);
                    conSql.cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    conSql.cmd.Parameters.AddWithValue("@gt", sex);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_SV_View.DataSource = data.Tables[0];
                    conSql.conn.Close();
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_MaSV.Text == "" && txt_TenSV.Text == "" && txt_HoLot.Text == "" &&
                txt_Lop.Text == "" && txt_Email.Text == "" &&
                ra_Nam.Checked == false && ra_Nu.Checked == false)
            {
                MessageBox.Show("Dữ Liệu Bị Rỗng", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Xác Nhận Thêm Thông Tin Này Vào CSDL", "Xác Nhận",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    conSql.query = @"INSERT INTO tab_SinhVien VALUES(@masv, @ho, @ten, @lop, @email, @gt)";
                    bool sex = ra_Nam.Checked ? true : false;
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                        conSql.cmd.Parameters.AddWithValue("@ho", txt_HoLot.Text);
                        conSql.cmd.Parameters.AddWithValue("@ten", txt_TenSV.Text);
                        conSql.cmd.Parameters.AddWithValue("@lop", txt_Lop.Text.ToUpper());
                        conSql.cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                        conSql.cmd.Parameters.AddWithValue("@gt", sex);
                        conSql.cmd.ExecuteNonQuery();
                        conSql.conn.Close();
                    }
                    MessageBox.Show("Đã Thêm Một Sinh Viên Mới Vào CSDL", "Thành Công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user1_Qt_Student_Load(sender, e);
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MaSV.Text = "";
            txt_HoLot.Text = "";
            txt_TenSV.Text = "";
            txt_Lop.Text = "";
            txt_Email.Text = "";
            ra_Nam.Checked = false;
            ra_Nu.Checked = false;
            user1_Qt_Student_Load(sender, e);
        }

        private void dgv_SV_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_SV_View.Rows[e.RowIndex];
                frm01_Qt_StudentEdit f = new frm01_Qt_StudentEdit(row);
                f.ShowDialog();
                user1_Qt_Student_Load(sender, e);
            }
        }

        private void dgv_SV_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_SV_View[0, e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }
    }
}
