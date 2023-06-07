using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QlyDV
{
    class KH
    {
        private string MaKh;
        private string HoTen;
        private string DiaChi;

        public KH() { }

        public KH(string MaKh, string HoTen, string DiaChi)
        {
            this.MaKh = MaKh;
            this.HoTen = HoTen;
            this.DiaChi = DiaChi;
        }
        KetNoi ob = new KetNoi();
        public DataTable Load_KH()
        {
            string sql = "select * from KhachHang";
            return ob.Load(sql);
        }

        public void Insert(KH kh1)
        {
            try
            {
                string sql = "Insert into KhachHang values('" + kh1.MaKh + "','" + kh1.HoTen + "','" + kh1.DiaChi + "')";
                ob.Execute(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trùng Khóa Chính !! Mời Nhập Lại");
            }
            
        }
        public void Update(KH kh1)
        {
            string sql = "Update KhachHang set MaKh = '" + kh1.MaKh + "', HoTen = '" + kh1.HoTen +
                "', DiaChi = '" + kh1.DiaChi + "' where KhachHang.MaKh = '" + kh1.MaKh + "'";
            ob.Execute(sql);
        }
        public void Delete(string MaKh)
        {
            string sql = "Delete from KhachHang where MaKh = '" + MaKh + "'";
            ob.Execute(sql);
        }
    }
}
