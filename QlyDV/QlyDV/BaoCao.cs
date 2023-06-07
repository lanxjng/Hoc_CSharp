using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QlyDV
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnInDs_Click(object sender, EventArgs e)
        {
            string sql="Select KhachHang.HoTen, DichVu.TenDv,DichVu.DonGia, ChungTu.SoLg";
            sql += " from KhachHang, DichVu,ChungTu where ChungTu.MaKh = KhachHang.MaKh and ";
            sql += " ChungTu.MaDv = DichVu.MaDv and (DichVu.DonGia * ChungTu.SoLg) < 100000 ";
            KetNoi sv = new KetNoi();
            DataTable dt = new DataTable();
            dt = sv.Load(sql);  
            reportViewer1.ProcessingMode =
            Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"E:\hoc Csharp\QlyDV\QlyDV\InDs.rdlc";  
            if (dt.Rows.Count > 0){
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = dt;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();}
            else    MessageBox.Show("Khong co du lieu"); 

        }

        
    }
}
