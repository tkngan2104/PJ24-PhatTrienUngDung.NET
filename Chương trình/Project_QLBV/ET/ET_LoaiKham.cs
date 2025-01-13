using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LoaiKham
    {
        private string maLoaiKham;
        private string tenLoaiKham;
        private float gia;

        public ET_LoaiKham(string maLoaiKham, string tenLoaiKham, float gia)
        {
            this.maLoaiKham = maLoaiKham;
            this.tenLoaiKham = tenLoaiKham;
            this.gia = gia;
        }

        public string MaLoaiKham { get => maLoaiKham; set => maLoaiKham = value; }
        public string TenLoaiKham { get => tenLoaiKham; set => tenLoaiKham = value; }
        public float Gia { get => gia; set => gia = value; }
    }
}
