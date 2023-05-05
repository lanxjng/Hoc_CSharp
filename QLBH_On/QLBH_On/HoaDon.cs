using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBH_On
{
    class HoaDon
    {
        private string MaHd;
        private string MaKh;
        private string MaSp;
        private float SoLg;
        private float DonGia;

        public HoaDon() { }
        public HoaDon(string MaHd, string MaSp, string MaKh, float SoLg, float DonGia)
        {
            this.MaHd = MaHd;
            this.MaSp = MaSp;
            this.MaKh = MaKh;
            this.SoLg = SoLg;
            this.DonGia = DonGia;
        }

        KetNoi ob = new KetNoi();
        public DataTable Load_HD()
        {
            string sql = "select * from HoaDon";
            return ob.Load(sql);
        }
        public DataTable Load_SanPham()
        {
            string sql = "select * from SanPham";
            return ob.Load(sql);
        }
        public DataTable Load_KhachHang()
        {
            string sql = "select * from KhachHang";
            return ob.Load(sql);
        }
        public void Insert(HoaDon hd1)
        {
            string sql = "Insert into HoaDon values('" + hd1.MaHd + "','" + hd1.MaSp + "','" + hd1.MaKh + "','" + hd1.SoLg + "','" + hd1.DonGia + "')";
            ob.Execute(sql);
        }
        public void Update(HoaDon hd1)
        {
            string sql = "Update HoaDon set MaHoaDon = '" + hd1.MaHd + "', MaSp = '"+hd1.MaSp +
                "', MaKh = '" + hd1.MaKh + "', SoLg = '" + hd1.SoLg + "', DonGia = '" + hd1.DonGia + 
                "' where HoaDon.MaKh = '" + hd1.MaKh + "'and HoaDon.MaSp = '" + hd1.MaSp + "'";
            ob.Execute(sql);
        }
        public void Delete(string SoLg)
        {
            string sql = "Delete from HoaDon where SoLg = '" + SoLg + "'";
            ob.Execute(sql);
        }
    }
}
