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
    public class BUS_NhanVien
    {
        // Khai báo biến tĩnh
        private static BUS_NhanVien instance;
        private DAL_NhanVien dal_nv = new
           DAL_NhanVien();
        private DAL_ChucVu dal_cv = new
           DAL_ChucVu();

        public static BUS_NhanVien Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_NhanVien();
                }
                return instance;
            }
        }
        // Xem danh sách nhân viên
        public void XemDSNhanVien(DataGridView dgvNhanVien)
        {
            // Gán DataSource cho DataGridView
            dgvNhanVien.DataSource = dal_nv.XemDSNhanVien();
        }
        // Lấy danh sách chức vụ và đổ dữ liệu ComboBox
        public void DoDLCV(ComboBox cboCV)
        {
            // Gán DataSource cho ComboBox
            cboCV.DataSource = dal_cv.ListCV();
            // MaCV là để lưu trữ dữ liệu dưới bảng
            cboCV.ValueMember = "MaCV";
            // TenCV là để hiển thị dữ liệu trong ComboBox
            cboCV.DisplayMember = "TenCV";
        }
        // Thêm Nhân viên
        public void ThemNhanVien(ET_NhanVien etNhanVien)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_nv.ThemNhanVien(etNhanVien) == true)
            {
                // Khi thêm thành công sẽ hiển thị thông báo này
                MessageBox.Show("Thêm nhân viên thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Khi thêm không thành công sẽ hiển thị thông báo này và ta biết mã bị trùng
                MessageBox.Show("Nhân viên đã có thông tin trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // Xóa nhân viên
        public void XoaNhanVien(DataGridView dgvNV)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_nv.XoaNhanVien(dgvNV.CurrentRow.Cells[0].Value.ToString()) == true)
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
        // Sửa nhân viên
        public void SuaNhanVien(ET_NhanVien etNV)
        {
            dal_nv.SuaNhanVien(etNV);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
