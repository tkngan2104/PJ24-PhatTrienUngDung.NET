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
    public partial class PhieuKhamBenh : Form
    {
        public PhieuKhamBenh()
        {
            InitializeComponent();
        }
        private _menu mainForm;

        public PhieuKhamBenh(_menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public bool KTraMa(string maPKB)
        {
            if (maPKB.Equals(dgvPKBenh.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMSPhieuKham.Text.Length == 0 || rtfTrieuChung.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void PhieuKhamBenh_Load(object sender, EventArgs e)
        {
            BUS_HoSoBenhAn.Instance.DoDLBenhNhan(cboMaBN);
            cboLKham.Items.Clear();
            BUS_HoSoBenhAn.Instance.DoDLBenhNhan(cboMaBN);
            BUS_PhieuKhamBenh.Instance.DoDLLoaiKham(cboLKham);
            BUS_PhieuKhamBenh.Instance.XemDSPhieuKhamBenh(dgvPKBenh, txtMaHSBA.Text);
            txtTenBN.Text = BUS_HoSoBenhAn.Instance.LayTenBNNhoMaBN(cboMaBN.SelectedValue.ToString());
            txtMaHSBA.Text = BUS_PhieuKhamBenh.Instance.layMaHoSoBA(cboMaBN.SelectedValue.ToString());
            txtMSPhieuKham.Text = BUS_PhieuKhamBenh.Instance.GeneratePhieuKhamBenhCode(cboMaBN.SelectedValue.ToString());
            dgvPKBenh.Columns[6].Visible = false;
            dgvPKBenh.Columns[7].Visible = false;
        }

        private void cboMaBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenBN.Text = BUS_HoSoBenhAn.Instance.LayTenBNNhoMaBN(cboMaBN.SelectedValue.ToString());
            txtMaHSBA.Text = BUS_PhieuKhamBenh.Instance.layMaHoSoBA(cboMaBN.SelectedValue.ToString());
            BUS_PhieuKhamBenh.Instance.XemDSPhieuKhamBenh(dgvPKBenh, txtMaHSBA.Text);
            txtMSPhieuKham.Text = BUS_PhieuKhamBenh.Instance.GeneratePhieuKhamBenhCode(cboMaBN.SelectedValue.ToString());
        }

        private void cboMaBN_SelectedValueChanged(object sender, EventArgs e)
        {
            txtTenBN.Text = BUS_HoSoBenhAn.Instance.LayTenBNNhoMaBN(cboMaBN.SelectedValue.ToString());
            txtMaHSBA.Text = BUS_PhieuKhamBenh.Instance.layMaHoSoBA(cboMaBN.SelectedValue.ToString());
        }

        private void dgvPKBenh_Click(object sender, EventArgs e)
        {
            cboMaBN.SelectedIndexChanged -= cboMaBN_SelectedIndexChanged;
            int dong = dgvPKBenh.CurrentCell.RowIndex;
            txtMSPhieuKham.Text = dgvPKBenh.Rows[dong].Cells[0].Value?.ToString() ?? "";
            dtpNgKham.Text = dgvPKBenh.Rows[dong].Cells[1].Value?.ToString() ??"";
            txtMaHSBA.Text = dgvPKBenh.Rows[dong].Cells[2].Value?.ToString() ?? "";
            rtfTrieuChung.Text = dgvPKBenh.Rows[dong].Cells[3].Value?.ToString() ?? "";
            if (dgvPKBenh.Rows[dong].Cells[4].Value == null)
            {
                rtfBenhNen.Text = string.Empty;
            }
            else
            {
                rtfBenhNen.Text = dgvPKBenh.Rows[dong].Cells[4].Value.ToString();
            }

            cboLKham.SelectedValue = dgvPKBenh.Rows[dong].Cells[5].Value?.ToString() ??"";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    if (BUS_PhieuKhamBenh.Instance.KiemTraHoSoBACuaBN(cboMaBN.SelectedValue.ToString()) == true)
                    {
                        BUS_PhieuKhamBenh.Instance.ThemPhieuKhamBenh(new ET_PhieuKhamBenh(txtMSPhieuKham.Text, dtpNgKham.Value, txtMaHSBA.Text, rtfTrieuChung.Text, rtfBenhNen.Text, cboLKham.SelectedValue.ToString()));
                        BUS_PhieuKhamBenh.Instance.XemDSPhieuKhamBenh(dgvPKBenh, txtMaHSBA.Text);
                    }

                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvPKBenh.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_PhieuKhamBenh.Instance.XoaPhieuKhamBenh(dgvPKBenh);
                    BUS_PhieuKhamBenh.Instance.XemDSPhieuKhamBenh(dgvPKBenh, txtMaHSBA.Text);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvPKBenh.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMSPhieuKham.Text) == true)
                        {
                            BUS_PhieuKhamBenh.Instance.SuaPhieuKhamBenh(new ET_PhieuKhamBenh(txtMSPhieuKham.Text, dtpNgKham.Value, txtMaHSBA.Text, rtfTrieuChung.Text, rtfBenhNen.Text, cboLKham.SelectedValue.ToString()));
                            BUS_PhieuKhamBenh.Instance.XemDSPhieuKhamBenh(dgvPKBenh, txtMaHSBA.Text);
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa mã của phiếu khám bệnh " + dgvPKBenh.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMSPhieuKham.Text = dgvPKBenh.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cboMaBN.SelectedIndexChanged += cboMaBN_SelectedIndexChanged;
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dtpNgKham_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgKham.Value > DateTime.Now)
            {
                MessageBox.Show("Không thể chỉnh ngày lớn hơn ngày hiện tại !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgKham.Value = DateTime.Now;
            }
        }

        private void txtMSPhieuKham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMSPhieuKham.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã số phiếu khám quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtfBenhNen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt và chữ số  !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rtfBenhNen.Text.Length > 499 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập bệnh nền quá 500 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtfTrieuChung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt và chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rtfTrieuChung.Text.Length > 999 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập triệu chứng quá 1000 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKham_Click(object sender, EventArgs e)
        {
            _menu frmMain = (_menu)this.ParentForm;
            frmMain.openChildForm(new DangKyKham());
        }
    }
}
