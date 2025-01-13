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
    public class BUS_LoaiBenhAn
    {
        // Khai báo biến tĩnh
        private static BUS_LoaiBenhAn instance;
        private DAL_LoaiBenhAn dal_lba = new
           DAL_LoaiBenhAn();

        public static BUS_LoaiBenhAn Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_LoaiBenhAn();
                }
                return instance;
            }
        }
        // Xem danh sách loại bệnh án
        public void XemDanhSachLoaiBA(DataGridView dgvLoaiBA)
        {
            // Gán DataSource cho DataGridView
            dgvLoaiBA.DataSource = dal_lba.XemDSLoaiBenhAn();
        }
        // Thêm loại bệnh án
        public void ThemLoaiBA(ET_LoaiBenhAn etLoaiBA)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_lba.ThemLoaiBA(etLoaiBA) == true)
            {
                // Khi thêm thành công sẽ hiển thị thông báo này
                MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Khi thêm không thành công sẽ hiển thị thông báo này và ta biết mã bị trùng
                MessageBox.Show("Dữ liệu có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa loại bệnh án
        public void XoaLoaiBA(DataGridView dgvLoaiBA)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_lba.XoaLoaiBenhAn(dgvLoaiBA.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                // Hiện lên thông báo khi xóa thành công
                MessageBox.Show("Hoàn tất xóa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hiện lên thông báo khi xóa không thành công
                MessageBox.Show("Dữ liệu đang được đối chuyên ngành !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Sửa loại bệnh án
        public void SuaLoaiBA(ET_LoaiBenhAn etLoaiBA)
        {
            //DAL_LoaiBenhAn.Instance.SuaLoaiBenhAn(etLoaiBA);
            //MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dal_lba.SuaLoaiBenhAn(etLoaiBA) == true)
            {
                MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
