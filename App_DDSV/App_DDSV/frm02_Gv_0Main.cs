using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_DDSV
{
    public delegate void SendMes(DataRow row);

    public partial class frm02_Gv_0Main : Form
    {
        private static DataRow info;
        public frm02_Gv_0Main(DataRow row)
        {
            info = row;
            InitializeComponent();
        }

        private void item_Main_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm02_Gv_0Main f = new frm02_Gv_0Main(info);
            f.ShowDialog();
            this.Close();
        }

        private void item_InfoLecturers_Click(object sender, EventArgs e)
        {
            frm02_Gv_InfoLecturers f = new frm02_Gv_InfoLecturers(info);
            f.ShowDialog();
        }

        private void item_Upass_Click(object sender, EventArgs e)
        {
            frm00_UpdatePass f = new frm00_UpdatePass(info.Field<string>("col_MaGV"));
            f.ShowDialog();
        }

        private void item_ClassInfo_Click(object sender, EventArgs e)
        {
            user2_Gv_ClassInfo u = new user2_Gv_ClassInfo(info);
            panel1.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        private void item_History_Click(object sender, EventArgs e)
        {
            user2_Gv_History u = new user2_Gv_History(info);
            panel1.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        private void item_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác Nhận Thoát Hệ Thống",
                "Thoát Hệ Thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Hide();
                frm00_LOGIN f = new frm00_LOGIN();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
