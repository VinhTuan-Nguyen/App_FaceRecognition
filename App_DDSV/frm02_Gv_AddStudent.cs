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
    public partial class frm02_Gv_AddStudent : Form
    {
        public frm02_Gv_AddStudent(string magv)
        {
            InitializeComponent();
            txt_MaGV.Text = magv;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(txt_MaHP.Text == "" || txt_MaSV.Text == "")
            {
                MessageBox.Show("Thông Tin Rỗng !", "Cảnh Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conSql.query = "SELECT * FROM tab_LopHP WHERE col_maHP=@mahp and col_MaGV=@magv";
                using(conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                    conSql.cmd.Parameters.AddWithValue("@magv", txt_MaGV.Text);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    if(data.Tables[0].Rows.Count > 0)
                    {
                        conSql.query = "SELECT * FROM tab_SinhVien WHERE col_MaSV=@masv " +
                            "SELECT * FROM tab_DKHP WHERE col_MaHP=@mahp and col_MaSV=@masv";
                        conSql.cmd = new SqlCommand(conSql.query,conSql.conn);
                        conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                        conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                        conSql.adapter = new SqlDataAdapter(conSql.cmd);
                        DataSet ds = new DataSet();
                        conSql.adapter.Fill(ds);
                        if(ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("Không Có Sinh Viên Này Trong CSDL", "Cảnh Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if(ds.Tables[1].Rows.Count > 0)
                        {
                            MessageBox.Show("Sinh Viên Đã Đăng Kí Học Phần Này", "Cảnh Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            conSql.query = "INSERT INTO tab_DKHP VALUES(@mahp, @masv)";
                            conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                            conSql.cmd.Parameters.AddWithValue("@mahp", txt_MaHP.Text);
                            conSql.cmd.Parameters.AddWithValue("@masv", txt_MaSV.Text);
                            conSql.cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm Thành Công !", "Thành Công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không Được Phép Thêm Vào Lớp Này !", "Cảnh Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    conSql.conn.Close();
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_MouseHover(object sender, EventArgs e)
        {
            btn_Save.ForeColor = Color.YellowGreen;
        }

        private void btn_Save_MouseLeave(object sender, EventArgs e)
        {
            btn_Save.ForeColor = Color.DarkGreen;
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
