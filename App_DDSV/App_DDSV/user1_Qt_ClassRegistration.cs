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
    public partial class user1_Qt_ClassRegistration : UserControl
    {
        public user1_Qt_ClassRegistration()
        {
            InitializeComponent();
        }

        private void btn_SV_Search_Click(object sender, EventArgs e)
        {
            btn_SV_Search.Enabled = false;
            btn_HP_Search.Enabled = true;
            user1_Qt_0_SVSearch u = new user1_Qt_0_SVSearch();
            panel_Tools.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }

        private void btn_HP_Search_Click(object sender, EventArgs e)
        {
            btn_HP_Search.Enabled = false;
            btn_SV_Search.Enabled = true;
            user1_Qt_0_HPSearch u = new user1_Qt_0_HPSearch();
            panel_Tools.Controls.Add(u);
            u.Dock = DockStyle.Fill;
            u.BringToFront();
        }
    }
}
