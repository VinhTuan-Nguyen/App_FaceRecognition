﻿using System;
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
    public partial class user2_Gv_History : UserControl
    {
        private static user2_Gv_History _instance;
        private static DataRow info;
        DataSet data = new DataSet();

        public static user2_Gv_History Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user2_Gv_History(info);
                return _instance;
            }
        }
        public user2_Gv_History(DataRow row)
        {
            info = row;
            InitializeComponent();
        }

        private void user2_Gv_History_Load(object sender, EventArgs e)
        {
            conSql.query = "SELECT DISTINCT col_MaHP, col_TenHP" +
                " FROM tab_LopHP" +
                " WHERE col_MaGV = @magv";

            using (conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@magv", info.Field<string>("col_MaGV"));
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                conSql.adapter.Fill(data);
                cbb_MaHP.DataSource = data.Tables[0];
                cbb_MaHP.DisplayMember = "col_MaHP";
                conSql.conn.Close();
            }
        }

        private void cbb_MaHP_TextChanged(object sender, EventArgs e)
        {
            int i = cbb_MaHP.SelectedIndex;
            txt_TenHP.Text = data.Tables[0].Rows[i].Field<string>("col_TenHP");
        }

        private void btn_GetList_Click(object sender, EventArgs e)
        {
            if(pick_End.Value < pick_Start.Value)
            {
                MessageBox.Show("Thời Gian Không Hợp Lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conSql.query = "SELECT DISTINCT col_NgayDD FROM tab_DiemDanh " +
                    "WHERE col_MaHP = @mahp and " +
                    "col_NgayDD BETWEEN @start and @end";
                using(conSql.conn = new SqlConnection(conSql.conString))
                {
                    conSql.conn.Open();
                    conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                    conSql.cmd.Parameters.AddWithValue("@mahp",cbb_MaHP.Text);
                    conSql.cmd.Parameters.AddWithValue("@start",pick_Start.Value);
                    conSql.cmd.Parameters.AddWithValue("@end",pick_End.Value);
                    conSql.adapter = new SqlDataAdapter(conSql.cmd);
                    DataSet data = new DataSet();
                    conSql.adapter.Fill(data);
                    if(data.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Không Tìm Thấy Dữ Liệu", "Dữ Liệu Rỗng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        cbb_List.DataSource = data.Tables[0];
                        cbb_List.DisplayMember = "col_NgayDD";
                    }

                    conSql.conn.Close();
                }
            }
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            conSql.query = "SELECT sv.*, col_GioDD, col_GhiChu FROM tab_DiemDanh dd, tab_SinhVien sv " +
                "WHERE dd.col_MaSV = sv.col_MaSV and " +
                "col_NgayDD = @date and " +
                "col_MaHP = @mahp";

            using(conSql.conn = new SqlConnection(conSql.conString))
            {
                conSql.conn.Open();
                conSql.cmd = new SqlCommand(conSql.query, conSql.conn);
                conSql.cmd.Parameters.AddWithValue("@date",cbb_List.Text);
                conSql.cmd.Parameters.AddWithValue("@mahp",cbb_MaHP.Text);
                conSql.adapter = new SqlDataAdapter(conSql.cmd);
                DataSet data = new DataSet();
                conSql.adapter.Fill(data);
                dgv_DataView.DataSource = data.Tables[0];
                conSql.conn.Close();
            }
        }
    }
}
