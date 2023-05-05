using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH_LkSql_Report
{
    public partial class Form_HD : Form
    {
        public Form_HD()
        {
            InitializeComponent();
        }

        private void Form_HD_Load(object sender, EventArgs e)
        {
            HoaDon ob = new HoaDon();
            dataGridView1.DataSource = ob.Load_HD();
            cbbMaKh.DataSource = ob.Load_KH();
            cbbMaKh.ValueMember = "MaKh";
            cbMaHang.DataSource = ob.Load_HH();
            cbMaHang.ValueMember = "MaHang";
            cbbMaKh.Text = "";
            cbMaHang.Text = "";
            txtSoLg.Clear();
            txtDonGia.Clear();
        }

        private void Chon_HD(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cbbMaKh.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            cbMaHang.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtSoLg.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtDonGia.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }

        private void STT(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HoaDon ob = new HoaDon(cbbMaKh.Text, cbMaHang.Text, float.Parse(txtSoLg.Text), float.Parse(txtDonGia.Text));
            ob.Insert(ob);
            Form_HD_Load(sender, e);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HoaDon ob = new HoaDon(cbbMaKh.Text, cbMaHang.Text, float.Parse(txtSoLg.Text), float.Parse(txtDonGia.Text));
            ob.Update(ob);
            Form_HD_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HoaDon ob = new HoaDon(cbbMaKh.Text, cbMaHang.Text, float.Parse(txtSoLg.Text), float.Parse(txtDonGia.Text));
            ob.Delete(txtSoLg.Text);
            Form_HD_Load(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
