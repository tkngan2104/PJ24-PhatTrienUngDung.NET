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
    public partial class TTBenhNhan : Form
    {
        public TTBenhNhan()
        {
            InitializeComponent();
        }
        private _menu mainForm;

        public TTBenhNhan(_menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private void TTBenhNhan_Load(object sender, EventArgs e)
        {
            BUS_BenhNhan.Instance.XemDSBenhNhan(dgvTTBenhNhan);
        }

        private void dgvTTBenhNhan_Click(object sender, EventArgs e)
        {
            int a = dgvTTBenhNhan.CurrentCell.RowIndex;
            txtMaBN.Text = dgvTTBenhNhan.Rows[a].Cells[0].Value?.ToString() ?? "";
            txtTenBN.Text = dgvTTBenhNhan.Rows[a].Cells[1].Value?.ToString() ?? "";
            string gender = dgvTTBenhNhan.Rows[a].Cells[2].Value?.ToString();
            radNam.Checked = (gender == radNam.Text);
            radNu.Checked = (gender == radNu.Text);
            if (DateTime.TryParse(dgvTTBenhNhan.Rows[a].Cells[3].Value?.ToString(), out DateTime birthDate))
            {
                if (birthDate < dtpNgSinh.MinDate || birthDate > dtpNgSinh.MaxDate)
                {
                    dtpNgSinh.Value = DateTime.Today; // Set to current date or any valid date
                }
                else
                {
                    dtpNgSinh.Value = birthDate; // Only set this if within valid range
                }
            }
            else
            {
                dtpNgSinh.Value = DateTime.Today; // or any default value if parsing fails
            }
            txtNgheNghiep.Text = dgvTTBenhNhan.Rows[a].Cells[5].Value?.ToString() ?? "";
            txtDiaChi.Text = dgvTTBenhNhan.Rows[a].Cells[4].Value?.ToString() ?? "";
            mtbSDT.Text = dgvTTBenhNhan.Rows[a].Cells[6].Value?.ToString() ?? "";
            txtCCCD.Text = dgvTTBenhNhan.Rows[a].Cells[7].Value?.ToString() ?? "";
            mtbTTLH.Text = dgvTTBenhNhan.Rows[a].Cells[8].Value?.ToString() ?? "";
        }
        public bool KTraMa(string maBN)
        {
            if (maBN.Equals(dgvTTBenhNhan.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaBN.Text.Length == 0 || txtTenBN.Text.Length == 0 || txtCCCD.Text.Length == 0 || mtbSDT.Text.Length == 0)
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
            DialogResult d = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    BUS_BenhNhan.Instance.ThemBenhNhan(new ET_BenhNhan(txtMaBN.Text, txtTenBN.Text, layGioiTinh(), dtpNgSinh.Value, txtDiaChi.Text, txtNgheNghiep.Text, mtbSDT.Text, txtCCCD.Text, mtbTTLH.Text));
                    BUS_BenhNhan.Instance.XemDSBenhNhan(dgvTTBenhNhan);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ nghề nghiệp!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTTBenhNhan.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BUS_BenhNhan.Instance.XoaBenhNhan(dgvTTBenhNhan);
                    BUS_BenhNhan.Instance.XemDSBenhNhan(dgvTTBenhNhan);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvTTBenhNhan.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaBN.Text) == true)
                        {
                            BUS_BenhNhan.Instance.SuaBENHNHAN(new ET_BenhNhan(txtMaBN.Text, txtTenBN.Text, layGioiTinh(), dtpNgSinh.Value, txtDiaChi.Text, txtNgheNghiep.Text, mtbSDT.Text, txtCCCD.Text, mtbTTLH.Text));
                            BUS_BenhNhan.Instance.XemDSBenhNhan(dgvTTBenhNhan);
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa mã bệnh nhân !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaBN.Text = dgvTTBenhNhan.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ nghề nghiệp", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaBN.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã bệnh nhân quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenBN.Text.Length > 49 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tên bệnh nhân quá 50 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpNgSinh_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgSinh.Value > DateTime.Now)
            {
                MessageBox.Show("Không thể đổi ngày sinh lớn hơn ngày " + DateTime.Now + "!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgSinh.Value = DateTime.Now;
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '/' && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt trừ '/' và '-',',' !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDiaChi.Text.Length > 999 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập địa chỉ quá 1000 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNgheNghiep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNgheNghiep.Text.Length > 79 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập nghề nghiệp quá 80 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập khoảng trắng, ký tự đặc biệt hay chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCCCD.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập CCCD quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtbTTLH_Validating(object sender, CancelEventArgs e)
        {
            //txtTTLienHe.Validating += new CancelEventHandler(txtTTLienHe_Validating);
            mtbTTLH.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtbTTLH.Text.Length != 10)  // 10 số cho số điện thoại
            {
                MessageBox.Show("Bạn phải nhập đủ 10 chữ số cho số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;  // Dừng sự kiện và giữ focus tại MaskedTextBox cho đến khi nhập đúng
            }
            // Đặt lại TextMaskFormat nếu cần
            mtbTTLH.TextMaskFormat = MaskFormat.IncludeLiterals;
        }

        private void mtbSDT_Validating(object sender, CancelEventArgs e)
        {
            mtbSDT.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtbSDT.Text.Length != 10)  // 10 số cho số điện thoại
            {
                MessageBox.Show("Bạn phải nhập đủ 10 chữ số cho số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;  // Dừng sự kiện và giữ focus tại MaskedTextBox cho đến khi nhập đúng
            }
            // Đặt lại TextMaskFormat nếu cần
            mtbSDT.TextMaskFormat = MaskFormat.IncludeLiterals;
        }

        private void btnLapHSBA_Click(object sender, EventArgs e)
        {
            if (dgvTTBenhNhan.SelectedRows.Count > 0)
            {
                string dataToSend = txtMaBN.Text;  // Dữ liệu bạn muốn gửi
                mainForm.openChildForm(new HoSoBenhAn(dataToSend));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBHYT_Click(object sender, EventArgs e)
        {
            if(dgvTTBenhNhan.SelectedRows.Count > 0)
            {
                string dataToSend = txtMaBN.Text;
                mainForm.openChildForm(new BaoHiemYTe(dataToSend));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUS_BenhNhan.Instance.TimKiemBenhNhan(txtTenBN.Text,
                mtbSDT.Text, txtCCCD.Text, dgvTTBenhNhan);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi trang này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
