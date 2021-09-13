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
    public partial class user2_Gv_History : UserControl
    {
        private static user2_Gv_History _instance;

        public static user2_Gv_History Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user2_Gv_History();
                return _instance;
            }
        }
        public user2_Gv_History()
        {
            InitializeComponent();
        }

        private void user2_Gv_History_Load(object sender, EventArgs e)
        {

        }
    }
}
