using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS__XuatDSKhamTheoTime
    {
        // Khai báo biến tĩnh
        private static BUS__XuatDSKhamTheoTime instance;
        private DAL__XuatDSKhamTheoTime dal_tk = new
           DAL__XuatDSKhamTheoTime();

        public static BUS__XuatDSKhamTheoTime Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS__XuatDSKhamTheoTime();
                }
                return instance;
            }
        }
        // Lấy danh sách lịch sử khám theo ngày
        public List<ET__XDSKhamTheoTime> LayDSLichSuKham(DateTime dtpNgay)
        {
            // Trả về list danh sách lịch sử khám theo ngày
            return dal_tk.LayDSLichSuKham(dtpNgay);
        }
        // Lấy danh sách lịch sử khám theo tháng
        public List<ET__XDSKhamTheoTime> LayDSKhamTheoThang(int thang, int nam)
        {
            // Trả về list danh sách lịch sử khám theo tháng
            return dal_tk.LayDSKhamTheoThang(thang, nam);
        }
        // Lấy danh sách lịch sử khám theo năm
        public List<ET__XDSKhamTheoTime> LayDSKhamTheoNam(int nam)
        {
            // Trả về list danh sách lịch sử khám theo năm
            return dal_tk.LayDSKhamTheoNam(nam);
        }
    }
}
