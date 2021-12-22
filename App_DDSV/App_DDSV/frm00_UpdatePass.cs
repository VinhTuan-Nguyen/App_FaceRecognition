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
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace App_DDSV
{
    public partial class frm00_UpdatePass : Form
    {
        private static string userID;

        public frm00_UpdatePass(string user)
        {
            InitializeComponent();
            userID = user;
            //timer1.Start();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(txt_OldPass.Text == "" || txt_NewPass.Text == "" || txt_AutPass.Text == "")
            {
                lb_Messenger.Text = "Hãy Nhập Vào Đầy Đủ Các Ô Trống";
            }
            else if (!Regex.IsMatch(txt_NewPass.Text, @"^[0-9a-zA-Z]{8,}$")
                && !Regex.IsMatch(txt_AutPass.Text, @"^[0-9a-zA-Z]{8,}$"))
            {
                MessageBox.Show("Mật Khẩu Mới Phải Từ 8 Kí Tự Trở Lên\nVà Bao Gồm Các Kí Tự: [a-z, A-Z, 0-9]",
                    "Mật Khẩu Không Hợp Lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txt_NewPass.Text != txt_AutPass.Text)
                {
                    MessageBox.Show("Mật Khẩu Mới Không Khớp\nKhông Thể Đổi Mật Khẩu",
                        "Sai Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (conSql.conn = new SqlConnection(conSql.conString))
                    {
                        conSql.conn.Open();
                        try
                        {
                            conSql.cmd = new SqlCommand("asp_AllUser", conSql.conn);
                            conSql.cmd.CommandType = CommandType.StoredProcedure;
                            conSql.cmd.Parameters.AddWithValue("@user", userID);
                            conSql.cmd.Parameters.AddWithValue("@pass", EnCryp(txt_OldPass.Text));
                            SqlDataReader data = conSql.cmd.ExecuteReader();

                            if (data.Read() == true)
                            {
                                conSql.query = @"UPDATE tab_Login SET col_Password = @newPass WHERE col_User = @userName";
                                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                                conSql.cmd.Parameters.AddWithValue("@newPass", EnCryp(txt_AutPass.Text));
                                conSql.cmd.Parameters.AddWithValue("@userName", userID);
                                conSql.cmd.ExecuteNonQuery();
                                lb_Messenger.Text = "Đổi Mật Khẩu Thành Công";
                            }
                            else
                            {
                                MessageBox.Show("Đổi Mật Khẩu Thất Bại\nBạn Đã Nhập Sai Mật Khẩu Cũ", "Nhập Sai Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Thông Tin Lỗi:\n\n" + ex, "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine(ex);
                        }
                        conSql.conn.Close();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txt_NewPass.Text != txt_AutPass.Text)
            {
                lb_Messenger.Text = " Mật Khẩu Mới Và Mật khẩu Xác Thực Không Giống Nhau";
            }
            else if(!Regex.IsMatch(txt_NewPass.Text, @"^[0-9a-zA-Z]{8,}$") && !Regex.IsMatch(txt_AutPass.Text, @"^[0-9a-zA-Z]{8,}$"))
            {
                lb_Messenger.Text = "Mật Khẩu Mới Phải Từ 8 Kí Tự Trở Lên Và Gồm:[a-z, A-Z, 0-9]";
            }
            else lb_Messenger.Text = "";
        }

        private void ch_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_OldPass.PasswordChar == '*' && txt_NewPass.PasswordChar == '*' && txt_AutPass.PasswordChar == '*')
            {
                txt_OldPass.PasswordChar = '\0';
                txt_NewPass.PasswordChar = '\0';
                txt_AutPass.PasswordChar = '\0';
            }
            else
            {
                txt_OldPass.PasswordChar = '*';
                txt_NewPass.PasswordChar = '*';
                txt_AutPass.PasswordChar = '*';
            }
        }

        private string EnCryp(string password)
        {
            String str = "";
            Byte[] buffer = Encoding.UTF8.GetBytes(password);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("x");
            }
            return str;
        }

        private void btn_Back_MouseHover(object sender, EventArgs e)
        {
            btn_Back.ForeColor = Color.OrangeRed;
        }

        private void btn_Back_MouseLeave(object sender, EventArgs e)
        {
            btn_Back.ForeColor = Color.Brown;
        }

        private void btn_OK_MouseHover(object sender, EventArgs e)
        {
            btn_OK.ForeColor = Color.YellowGreen;
        }

        private void btn_OK_MouseLeave(object sender, EventArgs e)
        {
            btn_OK.ForeColor = Color.DarkGreen;
        }
    }
}
