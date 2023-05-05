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
    public partial class Form_HH : Form
    {
        public Form_HH()
        {
            InitializeComponent();
        }

        private void Form_HH_Load(object sender, EventArgs e)
        {
            HangHoa ob = new HangHoa();
            dataGridView1.DataSource = ob.Load_HH();
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtSoLg.Clear();
            txtDonGia.Clear();

        }

        private void Chon_HH(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaHang.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtTenHang.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtSoLg.Text= dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtDonGia.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }

        private void STT(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HangHoa ob = new HangHoa(txtMaHang.Text,txtTenHang.Text, float.Parse(txtSoLg.Text), float.Parse(txtDonGia.Text));
            ob.Insert(ob);
            Form_HH_Load(sender, e);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HangHoa ob = new HangHoa(txtMaHang.Text, txtTenHang.Text, float.Parse(txtSoLg.Text), float.Parse(txtDonGia.Text));
            ob.Update(ob);
            Form_HH_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HangHoa ob = new HangHoa(txtMaHang.Text, txtTenHang.Text, float.Parse(txtSoLg.Text), float.Parse(txtDonGia.Text));
            ob.Delete(txtMaHang.Text);
            Form_HH_Load(sender, e);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
