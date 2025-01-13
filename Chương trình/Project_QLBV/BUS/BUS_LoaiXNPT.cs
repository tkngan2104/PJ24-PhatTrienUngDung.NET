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
    public class BUS_LoaiXNPT
    {
        // Khai báo biến tĩnh
        private static BUS_LoaiXNPT instance;
        private DAL_LoaiPTXN dal_lpt = new
           DAL_LoaiPTXN();

        public static BUS_LoaiXNPT Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_LoaiXNPT();
                }
                return instance;
            }
        }
        // Xem danh sách loại PT_XNCC
        public void XemDSLoaiPT_XNCC(DataGridView dgvDSLoaiPT_XNCC)
        {
            // Gán DataSource cho DataGridView
            dgvDSLoaiPT_XNCC.DataSource = dal_lpt.XemDSLoaiPT_XNCC();
        }
        // Thêm loại PT_XNCC
        public void ThemLoaiPT_XNCC(ET_LoaiPTXN etLoaiPTXNCC)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_lpt.ThemLoaiPT_XNCC(etLoaiPTXNCC) == true)
            {
                // Khi thêm thành công sẽ hiển thị thông báo này
                MessageBox.Show("Hoàn tất thêm dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Khi thêm không thành công sẽ hiển thị thông báo này và ta biết mã bị trùng
                MessageBox.Show("Dữ liệu đã có trong hệ trống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Xóa loại PT_XNCC
        public void XoaLoaiPT_XNCC(DataGridView dgvLoaiPT)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_lpt.XoaLoaiPT_XNCC(dgvLoaiPT.CurrentRow.Cells[0].Value.ToString()) == true)
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
        // Sửa loại PT_XNCC
        public void SuaLoaiPT_XNCC(ET_LoaiPTXN etLoaiPTXNCC)
        {
            //DAL_LoaiPTXN.Instance.SuaLoaiPT_XNCC(etLoaiPTXNCC);
            //MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dal_lpt.SuaLoaiPT_XNCC(etLoaiPTXNCC) == true)
            {
                MessageBox.Show("Hoàn tất sửa dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đã có trong hệ trống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
