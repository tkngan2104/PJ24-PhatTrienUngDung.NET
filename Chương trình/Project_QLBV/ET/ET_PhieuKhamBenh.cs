using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_PhieuKhamBenh
    {
        private string maSoPhieuKhamBenh;
        private DateTime ngayKham;
        private string maHoSoBA, trieuChung, benhNen, maLoaiKham;

        public ET_PhieuKhamBenh(string maSoPhieuKhamBenh, DateTime ngayKham, string maHoSoBA, string trieuChung, string benhNen, string maLoaiKham)
        {
            this.maSoPhieuKhamBenh = maSoPhieuKhamBenh;
            this.ngayKham = ngayKham;
            this.maHoSoBA = maHoSoBA;
            this.trieuChung = trieuChung;
            this.benhNen = benhNen;
            this.maLoaiKham = maLoaiKham;
        }

        public string MaSoPhieuKhamBenh { get => maSoPhieuKhamBenh; set => maSoPhieuKhamBenh = value; }
        public DateTime NgayKham { get => ngayKham; set => ngayKham = value; }
        public string MaHoSoBA { get => maHoSoBA; set => maHoSoBA = value; }
        public string TrieuChung { get => trieuChung; set => trieuChung = value; }
        public string BenhNen { get => benhNen; set => benhNen = value; }
        public string MaLoaiKham { get => maLoaiKham; set => maLoaiKham = value; }
    }
}
