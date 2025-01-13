using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_GiuongBenh
    {
        private string maGiuong;
        private int soGiuong;
        private string msPhong;

        public ET_GiuongBenh(string maGiuong, int soGiuong, string msPhong)
        {
            this.maGiuong = maGiuong;
            this.soGiuong = soGiuong;
            this.msPhong = msPhong;
        }

        public string MaGiuong { get => maGiuong; set => maGiuong = value; }
        public int SoGiuong { get => soGiuong; set => soGiuong = value; }
        public string MsPhong { get => msPhong; set => msPhong = value; }
    }
}
