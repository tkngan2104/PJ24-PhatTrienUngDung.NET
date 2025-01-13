using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_DamNhanChuyenMon
    {
        private string maCN, maNV, kinhNghiem;

        public ET_DamNhanChuyenMon(string maCN, string maNV, string kinhNghiem)
        {
            this.maCN = maCN;
            this.maNV = maNV;
            this.kinhNghiem = kinhNghiem;
        }

        public string MaCN { get => maCN; set => maCN = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string KinhNghiem { get => kinhNghiem; set => kinhNghiem = value; }
    }
}
