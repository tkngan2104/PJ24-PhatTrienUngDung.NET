using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LoaiBenhAn
    {
        private string maLoaiBA, tenLoaiBA;

        public ET_LoaiBenhAn(string maLoaiBA, string tenLoaiBA)
        {
            this.maLoaiBA = maLoaiBA;
            this.tenLoaiBA = tenLoaiBA;
        }

        public string MaLoaiBA { get => maLoaiBA; set => maLoaiBA = value; }
        public string TenLoaiBA { get => tenLoaiBA; set => tenLoaiBA = value; }
    }
}
