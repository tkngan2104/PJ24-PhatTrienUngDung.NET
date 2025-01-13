using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__LayThongTinBenhNhan
    {
        public string MSBN { get; set; }
        private string tenBN;
        private string diaChi;
        private string maSoBHYT;
        private string gioiTinh;

        public ET__LayThongTinBenhNhan(string MSBN, string tenBN, string diaChi, string maSoBHYT, string gioiTinh)
        {
            this.MSBN = MSBN;
            this.tenBN = tenBN;
            this.diaChi = diaChi;
            this.maSoBHYT = maSoBHYT;
            this.gioiTinh = gioiTinh;
        }

        public string TenBN { get => tenBN; set => tenBN = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaSoBHYT { get => maSoBHYT; set => maSoBHYT = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
