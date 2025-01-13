using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS__TimKiemLichSuChuaTri
    {
        // Khai báo biến tĩnh
        private static BUS__TimKiemLichSuChuaTri instance;
        private DAL__TimKiemLichSuChuaTri dal_tk = new
           DAL__TimKiemLichSuChuaTri();

        public static BUS__TimKiemLichSuChuaTri Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS__TimKiemLichSuChuaTri();
                }
                return instance;
            }
        }
        // Tìm lịch sử phậu thuật_xét nghiệm chụp chiếu của phiếu khám bệnh
        public void TimLichSuPT_XNCCCua1PKB(string maPKB, DataGridView dgv)
        {
            // Gán DataSouce cho DataGridView
            dgv.DataSource = dal_tk.TimLichSuPT_XNCCCua1PKB(maPKB);
        }
        // Tìm lịch sử nằm viện của phiếu khám bệnh
        public void TimLichNamVienCua1PKB(string maPKB, DataGridView dgv)
        {
            // Gán DataSouce cho DataGridView
            dgv.DataSource = dal_tk.TimLichNamVienCua1PKB(maPKB);
        }
        // Tìm lịch sử đi khám ở các phòng của phiếu khám bệnh
        public void TimLichKhamCua1PKB(string maPKB, DataGridView dgv)
        {
            // Gán DataSouce cho DataGridView
            dgv.DataSource = dal_tk.TimLichKhamCua1PKB(maPKB);
        }
        // Tìm thông tin của phiếu khám bệnh
        public void TimTTCua1PKB(string maPKB, DataGridView dgv)
        {
            // Gán DataSouce cho DataGridView
            dgv.DataSource = dal_tk.TimTTCua1PKB(maPKB);
        }
        // Tìm lịch sử phẫu thuật_xét nghiệm chụp chiếu theo tên BN
        public void TimLichSuPT_XNCCTheoTenBN(string maBN, DataGridView dgv)
        {
            // Gán DataSouce cho DataGridView
            dgv.DataSource = dal_tk.TimLichSuPT_XNCCTheoTenBN(maBN);
        }

        // Tìm lịch sử nằm viện theo tên BN
        public void TimLichNamVienNhoTenBN(string maBN, DataGridView dgv)
        {
            // Gán DataSouce cho DataGridView
            dgv.DataSource = dal_tk.TimLichNamVienNhoTenBN(maBN);
        }
        // Tìm lịch sử đi khám ở các phòng theo tên BN
        public void TimLichKhamNhoTenBN(string maBN, DataGridView dgv)
        {
            // Gán DataSouce cho DataGridView
            dgv.DataSource = dal_tk.TimLichKhamNhoTenBN(maBN);
        }
        // Tìm thông tin của BN theo BN
        public void TimTTNhoTenBN(string maBN, DataGridView dgv)
        {
            // Gán DataSouce cho DataGridView
            dgv.DataSource = dal_tk.TimTTNhoTenBN(maBN);
        }
        // Tìm thông tin toa thuốc theo MaBN
        public void XemDSToaThuoc(string maBN, DataGridView dgv)
        {
            // Gán DataSouce cho DataGridView
            dgv.DataSource = dal_tk.XemDSToaThuoc(maBN);
        }
    }
}
