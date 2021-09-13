using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_DDSV
{
    class conSql
    {
        public static string conString = 
            "Data Source=DESKTOP-18V51P3;" +
            "Initial Catalog=db_DDSV;" +
            "Integrated Security=True;" +
            "MultipleActiveResultSets=True";
        public static string query = "";
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter adapter;
    }
}
