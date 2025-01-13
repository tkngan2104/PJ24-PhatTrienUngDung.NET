using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__XHDToaThuoc
    {
        public ET__XHDToaThuoc(string tenThuoc, int soLuong, float donGia, float tien, float tienThuoc, string maNV, string hDSuDung)
        {
            TenThuoc = tenThuoc;
            SoLuong = soLuong;
            DonGia = donGia;
            Tien = tien;
            TienThuoc = tienThuoc;
            MaNV = maNV;
            HDSuDung = hDSuDung;
        }

        public ET__XHDToaThuoc(string tenThuoc, int soLuong, float donGia, float tien, float tienThuoc, string maNV, string hDSuDung, string tenBenh)
        {
            TenThuoc = tenThuoc;
            SoLuong = soLuong;
            DonGia = donGia;
            Tien = tien;
            TienThuoc = tienThuoc;
            MaNV = maNV;
            HDSuDung = hDSuDung;
            TenBenh = tenBenh;
        }

        public ET__XHDToaThuoc(string tenThuoc, int soLuong, float donGia, float tien, float tienThuoc, string maNV, string hDSuDung, string tenBenh, string mSPhieuKhamBenh)
        {
            TenThuoc = tenThuoc;
            SoLuong = soLuong;
            DonGia = donGia;
            Tien = tien;
            TienThuoc = tienThuoc;
            MaNV = maNV;
            HDSuDung = hDSuDung;
            TenBenh = tenBenh;
            MSPhieuKhamBenh = mSPhieuKhamBenh;
        }

        public string TenThuoc { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float Tien { get; set; }
        public float TienThuoc { get; set; }
        public string MaNV { get; set; }
        public string HDSuDung { get; set; }
        public string TenBenh { get; set; }
        public string MSPhieuKhamBenh { get; set; }
    }
}
