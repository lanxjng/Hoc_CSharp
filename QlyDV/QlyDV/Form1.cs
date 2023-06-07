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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nhậpDLBảngKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            f.Show();

        }

        private void nhậpDLBảngChứngTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChungTu f = new ChungTu();
            f.Show();

        }

        private void inBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậpDLBảngDịchVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DichVu f = new DichVu();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inBáoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BaoCao f = new BaoCao();
            f.Show();
            
           
        }
    }
}
