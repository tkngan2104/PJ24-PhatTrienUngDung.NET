using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__DSBenhNhanChuaTri
    {
        public string MSBN { get; set; }
        private string tenBN;
        private string diaChi;
        private string maSoBHYT;
        private string gioiTinh;
        private string trieuChung;
        private string benhNen;
        private string tenBenh;
        private string ketLuan;
        private string loiKhuyen;
        public string MSPhieuKhamBenh { get; set; }

        public ET__DSBenhNhanChuaTri(string mSBN, string tenBN, string diaChi, string maSoBHYT, string gioiTinh, string trieuChung, string benhNen, string tenBenh, string ketLuan, string loiKhuyen)
        {
            this.MSBN = mSBN;
            this.tenBN = tenBN;
            this.diaChi = diaChi;
            this.maSoBHYT = maSoBHYT;
            this.gioiTinh = gioiTinh;
            this.trieuChung = trieuChung;
            this.benhNen = benhNen;
            this.tenBenh = tenBenh;
            this.ketLuan = ketLuan;
            this.loiKhuyen = loiKhuyen;
        }

        public ET__DSBenhNhanChuaTri(string mSBN, string tenBN, string diaChi, string maSoBHYT, string gioiTinh, string trieuChung, string benhNen, string tenBenh, string ketLuan, string loiKhuyen, string mSPhieuKhamBenh)
        {
            this.MSBN = mSBN;
            this.tenBN = tenBN;
            this.diaChi = diaChi;
            this.maSoBHYT = maSoBHYT;
            this.gioiTinh = gioiTinh;
            this.trieuChung = trieuChung;
            this.benhNen = benhNen;
            this.tenBenh = tenBenh;
            this.ketLuan = ketLuan;
            this.loiKhuyen = loiKhuyen;
            this.MSPhieuKhamBenh = mSPhieuKhamBenh;
        }

        public string TenBN { get => tenBN; set => tenBN = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaSoBHYT { get => maSoBHYT; set => maSoBHYT = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string TrieuChung { get => trieuChung; set => trieuChung = value; }
        public string BenhNen { get => benhNen; set => benhNen = value; }
        public string TenBenh { get => tenBenh; set => tenBenh = value; }
        public string KetLuan { get => ketLuan; set => ketLuan = value; }
        public string LoiKhuyen { get => loiKhuyen; set => loiKhuyen = value; }
    }
}
