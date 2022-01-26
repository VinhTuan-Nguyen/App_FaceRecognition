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
    public partial class frm00_Note : Form
    {
        private static string Note;

        public frm00_Note(string date, string mahp, string masv, string note, string time, string name)
        {
            InitializeComponent();
            txt_Date.Text = date;
            txt_MaHP.Text = mahp;
            txt_MaSV.Text = masv;
            txt_Time.Text = time;
            txt_TenSV.Text = name;
            Note = note;
            switch (Note)
            {
                case "Có Mặt":
                    ra_Co.Checked = true;
                    break;
                case "Không Phép":
                    ra_Vang.Checked = true;
                    break;
                case "Có Phép":
                    ra_Phep.Checked = true;
                    break;
                default:
                    ra_Khac.Checked = true;
                    txt_GhiChu.Text = Note;
                    break;
            }
        }

        private void frm02_Gv_Note_Load(object sender, EventArgs e)
        {
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
                txt_GhiChu.Text = "Có Phép";
                txt_GhiChu.Enabled = false;
            }
            else if (ra_Vang.Checked == true)
            {
                txt_GhiChu.Text = "Không Phép";
                txt_GhiChu.Enabled = false;
            }
            else
            {
                txt_GhiChu.Enabled = true;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
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
                    conSql.cmd.Parameters.AddWithValue("@date", txt_Date.Text);
                    conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                    conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                    conSql.cmd.Parameters.AddWithValue("@time", txt_Time.Text);
                    conSql.cmd.ExecuteNonQuery();
                    conSql.conn.Close();
                }
                MessageBox.Show("Thay Đổi Ghi Chú Thành Công", "Thành Công");
            }
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_MouseHover(object sender, EventArgs e)
        {
            btn_OK.ForeColor = Color.YellowGreen;
        }

        private void btn_OK_MouseLeave(object sender, EventArgs e)
        {
            btn_OK.ForeColor = Color.DarkGreen;
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
