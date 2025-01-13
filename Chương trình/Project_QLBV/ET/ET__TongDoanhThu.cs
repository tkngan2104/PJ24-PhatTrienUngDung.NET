using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__TongDoanhThu
    {
        private float tongDoanhThuThuoc;
        private float tongDoanhThuPT_XNCC;
        private float tongDoanhThuVienPhi;
        private float tongDoanhThuTienKham;
        private float tongTien;
        private float tongTienBHYTChiTra;
        private float tongTienConLai;
        private DateTime ngayXuatTK;

        public ET__TongDoanhThu(float tongDoanhThuThuoc, float tongDoanhThuPT_XNCC, float tongDoanhThuVienPhi, float tongDoanhThuTienKham, float tongTien, float tongTienBHYTChiTra, float tongTienConLai, DateTime ngayXuatTK)
        {
            this.tongDoanhThuThuoc = tongDoanhThuThuoc;
            this.tongDoanhThuPT_XNCC = tongDoanhThuPT_XNCC;
            this.tongDoanhThuVienPhi = tongDoanhThuVienPhi;
            this.tongDoanhThuTienKham = tongDoanhThuTienKham;
            this.tongTien = tongTien;
            this.tongTienBHYTChiTra = tongTienBHYTChiTra;
            this.tongTienConLai = tongTienConLai;
            this.ngayXuatTK = ngayXuatTK;
        }

        public float TongDoanhThuThuoc { get => tongDoanhThuThuoc; set => tongDoanhThuThuoc = value; }
        public float TongDoanhThuPT_XNCC { get => tongDoanhThuPT_XNCC; set => tongDoanhThuPT_XNCC = value; }
        public float TongDoanhThuVienPhi { get => tongDoanhThuVienPhi; set => tongDoanhThuVienPhi = value; }
        public float TongDoanhThuTienKham { get => tongDoanhThuTienKham; set => tongDoanhThuTienKham = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        public float TongTienBHYTChiTra { get => tongTienBHYTChiTra; set => tongTienBHYTChiTra = value; }
        public float TongTienConLai { get => tongTienConLai; set => tongTienConLai = value; }
        public DateTime NgayXuatTK { get => ngayXuatTK; set => ngayXuatTK = value; }
    }
}
