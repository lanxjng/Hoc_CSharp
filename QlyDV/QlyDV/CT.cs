using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QlyDV
{
    class CT
    {
        private string MaCt;
        private DateTime Ngay;
        private string MaKh;
        private string MaDv;
        private float SoLg;

        public CT() { }
        public CT(string MaCt, DateTime Ngay, string MaKh, string MaDv, float SoLg)
        {
            this.MaCt = MaCt;
            this.Ngay = Ngay;
            this.MaKh = MaKh;
            this.MaDv = MaDv;
            this.SoLg = SoLg;
        }
        KetNoi ob = new KetNoi();
        public DataTable Load_CT()
        {
            string sql = "select * from ChungTu";
            return ob.Load(sql);
        }
        public DataTable Load_DV()
        {
            string sql = "select * from DichVu";
            return ob.Load(sql);
        }
        public DataTable Load_KH()
        {
            string sql = "select * from KhachHang";
            return ob.Load(sql);
        }

        public void Insert(CT ct1)
        {
            try
            {
                string sql = "Insert into ChungTu values('" + ct1.MaCt + "','" + ct1.Ngay + "','" + ct1.MaKh + "','" + ct1.MaDv + "','" + ct1.SoLg + "')";
                ob.Execute(sql);
            }catch (Exception ex)
            {
                MessageBox.Show("Trùng Khóa Chính !! Mời Nhập Lại");
            }
            
        }
        public void Update(CT ct1)
        {
            string sql = "Update ChungTu set MaCt = '" + ct1.MaCt + "', Ngay = '"+ct1.Ngay +
                "', MaKh = '" + ct1.MaKh + "', MaDv = '" + ct1.MaDv + "', SoLg = '" + ct1.SoLg + 
                "' where ChungTu.MaKh = '" + ct1.MaKh + "'and ChungTu.MaDv = '" + ct1.MaDv + "'";
            ob.Execute(sql);
        }
        public void Delete(string MaCt)
        {
            string sql = "Delete from ChungTu where MaCt = '" + MaCt + "'";
            ob.Execute(sql);
        }
    }


    
}
