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
    public class BUS_BangGia
    {
        // Khai báo biến tĩnh
        private static BUS_BangGia instance;
        private DAL_BangGia dal_bg = new
           DAL_BangGia();
        private DAL_LoaiPTXN dal_lpt = new
           DAL_LoaiPTXN();

        public static BUS_BangGia Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_BangGia();
                }
                return instance;
            }
        }
        // Load danh sách các dịch vụ và giá cả của nó
        public void XemDSBangGia(DataGridView dgvDSBangGia)
        {
            // Gán DataSource cho DataGridView
            dgvDSBangGia.DataSource = dal_bg.XemDSBangGia();
        }
        //Thêm dịch vụ vô bảng giá
        public void ThemBangGia(ET_BangGia etBangGia)
        {          
            if (dal_bg.ThemDichVu(etBangGia) == true)
            {
                // Khi không có mã trùng thì sẽ thêm được dịch vụs
                MessageBox.Show("Thêm dịch vụ thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else
            {
                // Khi có mã trùng thì sẽ hiện thông báo
                MessageBox.Show("Đã có dịch vụ trong danh sách !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Xóa dịch vụ
        public void XoaDichVu(DataGridView dgvDSDV)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_bg.XoaBangGia(dgvDSDV.CurrentRow.Cells[0].Value.ToString()) == true)
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

        // Sửa bảng giá
        public void SuaBangGia(ET_BangGia etBG)
        {
            dal_bg.SuaDichVu(etBG);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Đổ dữ liệu danh sách các loại phẫu thuật_xét nghiệm chụp chiếu vào ComboBox
        public void DoDLLoaiPT_XNCCVaoCB(ComboBox cboDV)
        {
            // Gán DataSource cho ComboBox
            cboDV.DataSource = dal_lpt.XemDSLoaiPT_XNCC();
            cboDV.DisplayMember = "Ten";//Ten sẽ là thuộc tính hiển thị lên cho ComboBox
            cboDV.ValueMember = "LoaiPT_XNCC1";//LoaiPT_XNCC là thuộc tính để lưu trữ dưới bảng
        }
    }
}
