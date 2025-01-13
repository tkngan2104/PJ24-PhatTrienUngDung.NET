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
    public class BUS_PhieuKhamBenh
    {
        // Khai báo biến tĩnh
        private static BUS_PhieuKhamBenh instance;
        private DAL_PhieuKhamBenh dal_pkb = new
           DAL_PhieuKhamBenh();
        private DAL_LoaiKham dal_lk = new
          DAL_LoaiKham();

        public static BUS_PhieuKhamBenh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_PhieuKhamBenh();
                }
                return instance;
            }
        }
        // Xme danh sách phiếu khám bệnh
        public void XemDSPhieuKhamBenh(DataGridView dgvDSPKB, string maHSBA)
        {
            // Gán DataSource cho DataGridView
            dgvDSPKB.DataSource = dal_pkb.XemDSPhieuKhamBenh(maHSBA);
        }
        // Lấy mã hồ sơ bệnh án nhờ mã bệnh nhân
        public string layMaHoSoBA(string maBN)
        {
            return dal_pkb.layMaHoSoBANhoMaBN(maBN);
        }
        // Lấy dữ liệu loại khám và đổ lên ComboBox
        public void DoDLLoaiKham(ComboBox cboLoaiKham)
        {
            // Gán DataSource cho ComboBox
            cboLoaiKham.DataSource = dal_lk.XemDSLoaiKham();
            // MaLoaiKham là để lưu trữ dữ liệu dưới bảng
            cboLoaiKham.ValueMember = "MaLoaiKham";
            // TenLoaiKham là để hiển thị dữ liệu trong ComboBox
            cboLoaiKham.DisplayMember = "TenLoaiKham";
        }
        // Kiểm tra hồ sơ bệnh án
        public bool KiemTraHoSoBACuaBN(string maBN)
        {
            // Nếu bệnh nhân chưa có hồ sơ bệnh án thì sẽ hiện thông báo lên
            if (dal_pkb.KiemTraHoSoBACuaBN(maBN) == false)
            {
                MessageBox.Show("Vui lòng tạo hồ sơ bệnh án cho bệnh nhân trước !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        // Thêm phiếu khám bệnh
        public void ThemPhieuKhamBenh(ET_PhieuKhamBenh etPKB)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_pkb.ThemPhieuKhamBenh(etPKB) == true)
            {
                // Khi thêm thành công sẽ hiển thị thông báo này
                MessageBox.Show("Thêm phiếu khám bệnh thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Khi thêm không thành công sẽ hiển thị thông báo này và ta biết mã bị trùng
                MessageBox.Show("Đã có phiếu khám bệnh này trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // Xóa phiếu khám bệnh
        public void XoaPhieuKhamBenh(DataGridView dgvDSPKB)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_pkb.XoaPhieuKhamBenh(dgvDSPKB.CurrentRow.Cells[0].Value.ToString()) == true)
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
        // Sửa phiếu khám bệnh
        public void SuaPhieuKhamBenh(ET_PhieuKhamBenh etPKB)
        {
            dal_pkb.SuaPhieuKhamBenh(etPKB);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Tạo tự động mã phiếu khám bệnh
        public string GeneratePhieuKhamBenhCode(string maBN)
        {
            return dal_pkb.GeneratePhieuKhamBenhCode(maBN);
        }
    }
}
