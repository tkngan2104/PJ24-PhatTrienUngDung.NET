using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_BenhNhan
    {
        // Khai báo biến tĩnh
        private static BUS_BenhNhan instance;
        private DAL_BenhNhan dal_bn = new
           DAL_BenhNhan();

        public static BUS_BenhNhan Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_BenhNhan();
                }
                return instance;
            }
        }
        // Lấy danh sách bệnh nhân
        public void XemDSBenhNhan(DataGridView dgvTTBN)
        {
            // Gán DataSource cho DataGridView
            dgvTTBN.DataSource = dal_bn.XemDSBN();
        }


        //Thêm bệnh nhân
        public void ThemBenhNhan(ET_BenhNhan etBN)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_bn.ThemBenhNhan(etBN) == true)
            {
                // Khi thêm thành công sẽ hiển thị thông báo này
                MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Khi thêm không thành công sẽ hiển thị thông báo này
                MessageBox.Show("Dữ liệu đã có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Xóa bệnh nhân
        public void XoaBenhNhan(DataGridView dgvBENHNHAN)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_bn.XoaBenhNhan(dgvBENHNHAN.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                // Hiện lên thông báo khi xóa thành công
                MessageBox.Show("Hoàn tất xóa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hiện lên thông báo khi xóa không thành công
                MessageBox.Show("Dữ liệu đang được đối chiếu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Sửa bệnh nhân
        public void SuaBENHNHAN(ET_BenhNhan etBN)
        {
            dal_bn.SuaBenhNhan(etBN);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool KiemTraHoSoBeNHan(string maBN)
        {
            return dal_bn.KiemTraBNCoHSBAChua(maBN);
        }
        // Tìm kiếm bệnh nhân theo tên bệnh nhân,số điện thoại và cccd
        public void TimKiemBenhNhan(string tenBN, string sdt, string cccd, DataGridView dgv)
        {
            // Gán DataSource cho DataGridView
            dgv.DataSource = dal_bn.TimKiemBenhNhan(tenBN, sdt, cccd);
        }
    }
}
