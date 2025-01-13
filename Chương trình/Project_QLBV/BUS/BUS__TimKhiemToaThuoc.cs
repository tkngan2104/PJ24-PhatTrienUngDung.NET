using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS__TimKhiemToaThuoc
    {
        // Khai báo biến tĩnh
        private static BUS__TimKhiemToaThuoc instance;
        private DAL__TimKiemToaThuoc dal_tk = new
            DAL__TimKiemToaThuoc();

        public static BUS__TimKhiemToaThuoc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS__TimKhiemToaThuoc();
                }
                return instance;
            }
        }
        // Lấy danh sách thuốc dùng cho toa thuốc
        public void XemDSToaThuocNhoMaToaThuoc(string maToaThuoc, DataGridView dgvDS)
        {
            // Gán DataSouce cho DataGridView
            dgvDS.DataSource = dal_tk.XemDSToaThuocNhoMaToaThuoc(maToaThuoc);
        }
        // Lấy danh sách thuốc dùng cho phiếu khám bệnh
        public void XemDSToaThuocNhoMaPKB(string maPKB, DataGridView dgvDS)
        {
            // Gán DataSouce cho DataGridView
            dgvDS.DataSource = dal_tk.XemDSToaThuocNhoMaPKB(maPKB);
        }
        // Lấy danh sách thuốc nhờ tên bệnh nhân nhờ đó lấy được danh sách phiếu khám bệnh
        public void XemDSToaThuocNhoTenBN(string maBN, DataGridView dgvDS)
        {
            // Gán DataSouce cho DataGridView
            dgvDS.DataSource = dal_tk.XemDSToaThuocNhoPKB(maBN);
        }
    }
}
