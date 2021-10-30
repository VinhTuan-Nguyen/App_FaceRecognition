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
    public partial class frm02_Gv_Note : Form
    {
        private static string Date;
        private static string MaHP;
        private static string MaSV;
        private static string Note;
        private static string Time;

        public frm02_Gv_Note(string date, string mahp, string masv, string note, string time)
        {
            Date = date;
            MaHP = mahp;
            MaSV = masv;
            Note = note;
            Time = time;
            InitializeComponent();
        }

        private void frm02_Gv_Note_Load(object sender, EventArgs e)
        {
            switch (Note)
            {
                case "Có Mặt":
                    ra_Co.Checked = true;
                    break;
                case "Vắng":
                    ra_Vang.Checked = true;
                    break;
                case "C.Phép":
                    ra_Phep.Checked = true;
                    break;
                default:
                    ra_Khac.Checked = true;
                    txt_GhiChu.Text = Note;
                    break;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ra_Co.Checked == true)
            {
                txt_GhiChu.Text = "Có Mặt";
                txt_GhiChu.Enabled = false;
            }
            else if (ra_Phep.Checked == true)
            {
                txt_GhiChu.Text = "C.Phép";
                txt_GhiChu.Enabled = false;
            }
            else if (ra_Vang.Checked == true)
            {
                txt_GhiChu.Text = "Vắng";
                txt_GhiChu.Enabled = false;
            }
            else
            {
                txt_GhiChu.Enabled = true;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác Nhận Thay Đổi Ghi Chú Của Sinh Viên Này", "Xác Nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                conSql.query = "UPDATE tab_DiemDanh SET col_GhiChu = @note WHERE " +
                    "col_NgayDD = @date and " +
                    "col_MaHP = @mahp and " +
                    "col_MaSV = @masv and " +
                    "col_GioDD = @time";
                using(conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@note", txt_GhiChu.Text);
                    conSql.cmd.Parameters.AddWithValue("@date", Date);
                    conSql.cmd.Parameters.AddWithValue("@mahp", MaHP);
                    conSql.cmd.Parameters.AddWithValue("@masv", MaSV);
                    conSql.cmd.Parameters.AddWithValue("@time", Time);
                    conSql.cmd.ExecuteNonQuery();
                    conSql.conn.Close();
                }
                MessageBox.Show("Thay Đổi Ghi Chú Thành Công", "Thành Công");
            }
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
