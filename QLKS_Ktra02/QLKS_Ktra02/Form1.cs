using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLKS_Ktra02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HoaDon ob = new HoaDon();
            dataGridView1.DataSource = ob.Load_HD();
            cbbMaKh.DataSource = ob.Load_KhachHang();
            cbbMaKh.ValueMember = "MaKh";
            cbbMaPhong.DataSource = ob.Load_Phong();
            cbbMaPhong.ValueMember = "MaPhong";
            txtSoHD.Clear();
            this.reportViewer1.RefreshReport();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HoaDon ob1 = new HoaDon(int.Parse(txtSoHD.Text), NgayHD.Value, cbbMaKh.Text, cbbMaPhong.Text, NgayDi.Value);
            ob1.Insert(ob1);
            Form1_Load(sender, e);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HoaDon ob1 = new HoaDon(int.Parse(txtSoHD.Text), NgayHD.Value, cbbMaKh.Text, cbbMaPhong.Text, NgayDi.Value);
            ob1.Update(ob1);
            Form1_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HoaDon ob1 = new HoaDon(int.Parse(txtSoHD.Text), NgayHD.Value, cbbMaKh.Text, cbbMaPhong.Text, NgayDi.Value);
            ob1.Delete(txtSoHD.Text);
            Form1_Load(sender, e);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            KetNoi ob = new KetNoi();
            string sql = " select SoHD, TenKh, DiaChi, Gia, DATEDIFF(day,NgayHD, NgayDi) as SoNgay";
            sql += " from HoaDon, KhachHang, Phong where HoaDon.MaKh = KhachHang.MaKh and HoaDon.MaPhong = Phong.MaPhong  ";
            DataTable dt = new DataTable();
            dt = ob.Load(sql);
            // Dat report lam nguon cho reportviewer
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"E:\hoc Csharp\QLKS_Ktra02\QLKS_Ktra02\ThongKe.rdlc";
            //Dat dataset lam nguon cho report
            ReportDataSource rps = new ReportDataSource();
            //Go ten dataset
            rps.Name = "ThongKe";
            rps.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rps);
            reportViewer1.RefreshReport();

        }

        private void Chon_HD(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtSoHD.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            NgayHD.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            cbbMaKh.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            cbbMaPhong.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            NgayDi.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }
        
    }
}
