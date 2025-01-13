using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__LichSuKham
    {
        private string tenPhong;
        private string maNV;
        private string maNguoiYC;
        public string MSPhieuKhamBenh { get; set; }
        public ET__LichSuKham(string tenPhong, string maNV, string maNguoiYC)
        {
            this.tenPhong = tenPhong;
            this.maNV = maNV;
            this.maNguoiYC = maNguoiYC;
        }

        public ET__LichSuKham(string tenPhong, string maNV, string maNguoiYC, string mSPhieuKhamBenh)
        {
            this.tenPhong = tenPhong;
            this.maNV = maNV;
            this.maNguoiYC = maNguoiYC;
            MSPhieuKhamBenh = mSPhieuKhamBenh;
        }

        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaNguoiYC { get => maNguoiYC; set => maNguoiYC = value; }
    }
}
