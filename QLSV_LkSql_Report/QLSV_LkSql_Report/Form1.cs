using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLSV_LkSql_Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Ketnoi ob = new Ketnoi();
            string sql = " select SinhVien.MaSv, HoTen, NgaySinh, TenMon, SoTc, Diem.Diem";
            sql += " from SinhVien, Diem, Mon where SinhVien.MaSv = Diem.MaSv";
            sql += " and Diem.MaMon = Mon.MaMon and SinhVien.MaSv = '" + txtMaSv.Text + "'";
            DataTable dt = new DataTable();
            dt = ob.Load(sql);
            // Dat report lam nguon cho reportviewer
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"E:\hoc Csharp\QLSV_LkSql_Report\QLSV_LkSql_Report\BangDiemSv.rdlc";
            //Dat dataset lam nguon cho report
            ReportDataSource rps = new ReportDataSource();
            //Go ten dataset
            rps.Name = "BangDiem";
            rps.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rps);
            reportViewer1.RefreshReport();



        }

        private void btnIn2_Click(object sender, EventArgs e)
        {
            Ketnoi ob = new Ketnoi();
            string sql = " select Mon.MaMon, TenMon, HoTen, SoTc, Diem.Diem , NgaySinh";
            sql += " from SinhVien, Diem, Mon where SinhVien.MaSv = Diem.MaSv";
            sql += " and Diem.MaMon = Mon.MaMon and SinhVien.MaSv = '" + txtMaMon.Text + "'";
            DataTable dt = new DataTable();
            dt = ob.Load(sql);
            // Dat report lam nguon cho reportviewer
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"E:\hoc Csharp\QLSV_LkSql_Report\QLSV_LkSql_Report\BangDiemTheoMaMon.rdlc";
            //Dat dataset lam nguon cho report
            ReportDataSource rps = new ReportDataSource();
            //Go ten dataset
            rps.Name = "BangDiemTheoMaMon";
            rps.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rps);
            reportViewer1.RefreshReport();
        }
    }
}
