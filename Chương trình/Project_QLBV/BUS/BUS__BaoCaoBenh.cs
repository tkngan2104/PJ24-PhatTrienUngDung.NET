using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS__BaoCaoBenh
    {
        // Khai báo 1 biến static
        private static BUS__BaoCaoBenh instance;
        private DAL__ThongKeDanhSachBenh dal_tk = new
            DAL__ThongKeDanhSachBenh();

        public static BUS__BaoCaoBenh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS__BaoCaoBenh();
                }
                return instance;
            }
        }
        // Hiển thị danh sách thống kê theo tên bệnh cụ thể
        public void HienThiDSThongKeNhoTen(string maBenh, DataGridView dgvDSTK, DateTime dtpNgay)
        {
            // Gán dữ liệu cho datagridview bằng datasource
            dgvDSTK.DataSource = dal_tk.HienThiDSThongKeNhoTen(maBenh, dtpNgay);
        }
        // Hiển thị danh sách thống kê của danh sách tất cả các bệnh
        public void HienThiDSThongKe(DataGridView dgvDSTK, DateTime dtpNgay)
        {
            // Gán dữ liệu cho datagridview bằng datasource
            dgvDSTK.DataSource = dal_tk.HienThiDSThongKe(dtpNgay);
        }
    }
}
