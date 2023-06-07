using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QlyDV
{
    class DV
    {
        private string MaDv;
        private string TenDv;
        private float DonGia;

        public DV() { }
        public DV(string MaDv, string TenDv, float DonGia)
        {
            this.MaDv = MaDv;
            this.TenDv = TenDv;
            this.DonGia = DonGia;
        }
        KetNoi ob = new KetNoi();
        public DataTable Load_DV()
        {
            string sql = "select * from DichVu";
            return ob.Load(sql);
        }
        
        public void Insert(DV dv1)
        {
            try
            {
                string sql = "Insert into DichVu values('" + dv1.MaDv + "','" + dv1.TenDv + "','" + dv1.DonGia + "')";
            ob.Execute(sql);
            }catch (Exception ex)
            {
                MessageBox.Show("Trùng Khóa Chính !! Mời Nhập Lại");
            }
            
        }
        public void Update(DV dv1)
        {
            string sql = "Update DichVu set MaDv = '" + dv1.MaDv + "', TenDv = '"+dv1.TenDv +
                "', DonGia = '" + dv1.DonGia + "' where DichVu.MaDv = '" + dv1.MaDv + "'";
            ob.Execute(sql);
        }
        public void Delete(string MaDv)
        {
            string sql = "Delete from DichVu where MaDv = '" + MaDv + "'";
            ob.Execute(sql);
        }
    }

}

