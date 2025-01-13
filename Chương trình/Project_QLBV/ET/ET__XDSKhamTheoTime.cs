using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__XDSKhamTheoTime
    {
        public ET__XDSKhamTheoTime(string MSPhong, string tenPhong, string tenKhoa, string MSBN, string tenBN, string MSPhieuKhamBenh, DateTime ngayKham)
        {
            this.MSPhong = MSPhong;
            this.TenPhong = tenPhong;
            this.TenKhoa = tenKhoa;
            this.MSBN = MSBN;
            this.TenBN = tenBN;
            this.MSPhieuKhamBenh = MSPhieuKhamBenh;
            this.NgayKham = ngayKham;
        }

        public string MSPhong { get; set; }
        public string TenPhong { get; set; }
        public string TenKhoa { get; set; }
        public string MSBN { get; set; }
        public string TenBN { get; set; }
        public string MSPhieuKhamBenh { get; set; }
        public DateTime NgayKham { get; set; }
    }
}
