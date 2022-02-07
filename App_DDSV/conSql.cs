using System;
using System.Data.SqlClient;

namespace App_DDSV
{
    class conSql
    {
        public static string server_Name = "DESKTOP-J3P25DG;";
        public static string db_Name = "db_DDSV;";


        public static string conString =
            "Data Source=" + server_Name +
            "Initial Catalog=" + db_Name +
            "Integrated Security=True;" +
            "MultipleActiveResultSets=True";
        public static string query = "";
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter adapter;
    }
}
