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
    public class BUS_Khoa
    {
        // Khai báo biến tĩnh
        private static BUS_Khoa instance;
        private DAL_Khoa dal_kh = new
            DAL_Khoa(); 

        public static BUS_Khoa Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Khoa();
                }
                return instance;
            }
        }
        // Xem danh sách khoa
        public void XemDSKhoa(DataGridView dgvKHOA)
        {
            // Gán DataSource cho DataGridView
            dgvKHOA.DataSource = dal_kh.XemDSKhoa();
        }
        // Thêm khoa
        public void ThemKhoa(ET_Khoa etKhoa)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_kh.ThemKhoa(etKhoa) == true)
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
        // Xóa khoa
        public void XoaKhoa(DataGridView dgvKHOA)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_kh.XoaKhoa(dgvKHOA.CurrentRow.Cells[0].Value.ToString()) == true)
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
        // Sửa khoa
        public void SuaKhoa(ET_Khoa etKhoa)
        {
            //DAL_Khoa.Instance.SuaKhoa(etKhoa);
            //MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dal_kh.SuaKhoa(etKhoa) == true)
            {
                MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đã có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
