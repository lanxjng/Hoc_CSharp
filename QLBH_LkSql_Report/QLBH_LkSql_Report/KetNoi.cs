using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLBH_LkSql_Report
{
    class KetNoi
    {
        public SqlConnection conn = new SqlConnection("Data Source=TRUONGJAE\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");

        public void Execute(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Update(dt);
            dt.AcceptChanges();

        }
        public DataTable Load(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, conn);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = comSelect;
            ad.Fill(dt);
            dt.AcceptChanges();
            return dt;
        }

    }
}
