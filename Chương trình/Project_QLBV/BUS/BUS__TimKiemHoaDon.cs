using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS__TimKiemHoaDon
    {
        // Khai báo biến tĩnh
        private static BUS__TimKiemHoaDon instance;
        private DAL__TimKiemHoaDon dal_tk = new
           DAL__TimKiemHoaDon();

        public static BUS__TimKiemHoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS__TimKiemHoaDon();
                }
                return instance;
            }
        }
        // Tìm kiếm hóa đơn nhờ phiếu khám bệnh
        public void TimKiemHoaDonNhoMaPKB(string maPKB, DataGridView dgvDSHD)
        {
            // Gán DataSouce cho DataGridView
            dgvDSHD.DataSource = dal_tk.TimKiemHoaDonNhoMaPKB(maPKB);
        }
        // Tìm kiếm hóa đơn nhờ tên bệnh nhân
        public void LayDSBenhNhan(string tenBN, DataGridView dgvDSBN)
        {
            // Gán DataSouce cho DataGridView
            dgvDSBN.DataSource = dal_tk.LayDSBenhNhan(tenBN);
        }
        // Đây là tìm kiếm danh sách phiếu khám bệnh khi tìm kiếm hóa đơn theo bệnh nhân
        public void LayDSPKB(string maBN, DataGridView dgvDSPKB)
        {
            // Gán DataSouce cho DataGridView
            dgvDSPKB.DataSource = dal_tk.LayDSPKB(maBN);
        }
    }
}
