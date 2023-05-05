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
    public partial class Form_KH : Form
    {
        public Form_KH()
        {
            InitializeComponent();
        }

        private void Form_KH_Load(object sender, EventArgs e)
        {
            Khachhang ob = new Khachhang();
            dataGridView1.DataSource = ob.Load_KH();
            txtMaKh.Clear();
            txtHoTen.Clear();
        }

        private void Chon_KH(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaKh.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            NgaySinh.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
        }

        private void STT(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Khachhang ob = new Khachhang(txtMaKh.Text, txtHoTen.Text, NgaySinh.Value);
            ob.Insert(ob);
            Form_KH_Load(sender, e);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Khachhang ob = new Khachhang(txtMaKh.Text, txtHoTen.Text, NgaySinh.Value);
            ob.Update(ob);
            Form_KH_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Khachhang ob = new Khachhang(txtMaKh.Text, txtHoTen.Text, NgaySinh.Value);
            ob.Delete(txtMaKh.Text);
            Form_KH_Load(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
