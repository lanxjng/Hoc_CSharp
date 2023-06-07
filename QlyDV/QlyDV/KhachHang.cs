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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void Chon_KH(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaKh.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtTenKh.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            KH ob = new KH();
            dataGridView1.DataSource = ob.Load_KH();
            txtMaKh.Clear();
            txtTenKh.Clear();
            txtDiaChi.Clear();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KH ob = new KH(txtMaKh.Text, txtTenKh.Text,txtDiaChi.Text);
            ob.Insert(ob);
            KhachHang_Load(sender, e); 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KH ob = new KH(txtMaKh.Text, txtTenKh.Text, txtDiaChi.Text);
            ob.Update(ob);
            KhachHang_Load(sender, e); 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KH ob = new KH(txtMaKh.Text, txtTenKh.Text, txtDiaChi.Text);
            ob.Delete(txtMaKh.Text);
            KhachHang_Load(sender, e); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
