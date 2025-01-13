using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS__ThongKeDoanhThu
    {
        // Khai báo biến tĩnh
        private static BUS__ThongKeDoanhThu instance;
        private DAL__ThongKeDoanhThu dal_tk = new
            DAL__ThongKeDoanhThu();

        public static BUS__ThongKeDoanhThu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS__ThongKeDoanhThu();
                }
                return instance;
            }
        }
        // Lấy danh sách thống kê doanh thu của từng phiếu khám bệnh theo ngày
        public void LayDSThongKeDoanhThuNhoPKBTheoNgay(DataGridView dgvDSTK, DateTime dtpNgay)
        {
            // Gán datasource cho datagridview
            dgvDSTK.DataSource = dal_tk.LayDSThongKeDoanhThuNhoPKBTheoNgay(dtpNgay);
        }
        public void LayDSThongKeDoanhThuNhoPKBTheoThang(DataGridView dgvDSTK, DateTime dtpNgay)
        {
            // Gán datasource cho datagridview
            dgvDSTK.DataSource = dal_tk.LayDSThongKeDoanhThuNhoPKBTheoThang(dtpNgay);
        }
        // Lấy danh sách thống kê doanh thu của từng phiếu khám bệnh theo năm

        public void LayDSThongKeDoanhThuNhoPKBTheoNam(DataGridView dgvDSTK, DateTime dtpNgay)
        {
            // Gán datasource cho datagridview
            dgvDSTK.DataSource = dal_tk.LayDSThongKeDoanhThuNhoPKBTheoNam(dtpNgay);
        }
        // Lấy tổng doanh thu theo ngày của tất cả các phiếu khám bệnh
        public void LayTongDoanhThuTheoNgay(DataGridView dgv, DateTime dtp)
        {
            // Gán datasource cho datagridview
            dgv.DataSource = dal_tk.LayTongDoanhThuTheoNgay(dtp);
        }
        // Lấy tổng doanh thu theo tháng của tất cả các phiếu khám bệnh
        public void LayTongDoanhThuTheoThang(DataGridView dgv, DateTime dtp)
        {
            // Gán datasource cho datagridview
            dgv.DataSource = dal_tk.LayTongDoanhThuTheoThang(dtp);
        }
        // Lấy tổng doanh thu theo năm của tất cả các phiếu khám bệnh
        public void LayTongDoanhThuTheoNam(DataGridView dgv, DateTime dtp)
        {
            // Gán datasource cho datagridview
            dgv.DataSource = dal_tk.LayTongDoanhThuTheoNam(dtp);
        }
    }
}
