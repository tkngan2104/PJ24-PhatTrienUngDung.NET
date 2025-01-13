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
    public class BUS_DangKyKham
    {
        // Khai báo biến tĩnh
        private static BUS_DangKyKham instance;
        private DAL_DangKyKham dal_dky = new
           DAL_DangKyKham();

        public static BUS_DangKyKham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_DangKyKham();
                }
                return instance;
            }
        }
        // Xem danh sách đăng ký khám
        public void XemDSDKyKham(DataGridView dgvDSDkyKham, DateTime dtp)
        {
            // Gán DataSource cho DataGridView
            dgvDSDkyKham.DataSource = dal_dky.XemDSDKyKhamTheoNgay(dtp);
        }
        // Khám
        public void DangKyKham(ET_DangKyKham etKham)
        {
            // Kiểm tra xem bệnh nhân đã thực hiện xong yêu cầu trước đó chưa mới cho thêm tiếp
            if (!(dal_dky.KiemTraTrangThaiKham(etKham.MaYeuCau)))
            {
                //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
                if (dal_dky.ThemDKyKham(etKham) == true)
                {
                    // Khi thêm thành công sẽ hiển thị thông báo này
                    MessageBox.Show("Đăng ký khám thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Khi thêm không thành công sẽ hiển thị thông báo này và ta biết mã bị trùng
                    MessageBox.Show("Đã đăng ký trước đó !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Khi chưa hoàn thiện lần khám trước thì hiện lên thông báo
                MessageBox.Show("Vui lòng khám xong yêu cầu trước đó !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Xóa đăng ký
        public void XoaDkyKham(DataGridView dgvDSDkyKham, string maKham)
        {
            // Khi mà bệnh nhân đã hoàn thành khám nghĩa là đã có nhân viên phụ trách thì không thể xóa   
            if (dal_dky.KiemTraTrangThaiKham(maKham))
            {
                // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
                if (dal_dky.XoaDKyKham(dgvDSDkyKham.CurrentRow.Cells[0].Value.ToString()) == true)
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
            else
            {
                // Hiện lên thông báo khi bệnh nhân đã khám mà nhân viên muốn xóa
                MessageBox.Show("Vui lòng không xóa để không mất dữ liệu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Sửa đăng ký
        public void SuaDSDkyKham(ET_DangKyKham etDKyKham, string maKham, string maPKB, string msPhong)
        {

            dal_dky.SuaDangKyKham(etDKyKham);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        // Đổ dữ liệu nhân viên yêu cầu dựa vào lần khám của phiếu khám bệnh lần khám đầu tiên sẽ là nhân viên lễ tần còn những lần sau sẽ là bác sĩ
        public void DoDLNVYeuCau(string msPhieuKham, ComboBox cboNVYC)
        {
            // Gán DataSource cho ComboBox
            cboNVYC.DataSource = dal_dky.DoDLLenNVYeuCau(msPhieuKham);
            // MaNV là dùng để lưu dữ liệu được chọn trong dữ liệu
            cboNVYC.ValueMember = "MaNV";
            // MaNV là dùng để hiển thị dữ liệu trên ComboBox
            cboNVYC.DisplayMember = "MaNV";
        }

        // Đổ dữ liệu nhân viên phụ trách dựa vào mã phòng
        public void DoDLNVPhuTrach(ComboBox cboNVPT, string maPhong)
        {
            // Gán DataSource cho ComboBox
            cboNVPT.DataSource = dal_dky.DoDLLenNVPhuTrach(maPhong);
            // MaNV là dùng để lưu dữ liệu được chọn trong dữ liệu
            cboNVPT.ValueMember = "MaNV";
            // MaNV là dùng để hiển thị dữ liệu trên ComboBox
            cboNVPT.DisplayMember = "MaNV";
        }
        // Lấy mã phòng nhờ tên phòng
        public string LayMaPhongNhoTenPhong(string tenPhong)
        {
            // Trà về mã phòng
            return dal_dky.LayMaPhongNhoTenPhong(tenPhong);
        }
        // Lấy tên nhân viên nhờ MaNV
        public string LayTenNV(string maNV)
        {
            // Trả về tên nhân viên
            return dal_dky.layTenNVNhoMaNV(maNV);
        }
        // Lấy danh sách tên phòng
        public List<string> LayDSTenPhong()
        {
            try
            {
                // Gọi đến phương thức DAL để lấy danh sách tên các phòng khám
                return dal_dky.LayDSTenPhong();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                throw new Exception("Lỗi khi lấy danh sách tên phòng khám: " + ex.Message);
            }
        }
        // Lấy MaBN nhờ MaPKB
        public string layMaBNNhoMaPKB(string maPKB)
        {
            // Trả về mã bệnh nhân
            return dal_dky.layMaBNhoMaPKB(maPKB);
        }
        // Lấy tên bệnh nhân nhờ mã bệnh nhân
        public string layTenBNNhoMaBN(string maBN)
        {
            // Trả về Tên bệnh nhân
            return dal_dky.layTenBNNhoMaBN(maBN);
        }
        // Lấy tên phòng nhờ mã phòng
        public string layTenPhongNhoMaPhong(string maPhong)
        {
            // Trả về tên phòng
            return dal_dky.layTenPhongNhoMaPhong(maPhong);
        }
        // Lấy danh sách tất cả các nhân viên
        public void LayTatCaDSNV(ComboBox cboNV)
        {
            // Gán DataSource cho ComboBox
            cboNV.DataSource = dal_dky.DoDLLenNV();
            // MaNV là dùng để lưu dữ liệu được chọn trong dữ liệu
            cboNV.ValueMember = "MaNV";
            // MaNV là dùng để hiển thị dữ liệu trên ComboBox
            cboNV.DisplayMember = "MaNV";
        }
        // Lấy triệu chứng của phiếu khám bệnh
        public string LayTrieuChung(string msPKB)
        {
            // Trà về dữ liệu
            return dal_dky.layTrieuChungNhoPKB(msPKB);
        }

        // Tạo mã khám tự động
        public string GenerateMaKhamCode(string maPKB)
        {
            return dal_dky.GenerateMaKhamCode(maPKB);
        }
        // Lấy danh sách phiếu khám bệnh theo ngày khám
        public void LayPKBTheoNgayKham(DateTime dtp, ComboBox cbo)
        {
            // Gán DataSource cho ComboBox
            cbo.DataSource = dal_dky.LayPKBTheoNgayKham(dtp);
            // MSPhieuKhamBenh là dùng để lưu dữ liệu được chọn trong dữ liệu
            cbo.ValueMember = "MSPhieuKhamBenh";
            // MSPhieuKhamBenh là dùng để hiển thị dữ liệu trên ComboBox
            cbo.DisplayMember = "MSPhieuKhamBenh";
        }
        // Lấy danh sách đang chờ làm phẫu thuật_xét nghiệm chụp chiếu
        public void LayDSDangChoPT_XNCCTheoNgay(DateTime dtp, DataGridView dgv)
        {
            // Gán DataSource cho DataGridView
            dgv.DataSource = dal_dky.LayDSDangChoPT_XNCCTheoNgay(dtp);
        }
        // Kiểm tra coi tên phòng có chứa Phòng phẫu thuật không
        public bool KiemTraPhong(string tenPhong)
        {
            return tenPhong.Contains("Phòng phẫu thuật");
        }
        // Kiểm tra xem phiếu khám bệnh có chuẩn đoán chứa
        public bool KiemTraCoChuanDoanChua(string maPKB)
        {
            // Trả về true or false
            return dal_dky.KiemTraCoChuanDoanChua(maPKB);
        }
        //Kiểm tra xem đây có phải là phòng khám không
        public bool KiemTraTrangThaiKhamCuaPhongKham(string maKham)
        {
            // Trả về true or false
            return dal_dky.KiemTraTrangThaiKhamCuaPhongKham(maKham);
        }
        public bool KiemTraTrangThaiKhamCuaPhongBenh(string maKham)
        {
            // Trả về true or false
            return dal_dky.KiemTraTrangThaiKhamCuaPhongBenh(maKham);
        }
        // Kiểm tra xem đây có phải lần khám đầu tiên của phiếu khám không
        public bool KiemTraLanKhamDauCuaPKKham(string maPK)
        {
            return dal_dky.KiemTraLanKhamDauCuaPKKham(maPK);
        }
        // Kiểm tra xem đây có phải phòng chức năng hay phòng bệnh không
        public bool KiemTraLoaiPhong(string maPhong)
        {
            // Trả về true or false
            return dal_dky.KiemTraLoaiPhong(maPhong);
        }
        // Kiểm tra xem bệnh nhân đã khám lần nào chưa
        public bool KiemTraDiKhamChua(string maPKB)
        {
            // Trả về true or false
            return dal_dky.KiemTraDiKhamChua(maPKB);
        }
    }
}
