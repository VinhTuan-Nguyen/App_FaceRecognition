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
    public partial class user1_Qt_Rollcall : UserControl
    {
        private static user1_Qt_Rollcall _instance;
        public static user1_Qt_Rollcall Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user1_Qt_Rollcall();
                return _instance;
            }
        }
        public user1_Qt_Rollcall()
        {
            InitializeComponent();
        }

        private void user1_Qt_Rollcall_Load(object sender, EventArgs e)
        {

        }
    }
}
