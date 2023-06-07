using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLBH_On
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
            cbbMaSp.DataSource = ob.Load_SanPham();
            cbbMaSp.ValueMember = "MaSp";
            txtSoLg.Clear();
            txtDonGia.Clear();
            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chon_Hd(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaHd.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            cbbMaKh.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            cbbMaKh.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtSoLg.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtDonGia.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HoaDon ob = new HoaDon(txtMaHd.Text, cbbMaSp.Text, cbbMaKh.Text, float.Parse(txtSoLg.Text), float.Parse(txtDonGia.Text));
            ob.Insert(ob);
            Form1_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HoaDon ob = new HoaDon(txtMaHd.Text, cbbMaSp.Text, cbbMaKh.Text, float.Parse(txtSoLg.Text), float.Parse(txtDonGia.Text));
            ob.Update(ob);
            Form1_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HoaDon ob = new HoaDon(txtMaHd.Text, cbbMaSp.Text, cbbMaKh.Text, float.Parse(txtSoLg.Text), float.Parse(txtDonGia.Text));
            ob.Delete(txtSoLg.Text);
            Form1_Load(sender, e);

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            KetNoi ob = new KetNoi();
            string sql = " select MaHoaDon, HoTen, DiaChi, TenSp, HoaDon.SoLg, HoaDon.DonGia";
            sql += " from HoaDon, KhachHang, SanPham where HoaDon.MaKh = KhachHang.MaKh and HoaDon.MaSp = SanPham.MaSp and HoaDon.MaHoaDon = '"+ txtTK.Text +"'  ";
            DataTable dt = new DataTable();
            dt = ob.Load(sql);
            // Dat report lam nguon cho reportviewer
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"E:\hoc Csharp\C_Sharp_Cua_Lan\QLBH_On\QLBH_On\InHoaDon.rdlc";
            //Dat dataset lam nguon cho report
            ReportDataSource rps = new ReportDataSource();
            //Go ten dataset
            rps.Name = "InHoaDon";
            rps.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rps);
            reportViewer1.RefreshReport();


        }
    }
}
