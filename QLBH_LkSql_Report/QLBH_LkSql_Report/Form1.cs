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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bảngKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_KH f = new Form_KH();
            f.Show();
        }

        private void bảngHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_HH f = new Form_HH();
            f.Show();
        }

        private void bảngHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_HD f = new Form_HD();
            f.Show();
        }

        private void báoCáoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bao_Cao_Hoa_Don f = new Bao_Cao_Hoa_Don();
            f.Show();
        }
    }
}
