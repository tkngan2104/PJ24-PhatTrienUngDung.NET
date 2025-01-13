using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__LayTinhTrangSucKhoe
    {
        public string MSPhieuKhamBenh { get; set; }
        public string MSBN { get; set; }
        public string TenBN { get => tenBN; set => tenBN = value; }
        public string TenBenh { get => tenBenh; set => tenBenh = value; }
        public string TinhTrangPhauThuat { get => tinhTrangPhauThuat; set => tinhTrangPhauThuat = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        private string tenBN;
        private string tenBenh;
        private string tinhTrangPhauThuat;
        private string gioiTinh;

        public ET__LayTinhTrangSucKhoe(string phieuKhamBenh, string mSBN, string tenBN, string tenBenh, string tinhTrangPhauThuat, string gioiTinh)
        {
            MSPhieuKhamBenh = phieuKhamBenh;
            MSBN = mSBN;
            this.tenBN = tenBN;
            this.tenBenh = tenBenh;
            this.tinhTrangPhauThuat = tinhTrangPhauThuat;
            this.gioiTinh = gioiTinh;
        }
    }
}
