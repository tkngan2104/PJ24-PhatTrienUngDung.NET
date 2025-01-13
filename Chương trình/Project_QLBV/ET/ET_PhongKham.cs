using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_PhongKham
    {
        private string msPhong;
        private string tenPhong;
        private string diaDiem;
        private string maKhoa;
        private int soGiuong;
        private string loai;

        public ET_PhongKham(string msPhong, string tenPhong, string diaDiem, string maKhoa, int soGiuong, string loai)
        {
            this.msPhong = msPhong;
            this.tenPhong = tenPhong;
            this.diaDiem = diaDiem;
            this.maKhoa = maKhoa;
            this.soGiuong = soGiuong;
            this.loai = loai;
        }

        public string MsPhong { get => msPhong; set => msPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public int SoGiuong { get => soGiuong; set => soGiuong = value; }
        public string Loai { get => loai; set => loai = value; }
    }
}
