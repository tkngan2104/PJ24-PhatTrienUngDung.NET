using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_HoaDon
    {
        public string MSPhieuKhamBenh { get; set; }
        private string maHD;
        private DateTime ngayXuatHD;
        private float tienThuoc, tienKham, tienGiuong, tienPT_XNCC, tongTien;

        public ET_HoaDon(string mSPhieuKhamBenh, string maHD, DateTime ngayXuatHD, float tienThuoc, float tienKham, float tienGiuong, float tienPT_XNCC, float tongTien, float tienBHYTChiTra, float tongTienSauKhiGiam)
        {
            MSPhieuKhamBenh = mSPhieuKhamBenh;
            this.maHD = maHD;
            this.ngayXuatHD = ngayXuatHD;
            this.tienThuoc = tienThuoc;
            this.tienKham = tienKham;
            this.tienGiuong = tienGiuong;
            this.tienPT_XNCC = tienPT_XNCC;
            this.tongTien = tongTien;
            TienBHYTChiTra = tienBHYTChiTra;
            TongTienSauKhiGiam = tongTienSauKhiGiam;
        }

        public float TienBHYTChiTra { get; set; }
        public float TongTienSauKhiGiam { get; set; }
        public string MaHD { get => maHD; set => maHD = value; }
        public DateTime NgayXuatHD { get => ngayXuatHD; set => ngayXuatHD = value; }
        public float TienThuoc { get => tienThuoc; set => tienThuoc = value; }
        public float TienKham { get => tienKham; set => tienKham = value; }
        public float TienGiuong { get => tienGiuong; set => tienGiuong = value; }
        public float TienPT_XNCC { get => tienPT_XNCC; set => tienPT_XNCC = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
