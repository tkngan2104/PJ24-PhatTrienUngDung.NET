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
    public class BUS_Thuoc
    {
        // Khai báo biến tĩnh
        private static BUS_Thuoc instance;
        private DAL_Thuoc dal_thuoc = new
           DAL_Thuoc();

        public static BUS_Thuoc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Thuoc();
                }
                return instance;
            }
        }
        // Xem danh sách thuốc
        public void ListTHUOC(DataGridView dgvTHUOC)
        {
            // Gắn DataSource cho DataGridView
            dgvTHUOC.DataSource = dal_thuoc.ListTHUOC();
        }
        // Thêm thuốc
        public void ThemThuoc(ET_Thuoc etThuoc)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_thuoc.ThemThuoc(etThuoc) == true)
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
        // Xóa thuốc
        public void XoaThuoc(DataGridView dgvTHUOC)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_thuoc.XoaThuoc(dgvTHUOC.CurrentRow.Cells[0].Value.ToString()) == true)
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
        // Sửa thuốc
        public void SuaThuoc(ET_Thuoc etThuoc)
        {
            dal_thuoc.SuaThuoc(etThuoc);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
