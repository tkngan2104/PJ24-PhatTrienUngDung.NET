using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET__LayThongKeCuTheBenh
    {
        public ET__LayThongKeCuTheBenh(string maBenh, string tenBenh, int soLuongNam, int soLuongNu, int tongSoLuong)
        {
            MaBenh = maBenh;
            TenBenh = tenBenh;
            SoLuongNam = soLuongNam;
            SoLuongNu = soLuongNu;
            TongSoLuong = tongSoLuong;
        }

        public string MaBenh { get; set; }
        public string TenBenh { get; set; }
        public int SoLuongNam { get; set; }
        public int SoLuongNu { get; set; }
        public int TongSoLuong { get; set; }
    }
}
