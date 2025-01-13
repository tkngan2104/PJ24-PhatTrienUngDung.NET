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
    public partial class TTNhanVien : Form
    {
        public TTNhanVien()
        {
            InitializeComponent();
        }

        private void TTNhanVien_Load(object sender, EventArgs e)
        {
            BUS_NhanVien.Instance.XemDSNhanVien(dgvTTNhanVien);
            cboChucVu.Items.Clear();
            cboKhoa.Items.Clear();
            BUS_PhongKham.Instance.DoDLKhoaLenCB(cboKhoa);
            BUS_NhanVien.Instance.DoDLCV(cboChucVu);
            dgvTTNhanVien.Columns[8].Visible = false;
            dgvTTNhanVien.Columns[9].Visible = false;
        }

        private void dgvTTNhanVien_Click(object sender, EventArgs e)
        {
            int dong = dgvTTNhanVien.CurrentCell.RowIndex;
            txtMSNhanVien.Text = dgvTTNhanVien.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtTenNV.Text = dgvTTNhanVien.Rows[dong].Cells[1].Value?.ToString() ?? "";
            string gender = dgvTTNhanVien.Rows[dong].Cells[2].Value?.ToString();
            radNam.Checked = (gender == radNam.Text);
            radNu.Checked = (gender == radNu.Text);
            if (DateTime.TryParse(dgvTTNhanVien.Rows[dong].Cells[5].Value?.ToString(), out DateTime birthDate))
            {
                if (birthDate < dtpNgBatDau.MinDate || birthDate > dtpNgBatDau.MaxDate)
                {
                    dtpNgBatDau.Value = DateTime.Today; // Set to current date or any valid date
                }
                else
                {
                    dtpNgBatDau.Value = birthDate; // Only set this if within valid range
                }
            }
            else
            {
                dtpNgBatDau.Value = DateTime.Today; // or any default value if parsing fails
            }
            txtSDT.Text = dgvTTNhanVien.Rows[dong].Cells[3].Value?.ToString() ?? "";
            txtEmail.Text = dgvTTNhanVien.Rows[dong].Cells[4].Value?.ToString() ?? "";
            cboKhoa.SelectedValue = dgvTTNhanVien.Rows[dong].Cells[6].Value?.ToString() ?? "";
            cboChucVu.SelectedValue = dgvTTNhanVien.Rows[dong].Cells[7].Value?.ToString() ?? "";
        }
        public bool KTraMa(string msNV)
        {
            if (msNV.Equals(dgvTTNhanVien.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMSNhanVien.Text.Length == 0 || txtTenNV.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        public string layGioiTinh()
        {
            string gtinh = string.Empty;
            if (radNam.Checked == true)
            {
                gtinh = radNam.Text;
            }
            else
            {
                gtinh = radNu.Text;
            }
            return gtinh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    BUS_NhanVien.Instance.ThemNhanVien(new ET_NhanVien(txtMSNhanVien.Text, txtTenNV.Text, layGioiTinh(), txtSDT.Text, txtEmail.Text, dtpNgBatDau.Value, cboKhoa.SelectedValue.ToString(), cboChucVu.SelectedValue.ToString()));
                    BUS_NhanVien.Instance.XemDSNhanVien(dgvTTNhanVien);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ SĐT và Email!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                BUS_NhanVien.Instance.XoaNhanVien(dgvTTNhanVien);
                BUS_NhanVien.Instance.XemDSNhanVien(dgvTTNhanVien);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    if (KTraMa(txtMSNhanVien.Text) == true)
                    {
                        BUS_NhanVien.Instance.SuaNhanVien(new ET_NhanVien(txtMSNhanVien.Text, txtTenNV.Text, layGioiTinh(), txtSDT.Text, txtEmail.Text, dtpNgBatDau.Value, cboKhoa.SelectedValue.ToString(), cboChucVu.SelectedValue.ToString()));
                        BUS_NhanVien.Instance.XemDSNhanVien(dgvTTNhanVien);
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa mã bệnh nhân " + dgvTTNhanVien.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMSNhanVien.Text = dgvTTNhanVien.CurrentRow.Cells[0].Value.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ SĐT và Email!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void txtMSNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMSNhanVien.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã nhân viên quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt và khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenNV.Text.Length > 49 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tên nhân viên quá 50 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.') || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt và khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text.Length > 29 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập email quá 30 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpNgBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgBatDau.Value > DateTime.Now)
            {
                MessageBox.Show("Không thể chỉnh ngày lớn hơn ngày hiện tại !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgBatDau.Value = DateTime.Now;
            }
        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            txtSDT.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtSDT.Text.Length != 10)  // 10 số cho số điện thoại
            {
                MessageBox.Show("Bạn phải nhập đủ 10 chữ số cho số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;  // Dừng sự kiện và giữ focus tại MaskedTextBox cho đến khi nhập đúng
            }
            // Đặt lại TextMaskFormat nếu cần
            txtSDT.TextMaskFormat = MaskFormat.IncludeLiterals;
        }
    }
}
