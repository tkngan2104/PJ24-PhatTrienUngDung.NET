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
    public class BUS_GiuongBenh
    {
        // Khai báo biến tĩnh
        private static BUS_GiuongBenh instance;
        private DAL_GiuongBenh dal_gb = new
           DAL_GiuongBenh();

        public static BUS_GiuongBenh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_GiuongBenh();
                }
                return instance;
            }
        }
        // Xem danh sách giường bệnh
        public void XemDSGiuongBenh(DataGridView dgvDSGB, string maPhong)
        {
            // Gán DataSource cho DataGridView
            dgvDSGB.DataSource = dal_gb.XemDSGiuongBenh(maPhong);
        }
        // Thêm giường bệnh
        public void ThemGiuongBenh(ET_GiuongBenh etGB)
        {
            // Kiểm tra xem số giường của phòng đó có vượt qua số giường đã quy định của phòng khám không dựa vào số giường bên bảng PhongKham
            if (dal_gb.KiemTraSoGiuong(etGB.MsPhong) == true)
            {
                //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
                if (dal_gb.ThemGiuongBenh(etGB) == true)
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
            else
            {
                // Nếu số giường vượt quá giới hạn thì sẽ hiện lên thông báo này
                MessageBox.Show("Số lượng giường trong phòng đã đạt giới hạn !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Xóa giường bệnh
        public void XoaGiuongBenh(DataGridView dgvDSGB)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_gb.XoaGiuongBenh(dgvDSGB.CurrentRow.Cells[0].Value.ToString()) == true)
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
        // Sửa giường bệnh
        public void SuaGiuongBenh(ET_GiuongBenh etGB)
        {
            dal_gb.SuaGiuongBenh(etGB);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Đổ dữ liệu phòng lên ComboBox
        public void DoDLPhongLenCB(ComboBox cboPhongKham)
        {
            // Gán DataSource cho ComboBox
            cboPhongKham.DataSource = dal_gb.LayDSPhongBenh();
            //TenPhong là thuộc tính để hiển thị dữ liệu lên ComboBox
            cboPhongKham.DisplayMember = "TenPhong";
            //MSPhong là thuộc tính để lưu trữ dữ liệu 
            cboPhongKham.ValueMember = "MSPhong";
        }
    }
}
