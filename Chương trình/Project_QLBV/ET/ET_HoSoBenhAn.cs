using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_HoSoBenhAn
    {
        private string maHoSoBA, maBN;
        private DateTime ngayTao;

        public ET_HoSoBenhAn(string maHoSoBA, string maBN, DateTime ngayTao)
        {
            this.maHoSoBA = maHoSoBA;
            this.maBN = maBN;
            this.ngayTao = ngayTao;
        }

        public string MaHoSoBA { get => maHoSoBA; set => maHoSoBA = value; }
        public string MaBN { get => maBN; set => maBN = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
    }
}
