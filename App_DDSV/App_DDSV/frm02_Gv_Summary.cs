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
    public partial class frm02_Gv_Summary : Form
    {
        private static string MaHP;
        private static string TenHP;
        private static string Date;
        public frm02_Gv_Summary(string mahp, string tenhp, string date)
        {
            MaHP = mahp;
            TenHP = tenhp;
            Date = date;
            InitializeComponent();
        }

        private void frm02_Gv_RollCall_Load(object sender, EventArgs e)
        {
            txt_MaHP.Text = MaHP;
            txt_TenHP.Text = TenHP;
            txt_Date.Text = Date;
        }

        private void btn_Summary_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác Nhận Kết Thúc Buổi Điểm Danh", " Xác Nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
