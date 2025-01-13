using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS__LayThongKeBenhCuThe
    {
        // Khai báo biến static
        private static BUS__LayThongKeBenhCuThe instance;
        private DAL__LayThongKeBenhCuThe dal_tk = new
            DAL__LayThongKeBenhCuThe();

        public static BUS__LayThongKeBenhCuThe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS__LayThongKeBenhCuThe();
                }
                return instance;
            }
        }
        // Xuất báo cáo của bệnh cụ thể theo năm
        public List<ET__LayThongKeCuTheBenh> XuatTKCuaBenhCuThe(string maBenh, int nam)
        {
            // Trả về danh sách của bệnh cụ thể theo năm
            return dal_tk.XuatTKCuaBenhCuThe(maBenh, nam);
        }
        // Xuất báo cáo tình trạng sức khỏe của bệnh nhân
        public List<ET__LayTinhTrangSucKhoe> LayTinhTrangSKCuaBenhNhan(string maBenh, int nam)
        {
            // Trả về danh sách của tình trang sức khỏe của bệnh nhân
            return dal_tk.LayTinhTrangSKCuaBenhNhan(maBenh, nam);
        }
        // Xuất báo cáo của danh sách bệnh
        public List<ET__LayThongKeCuTheBenh> XuatTKCuaDSBenh(int nam)
        {
            // Trả về danh sách của bệnh
            return dal_tk.XuatTKCuaDSBenh(nam);
        }
    }
}
