using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_XetNghiemPhauThuat
    {
        private string msPhieuKhamBenh, maYC, maNV, msPhong, maLoaiChiTietDV;
        private DateTime thoiGianThucHien;
        private string ketQua, mucDoRuiRo, loai, maLoaiBA;

        public ET_XetNghiemPhauThuat(string msPhieuKhamBenh, string maYC, string maNV, string msPhong, string maLoaiChiTietDV, DateTime thoiGianThucHien, string ketQua, string mucDoRuiRo, string loai, string maLoaiBA)
        {
            this.msPhieuKhamBenh = msPhieuKhamBenh;
            this.maYC = maYC;
            this.maNV = maNV;
            this.msPhong = msPhong;
            this.maLoaiChiTietDV = maLoaiChiTietDV;
            this.thoiGianThucHien = thoiGianThucHien;
            this.ketQua = ketQua;
            this.mucDoRuiRo = mucDoRuiRo;
            this.loai = loai;
            this.maLoaiBA = maLoaiBA;
        }

        public string MsPhieuKhamBenh { get => msPhieuKhamBenh; set => msPhieuKhamBenh = value; }
        public string MaYC { get => maYC; set => maYC = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MsPhong { get => msPhong; set => msPhong = value; }
        public string MaLoaiChiTietDV { get => maLoaiChiTietDV; set => maLoaiChiTietDV = value; }
        public DateTime ThoiGianThucHien { get => thoiGianThucHien; set => thoiGianThucHien = value; }
        public string KetQua { get => ketQua; set => ketQua = value; }
        public string MucDoRuiRo { get => mucDoRuiRo; set => mucDoRuiRo = value; }
        public string Loai { get => loai; set => loai = value; }
        public string MaLoaiBA { get => maLoaiBA; set => maLoaiBA = value; }
    }
}
