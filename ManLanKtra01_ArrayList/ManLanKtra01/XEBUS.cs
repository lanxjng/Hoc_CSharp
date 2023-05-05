using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace ManLanKtra01
{
    class XEBUS : OTO, IComparer
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
            return (GiaChuaThue*1.12);
        }

        public int Compare(object x, object y)
        {
            XEBUS p1 = x as XEBUS;
            XEBUS p2 = y as XEBUS;
            if (p1.TrongTai > p2.TrongTai)
            {
                return 1;
            }
            else if (p1.TrongTai == p2.TrongTai)
            {
                return 0;
            }
            else
                return -1;
        }



        public void Ghi_File(string filename)
        {
            BinaryWriter bw = null;
            int dem = 0;
            try
            {
                bw = new BinaryWriter(new FileStream(filename, FileMode.Create));

                for (int i = 1; i < filename.Length; i++)
                {
                    if (TrongTai > 100 && TrongTai < 200) dem++ ;
                }
                bw.Write(dem);
                for (int i = 1; i < filename.Length; i++)
                    if (TrongTai > 100 && TrongTai < 200) bw.Write(i) dem++;
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
            finally { bw.Close(); }
        }

        
        

    }
}
