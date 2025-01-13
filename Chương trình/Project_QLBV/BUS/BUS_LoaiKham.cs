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
    public class BUS_LoaiKham
    {
        // Khai báo biến tĩnh
        private static BUS_LoaiKham instance;
        private DAL_LoaiKham dal_lk = new
           DAL_LoaiKham();

        public static BUS_LoaiKham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_LoaiKham();
                }
                return instance;
            }
        }
        // Xem danh sách loại khám
        public void XemDSLoaiKham(DataGridView dgvDSLK)
        {
            // Gán DataSource cho DataGridView
            dgvDSLK.DataSource = dal_lk.XemDSLoaiKham();
        }
        // Thêm loại khám
        public void ThemLoaiKham(ET_LoaiKham etLoaiKham)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_lk.ThemLoaiKham(etLoaiKham) == true)
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
        // Xóa loại khám
        public void XoaLoaiKham(DataGridView dgvDSLoaiKham)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_lk.XoaLoaiKham(dgvDSLoaiKham.CurrentRow.Cells[0].Value.ToString()) == true)
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
        // Sửa loại khám
        public void SuaLoaiKham(ET_LoaiKham etLoaiKham)
        {
            dal_lk.SuaLoaiKham(etLoaiKham);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //if (DAL_LoaiKham.Instance.SuaLoaiKham(etLoaiKham) == true)
            //{
            //    MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Dữ liệu đã có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
