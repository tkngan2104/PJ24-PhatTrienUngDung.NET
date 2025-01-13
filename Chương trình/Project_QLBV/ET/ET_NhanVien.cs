using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NhanVien
    {
        private string maNV, tenNV, gioiTinh, soDT, email;
        private DateTime ngayBatDauLam;
        private string maKhoa, maCV;

        public ET_NhanVien(string maNV, string tenNV, string gioiTinh, string soDT, string email, DateTime ngayBatDauLam, string maKhoa, string maCV)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.gioiTinh = gioiTinh;
            this.soDT = soDT;
            this.email = email;
            this.ngayBatDauLam = ngayBatDauLam;
            this.maKhoa = maKhoa;
            this.maCV = maCV;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Email { get => email; set => email = value; }
        public DateTime NgayBatDauLam { get => ngayBatDauLam; set => ngayBatDauLam = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string MaCV { get => maCV; set => maCV = value; }
    }
}
