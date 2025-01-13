using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS__ThongKeMatDoKhamCuaBN
    {
        // Khai báo biến tĩnh
        private static BUS__ThongKeMatDoKhamCuaBN instance;
        private DAL__BaoCaoMatDoKhamCuaPK dal_bc = new DAL__BaoCaoMatDoKhamCuaPK();

        public static BUS__ThongKeMatDoKhamCuaBN Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS__ThongKeMatDoKhamCuaBN();
                }
                return instance;
            }
        }
        // Lấy danh sách dữ liệu các phòng khám và đổ dữ liệu lên ComboBox
        public void DoDuLieuCBPhongKham(ComboBox cbo)
        {
            // Gán DataSouce vào Combobox
            cbo.DataSource = dal_bc.LayDSPK();
            cbo.ValueMember = "MSPhong";// MSPhong là dùng để lữu trữ dưới liệu dưới danh sách
            cbo.DisplayMember = "TenPhong";// TenPhong là để hiện thị dữ liệu trên combobox
        }
        // Lấy dữ liệu bệnh nhân đến khám theo ngày
        public void ThongKeDSTheoNgay(DateTime dtpNgay, DataGridView dgv)
        {
            // Gán DataSouce cho DataGridView
            dgv.DataSource = dal_bc.ThongKeDSTheoNgay(dtpNgay);
        }
        // Lấy dữ liệu bệnh nhân đến khám theo tháng
        public void ThongKeDSTheoThang(DateTime dtpNgay, DataGridView dgv)
        {
            // Gán DataSouce cho DataGridView
            dgv.DataSource = dal_bc.ThongKeDSTheoThang(dtpNgay);
        }
        // Lấy dữ liệu bệnh nhân đến khám theo năm
        public void ThongKeDSTheoNam(DateTime dtpNgay, DataGridView dgv)
        {
            // Gán DataSouce cho DataGridView
            dgv.DataSource = dal_bc.ThongKeDSTheoNam(dtpNgay);
        }
    }
}
