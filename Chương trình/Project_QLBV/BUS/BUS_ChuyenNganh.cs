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
    public class BUS_ChuyenNganh
    {
        // Khai báo biến tĩnh
        private static BUS_ChuyenNganh instance;
        private DAL_ChuyenNganh dal_cn = new
           DAL_ChuyenNganh();
        private DAL_Khoa dal_kh = new
           DAL_Khoa();

        public static BUS_ChuyenNganh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChuyenNganh();
                }
                return instance;
            }
        }
        // Lấy danh sách chuyên ngành
        public void ListCN(DataGridView dgvCN)
        {
            // Gán DataSource cho DataGridView
            dgvCN.DataSource = dal_cn.ListCN();
        }
        // Lấy dữ liệu khoa vào ComboBox
        public void DoDuLieuKhoa(ComboBox cboKhoa)
        {
            // Gán DataSource cho DataGridView
            cboKhoa.DataSource = dal_kh.XemDSKhoa();
            // TenKhoa sẽ là thuộc tính để hiển thị lên ComboBox
            cboKhoa.DisplayMember = "TenKhoa";
            // MaKhoa sẽ là thuộc tính để lưu vào bảng
            cboKhoa.ValueMember = "MaKhoa";
        }

        public void ThemCN(ET_ChuyenNganh etCN)
        {
            if (dal_cn.ThemCN(etCN) == true)
            {
                MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đã có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void XoaCN(DataGridView dgvCN)
        {
            if (dal_cn.XoaCN(dgvCN.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                MessageBox.Show("Hoàn tất xóa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể xóa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SuaCN(ET_ChuyenNganh etCN)
        {
            dal_cn.SuaCN(etCN);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
