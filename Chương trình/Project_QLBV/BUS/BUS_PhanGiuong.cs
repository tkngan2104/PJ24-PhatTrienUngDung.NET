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
    public class BUS_PhanGiuong
    {
        // Khai báo biến tĩnh
        private static BUS_PhanGiuong instance;
        private DAL_PhanGiuong dal_pg = new
           DAL_PhanGiuong();

        public static BUS_PhanGiuong Instance
        {
            get
            
            {
                if (instance == null)
                {
                    instance = new BUS_PhanGiuong();
                }
                return instance;
            }
        }
        // Xem danh sách phân giường
        public void XemDSPhanGiuong(DataGridView dgvDSPhanGiuong, DateTime dtp)
        {
            // Gán DataSource cho DataGridView
            dgvDSPhanGiuong.DataSource = dal_pg.XemDSPhanGiuong(dtp);
        }
        // Phân giường
        public void ThemPhanGiuong(ET_PhanGiuong etPG)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_pg.PhanGiuong(etPG) == true)
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
        // Xóa phân giường
        public void XoaPhanGiuo0ng(DataGridView dgvDSPG)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_pg.XoaPhanGiuong(dgvDSPG.CurrentRow.Cells[4].Value.ToString()) == true)
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
        // Sửa phân giường
        public void SuaPhanGiuong(ET_PhanGiuong etPG)
        {
            dal_pg.SuaPhanGiuong(etPG);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Lấy phiếu khám bệnh từ mã yêu cầu

        public string LayPKBTuMaYC(string maYC)
        {
            return dal_pg.LayPhieuKhamBenhNhoYC(maYC);
        }
        // Lấy số giường nhờ phòng và đổ dữ liệu lên ComboBox
        public void LayGiuongTuPhong(string maPhong, ComboBox cboGB)
        {
            // Gán DataSource cho ComboBox
            cboGB.DataSource = dal_pg.LayDSGiuongNhoPhong(maPhong);
            // MaGiuong là để lưu trữ dữ liệu dưới bảng
            cboGB.ValueMember = "MaGiuong";
            // MaGiuong là để hiển thị dữ liệu trong ComboBox
            cboGB.DisplayMember = "MaGiuong";
        }
        // Lấy số giường dựa vào mã giường
        public int LaySoGiuongTuMaGiuong(string maGiuong)
        {
            return dal_pg.LayTenGiuongTuMaGiuong(maGiuong);
        }
        // Kiểm tra ngày nhập giường
        public bool KiemTraNgayNhapGiuong(DateTime ngayNhap, string maPKB)
        {
            // Trả về true or false
            return dal_pg.KiemTraNgayNhapGiuong(ngayNhap, maPKB);
        }
        // Lấy ngày nhận giường
        public DateTime? LayNgayNhanGiuong(string maPKB)
        {
            // Call the DAL method and get the nullable DateTime
            DateTime? ngayNhanGiuong = dal_pg.LayNgayNhanGiuong(maPKB);

            // Return the nullable DateTime as is
            return ngayNhanGiuong;
        }
        // Kiểm tra xem giường có trống hay không
        public bool KiemTraTrangThaiGiuong(string maGiuong, DateTime ngayNhan, DateTime ngayTra)
        {
            // Trả về true or false
            return dal_pg.KiemTraTrangThaiGiuong(maGiuong, ngayNhan, ngayTra);
        }

        // Lấy danh sách dịch vụ vụ và đổ dữ liệu ComboBox
        public void DoDLDVTuMaPhong(string maPhong, ComboBox cboDV)
        {
            
            // Gán DataSource cho ComboBox
            cboDV.DataSource = dal_pg.LayDSDVTheoMaPhong(maPhong);
            // MaLoaiChiTietDV là để lưu trữ dữ liệu dưới bảng
            cboDV.ValueMember = "MaLoaiChiTietDV";
            // TenLoaiChiTietDV là để hiển thị dữ liệu trong ComboBox
            cboDV.DisplayMember = "TenLoaiChiTietDV";
        }
    }
}
