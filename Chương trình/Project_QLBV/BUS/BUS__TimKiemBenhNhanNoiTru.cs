using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS__TimKiemBenhNhanNoiTru
    {
        // Khai báo biến tĩnh
        private static BUS__TimKiemBenhNhanNoiTru instance;
        private DAL__TimBenhNhanNoiTru dal_tk = new
           DAL__TimBenhNhanNoiTru();

        public static BUS__TimKiemBenhNhanNoiTru Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS__TimKiemBenhNhanNoiTru();
                }
                return instance;
            }
        }
        // Lấy danh sách bệnh nhân nhập viện dựa theo ngày phân giường và sẽ lấy theo ngày
        public void LayDSBenhNhanTheoNgay(DateTime dtp, DataGridView dgvDS)
        {
            // Gán DataSouce cho DataGridView
            dgvDS.DataSource = dal_tk.LayDSBenhNhanTheoNgay(dtp);
        }
        // Lấy danh sách bệnh nhân nhập viện dựa theo ngày phân giường và sẽ lấy theo tháng
        public void LayDSBenhNhanTheoThang(DateTime dtp, DataGridView dgvDS)
        {
            // Gán DataSouce cho DataGridView
            dgvDS.DataSource = dal_tk.LayDSBenhNhanTheoThang(dtp);
        }
        // Lấy danh sách bệnh nhân nhập viện dựa theo ngày phân giường và sẽ lấy theo năm
        public void LayDSBenhNhanTheoNam(DateTime dtp, DataGridView dgvDS)
        {
            // Gán DataSouce cho DataGridView
            dgvDS.DataSource = dal_tk.LayDSBenhNhanTheoNam(dtp);
        }
        // Lấy danh sách bệnh nhân nhập viện dựa theo ngày phân giường và sẽ lấy theo khoảng thời gian
        public void LayDSBenhNhanTheoKhoangTG(DateTime dtpTuNgay, DateTime dtpNgayDen, DataGridView dgvDS)
        {
            // Gán DataSouce cho DataGridView
            dgvDS.DataSource = dal_tk.LayDSBenhNhanTheoKhoangTG(dtpTuNgay, dtpNgayDen);
        }
    }
}
