using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TongDoanhThu
    {
        // Khai báo biến tĩnh
        private static BUS_TongDoanhThu instance;
        private DAL_TongDoanhThu dal_dt = new
           DAL_TongDoanhThu();

        public static BUS_TongDoanhThu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_TongDoanhThu();
                }
                return instance;
            }
        }

        //Xuất tiền của tất cả các PKB theo ngày
        public List<ET__XHDTatCaPKBTheoTime> XuatTienCuaTatCaCacPKBTheoNgay(DateTime dtp)
        {
            return dal_dt.XuatTienCuaTatCaCacPKBTheoNgay(dtp);
        }

        //Xuất tổng doanh thu theo ngày
        public List<ET__TongDoanhThu> ThongKeDoanhThuTheoNgay(DateTime dtp)
        {
            return dal_dt.ThongKeDoanhThuTheoNgay(dtp);
        }

        //Theo tháng
        //Xuất tiền của tất cả các PKB theo tháng
        public List<ET__XHDTatCaPKBTheoTime> XuatTienCuaTatCaCacPKBTheoThang(int thang, int nam)
        {
            return dal_dt.XuatTienCuaTatCaCacPKBTheoThang(thang, nam);
        }

        //Xuất tổng doanh thu theo tháng
        public List<ET__TongDoanhThu> ThongKeDoanhThuTheoThang(int thang, int nam)
        {
            return dal_dt.ThongKeDoanhThuTheoThang(thang, nam);
        }
        //Nam
        //Xuất tiền của tất cả các PKB theo năm
        public List<ET__XHDTatCaPKBTheoTime> XuatTienCuaTatCaCacPKBTheoNam(int nam)
        {
            return dal_dt.XuatTienCuaTatCaCacPKBTheoNam(nam);
        }

        //Xuất tổng doanh thu theo năm
        public List<ET__TongDoanhThu> ThongKeDoanhThuTheoNam(int nam)
        {
            return dal_dt.ThongKeDoanhThuTheoNam(nam);
        }
    }
}
