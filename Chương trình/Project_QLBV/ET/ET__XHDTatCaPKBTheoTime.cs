using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__XHDTatCaPKBTheoTime
    {
        private string maHD;
        public string MSPhieuKhamBenh { get; set; }
        public string MaHD { get => maHD; set => maHD = value; }
        public DateTime NgayXuatHD { get => ngayXuatHD; set => ngayXuatHD = value; }
        public float TienThuoc { get => tienThuoc; set => tienThuoc = value; }
        public float TienKham { get => tienKham; set => tienKham = value; }
        public float TienGiuong { get => tienGiuong; set => tienGiuong = value; }
        public float TienPT_XNCC { get => tienPT_XNCC; set => tienPT_XNCC = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        public float TienBHYTChiTra { get => tienBHYTChiTra; set => tienBHYTChiTra = value; }
        public float TongTienSauKhiDaGiam { get => tongTienSauKhiDaGiam; set => tongTienSauKhiDaGiam = value; }

        private DateTime ngayXuatHD;
        private float tienThuoc;
        private float tienKham;
        private float tienGiuong;
        private float tienPT_XNCC;
        private float tongTien;
        private float tienBHYTChiTra;
        private float tongTienSauKhiDaGiam;

        public ET__XHDTatCaPKBTheoTime(string maHD, string mSPhieuKhamBenh, DateTime ngayXuatHD, float tienThuoc, float tienKham, float tienGiuong, float tienPT_XNCC, float tongTien, float tienBHYTChiTra, float tongTienSauKhiDaGiam)
        {
            this.maHD = maHD;
            MSPhieuKhamBenh = mSPhieuKhamBenh;
            this.ngayXuatHD = ngayXuatHD;
            this.tienThuoc = tienThuoc;
            this.tienKham = tienKham;
            this.tienGiuong = tienGiuong;
            this.tienPT_XNCC = tienPT_XNCC;
            this.tongTien = tongTien;
            this.tienBHYTChiTra = tienBHYTChiTra;
            this.tongTienSauKhiDaGiam = tongTienSauKhiDaGiam;
        }
    }
}
