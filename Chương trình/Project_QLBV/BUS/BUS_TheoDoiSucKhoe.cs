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
    public class BUS_TheoDoiSucKhoe
    {
        // Khai báo biến tĩnh
        private static BUS_TheoDoiSucKhoe instance;
        private DAL_TheoDoiSucKhoe dal_tdsk = new
           DAL_TheoDoiSucKhoe();

        public static BUS_TheoDoiSucKhoe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_TheoDoiSucKhoe();
                }
                return instance;
            }
        }
        // Xem danh sách theo dõi sức khỏe theo phiếu khám bệnh
        public void XemDSTheoDoiSK(DataGridView dgvDSTD, string maPKB)
        {
            // Gán DataGridView cho DataGridView
            dgvDSTD.DataSource = dal_tdsk.XemDSTheoDoi(maPKB);
        }
        // Thêm theo dõi
        public void ThemTheoDoi(ET_TheoDoiSucKhoe etTD)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_tdsk.ThemTheoDoi(etTD) == true)
            {
                // Khi thêm thành công sẽ hiển thị thông báo này
                MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Khi thêm không thành công sẽ hiển thị thông báo này và ta biết mã bị trùng
                MessageBox.Show("Dữ liệu đã có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Xóa theo dõi sức khỏe
        public void XoaTheoDoiSK(DataGridView dgvDSTD)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_tdsk.XoaTheoDoiSK(dgvDSTD.CurrentRow.Cells[0].Value.ToString()) == true)
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
        // Sửa theo dõi
        public void SuaTheoDoiSK(ET_TheoDoiSucKhoe etTD)
        {
            dal_tdsk.SuaTheoDoiSK(etTD);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Kiểm tra ngày theo dõi xem có lớn hơn bằng ngày nhận giường và nhỏ hơn bằng ngày trả giường không
        public bool KiemTraNgayTD(DateTime dtpNgayTD, string maPKB)
        {
            return dal_tdsk.KiemTraNgayTD(dtpNgayTD, maPKB);
        }

        // Tạo tự động mã theo dõi
        public string GenerateTheoDoiSucKhoeCode(string maPK)
        {
            return dal_tdsk.GenerateTheoDoiSucKhoeCode(maPK);
        }
        // Lấy nhân viên cùng khoa với nhân viên phụ trách chính
        public void LayNVTuNVPhuTrach(ComboBox cboNV, string maNVPhuTrach)
        {
            // Gán DataSource cho ComboBox
            cboNV.DataSource = dal_tdsk.LayDSNVCungKhoaVoiNVPhuTrach(maNVPhuTrach);
            // MaNV là để lưu trữ dữ liệu dưới bảng
            cboNV.ValueMember = "MaNV";
            // MaNV là để hiển thị dữ liệu trong ComboBox
            cboNV.DisplayMember = "MaNV";
        }
        // Lấy ngày nhận giường của phiếu khám bệnh
        public DateTime? LayNgayNhanGiuong(string maPKB)
        {
            // Call the DAL method and get the nullable DateTime
            DateTime? ngayTraGiuong = dal_tdsk.LayNgayNhanGiuong(maPKB);

            // Return the nullable DateTime as is
            return ngayTraGiuong;
        }
        // Lấy ngày trả giường của phiếu khám bệnh
        public DateTime? LayNgayTraGiuong(string maPKB)
        {
   
            // Call the DAL method and get the nullable DateTime
            DateTime? ngayTraGiuong = dal_tdsk.LayNgayTraGiuong(maPKB);

            // Return the nullable DateTime as is
            return ngayTraGiuong;
        }
    }
}
