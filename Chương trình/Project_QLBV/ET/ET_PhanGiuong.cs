using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_PhanGiuong
    {
        private string maYC, maGiuong;
        private DateTime ngayNhanGiuong, ngayTraGiuong;
        private string msPhieuKhamBenh, maLoaiBA, maLoaiChiTietDV;

        public ET_PhanGiuong(string maYC, string maGiuong, DateTime ngayNhanGiuong, DateTime ngayTraGiuong, string msPhieuKhamBenh, string maLoaiBA, string maLoaiChiTietDV)
        {
            this.maYC = maYC;
            this.maGiuong = maGiuong;
            this.ngayNhanGiuong = ngayNhanGiuong;
            this.ngayTraGiuong = ngayTraGiuong;
            this.msPhieuKhamBenh = msPhieuKhamBenh;
            this.maLoaiBA = maLoaiBA;
            this.maLoaiChiTietDV = maLoaiChiTietDV;
        }

        public string MaYC { get => maYC; set => maYC = value; }
        public string MaGiuong { get => maGiuong; set => maGiuong = value; }
        public DateTime NgayNhanGiuong { get => ngayNhanGiuong; set => ngayNhanGiuong = value; }
        public DateTime NgayTraGiuong { get => ngayTraGiuong; set => ngayTraGiuong = value; }
        public string MsPhieuKhamBenh { get => msPhieuKhamBenh; set => msPhieuKhamBenh = value; }
        public string MaLoaiBA { get => maLoaiBA; set => maLoaiBA = value; }
        public string MaLoaiChiTietDV { get => maLoaiChiTietDV; set => maLoaiChiTietDV = value; }
    }
}
