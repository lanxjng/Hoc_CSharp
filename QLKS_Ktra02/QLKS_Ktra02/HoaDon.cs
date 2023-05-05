using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS_Ktra02
{
    class HoaDon
    {
        private int SoHD;
        DateTime NgayHD;
        private string MaKh;
        private string MaPhong;
        DateTime NgayDi;

        public HoaDon() { }
        public HoaDon(int SoHD, DateTime NgayHD, string MaKh, string MaPhong, DateTime NgayDi)
        {
            this.SoHD = SoHD;
            this.NgayHD = NgayHD;
            this.MaKh = MaKh;
            this.MaPhong = MaPhong;
            this.NgayDi = NgayDi;
        }
        KetNoi ob = new KetNoi();
        public DataTable Load_HD()
        {
            string sql = "select * from HoaDon";
            return ob.Load(sql);
        }
        public DataTable Load_Phong()
        {
            string sql = "select * from Phong";
            return ob.Load(sql);
        }
        public DataTable Load_KhachHang()
        {
            string sql = "select * from KhachHang";
            return ob.Load(sql);
        }
        public void Insert(HoaDon hd1)
        {
            string sql = "Insert into HoaDon values('" + hd1.SoHD + "','" + hd1.NgayHD + "','" + hd1.MaKh + "','" + hd1.MaPhong + "','" + hd1.NgayDi + "')";
            ob.Execute(sql);
        }
        public void Update(HoaDon hd1)
        {
            string sql = "Update HoaDon set SoHD = '" + hd1.SoHD + "' where HoaDon.MaKh = '" + hd1.MaKh + "'and HoaDon.MaPhong = '" + hd1.MaPhong + "'";
            ob.Execute(sql);
        }
        public void Delete(string SoHD)
        {
            string sql = "Delete from HoaDon where SoHD = '" + SoHD + "'";
            ob.Execute(sql);
        }
    }
}
