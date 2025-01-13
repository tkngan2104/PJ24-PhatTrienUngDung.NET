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
    public class BUS_BenhLy
    {
        // Khai báo biến tĩnh
        private static BUS_BenhLy instance;
        private DAL_BenhLy dal_bl = new
           DAL_BenhLy();

        public static BUS_BenhLy Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_BenhLy();
                }
                return instance;
            }
        }
        // Lấy danh sách bệnh bệnh lý
        public void XemDSBenhLy(DataGridView dgvDSBenhLy)
        {
            // Gán DataSource cho DataGridView
            dgvDSBenhLy.DataSource = dal_bl.XemDSBenhLy();
        }
        //Thêm danh sách bệnh lý
        public void ThemBenhLy(ET_BenhLy etBenhLy)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_bl.ThemBenhLy(etBenhLy) == true)
            {
                // Khi thêm thành công sẽ hiển thị thông báo này
                MessageBox.Show("Thêm bệnh lý thành công !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Khi thêm không thành công sẽ hiển thị thông báo này và ta biết mã bị trùng
                MessageBox.Show("Đã có bệnh trong danh sách !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // Xóa bệnh lý
        public void XoaBenhLy(DataGridView dgvDSBenhLy)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_bl.XoaBenhLy(dgvDSBenhLy.CurrentRow.Cells[0].Value.ToString()) == true)
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
        // Sửa bệnh lý
        public void SuaBenhLy(ET_BenhLy etBenhLy)
        {
            dal_bl.SuaBenhLy(etBenhLy);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
