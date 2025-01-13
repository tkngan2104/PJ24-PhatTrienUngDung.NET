using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__XHDGiuongBenh
    {
        private string tenPhongBenh;
        private int soGiuongBenh;
        private DateTime ngayNhanGiuong;
        private DateTime ngayTraGiuong;
        private float gia;
        private float tienGiuong;
        public string MSPhieuKhamBenh { get; set; }
        public string TenPhongBenh { get => tenPhongBenh; set => tenPhongBenh = value; }
        public int SoGiuongBenh { get => soGiuongBenh; set => soGiuongBenh = value; }
        public DateTime NgayNhanGiuong { get => ngayNhanGiuong; set => ngayNhanGiuong = value; }
        public DateTime NgayTraGiuong { get => ngayTraGiuong; set => ngayTraGiuong = value; }
        public float Gia { get => gia; set => gia = value; }
        public float TienGiuong { get => tienGiuong; set => tienGiuong = value; }

        public ET__XHDGiuongBenh(string tenPhongBenh, int soGiuongBenh, DateTime ngayNhanGiuong, DateTime ngayTraGiuong, float gia, float tienGiuong)
        {
            this.tenPhongBenh = tenPhongBenh;
            this.soGiuongBenh = soGiuongBenh;
            this.ngayNhanGiuong = ngayNhanGiuong;
            this.ngayTraGiuong = ngayTraGiuong;
            this.gia = gia;
            this.tienGiuong = tienGiuong;
        }

        public ET__XHDGiuongBenh(string tenPhongBenh, int soGiuongBenh, DateTime ngayNhanGiuong, DateTime ngayTraGiuong, float gia, float tienGiuong, string mSPhieuKhamBenh)
        {
            this.tenPhongBenh = tenPhongBenh;
            this.soGiuongBenh = soGiuongBenh;
            this.ngayNhanGiuong = ngayNhanGiuong;
            this.ngayTraGiuong = ngayTraGiuong;
            this.gia = gia;
            this.tienGiuong = tienGiuong;
            this.MSPhieuKhamBenh = mSPhieuKhamBenh;
        }
    }
}
