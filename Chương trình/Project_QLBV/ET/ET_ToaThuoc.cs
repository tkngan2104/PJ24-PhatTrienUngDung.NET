using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ToaThuoc
    {
        private string maToaThuoc, maChuanDoan, msPhieuKhamBenh, msThuoc;
        private int soLuong;
        private float giaTien;
        private DateTime ngayCap;
        private string huongDanSD, maNV;
        public ET_ToaThuoc(string maToaThuoc, string maChuanDoan, string msPhieuKhamBenh, string msThuoc, int soLuong, float giaTien, DateTime ngayCap, string huongDanSD, string maNV)
        {
            this.maToaThuoc = maToaThuoc;
            this.maChuanDoan = maChuanDoan;
            this.msPhieuKhamBenh = msPhieuKhamBenh;
            this.msThuoc = msThuoc;
            this.soLuong = soLuong;
            this.giaTien = giaTien;
            this.ngayCap = ngayCap;
            this.huongDanSD = huongDanSD;
            this.maNV = maNV;
        }

        public string MaToaThuoc { get => maToaThuoc; set => maToaThuoc = value; }
        public string MaChuanDoan { get => maChuanDoan; set => maChuanDoan = value; }
        public string MsPhieuKhamBenh { get => msPhieuKhamBenh; set => msPhieuKhamBenh = value; }
        public string MsThuoc { get => msThuoc; set => msThuoc = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float GiaTien { get => giaTien; set => giaTien = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string HuongDanSD { get => huongDanSD; set => huongDanSD = value; }
        public string MaNV { get => maNV; set => maNV = value; }
    }
}
