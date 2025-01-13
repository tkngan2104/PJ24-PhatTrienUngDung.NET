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
    public partial class PhongKham : Form
    {
        public PhongKham()
        {
            InitializeComponent();
        }

        private void PhongKham_Load(object sender, EventArgs e)
        {
            cboKhoa.Items.Clear();
            BUS_PhongKham.Instance.DoDLKhoaLenCB(cboKhoa);
            BUS_PhongKham.Instance.LayDSPhongKham(dgvDanhSachPhongKham, cboKhoa.SelectedValue.ToString());
            dgvDanhSachPhongKham.Columns[6].Visible = false;
        }

        private void dgvDanhSachPhongKham_Click(object sender, EventArgs e)
        {
            int dong = dgvDanhSachPhongKham.CurrentCell.RowIndex;
            txtMaPhong.Text = dgvDanhSachPhongKham.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtTenPhong.Text = dgvDanhSachPhongKham.Rows[dong].Cells[1].Value?.ToString() ?? "";
            if (dgvDanhSachPhongKham.Rows[dong].Cells[2].Value != null)
            {
                txtDiaDiem.Text = dgvDanhSachPhongKham.Rows[dong].Cells[2].Value.ToString();
            }
            else
            {
                txtDiaDiem.Text = string.Empty;
            }
            cboKhoa.SelectedValue = dgvDanhSachPhongKham.Rows[dong].Cells[3].Value?.ToString() ?? "";
            numSoGiuong.Value = Convert.ToInt32(dgvDanhSachPhongKham.Rows[dong].Cells[4].Value ?? 0);
            string cellValue = Convert.ToString(dgvDanhSachPhongKham.Rows[dong].Cells[5].Value);

            if (cellValue == radPhongKham.Text)
            {
                radPhongKham.Checked = true;
            }
            if (cellValue == radPhongChucNang.Text)
            {
                radPhongChucNang.Checked = true;
            }
            if (cellValue == radPhongBenh.Text)
            {
                radPhongBenh.Checked = true;
            }
            cboKhoa.SelectedIndexChanged -= cboKhoa_SelectedIndexChanged;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboKhoa.SelectedIndex != -1)
            {
                BUS_PhongKham.Instance.LayDSPhongKham(dgvDanhSachPhongKham, cboKhoa.SelectedValue.ToString());
            }
        }

        public string layLoaiPhong()
        {
            string loaiPhong = string.Empty;
            if (radPhongKham.Checked == true)
            {
                loaiPhong = radPhongKham.Text;
            }
            if (radPhongChucNang.Checked == true)
            {
                loaiPhong = radPhongChucNang.Text;
            }
            if (radPhongBenh.Checked == true)
            {
                loaiPhong = radPhongBenh.Text;
            }
            return loaiPhong;
        }

        public bool KTraMa(string maPK)
        {
            if (maPK.Equals(dgvDanhSachPhongKham.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaPhong.Text.Length == 0 || txtTenPhong.Text.Length == 0 || numSoGiuong.Text.Length == 0)
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
                    BUS_PhongKham.Instance.ThemPhongKham(new ET_PhongKham(txtMaPhong.Text, txtTenPhong.Text, txtDiaDiem.Text, cboKhoa.SelectedValue.ToString(), Convert.ToInt32(numSoGiuong.Value), layLoaiPhong()));
                    BUS_PhongKham.Instance.LayDSPhongKham(dgvDanhSachPhongKham, cboKhoa.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachPhongKham.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_PhongKham.Instance.XoaPhongKham(dgvDanhSachPhongKham);
                    BUS_PhongKham.Instance.LayDSPhongKham(dgvDanhSachPhongKham, cboKhoa.SelectedValue.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachPhongKham.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaPhong.Text) == true)
                        {
                            BUS_PhongKham.Instance.SuaPhongKham(new ET_PhongKham(txtMaPhong.Text, txtTenPhong.Text, txtDiaDiem.Text, cboKhoa.SelectedValue.ToString(), Convert.ToInt32(numSoGiuong.Value), layLoaiPhong()));
                            BUS_PhongKham.Instance.LayDSPhongKham(dgvDanhSachPhongKham, cboKhoa.SelectedValue.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa mã " + dgvDanhSachPhongKham.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaPhong.Text = dgvDanhSachPhongKham.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cboKhoa.SelectedIndexChanged += cboKhoa_SelectedIndexChanged;
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

        private void txtMaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaPhong.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã phòng quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenPhong.Text.Length > 89 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tên phòng quá 90 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDiaDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDiaDiem.Text.Length > 120 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập địa điểm quá 120 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
