using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace QLBH_LkSql_Report
{
    class Khachhang
    {
        private string MaKh;
        private string HoTen;
        DateTime NgaySinh;

        public Khachhang () { }
        public Khachhang(string MaKh, string HoTen, DateTime NgaySinh)
        {
            this.MaKh = MaKh;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;

        }
        KetNoi ob = new KetNoi();
        public DataTable Load_KH()
        {
            string sql = "select * from KhachHang";
            return ob.Load(sql);
        }
        public void Insert(Khachhang ob1)
        {
            string sql = "Insert into KhachHang values('" + ob1.MaKh + "','" + ob1.HoTen + "','" + ob1.NgaySinh + "')";
            ob.Execute(sql);
        }
        public void Update(Khachhang ob1)
        {
            string sql = "Update KhachHang set HoTen = '" + ob1.HoTen + "' where MaKh = '" + ob1.MaKh + "'";
            ob.Execute(sql);
        }
        public void Delete(string MaKh)
        {
            string sql = "Delete from KhachHang where MaKh = '" + MaKh + "'";
            ob.Execute(sql);
        }
    }
}
