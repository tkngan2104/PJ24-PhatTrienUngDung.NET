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
    public class BUS_ToaThuoc
    {
        // Khai báo biến tĩnh
        private static BUS_ToaThuoc instance;
        private DAL_ToaThuoc dal_tt = new
           DAL_ToaThuoc();

        public static BUS_ToaThuoc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ToaThuoc();
                }
                return instance;
            }
        }
        // Xem danh sách toa thuốc
        public void XemDSTTThuoc(DataGridView dgvDSTT, string msPKB)
        {
            // Gắn DataSource cho DataGridView
            dgvDSTT.DataSource = dal_tt.XemDSToaThuoc(msPKB);
        }
        // Thêm thuốc vào toa thuốc
        public void ThemThuocVaoTT(ET_ToaThuoc etToaThuoc)
        {
            //Kiểm tra mã số toa thuốc + mã phiếu khám bệnh + mã thuốc trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_tt.ThemThuocVoToa(etToaThuoc) == true)
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
        // Xóa thuốc khỏi toa thuốc
        public void XoaThuoc(DataGridView dgvTT)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_tt.XoaThuocKhoiToa(dgvTT.CurrentRow.Cells[0].Value.ToString(), dgvTT.CurrentRow.Cells[1].Value.ToString()) == true)
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
        // Lấy danh sách tên thuốc
        public List<string> LayDSTenThuoc()
        {
            try
            {
                // Gọi đến phương thức DAL để lấy danh sách tên các phòng khám
                return dal_tt.LayDSThuoc();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                throw new Exception("Lỗi khi lấy danh sách tên thuốc: " + ex.Message);
            }
        }

        // Lấy mã thuốc nhờ tên thuốc
        public string LayMaThuocNhoTenThuoc(string tenThuoc)
        {
            return DAL_ToaThuoc.Instance.LayMaThuocNhoTenThuoc(tenThuoc);
        }
        // Lấy tên thuốc nhờ mã thuốc
        public string LayTenThuocNhoMaThuoc(string maThuoc)
        {
            return DAL_ToaThuoc.Instance.LayTenThuocNhoMaThuoc(maThuoc);
        }
        // Lấy giá tiền của thuốc nhờ mã thuốc
        public float LayGiaTienNhoMaThuoc(string maThuoc)
        {
            return DAL_ToaThuoc.Instance.LayDSGiaTienCuaThuoc(maThuoc);
        }
        // Lấy mã chuẩn đoán nhờ phiếu khám bệnh
        public string LayMaCDNhoPKB(string maPKB)
        {
            return DAL_ToaThuoc.Instance.LayMaCDNhoPKB(maPKB);
        }
        // Lấy chuẩn đoán nhớ phiếu khám bệnh
        public string LayChuanDoanNhoPKB(string maPKB)
        {
            return DAL_ToaThuoc.Instance.LayChuanDoanCuaPKB(maPKB);
        }
        // Lấy danh sách nhân viên khoa dược
        public void LayDSNVKhoaDuoc(ComboBox cboNV)
        {
            // Gán DataSource cho ComboBox
            cboNV.DataSource = DAL_ToaThuoc.Instance.DoDLNVKhoaDuocLenCB();
            // MaNV là để lưu trữ dữ liệu dưới bảng
            cboNV.ValueMember = "MaNV";
            // MaNV là để hiển thị dữ liệu trong ComboBox
            cboNV.DisplayMember = "MaNV";
        }
        // Cập nhập tiền của toa thuốc
        public void CapNhapTienCuaTThuoc()
        {
            DAL_ToaThuoc.Instance.CapNhapTienCuaTThuoc();
        }
        // Cập nhập giá tiền
        public void CapNhapGiaTien()
        {
            DAL_ToaThuoc.Instance.CapNhapGiaTien();
        }
        // Tạo mã toa thuốc
        public string GenerateToaThuocCode(string maPKB)
        {
            return DAL_ToaThuoc.Instance.GenerateToaThuocCode(maPKB);
        }
    }
}
