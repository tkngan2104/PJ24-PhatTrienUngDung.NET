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
    public class BUS_XetNghiemPhauThuat
    {
        // Khai báo biến tĩnh
        private static BUS_XetNghiemPhauThuat instance;
        private DAL_XetNghiemPhauThuat dal_xn = new
           DAL_XetNghiemPhauThuat();
        private DAL_LoaiBenhAn dal_lba = new
           DAL_LoaiBenhAn();

        public static BUS_XetNghiemPhauThuat Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_XetNghiemPhauThuat();
                }
                return instance;
            }
        }
        // Lấy danh sách làm phẫu thuật_xét nghiệm chụp chiếu
        public void XemDSLamPTXNCC(DataGridView dgvDS)
        {
            // Gắn DataSource theo DataGridView
            dgvDS.DataSource = dal_xn.XemDSLamPTXNCC();
        }
        // Thêm vô danh sách làm PT_XNCC
        public void ThemDSLamPTXNCC(ET_XetNghiemPhauThuat et)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_xn.ThemDSPTXNCC(et) == true)
            {
                // Khi thêm thành công sẽ hiển thị thông báo này
                MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Khi thêm không thành công sẽ hiển thị thông báo này và ta biết mã bị trùng
                MessageBox.Show("Bệnh nhân đã thực hiện yêu cầu này !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Sửa danh sách PT_XNCC
        public void SuaDSLamPTXNCC(ET_XetNghiemPhauThuat et)
        {
            dal_xn.SuaDSLamPTXNCC(et);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Kiểm tra xem khi chọn rad Phẫu thuật thì có chuẩn đoán chưa thì mới được thực hiện
        public bool KiemTra(string msPKB)
        {
            return dal_xn.KiemTraPhauThuat(msPKB);
        }
        // Lấy Danh sách tên dịch vụ
        public List<string> LayDSTenDV(string tenDV)
        {
            try
            {
                // Gọi đến phương thức DAL để lấy danh sách tên các phòng khám
                return dal_xn.XemDSDichVu(tenDV);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                throw new Exception("Lỗi khi lấy danh sách tên phòng khám: " + ex.Message);
            }
        }
        // Lấy mã phiếu khám bệnh từ mã yêu cầu của bảng Kham
        public string layMSPhieuKhamBenh(string maYC)
        {
            return dal_xn.layMSPhieuKhamBenh(maYC);
        }
        // Lấy mã phòng từ mã yêu cầu của bảng Kham
        public string layMaPhongTuYC(string maYC)
        {
            return dal_xn.layMaPhongCuaYC(maYC);
        }
        // Lấy MaNV từ mã yêu cầu
        public string layMaNVTuYC(string maYC)
        {
            return dal_xn.layMaNVCuaYC(maYC);
        }
        // Lấy Mã dịch vụ từ tên dịch vụ
        public string layMaDVTuTenDV(string tenDV)
        {
            return dal_xn.layMaDVTuTenDV(tenDV);
        }
        // Lấy tên dịch vụ từ mã dịch vụ
        public string layTenDVTuMaDVDV(string maDV)
        {
            return dal_xn.layTenTuMaDV(maDV);
        }
        // Đổ dữ liệu từ loại bệnh án lên ComboBox
        public void doDLLoaiBA(ComboBox cboLoaiBA)
        {
            // Gán DataSource cho ComboBox
            cboLoaiBA.DataSource = dal_lba.XemDSLoaiBenhAn();
            // TenLoaiBA là để hiển thị dữ liệu trong ComboBox
            cboLoaiBA.DisplayMember = "TenLoaiBA";
            // MaLoaiBA là để lưu trữ dữ liệu dưới bảng
            cboLoaiBA.ValueMember = "MaLoaiBA";
        }
    }
}
