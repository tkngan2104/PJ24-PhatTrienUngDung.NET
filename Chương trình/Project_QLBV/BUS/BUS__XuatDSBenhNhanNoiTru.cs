using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS__XuatDSBenhNhanNoiTru
    {
        private static BUS__XuatDSBenhNhanNoiTru instance;
        private DAL__XuatDSBNNoiTru dal_tk = new
           DAL__XuatDSBNNoiTru();

        public static BUS__XuatDSBenhNhanNoiTru Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS__XuatDSBenhNhanNoiTru();
                }
                return instance;
            }
        }

        public List<ET__XDSBenhNhanNoiTru> XuatDSBNTheoNgay(DateTime dtpNgay)
        {
            return dal_tk.XuatDSBNTheoNgay(dtpNgay);
        }

        public List<ET__XDSBenhNhanNoiTru> XuatDSBNTheoThang(int thang, int nam)
        {
            return dal_tk.XuatDSBNTheoThang(thang, nam);
        }

        public List<ET__XDSBenhNhanNoiTru> XuatDSBNTheoNam(int nam)
        {
            return dal_tk.XuatDSBNTheoNam(nam);
        }

        public List<ET__XDSBenhNhanNoiTru> XuatDSBNTheoKhoangThoiGian(DateTime dtpTuNgay, DateTime dtpDenNgay)
        {
            return dal_tk.XuatDSBNTheoKhoangThoiGian(dtpTuNgay, dtpDenNgay);
        }
    }
}
