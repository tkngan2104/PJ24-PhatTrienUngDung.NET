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
    public class BUS_ChuanDoan
    {
        // Khai báo biến tĩnh
        private static BUS_ChuanDoan instance;
        private DAL_ChuanDoan dal_cd = new
           DAL_ChuanDoan();
        private DAL_LoaiBenhAn dal_lba = new
           DAL_LoaiBenhAn();
        private DAL_ToaThuoc dal_tt = new
           DAL_ToaThuoc();

        public static BUS_ChuanDoan Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChuanDoan();
                }
                return instance;
            }
        }
        // Lấy danh sách chuẩn đoán theo ngày
        public void XemDSChuanDoan(DataGridView dgvDSCD, DateTime dtpNgay)
        {
            // Gán DataSource cho DataGridView
            dgvDSCD.DataSource = dal_cd.XemDSChuanDoan(dtpNgay);
        }
        // Thêm chuẩn đoán
        public void ThemChuanDoan(ET_ChuanDoan etCD)
        {          
            if (dal_cd.KiemTraTrangThai(etCD.MsPhieuKhamBenh, etCD.MsNV))
            {
                //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
                if (DAL_ChuanDoan.Instance.ThemChuanDoan(etCD) == true)
                {
                    // Khi thêm thành công sẽ hiển thị thông báo này
                    MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Khi thêm không thành công sẽ hiển thị thông báo này và ta biết mã bị trùng
                    MessageBox.Show("Bệnh nhân đã được chuẩn đoán rồi !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bệnh nhân chưa được khám !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Xóa chuẩn đoán 
        public void XoaChuanDoan(DataGridView dgvDSChuanDoan)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_cd.XoaChuanDoan(dgvDSChuanDoan.CurrentRow.Cells[0].Value.ToString()) == true)
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
        // Sửa chuẩn đoán
        public void SuaChuanDoan(ET_ChuanDoan etCD)
        {
            dal_cd.SuaChuanDoan(etCD);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Đổ dữ liệu các loại bệnh án vào ComboBox
        public void DoDLLoaiBALenCB(ComboBox cboLoaiBA)
        {
            // Gán DataSource cho ComboBox
            cboLoaiBA.DataSource = dal_lba.XemDSLoaiBenhAn();
            // MaLoaiBA là để lưu trữ dữ liệu bằng mã
            cboLoaiBA.ValueMember = "MaLoaiBA";
            // TenLoaiBA là để hiển thị dữ liệu là tên
            cboLoaiBA.DisplayMember = "TenLoaiBA";
        }
        // Dựa vào mã yêu cầu của bảng Kham lấy maNV phụ trách
        public string layMaNVNhoMaNVYCau(string maYC)
        {
            // Trả về mã NVPhuTrach
            return dal_cd.LayMaNVNhoMaYeuCau(maYC);
        }
        // Dựa vào mã yêu cầu của bảng Kham lấy tên phòng
        public string layTenPhongNhoMaYCau(string maYC)
        {
            // Trả về tên phòng
            return dal_cd.LayTenPhongNhoMaYeuCau(maYC);
        }
        // Tạo mã chuẩn đoán tự đõng
        public string GenerateChuanDoanCode(string maPKB)
        {
            return dal_cd.GenerateChuanDoanCode(maPKB);
        }

        public void LayLanKhamNhoPhieuKhamBenh(string msPKB, ComboBox cboLK)
        {
            cboLK.DataSource = dal_cd.LayLanKhamNhoPhieuKhamBenh(msPKB);
            cboLK.ValueMember = "MaYeuCau";
            cboLK.DisplayMember = "MaYeuCau";
        }

        public void LayDSPhieuKhamBenh(ComboBox cboPKB)
        {
            cboPKB.DataSource = dal_cd.LayDSPhieuKhamBenh();
            cboPKB.ValueMember = "MSPhieuKhamBenh";
            cboPKB.DisplayMember = "MSPhieuKhamBenh";
        }
        // Lấy danh sách bệnh lý
        public List<string> LayDSTenBenhLy()
        {
            try
            {
                // Phương thức này trả về danh sách các chuỗi, mỗi chuỗi là tên của một bệnh lý.
                return dal_cd.LayDSBenhLy();
            }
            catch (Exception ex)
            {
                // Trong trường hợp xảy ra lỗi khi truy cập hoặc xử lý dữ liệu, ném ra một ngoại lệ mới.
                throw new Exception("Lỗi khi lấy danh sách tên phòng khám: " + ex.Message);
            }
        }
        // Lấy được tên bệnh nhờ mã bệnh
        public string LayTenBenhNhoMaBenh(string maBenh)
        {
            // Trả về tên bệnh nhờ mã bệnh
            return dal_cd.layTenBenhNhoMaBenh(maBenh);
        }
        // Lấy mã bệnh nhờ tên bệnh
        public string LayMaBenhNhoTenBenh(string tenBenh)
        {
            // Trả về mã bệnh nhờ tên bệnh
            return dal_cd.layMaBenhNhoTenBenh(tenBenh);

        }
        public float LayGiaTienCuaThuoc(string msThuoc)
        {
            return dal_tt.LayDSGiaTienCuaThuoc(msThuoc);
        }
        // Tìm danh sách phiếu khám bệnh đã có toa thuốc
        public void TimDSCoToaThuoc(DataGridView dgvDSCD, DateTime dtpNgay)
        {
            // Gán DataSource cho DataGridView
            dgvDSCD.DataSource = dal_cd.TimDSCoToaThuoc(dtpNgay);
        }
        // Tìm danh sách phiếu khám bệnh chưa có toa thuốc
        public void TimDSChuaToaThuoc(DataGridView dgvDSCD, DateTime dtpNgay)
        {
            // Gán DataSource cho DataGridView
            dgvDSCD.DataSource = dal_cd.TimDSChuaToaThuoc(dtpNgay);
        }
    }
}
