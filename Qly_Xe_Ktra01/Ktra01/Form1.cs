using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ktra01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XEBUS[] xe = new XEBUS[1000];
        int n;
        int index;

        private void btnThem_Click(object sender, EventArgs e)
        {
            xe[n] = new XEBUS(txtHangSx.Text, int.Parse(txtSoGhe.Text), float.Parse(txtGiaChuaThue.Text), 
                int.Parse(txtSoTuyen.Text), float.Parse(txtTrongTai.Text));
            n++;
            txtHangSx.Clear();
            txtSoGhe.Clear();
            txtGiaChuaThue.Clear();
            txtSoTuyen.Clear();
            txtTrongTai.Clear();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            XEBUS ob = new XEBUS(txtHangSx.Text, int.Parse(txtSoGhe.Text), float.Parse(txtGiaChuaThue.Text),
                    int.Parse(txtSoTuyen.Text), float.Parse(txtTrongTai.Text));
            ob.Update(xe,ob.HangSx,n,ob);
            ob.Show(Lv1, xe, n);
            txtHangSx.Clear();
            txtSoGhe.Clear();
            txtGiaChuaThue.Clear();
            txtSoTuyen.Clear();
            txtTrongTai.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XEBUS ob = new XEBUS(txtHangSx.Text, int.Parse(txtSoGhe.Text), float.Parse(txtGiaChuaThue.Text),
                    int.Parse(txtSoTuyen.Text), float.Parse(txtTrongTai.Text));
            ob.Delete(xe,n,ob.HangSx);
            n--;
            ob.Show(Lv1, xe, n);
            txtHangSx.Clear();
            txtSoGhe.Clear();
            txtGiaChuaThue.Clear();
            txtSoTuyen.Clear();
            txtTrongTai.Clear();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            XEBUS ob = new XEBUS(txtHangSx.Text, int.Parse(txtSoGhe.Text), float.Parse(txtGiaChuaThue.Text),
                    int.Parse(txtSoTuyen.Text), float.Parse(txtTrongTai.Text));
            ob.Insert(xe, ob.HangSx, n,index, ob);
            ob.Show(Lv1, xe, n++);
            txtHangSx.Clear();
            txtSoGhe.Clear();
            txtGiaChuaThue.Clear();
            txtSoTuyen.Clear();
            txtTrongTai.Clear();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            XEBUS ob = new XEBUS();
            ob.Show(Lv1, xe, n);
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            XEBUS ob = new XEBUS();
            ob.SapXep(xe,n, ob);
            ob.Show(Lv1, xe, n);
           
        }

        private void Chon(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var xe = e.Item;
            txtHangSx.Text = xe.SubItems[0].Text;
            txtSoGhe.Text = xe.SubItems[1].Text;
            txtGiaChuaThue.Text = xe.SubItems[2].Text;
            txtSoTuyen.Text = xe.SubItems[3].Text;
            txtTrongTai.Text = xe.SubItems[4].Text;
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            XEBUS ob = new XEBUS();
            ob.TimKiem(xe,n, txtTk.Text, Lv1);
            ob.Show(Lv1, xe, n);


        }

    }
}
