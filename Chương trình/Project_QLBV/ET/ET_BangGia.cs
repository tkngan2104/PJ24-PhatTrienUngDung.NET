using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_BangGia
    {
        private string maDV, tenDV;
        private float gia;
        private string maKhoa, loaiPT_XNCC;

        public ET_BangGia(string maDV, string tenDV, float gia, string maKhoa, string loaiPT_XNCC)
        {
            this.maDV = maDV;
            this.tenDV = tenDV;
            this.gia = gia;
            this.maKhoa = maKhoa;
            this.loaiPT_XNCC = loaiPT_XNCC;
        }

        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public float Gia { get => gia; set => gia = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string LoaiPT_XNCC { get => loaiPT_XNCC; set => loaiPT_XNCC = value; }
    }
}
