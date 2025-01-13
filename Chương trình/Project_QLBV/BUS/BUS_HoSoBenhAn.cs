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
    public class BUS_HoSoBenhAn
    {
        // Khai báo biến tĩnh
        private static BUS_HoSoBenhAn instance;
        private DAL_HoSoBenhAn dal_hs = new
           DAL_HoSoBenhAn();
        private DAL_BenhNhan dal_bn = new
           DAL_BenhNhan();

        public static BUS_HoSoBenhAn Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_HoSoBenhAn();
                }
                return instance;
            }
        }
        // Xem danh sách hồ sơ bệnh án
        public void XemDSHoSoBA(DataGridView dgvHSBA)
        {
            // Gán DataSource cho DataGridView
            dgvHSBA.DataSource = dal_hs.XemDSHoSoBA();
        }
        public void DoDLBenhNhan(ComboBox cboBN)
        {
            
            cboBN.DataSource = dal_bn.XemDSBN();
            cboBN.DisplayMember = "MSBN";
            cboBN.ValueMember = "MSBN";
        }
        // Lấy tên bệnh nhân nhờ mã bệnh nhân
        public string LayTenBNNhoMaBN(string maBN)
        {
            return DAL_BenhNhan.Instance.LayTenBNNhoMaBN(maBN);
        }
        // Thêm hồ sơ bệnh án
        public void ThemHoSoBA(ET_HoSoBenhAn etHoSoBA)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_hs.ThemHoSoBA(etHoSoBA) == true)
            {
                // Khi thêm thành công sẽ hiển thị thông báo này
                MessageBox.Show("Thêm hồ sơ bệnh án cho bệnh nhân thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Khi thêm không thành công sẽ hiển thị thông báo này và ta biết mã bị trùng
                MessageBox.Show("Bệnh nhân đã có hồ sơ  bệnh án !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // Xóa hồ sơ bệnh án
        public void XoaHoSoBA(DataGridView dgvDSHoSoBA)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_hs.XoaHoSoBA(dgvDSHoSoBA.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                // Hiện lên thông báo khi xóa thành công
                MessageBox.Show("Hoàn tất xóa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hiện lên thông báo khi xóa không thành công
                MessageBox.Show("Không thể xóa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SuaHoSoBA(ET_HoSoBenhAn etHoSoBA)
        {
            dal_hs.SuaHoSoBA(etHoSoBA);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Tạo mã hồ sơ bệnh án tự động
        public string taoMaHoSoBA(string maBN)
        {
            return dal_hs.GenerateHoSoBenhAnCode(maBN);
        }
    }
}
