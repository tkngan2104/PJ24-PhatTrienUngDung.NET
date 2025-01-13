using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_BenhNhan
    {
        private string maSoBN, tenBN, gioiTinh;
        private DateTime ngaySinh;
        private string diaChi, ngheNghiep, soDienThoai, cccd, ttLienHe;

        public ET_BenhNhan(string maSoBN, string tenBN, string gioiTinh, DateTime ngaySinh, string diaChi, string ngheNghiep, string soDienThoai, string cccd, string ttLienHe)
        {
            this.maSoBN = maSoBN;
            this.tenBN = tenBN;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.ngheNghiep = ngheNghiep;
            this.soDienThoai = soDienThoai;
            this.cccd = cccd;
            this.ttLienHe = ttLienHe;
        }

        public string MaSoBN { get => maSoBN; set => maSoBN = value; }
        public string TenBN { get => tenBN; set => tenBN = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string TtLienHe { get => ttLienHe; set => ttLienHe = value; }
    }
}
