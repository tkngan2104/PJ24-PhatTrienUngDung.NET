using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__DoanhThu
    {
        private string msPhieuKhamBenh;
        private int soBenhNhan;
        private float tienPT_XNCC;
        private float tienThuoc;
        private float tienGiuong;
        private float tienKham;
        private float tienBHYTChiTra;
        private float tongTienTamThoi;
        private float tongTienSauKhiDaGiam;

        public ET__DoanhThu(string msPhieuKhamBenh, int soBenhNhan, float tienPT_XNCC, float tienThuoc, float tienGiuong, float tienKham, float tienBHYTChiTra, float tongTienTamThoi, float tongTienSauKhiDaGiam)
        {
            this.msPhieuKhamBenh = msPhieuKhamBenh;
            this.soBenhNhan = soBenhNhan;
            this.tienPT_XNCC = tienPT_XNCC;
            this.tienThuoc = tienThuoc;
            this.tienGiuong = tienGiuong;
            this.tienKham = tienKham;
            this.tienBHYTChiTra = tienBHYTChiTra;
            this.tongTienTamThoi = tongTienTamThoi;
            this.tongTienSauKhiDaGiam = tongTienSauKhiDaGiam;
        }

        public string MsPhieuKhamBenh { get => msPhieuKhamBenh; set => msPhieuKhamBenh = value; }
        public int SoBenhNhan { get => soBenhNhan; set => soBenhNhan = value; }
        public float TienPT_XNCC { get => tienPT_XNCC; set => tienPT_XNCC = value; }
        public float TienThuoc { get => tienThuoc; set => tienThuoc = value; }
        public float TienGiuong { get => tienGiuong; set => tienGiuong = value; }
        public float TienKham { get => tienKham; set => tienKham = value; }
        public float TienBHYTChiTra { get => tienBHYTChiTra; set => tienBHYTChiTra = value; }
        public float TongTienTamThoi { get => tongTienTamThoi; set => tongTienTamThoi = value; }
        public float TongTienSauKhiDaGiam { get => tongTienSauKhiDaGiam; set => tongTienSauKhiDaGiam = value; }
    }
}
