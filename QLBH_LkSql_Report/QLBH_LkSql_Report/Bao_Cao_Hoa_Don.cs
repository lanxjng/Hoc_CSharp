using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLBH_LkSql_Report
{
    public partial class Bao_Cao_Hoa_Don : Form
    {
        public Bao_Cao_Hoa_Don()
        {
            InitializeComponent();
        }

        private void Bao_Cao_Hoa_Don_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
         {
                    KetNoi ob = new KetNoi();
                    string sql="select KhachHang.HoTen, HangHoa.TenHang, HoaDon.SoLuong, HoaDon.DonGia";
                    sql += " from KhachHang, HangHoa, HoaDon where KhachHang.MaKh = HoaDon.MaKh and ";
                    sql += " HangHoa.MaHang = HoaDon.MaHang ";
                    DataTable dt = new DataTable();
                    dt = ob.Load(sql);
                    // Dat report lam nguon cho reportviewer
                    reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    reportViewer1.LocalReport.ReportPath = @"E:\hoc Csharp\QLBH_LkSql_Report\QLBH_LkSql_Report\BaoCao.rdlc";
                    //Dat dataset lam nguon cho report
                    ReportDataSource rps = new ReportDataSource();
                    //Go ten dataset
                    rps.Name = "BaoCao";
                    rps.Value = dt;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rps);
                    reportViewer1.RefreshReport();

        }
    }
}
