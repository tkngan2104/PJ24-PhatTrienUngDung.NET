using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_DangKyKham
    {
        private string maYeuCau, maPhieuKham, maPhong, maNVYeuCau, maNgPhuTrach;

        public ET_DangKyKham(string maYeuCau, string maPhieuKham, string maPhong, string maNVYeuCau, string maNgPhuTrach)
        {
            this.maYeuCau = maYeuCau;
            this.maPhieuKham = maPhieuKham;
            this.maPhong = maPhong;
            this.maNVYeuCau = maNVYeuCau;
            this.maNgPhuTrach = maNgPhuTrach;
        }

        public string MaYeuCau { get => maYeuCau; set => maYeuCau = value; }
        public string MaPhieuKham { get => maPhieuKham; set => maPhieuKham = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaNVYeuCau { get => maNVYeuCau; set => maNVYeuCau = value; }
        public string MaNgPhuTrach { get => maNgPhuTrach; set => maNgPhuTrach = value; }
    }
}
