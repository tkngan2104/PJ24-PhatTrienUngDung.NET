using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LoaiPTXN
    {
        private string loai;
        private string ten;

        public ET_LoaiPTXN(string loai, string ten)
        {
            this.loai = loai;
            this.ten = ten;
        }

        public string Loai { get => loai; set => loai = value; }
        public string Ten { get => ten; set => ten = value; }
    }
}
