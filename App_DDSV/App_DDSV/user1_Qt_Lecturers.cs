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
        private static user1_Qt_Lecturers _instance;
        public static user1_Qt_Lecturers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user1_Qt_Lecturers();
                return _instance;
            }
        }
        public user1_Qt_Lecturers()
        {
            InitializeComponent();
        }

        private void user1_Qt_Lecturers_Load(object sender, EventArgs e)
        {
            conSql.query = @"SELECT * FROM tab_GiangVien";
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
            if (txt_MaGV.Text == "" && txt_HoLot.Text == "" && txt_Ten.Text == "" &&
                txt_Khoa.Text == "" && txt_Email.Text == "" &&
                ra_Nam.Checked == false && ra_Nu.Checked == false)
            {
                MessageBox.Show("Ít Nhất Phải Có Một Thông Tin Nào Đó!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_MaGV.Text != "" || txt_HoLot.Text != "" || txt_Ten.Text != "" ||
                txt_Khoa.Text != "" || txt_Email.Text != "" &&
                (ra_Nam.Checked == false && ra_Nu.Checked == false))
            {
                conSql.query = "SELECT * FROM tab_GiangVien WHERE " +
                    "col_MaGV = @magv or " +
                    "col_HoLot LIKE @ho or " +
                    "col_Ten = @ten or " +
                    "col_Khoa = @khoa or " +
                    "col_Email = @email";
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                    conSql.cmd.Parameters.AddWithValue("@ho", txt_HoLot.Text);
                    conSql.cmd.Parameters.AddWithValue("@ten", txt_Ten.Text);
                    conSql.cmd.Parameters.AddWithValue("@khoa", txt_Khoa.Text);
                    conSql.cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    dgv_GV_View.DataSource = data.Tables[0];
                    conSql.conn.Close();
                }
            }
            else
            {
                bool sex = ra_Nam.Checked ? true : false;
                conSql.query = "SELECT * FROM tab_GiangVien WHERE " +
                    "col_MaGV = @magv or " +
                    "col_HoLot LIKE @ho or " +
                    "col_Ten = @ten or " +
                    "col_Khoa = @khoa or " +
                    "col_Email = @email or " +
                    "col_GioiTinh = @gt";
                using (conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                    conSql.cmd.Parameters.AddWithValue("@ho", txt_HoLot.Text);
                    conSql.cmd.Parameters.AddWithValue("@ten", txt_Ten.Text);
                    conSql.cmd.Parameters.AddWithValue("@khoa", txt_Khoa.Text);
                    conSql.cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    conSql.cmd.Parameters.AddWithValue("@gt", sex);
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
            if (txt_MaGV.Text == "" || txt_HoLot.Text == "" || txt_Ten.Text == "" ||
                txt_Khoa.Text == "" || txt_Email.Text == "" ||
                (ra_Nam.Checked == false && ra_Nu.Checked == false))
            {
                MessageBox.Show("Chưa Nhập Đầy Đủ Các Thông Tin !", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool sex = ra_Nam.Checked ? true : false;
                string gt = ra_Nam.Checked ? "Nam" : "Nữ";
                conSql.query = @"INSERT INTO tab_GiangVien VALUES (@magv, @holot, @ten, @khoa, @email, @gt)";

                DialogResult result = MessageBox.Show("Xác Nhận Thêm Các Thông Tin Này Vào CSDL:" +
                    "\nMã Giảng Viên: " + txt_MaGV.Text +
                    "\nHọ Tên Giảng Viên: " + txt_HoLot.Text + " " + txt_Ten.Text +
                    "\nKhoa: " + txt_Khoa.Text +
                    "\nEmail: " + txt_Email.Text +
                    "\nGiới Tính: " + gt,
                    "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                        conSql.cmd.Parameters.AddWithValue("@holot", txt_HoLot.Text);
                        conSql.cmd.Parameters.AddWithValue("@ten", txt_Ten.Text);
                        conSql.cmd.Parameters.AddWithValue("@khoa", txt_Khoa.Text);
                        conSql.cmd.Parameters.AddWithValue("@email ", txt_Email.Text);
                        conSql.cmd.Parameters.AddWithValue("@gt", sex);
                        conSql.cmd.ExecuteNonQuery();
                        conSql.conn.Close();
                    }
                    MessageBox.Show("Đã Thêm Một Trường Vào CSDL !", "Thành Công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user1_Qt_Lecturers_Load(sender, e);
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MaGV.Text = "";
            txt_HoLot.Text = "";
            txt_Ten.Text = "";
            txt_Khoa.Text = "";
            txt_Email.Text = "";
            ra_Nam.Checked = false;
            ra_Nu.Checked = false;
            user1_Qt_Lecturers_Load(sender, e);
        }

        private void dgv_GV_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_GV_View.Rows[e.RowIndex];
            frm01_Qt_LecturersEdit f = new frm01_Qt_LecturersEdit(row);
            f.ShowDialog();
            user1_Qt_Lecturers_Load(sender, e);
        }

        private void dgv_GV_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgv_GV_View["col_Stt", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }
    }
}
