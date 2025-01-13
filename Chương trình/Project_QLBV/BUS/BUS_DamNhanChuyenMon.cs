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
    public class BUS_DamNhanChuyenMon
    {
        // Khai báo biến tĩnh
        private static BUS_DamNhanChuyenMon instance;
        private DAL_DamNhanChuyenMon dal_dn = new
           DAL_DamNhanChuyenMon();
        public static BUS_DamNhanChuyenMon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_DamNhanChuyenMon();
                }
                return instance;
            }
        }
        // Xem danh sách đảm nhận
        public void XemDSDamNhan(DataGridView dgvDSDamNhan)
        {
            // Gán DataSource cho DataGridView
            dgvDSDamNhan.DataSource = dal_dn.XemDSDamNhan();
        }
        // Thêm đảm nhận
        public void ThemDamNhan(ET_DamNhanChuyenMon etDamNhanCN)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_dn.ThemDamNhan(etDamNhanCN) == true)
            {
                // Khi thêm thành công sẽ hiển thị thông báo này
                MessageBox.Show("Thêm đảm nhận cho bệnh nhân thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Khi thêm không thành công sẽ hiển thị thông báo này và ta biết mã bị trùng
                MessageBox.Show("Nhân viên đã có đảm nhân chuyên môn này !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Xóa đảm nhận
        public void XoaDamNhanChuyenMon(DataGridView dgvDSDamNhanChuyenMon)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_dn.XoaDamNhan(dgvDSDamNhanChuyenMon.CurrentRow.Cells[0].Value.ToString(), dgvDSDamNhanChuyenMon.CurrentRow.Cells[1].Value.ToString()) == true)
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
        // Sửa đảm nhận
        public void SuaDamNhanChuyenMon(ET_DamNhanChuyenMon etDamNhan)
        {
            dal_dn.SuaDamNhan(etDamNhan);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Đổ dữ liệu nhân viên vào ComboBox
        public void DoDLNhanVien(ComboBox cboNV)
        {
            // Gán DataSource cho ComboBox
            cboNV.DataSource = dal_dn.LayDSNVC();
            // MaNV là dùng để lưu dữ liệu được chọn trong dữ liệu
            cboNV.ValueMember = "MaNV";
            // MaNV là dùng để hiển thị dữ liệu trên ComboBox
            cboNV.DisplayMember = "MaNV";
        }
        // Đổ dữ liệu chuyên ngành vào ComboBox

        public void DoDLLenCBChuyenNganh(ComboBox cboCN, string maNV)
        {
            // Gán DataSource cho ComboBox
            cboCN.DataSource = dal_dn.LayDSChuyenNganhNhoMaNV(maNV);
            // MaNV là dùng để lưu dữ liệu được chọn trong dữ liệu
            cboCN.DisplayMember = "TenChuyenNganh";
            // MaNV là dùng để hiển thị dữ liệu trên ComboBox
            cboCN.ValueMember = "MaChuyenNganh";
        }
        // Tính kinh nghiệm làm việc dựa vào ngày bắt đầu làm
        public void TinhKinhNghiem(DateTime dtpNgay, string maNV, string maCN)
        {
            dal_dn.HamCapNhapKinhNghiem(dtpNgay, maNV, maCN);
        }
    }
}
