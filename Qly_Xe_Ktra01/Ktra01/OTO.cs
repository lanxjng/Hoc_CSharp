using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;



namespace Ktra01
{
    class OTO
    {
        public string HangSx { get; set; }
        public int SoGhe { get; set; }
        public float GiaChuaThue { get; set; }

        public OTO() { }
        public OTO(string HangSx, int SoGhe, float GiaChuaThue)
        {
            this.HangSx = HangSx;
            this.SoGhe = SoGhe;
            this.GiaChuaThue = GiaChuaThue;
        }
    }
    class XEBUS : OTO
    {
        public int SoTuyen { get; set; }
        public float TrongTai { get; set; }
        public XEBUS() { }
        public XEBUS(string HangSx, int SoGhe, float GiaChuaThue, int SoTuyen, float TrongTai)
            : base(HangSx, SoGhe, GiaChuaThue)
        {
            this.SoTuyen = SoTuyen;
            this.TrongTai = TrongTai;
        }

        public double GiaSauThue()
        {
            return (GiaChuaThue * 1.12);
        }
        public void Show (ListView lv, XEBUS[] xe, int n)
        {
            lv.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                lv.Items.Add(xe[i].HangSx);
                lv.Items[i].SubItems.Add(xe[i].SoGhe.ToString());
                lv.Items[i].SubItems.Add(xe[i].GiaChuaThue.ToString());
                lv.Items[i].SubItems.Add(xe[i].SoTuyen.ToString());
                lv.Items[i].SubItems.Add(xe[i].TrongTai.ToString());
            }
        }

        public void Delete(XEBUS[] xe, int n, string HangSx)
        {
            int vt = 0;
            for (int i = 0; i < n; i++)
            {
                if (xe[i].HangSx == HangSx)
                {
                    vt = i;
                    break;
                }
            }
            for (int i = vt; i < n - 1; i++)
            {
                xe[i] = xe[i + 1];
            }
        }

        public void Update(XEBUS[] xe, string HangSx, int n, XEBUS sv1)
        {
            int vt = 0;
            int i;
            for (i = 0; i < n; i++)
            {
                if (xe[i].HangSx.Equals(HangSx))
                {
                    vt = i; break;
                }
            }
            xe[vt] = sv1;
        }
        public int Insert(XEBUS[] xe, string HangSx, int n, int vt, XEBUS ob1)
        {
            vt = 0;
            int i;
            for (i = 0; i < n ; i++)
            {
                if (xe[i].HangSx.Equals(HangSx))
                {
                    vt = i; break;
                }
            }
            xe[vt] = ob1;
            return n++;
        }

        public void SapXep(XEBUS [] xe, int n, XEBUS ob)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (xe[j].TrongTai < xe[i].TrongTai)
                    {
                        ob = xe[i];
                        xe[i] = xe[j];
                        xe[j] = ob;
                    }
                }
            }
           
        }
        public void TimKiem(XEBUS[] xe, int n, string Tk, ListView lv)
        {

            lv.Items.Clear();
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (xe[i].Equals(Tk))
                {
                    lv.Items.Add(xe[i].HangSx);
                    lv.Items[j].SubItems.Add(xe[i].SoGhe.ToString());
                    lv.Items[j].SubItems.Add(xe[i].GiaChuaThue.ToString());
                    lv.Items[j].SubItems.Add(xe[i].SoTuyen.ToString());
                    lv.Items[j].SubItems.Add(xe[i].TrongTai.ToString());
                
                }
            }

        }




        public void Ghi_File(XEBUS [] xe, int n, ListView lv)
        {
            BinaryWriter bw = null;
            string kq = "";
            int j = 0;
            try
            {
                bw = new BinaryWriter(new FileStream(" Doc", FileMode.Create));

                for (int i = 1; i < n; i++)
                {
                    if (xe[i].TrongTai > 100 && xe[i].TrongTai < 200) 
                    {
                        kq += "Hang Sx :" + xe[i].HangSx + "; So ghe: " + xe[i].SoGhe.ToString() +";Gia chua thue: " 
                        + xe[i].GiaChuaThue.ToString() + "; So tuyen: "+ xe[i].SoTuyen.ToString() + "; Trong tai: " 
                        + xe[i].TrongTai.ToString();
                    }
                    else
                    {
                        lv.Items.Add(xe[j].HangSx);
                        lv.Items[j].SubItems.Add(xe[i].SoGhe.ToString());
                        lv.Items[j].SubItems.Add(xe[i].GiaChuaThue.ToString());
                        lv.Items[j].SubItems.Add(xe[i].SoTuyen.ToString());
                        lv.Items[j].SubItems.Add(xe[i].TrongTai.ToString());
                    j++;
                    }
                }
                bw.Write(kq);
                
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
            finally { bw.Close(); }
        }




    }
}
