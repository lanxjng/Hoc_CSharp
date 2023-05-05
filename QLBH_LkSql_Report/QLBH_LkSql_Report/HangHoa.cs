using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace QLBH_LkSql_Report
{
    class HangHoa
    {
        private string MaHang;
        private string TenHang;
        float SoLg;
        float DonGia;

        public HangHoa() { }
        public HangHoa(string MaHang, string TenHang, float SoLg, float DonGia)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.SoLg = SoLg;
            this.DonGia = DonGia;
        }
        KetNoi ob = new KetNoi();
        public DataTable Load_HH()
        {
            string sql = "select * from HangHoa";
            return ob.Load(sql);
        }
        public void Insert(HangHoa ob1)
        {
            string sql = "Insert into HangHoa values('" + ob1.MaHang + "','" + ob1.TenHang + "','" + ob1.SoLg + "','" + ob1.DonGia + "')";
            ob.Execute(sql);
        }
        public void Update(HangHoa ob1)
        {
            string sql = "Update HangHoa set TenHang = '" + ob1.TenHang + "' where MaHang = '" + ob1.MaHang + "'";
            ob.Execute(sql);
        }
        public void Delete(string MaHang)
        {
            string sql = "Delete from HangHoa where MaHang = '" + MaHang + "'";
            ob.Execute(sql);
        }
    }
}
