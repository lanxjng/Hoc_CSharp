using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QlyDV
{
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            DV ob = new DV();
            dataGridView1.DataSource = ob.Load_DV();
            txtMaDv.Clear();
            txtTenDv.Clear();
            txtDonGia.Clear();

        }

        private void Chon_DV(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaDv.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtTenDv.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtDonGia.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DV ob = new DV(txtMaDv.Text, txtTenDv.Text, float.Parse(txtDonGia.Text));
            ob.Insert(ob);
            DichVu_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DV ob = new DV(txtMaDv.Text, txtTenDv.Text, float.Parse(txtDonGia.Text));
            ob.Update(ob);
            DichVu_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DV ob = new DV(txtMaDv.Text, txtTenDv.Text, float.Parse(txtDonGia.Text));
            ob.Delete(txtMaDv.Text);
            DichVu_Load(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
