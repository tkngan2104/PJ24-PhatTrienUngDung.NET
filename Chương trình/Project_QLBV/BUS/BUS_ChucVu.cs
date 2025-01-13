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
    public class BUS_ChucVu
    {
        // Khai báo biến tĩnh
        private static BUS_ChucVu instance;
        private DAL_ChucVu dal_cv = new
           DAL_ChucVu();

        public static BUS_ChucVu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChucVu();
                }
                return instance;
            }
        }
        // Xem danh sách chức vụ
        public void ListCV(DataGridView dgvCV)
        {
            // Gán DataSource cho DataGridView
            dgvCV.DataSource = dal_cv.ListCV();
        }

        public void ThemCV(ET_ChucVu etCV)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_cv.ThemCV(etCV) == true)
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
        // Xóa chức vụ
        public void XoaCV(DataGridView dgvCV)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_cv.XoaCV(dgvCV.CurrentRow.Cells[0].Value.ToString()) == true)
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
        // Sửa chức vụ
        public void SuaCV(ET_ChucVu etCV)
        {
            //DAL_ChucVu.Instance.SuaCV(etCV);
            //MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dal_cv.SuaCV(etCV) == true)
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
