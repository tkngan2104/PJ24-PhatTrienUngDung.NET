using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__XHDXetNghiemPhauThuat
    {
        private string tenPhongPT_XNCC;
        private DateTime thoiGianThucHien;
        private string ketQua;
        private float gia;
        private string tenLoaiChiTietDV;
        private float tienPT_XNCC;
        public string MSPhieuKhamBenh { get; set; }

        public ET__XHDXetNghiemPhauThuat(string tenPhongPT_XNCC, DateTime thoiGianThucHien, string ketQua, float gia, string tenLoaiChiTietDV, float tienPT_XNCC)
        {
            this.tenPhongPT_XNCC = tenPhongPT_XNCC;
            this.thoiGianThucHien = thoiGianThucHien;
            this.ketQua = ketQua;
            this.gia = gia;
            this.tenLoaiChiTietDV = tenLoaiChiTietDV;
            this.tienPT_XNCC = tienPT_XNCC;
        }

        public ET__XHDXetNghiemPhauThuat(string tenPhongPT_XNCC, DateTime thoiGianThucHien, string ketQua, float gia, string tenLoaiChiTietDV, float tienPT_XNCC, string mSPhieuKhamBenh)
        {
            this.tenPhongPT_XNCC = tenPhongPT_XNCC;
            this.thoiGianThucHien = thoiGianThucHien;
            this.ketQua = ketQua;
            this.gia = gia;
            this.tenLoaiChiTietDV = tenLoaiChiTietDV;
            this.tienPT_XNCC = tienPT_XNCC;
            this.MSPhieuKhamBenh = mSPhieuKhamBenh;
        }

        public string TenPhongPT_XNCC { get => tenPhongPT_XNCC; set => tenPhongPT_XNCC = value; }
        public DateTime ThoiGianThucHien { get => thoiGianThucHien; set => thoiGianThucHien = value; }
        public string KetQua { get => ketQua; set => ketQua = value; }
        public float Gia { get => gia; set => gia = value; }
        public string TenLoaiChiTietDV { get => tenLoaiChiTietDV; set => tenLoaiChiTietDV = value; }
        public float TienPT_XNCC { get => tienPT_XNCC; set => tienPT_XNCC = value; }
    }
}
