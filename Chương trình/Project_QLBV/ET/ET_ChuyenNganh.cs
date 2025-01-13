using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChuyenNganh
    {
        private string maCN, tenCN, maKhoa;

        public ET_ChuyenNganh(string maCN, string tenCN, string maKhoa)
        {
            this.maCN = maCN;
            this.tenCN = tenCN;
            this.maKhoa = maKhoa;
        }

        public string MaCN { get => maCN; set => maCN = value; }
        public string TenCN { get => tenCN; set => tenCN = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
