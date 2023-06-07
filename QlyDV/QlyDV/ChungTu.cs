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
    public partial class ChungTu : Form
    {
        public ChungTu()
        {
            InitializeComponent();
        }

        private void ChungTu_Load(object sender, EventArgs e)
        {
            CT ob = new CT();
            dataGridView1.DataSource = ob.Load_CT();
            cbbMaKh.DataSource = ob.Load_KH();
            cbbMaKh.ValueMember = "MaKh";
            cbbMaDv.DataSource = ob.Load_DV();
            cbbMaDv.ValueMember = "MaDv";
            txtMaCt.Clear();
            txtSoLg.Clear();

        }

        private void Chon_CT(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaCt.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            cbbMaKh.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            cbbMaDv.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtSoLg.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CT ob = new CT(txtMaCt.Text, dateTimePicker1.Value, cbbMaKh.Text, cbbMaDv.Text, float.Parse(txtSoLg.Text));
            ob.Insert(ob);
            ChungTu_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CT ob = new CT(txtMaCt.Text, dateTimePicker1.Value, cbbMaKh.Text, cbbMaDv.Text, float.Parse(txtSoLg.Text));
            ob.Update(ob);
            ChungTu_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CT ob = new CT(txtMaCt.Text, dateTimePicker1.Value, cbbMaKh.Text, cbbMaDv.Text, float.Parse(txtSoLg.Text));
            ob.Delete(txtMaCt.Text);
            ChungTu_Load(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
