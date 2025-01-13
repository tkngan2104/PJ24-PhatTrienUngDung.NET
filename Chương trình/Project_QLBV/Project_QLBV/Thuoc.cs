using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLBV
{
    public partial class Thuoc : Form
    {
        public Thuoc()
        {
            InitializeComponent();
        }

        private void Thuoc_Load(object sender, EventArgs e)
        {
            BUS_Thuoc.Instance.ListTHUOC(dgvDanhSachDuocPham);
        }

        private void dgvDanhSachDuocPham_Click(object sender, EventArgs e)
        {
            int dong = dgvDanhSachDuocPham.CurrentCell.RowIndex;
            txtMSThuoc.Text = dgvDanhSachDuocPham.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtTenThuoc.Text = dgvDanhSachDuocPham.Rows[dong].Cells[1].Value?.ToString() ?? "";
            txtDangThuoc.Text = dgvDanhSachDuocPham.Rows[dong].Cells[2].Value?.ToString() ?? "";
            txtDVTinh.Text = dgvDanhSachDuocPham.Rows[dong].Cells[3].Value?.ToString() ?? "";
            txtXuatXu.Text = dgvDanhSachDuocPham.Rows[dong].Cells[5].Value?.ToString() ?? "";
            txtDonGia.Text = dgvDanhSachDuocPham.Rows[dong].Cells[4].Value?.ToString() ?? "";
        }
        public bool KTraMa(string msThuoc)
        {
            if (msThuoc.Equals(dgvDanhSachDuocPham.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMSThuoc.Text.Length == 0 || txtTenThuoc.Text.Length == 0 || txtDangThuoc.Text.Length == 0 || txtDVTinh.Text.Length == 0 || txtXuatXu.Text.Length == 0 || txtDonGia.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    BUS_Thuoc.Instance.ThemThuoc(new ET_Thuoc(txtMSThuoc.Text, txtTenThuoc.Text, txtDangThuoc.Text, txtDVTinh.Text, float.Parse(txtDonGia.Text), txtXuatXu.Text));
                    BUS_Thuoc.Instance.ListTHUOC(dgvDanhSachDuocPham);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachDuocPham.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BUS_Thuoc.Instance.XoaThuoc(dgvDanhSachDuocPham);
                    BUS_Thuoc.Instance.ListTHUOC(dgvDanhSachDuocPham);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachDuocPham.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMSThuoc.Text) == true)
                        {
                            BUS_Thuoc.Instance.SuaThuoc(new ET_Thuoc(txtMSThuoc.Text, txtTenThuoc.Text, txtDangThuoc.Text, txtDVTinh.Text, float.Parse(txtDonGia.Text), txtXuatXu.Text));
                            BUS_Thuoc.Instance.ListTHUOC(dgvDanhSachDuocPham);
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa mã thuốc !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMSThuoc.Text = dgvDanhSachDuocPham.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi trang này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMSThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMSThuoc.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã thuốc quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenThuoc.Text.Length > 99 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tên thuốc quá 100 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDangThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDangThuoc.Text.Length > 149 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập dạng thuốc quá 150 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDVTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDVTinh.Text.Length > 49 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập đơn vị tính quá 50 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập khoảng trắng, ký tự đặc biệt hay chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtXuatXu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtXuatXu.Text.Length > 99 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập xuất xứ quá 100 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
