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
    public class BUS_BHYT
    {
        // Khai báo biến tĩnh
        private static BUS_BHYT instance;
        private DAL_BHYT dal_bhyt = new
           DAL_BHYT();
        private DAL_BenhNhan dal_bn = new
           DAL_BenhNhan();
        public static BUS_BHYT Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_BHYT();
                }
                return instance;
            }
        }
        // Xem danh sách bảo hiểm y tế
        public void XemDSBHYT(DataGridView dgvDSBHYT)
        {
            // Gán DataSource cho DataGridView
            dgvDSBHYT.DataSource = dal_bhyt.XemBHYT();
        }
        // Thêm bệnh lý
        public void Thembhyt(ET_BHYT etbhyt)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_bhyt.ThemBHYT(etbhyt) == true)
            {
                // Khi thêm thành công sẽ hiển thị thông báo này
                MessageBox.Show("Thêm bảo hiểm y tế !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Khi thêm không thành công sẽ hiển thị thông báo này và ta biết mã bị trùng
                MessageBox.Show("Bệnh nhân đã có bảo hiểm y tế !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // Xóa bảo hiểm y tế
        public void XoaDSBHYT(DataGridView dgvDSBHYT)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_bhyt.XoaBHYT(dgvDSBHYT.CurrentRow.Cells[0].Value.ToString()) == true)
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
        // Sửa BHYT
        public void SuaDSBHYT(ET_BHYT etBHYT)
        {
            dal_bhyt.SuaBHYT(etBHYT);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        public void DoDLBenhNhanChuaCoBHYT(ComboBox cboBN)
        {
            // Cập nhật dữ liệu vào ComboBox
            cboBN.DataSource = dal_bhyt.DoDLCBDSBNChuaCoBHYT();
            cboBN.ValueMember = "MSBN";
            cboBN.DisplayMember = "MSBN";

        }

        public void DoDLBenhNhanVoCB(ComboBox cboBN)
        {
            cboBN.DataSource = dal_bn.XemDSBN();
            cboBN.ValueMember = "MSBN";
            cboBN.DisplayMember = "MSBN";
        }
        //Cập nhập ngày hết hạn dựa vào ngày cấp phát và tự cộng thêm 5 năm
        public void CapNhapNgayHH()
        {
            dal_bhyt.CapNhatNgayHetHan();
        }
        //Kiểm tra xem BHYT hết hạn chưa
        public bool KiemTraXemBHYTHetHanChua(string maBHYT)
        {
            return dal_bhyt.KiemTraXemBHYTHetHanChua(maBHYT);
        }
    }
}
