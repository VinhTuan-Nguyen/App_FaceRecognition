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
    public partial class frm01_Qt_0Main : Form
    {
        private static string userID;
        public frm01_Qt_0Main(string User)
        {
            userID = User;
            InitializeComponent();
        }

        private void item_Class_Click(object sender, EventArgs e)
        {
            user1_Qt_Class u = new user1_Qt_Class();
            panel1.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        private void item_ClassRegistration_Click(object sender, EventArgs e)
        {
            user1_Qt_ClassRegistration u = new user1_Qt_ClassRegistration();
            panel1.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        private void item_Lecturers_Click(object sender, EventArgs e)
        {
            user1_Qt_Lecturers u = new user1_Qt_Lecturers();
            panel1.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        private void item_Student_Click(object sender, EventArgs e)
        {
            user1_Qt_Student u = new user1_Qt_Student();
            panel1.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        public void item_Rollcall_Click(object sender, EventArgs e)
        {
            user1_Qt_Rollcall u = new user1_Qt_Rollcall();
            panel1.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        private void item_Account_Click(object sender, EventArgs e)
        {
            user1_Qt_Account u = new user1_Qt_Account();
            panel1.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        private void item_UpdatePass_Click(object sender, EventArgs e)
        {
            frm00_UpdatePass f = new frm00_UpdatePass(userID);
            f.ShowDialog();
        }

        private void item_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Chắc Chắn Muốn Thoát Hệ Thống ?",
                "Thoát Hệ Thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Hide();
                frm00_LOGIN f = new frm00_LOGIN();
                f.ShowDialog();
                this.Close();
            }
        }

        private void item_Help_Click(object sender, EventArgs e)
        {

        }

        private void item_Main_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm01_Qt_0Main f = new frm01_Qt_0Main(userID);
            f.ShowDialog();
            this.Close();
        }

        private void btn_qlDD_Click(object sender, EventArgs e)
        {
            item_Rollcall_Click(sender, e);
        }

        private void btn_qlHP_Click(object sender, EventArgs e)
        {
            item_Class_Click(sender, e);
        }

        private void btn_qlDKHP_Click(object sender, EventArgs e)
        {
            item_ClassRegistration_Click(sender, e);
        }

        private void btn_qlSV_Click(object sender, EventArgs e)
        {
            item_Student_Click(sender, e);
        }

        private void btn_qlGV_Click(object sender, EventArgs e)
        {
            item_Lecturers_Click(sender, e);
        }

        private void btn_qlACC_Click(object sender, EventArgs e)
        {
            item_Account_Click(sender, e);
        }

        private void btn_Upass_Click(object sender, EventArgs e)
        {
            item_UpdatePass_Click(sender, e);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            item_LogOut_Click(sender, e);
        }

        private void btn_Train_Click(object sender, EventArgs e)
        {

        }
    }
}
