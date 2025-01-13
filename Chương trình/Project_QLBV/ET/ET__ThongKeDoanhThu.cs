using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__ThongKeDoanhThu
    {
        private float tongTienThuoc;
        private float tongTienPT_XNCC;
        private float tongTienGB;
        private float tongTienKham;
        private float tienBHYTChiTra;
        private float tongTien;
        private float tongTienSauKhiDaGiam;

        public ET__ThongKeDoanhThu(float tongTienThuoc, float tongTienPT_XNCC, float tongTienGB, float tongTienKham, float tienBHYTChiTra, float tongTien, float tongTienSauKhiDaGiam)
        {
            this.tongTienThuoc = tongTienThuoc;
            this.tongTienPT_XNCC = tongTienPT_XNCC;
            this.tongTienGB = tongTienGB;
            this.tongTienKham = tongTienKham;
            this.tienBHYTChiTra = tienBHYTChiTra;
            this.tongTien = tongTien;
            this.tongTienSauKhiDaGiam = tongTienSauKhiDaGiam;
        }

        public float TongTienThuoc { get => tongTienThuoc; set => tongTienThuoc = value; }
        public float TongTienPT_XNCC { get => tongTienPT_XNCC; set => tongTienPT_XNCC = value; }
        public float TongTienGB { get => tongTienGB; set => tongTienGB = value; }
        public float TongTienKham { get => tongTienKham; set => tongTienKham = value; }
        public float TienBHYTChiTra { get => tienBHYTChiTra; set => tienBHYTChiTra = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        public float TongTienSauKhiDaGiam { get => tongTienSauKhiDaGiam; set => tongTienSauKhiDaGiam = value; }
    }
}
