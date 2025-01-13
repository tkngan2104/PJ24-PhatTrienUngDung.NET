using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__XDSBenhNhanNoiTru
    {
        public string MSBN { get; set; }
        private string tenBN;
        private string gioiTinh;
        public DateTime NgSinh { get; set; }
        public string SDT { get; set; }
        private string maSoBHYT;
        private DateTime ngayNhanGiuong;
        private DateTime ngayTraGiuong;
        private string tenBenh;
        private string tenPhong;
        private string maGiuong;
        private string benhNen;
        private string trangThaiXuatVien;
        private int tongSoCa;
        public string MaNV { get; set; }
        public string MSPhieuKhamBenh { get; set; }
        public string TenBN { get => tenBN; set => tenBN = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string MaSoBHYT { get => maSoBHYT; set => maSoBHYT = value; }
        public DateTime NgayNhanGiuong { get => ngayNhanGiuong; set => ngayNhanGiuong = value; }
        public DateTime NgayTraGiuong { get => ngayTraGiuong; set => ngayTraGiuong = value; }
        public string TenBenh { get => tenBenh; set => tenBenh = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string MaGiuong { get => maGiuong; set => maGiuong = value; }
        public string BenhNen { get => benhNen; set => benhNen = value; }
        public string TrangThaiXuatVien { get => trangThaiXuatVien; set => trangThaiXuatVien = value; }
        public int TongSoCa { get => tongSoCa; set => tongSoCa = value; }

        public ET__XDSBenhNhanNoiTru(string mSBN, string tenBN, string gioiTinh, DateTime ngSinh, string sDT, string maSoBHYT, DateTime ngayNhanGiuong, DateTime ngayTraGiuong, string tenBenh, string tenPhong, string maGiuong, string benhNen, string trangThaiXuatVien, int tongSoCa, string maNV, string mSPhieuKhamBenh)
        {
            MSBN = mSBN;
            this.tenBN = tenBN;
            this.gioiTinh = gioiTinh;
            NgSinh = ngSinh;
            SDT = sDT;
            this.maSoBHYT = maSoBHYT;
            this.ngayNhanGiuong = ngayNhanGiuong;
            this.ngayTraGiuong = ngayTraGiuong;
            this.tenBenh = tenBenh;
            this.tenPhong = tenPhong;
            this.maGiuong = maGiuong;
            this.benhNen = benhNen;
            this.trangThaiXuatVien = trangThaiXuatVien;
            this.tongSoCa = tongSoCa;
            MaNV = maNV;
            MSPhieuKhamBenh = mSPhieuKhamBenh;
        }
    }
}
