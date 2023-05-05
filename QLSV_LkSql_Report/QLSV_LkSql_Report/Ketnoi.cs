using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLSV_LkSql_Report
{
    class Ketnoi
    {
        public static SqlConnection con = new SqlConnection("Data Source=TRUONGJAE\\SQLEXPRESS;Initial Catalog=QLSV_LkC#;Integrated Security=True");
        public DataTable Load(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
