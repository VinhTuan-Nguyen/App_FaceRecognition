﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_DDSV
{
    public partial class frm00_LOGIN : Form
    {
        public frm00_LOGIN()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void ch_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_Pasword.PasswordChar == '*')
            {
                txt_Pasword.PasswordChar = '\0';
            }
            else txt_Pasword.PasswordChar = '*';
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Chắc Chắn Bạn Muốn Thoát ?", "Thông Báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                try
                {
                    conSql.cmd = new SqlCommand("asp_AllUser", conSql.conn);
                    conSql.cmd.CommandType = CommandType.StoredProcedure;
                    conSql.cmd.Parameters.AddWithValue("@user", txt_User.Text);
                    conSql.cmd.Parameters.AddWithValue("@pass", EnCryp(txt_Pasword.Text));

                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataTable table = new DataTable();
                    conSql.adapter.Fill(table);

                    if(table.Rows.Count > 0)
                    {
                        if (table.Rows[0].Field<string>("col_Role") == "admin")
                        {
                            this.Hide();
                            frm01_Qt_0Main f = new frm01_Qt_0Main(txt_User.Text);
                            f.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            conSql.query = @"SELECT * FROM tab_GiangVien WHERE col_MaGV = @magv";
                            conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                            conSql.cmd.Parameters.AddWithValue("@magv", txt_User.Text);
                            conSql.adapter = new SqlDataAdapter(conSql.cmd);
                            DataSet data = new DataSet();
                            conSql.adapter.Fill(data);
                            if (data.Tables[0].Rows.Count > 0)
                            {
                                this.Hide();
                                DataRow row = data.Tables[0].Rows[0];
                                frm02_Gv_0Main f = new frm02_Gv_0Main(row);
                                f.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Tài Khoản Đã Được Khởi Tạo\n" +
                                    "Nhưng Thông Tin Giảng Viên Chưa Có Trong CSDL",
                                    "Đăng Nhập Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đăng Nhập Thất Bại\nSai Tài Khoản Hoặc Mật Khẩu", "Lỗi Đăng Nhập",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thông Tin Lỗi:\n\n" + ex.Message, "Lỗi Kết Nối",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conSql.conn.Close();
            }
        }

        private void txt_User_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_Pasword.Focus();
            }
        }

        private void txt_Pasword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login.PerformClick();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string i = txt_User.Text.ToString();
            if (i.Length == 10)
            {
                lb_Messenger.Text = "User ID Không được nhập quá 10 kí tự !";
            }
            else
            {
                lb_Messenger.Text = "";
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
    }
}