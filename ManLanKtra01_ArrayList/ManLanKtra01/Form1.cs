using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ManLanKtra01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList xe = new ArrayList();
        int index;

        private void btnSua_Click(object sender, EventArgs e)
        {
            XEBUS ob = new XEBUS(txtHangSx.Text, int.Parse(txtSoGhe.Text), float.Parse(txtGiaChuaThue.Text),
            int.Parse(txtSoTuyen.Text), float.Parse(txtTrongTai.Text));
            xe.RemoveAt(index);
            xe.Insert(index, ob);
            txtHangSx.Clear();
            txtSoGhe.Clear();
            txtGiaChuaThue.Clear();
            txtSoTuyen.Clear();
            txtTrongTai.Clear();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xe.RemoveAt(index);
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
            xe.Insert(index, ob);
            txtHangSx.Clear();
            txtSoGhe.Clear();
            txtGiaChuaThue.Clear();
            txtSoTuyen.Clear();
            txtTrongTai.Clear();

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            Lv1.Items.Clear();
            string[] arr = new string[6];
            ListViewItem lvitem;
            foreach (XEBUS item in xe)
            {
                arr[0] = item.HangSx;
                arr[1] = item.SoGhe.ToString();
                arr[2] = item.GiaChuaThue.ToString();
                arr[3] = item.SoTuyen.ToString();
                arr[4] = item.TrongTai.ToString();
                lvitem = new ListViewItem(arr);
                Lv1.Items.Add(lvitem);

            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            xe.Sort(new XEBUS());
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            XEBUS ob = new XEBUS(txtHangSx.Text, int.Parse(txtSoGhe.Text), float.Parse(txtGiaChuaThue.Text),
            int.Parse(txtSoTuyen.Text), float.Parse(txtTrongTai.Text));
            ob.Ghi_File(txtFilename.Text);
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            xe.IndexOf(txtTk == txtHangSx);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XEBUS ob = new XEBUS(txtHangSx.Text, int.Parse(txtSoGhe.Text), float.Parse(txtGiaChuaThue.Text),
            int.Parse(txtSoTuyen.Text), float.Parse(txtTrongTai.Text));
            xe.Add(ob);
            txtHangSx.Clear();
            txtSoGhe.Clear();
            txtGiaChuaThue.Clear();
            txtSoTuyen.Clear();
            txtTrongTai.Clear();

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var xe = e.Item;
            txtHangSx.Text = xe.SubItems[0].Text;
            txtSoGhe.Text = xe.SubItems[1].Text;
            txtGiaChuaThue.Text = xe.SubItems[2].Text;
            txtSoTuyen.Text = xe.SubItems[3].Text;
            txtTrongTai.Text = xe.SubItems[4].Text;

        }

        private void Lv1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }






    }
}
