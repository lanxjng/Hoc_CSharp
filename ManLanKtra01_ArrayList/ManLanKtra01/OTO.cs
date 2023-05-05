using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManLanKtra01
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
}
