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
    public class BUS_HoaDon
    {
        // Khai báo biến tĩnh
        private static BUS_HoaDon instance;
        private DAL_HoaDon dal_hd = new
           DAL_HoaDon();

        public static BUS_HoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_HoaDon();
                }
                return instance;
            }
        }
        // Xem danh sách hóa đơn
        public void XemDSHoaDon(DataGridView dgvDSHD, DateTime dtpNgay)
        {
            // Gán DataSource cho DataGridView
            dgvDSHD.DataSource = dal_hd.XemDSHoaDon(dtpNgay);
        }
        // Thêm hóa đơn
        public void ThemHoaDon(ET_HoaDon etHD)
        {
            //Kiểm tra mã phiếu khám bệnh trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_hd.ThemHoaDon(etHD) == true)
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
        // Xóa hóa đơn
        public void XoaHoaDon(DataGridView dgvDSHD)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_hd.XoaHoaDon(dgvDSHD.CurrentRow.Cells[0].Value.ToString()) == true)
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
        // Sửa hóa đơn
        public void SuaHoaDon(ET_HoaDon etHD)
        {
            dal_hd.SuaHoaDon(etHD);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Kiểm tra ngày xuất hóa đơn
        public bool KiemTraNgayXuatHD(DateTime ngayXuatHD, string maPKB)
        {
            return dal_hd.KiemTraNgayXuatHD(ngayXuatHD, maPKB);
        }
        // Tính tiền thuốc của phiếu khám bệnh
        public float TinhTienThuoc(string maTT, string maPKB)
        {
            return dal_hd.TinhTienThuoc(maTT, maPKB);
        }
        // Tính tiền khám của phiếu khám bệnh
        public float TinhTienKham(string maPKB)
        {
            return dal_hd.TinhTienKham(maPKB);
        }
        // Tính tiền giường của phiếu khám bệnh
        public float TinhTienGiuong(string maPKB)
        {
            return dal_hd.TinhGiuongBenh(maPKB);
        }
        // Tính tiền phẫu thuật của phiếu khám bệnh
        public float TinhPhauThuat(string maPKB)
        {
            return dal_hd.TinhPhauThuat(maPKB);
        }

        // Tính tổng cộng chi phí lại
        public float TinhTongCong(string maTT, string maPKB)
        {
            return dal_hd.TinhTienTongCong(maTT, maPKB);
        }
        
        // Lấy Toa thuốc của PKB và phải kê toa thuốc mới được xuất hóa đơn
        public string layMaTTNhoPKB(string maPKB)
        {
            return dal_hd.LayMaTTNhoPKB(maPKB);
        }
        // Cập nhập tiền thuốc của tất cả PKB
        public void CapNhapTienThuocCuaPKB()
        {
            dal_hd.CapNhapTienThuocCuaPKB();
        }
        // Cập nhập tiền khám của tất cả PKB
        public void CapNhapTienKhamCuaPKB()
        {
            dal_hd.CapNhapTienKhamCuaPKB();
        }
        // Cập nhập tiền giường của tất cả PKB
        public void CapNhapTienGiuongCuaPKB()
        {
            dal_hd.CapNhapTienGiuongCuaPKB();
        }
        // Cập nhập tiền phẫu thuật_xncc của tất cả PKB
        public void CapNhapTienPhauThuatCuaPKB()
        {
            dal_hd.CapNhapTienPhauThuatCuaPKB();
        }
        // Cập nhập tổng tiền của tất cả PKB
        public void CapNhapTongTienCuaPKB()
        {
            dal_hd.CapNhapTongTienCuaPKB();
        }

        //Tính tiền bảo hiển y tế sẽ trả của phiếu khám bệnh
        public float TinhTienBHYTChiTra(string maPKB)
        {
            return dal_hd.TinhTienBHYTChiTra(maPKB);
        }
        // Cập nhập tiền bảo hiểm y tế chi trả của tất cả PKB
        public void CapNhapTienBHYTChiTra()
        {
            dal_hd.CapNhapTienBHYTChiTra();
        }
        // Tính tiền sau khi BHYT chi trả của phiếu khám bệnh
        public float TinhTienSauKhiBHYTChiTra(string maPKB)
        {
            return dal_hd.TinhTongTienSauKhiTienBHYTChiTra(maPKB);
        }
        // Cập nhập tiền BHYT chi trả của tất cả phiếu khám bệnh
        public void CapNhapTienSauKhiBHYTChiTra()
        {
            dal_hd.CapNhapTienSauKhiBHYTChiTra();
        }
        // Tạo tự động mã hóa đơn
        public string GenerateHoaDonCode(string maPKB)
        {
            return dal_hd.GenerateHoaDonCode(maPKB);
        }
        //Kiểm tra xem bệnh nhân có hóa đơn chưa
        public bool KiemTraXemBenhNhanCoHoaDonChua(string maPKB)
        {
            return dal_hd.KiemTraCoHoaDonChua(maPKB);
        }
    }
}
