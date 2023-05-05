using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace QLBH_LkSql_Report
{
    class HoaDon
    {
        private string MaKh;
        private string MaHang;
        float SoLg;
        float DonGia;

        public HoaDon() { }
        public HoaDon(string MaKh, string MaHang, float SoLg, float DonGia)
        {
            this.MaKh = MaKh;
            this.MaHang = MaHang;
            this.SoLg = SoLg;
            this.DonGia = DonGia;
        }
        public DataTable Load_KH()
        {
            string sql = "select * from KhachHang";
            return ob.Load(sql);
        }
        public DataTable Load_HH()
        {
            string sql = "select * from HangHoa";
            return ob.Load(sql);
        }

        KetNoi ob = new KetNoi();
        public DataTable Load_HD()
        {
            string sql = "select * from HoaDon";
            return ob.Load(sql);
        }
        public void Insert(HoaDon ob1)
        {
            string sql = "Insert into HoaDon values('" + ob1.MaKh + "','" + ob1.MaHang + "','" + ob1.SoLg + "','" + ob1.DonGia + "')";
            ob.Execute(sql);
        }
        public void Update(HoaDon ob1)
        {
            string sql = "Update HoaDon set SoLuong = '" + ob1.SoLg + "' where MaKh = '" + ob1.MaKh + "'";
            ob.Execute(sql);
        }
        public void Delete(string MaKh)
        {
            string sql = "Delete from HoaDon where MaKh = '" + MaKh + "'";
            ob.Execute(sql);
        }
    }
}
