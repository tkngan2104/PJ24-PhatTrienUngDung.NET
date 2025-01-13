using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_TheoDoiSucKhoe
    {
        private string maTheoDoi, maYC, maSoPKB, maNV;
        private DateTime ngayTheoDoi;
        private string tinhTrangSK, ghiChu;

        public ET_TheoDoiSucKhoe(string maTheoDoi, string maYC, string maSoPKB, string maNV, DateTime ngayTheoDoi, string tinhTrangSK, string ghiChu)
        {
            this.maTheoDoi = maTheoDoi;
            this.maYC = maYC;
            this.maSoPKB = maSoPKB;
            this.maNV = maNV;
            this.ngayTheoDoi = ngayTheoDoi;
            this.tinhTrangSK = tinhTrangSK;
            this.ghiChu = ghiChu;
        }

        public string MaTheoDoi { get => maTheoDoi; set => maTheoDoi = value; }
        public string MaYC { get => maYC; set => maYC = value; }
        public string MaSoPKB { get => maSoPKB; set => maSoPKB = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayTheoDoi { get => ngayTheoDoi; set => ngayTheoDoi = value; }
        public string TinhTrangSK { get => tinhTrangSK; set => tinhTrangSK = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
