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
    public partial class frm02_Gv_RollCall : Form
    {
        DateTime date = DateTime.Now;
        private static string MaHp;
        private static DataGridViewColumn Column;
        public frm02_Gv_RollCall(string mahp, DataGridViewColumn column)
        {
            MaHp = mahp;
            Column = column;
            InitializeComponent();
        }

        private void frm02_Gv_RollCall_Load(object sender, EventArgs e)
        {
            lb_DateTime.Text = date.ToString();
            lb_MaHP.Text = MaHp;
        }
    }
}
