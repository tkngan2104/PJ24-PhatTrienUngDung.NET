using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_BenhLy
    {
        private string maBenh, tenBenh;

        public ET_BenhLy(string maBenh, string tenBenh)
        {
            this.maBenh = maBenh;
            this.tenBenh = tenBenh;
        }

        public string MaBenh { get => maBenh; set => maBenh = value; }
        public string TenBenh { get => tenBenh; set => tenBenh = value; }
    }
}
