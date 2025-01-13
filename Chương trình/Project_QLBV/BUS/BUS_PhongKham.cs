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
    public class BUS_PhongKham
    {
        // Khai báo biến tĩnh
        private static BUS_PhongKham instance;
        private DAL_PhongKham dal_pk = new
           DAL_PhongKham();

        private DAL_Khoa dal_kh = new
           DAL_Khoa();
        public static BUS_PhongKham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_PhongKham();
                }
                return instance;
            }
        }
        // Xem danh sách phòng khám
        public void LayDSPhongKham(DataGridView dgvDSPhongKham, string maKhoa)
        {
            // Gán DataSource cho DataGridView
            dgvDSPhongKham.DataSource = dal_pk.XemDSPhongKham(maKhoa);
        }
        // Đổ dữ liệu khoa lên ComboBox
        public void DoDLKhoaLenCB(ComboBox cboKhoa)
        {
            // Gán DataSource cho ComboBox
            cboKhoa.DataSource = dal_kh.XemDSKhoa();
            // MaKhoa là để lưu trữ dữ liệu dưới bảng
            cboKhoa.ValueMember = "MaKhoa";
            // TenKhoa là để hiển thị dữ liệu trong ComboBox
            cboKhoa.DisplayMember = "TenKhoa";
        }
        // Thêm phòng khám
        public void ThemPhongKham(ET_PhongKham etPK)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_pk.ThemPhongKham(etPK) == true)
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
        // Xóa phòng khám
        public void XoaPhongKham(DataGridView dgvDSKham)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_pk.XoaPhongKham(dgvDSKham.CurrentRow.Cells[0].Value.ToString()) == true)
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
        //Sửa phòng khám
        public void SuaPhongKham(ET_PhongKham etPK)
        {
            dal_pk.SuaPhongKham(etPK);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
