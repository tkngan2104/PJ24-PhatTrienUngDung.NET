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
    public partial class LoaiKham : Form
    {
        public LoaiKham()
        {
            InitializeComponent();
        }

        private void LoaiKham_Load(object sender, EventArgs e)
        {
            BUS_LoaiKham.Instance.XemDSLoaiKham(dgvDanhSachLoaiKham);
        }

        private void dgvDanhSachLoaiKham_Click(object sender, EventArgs e)
        {
            int dong = dgvDanhSachLoaiKham.CurrentCell.RowIndex;
            txtMaLoaiKham.Text = dgvDanhSachLoaiKham.Rows[dong].Cells[0].Value?.ToString()??"";
            txtTenLoaiKham.Text = dgvDanhSachLoaiKham.Rows[dong].Cells[1].Value?.ToString()??"";
            if (dgvDanhSachLoaiKham.Rows[dong].Cells[2].Value != null)
            {
                txtGia.Text = dgvDanhSachLoaiKham.Rows[dong].Cells[2].Value.ToString();
            }
            else
            {
                txtGia.Text = ""; // Hoặc xử lý khác phù hợp nếu ô là null
            }
        }

        public bool KTraMa(string msThuoc)
        {
            if (msThuoc.Equals(dgvDanhSachLoaiKham.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaLoaiKham.Text.Length == 0 || txtTenLoaiKham.Text.Length == 0 || txtGia.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Thanh công cụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    BUS_LoaiKham.Instance.ThemLoaiKham(new ET_LoaiKham(txtMaLoaiKham.Text, txtTenLoaiKham.Text, float.Parse(txtGia.Text)));
                    BUS_LoaiKham.Instance.XemDSLoaiKham(dgvDanhSachLoaiKham);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                BUS_LoaiKham.Instance.XoaLoaiKham(dgvDanhSachLoaiKham);
                BUS_LoaiKham.Instance.XemDSLoaiKham(dgvDanhSachLoaiKham);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    if (KTraMa(txtMaLoaiKham.Text) == true)
                    {
                        BUS_LoaiKham.Instance.SuaLoaiKham(new ET_LoaiKham(txtMaLoaiKham.Text, txtTenLoaiKham.Text, float.Parse(txtGia.Text)));
                        BUS_LoaiKham.Instance.XemDSLoaiKham(dgvDanhSachLoaiKham);
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa mã loại khám !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaLoaiKham.Text = dgvDanhSachLoaiKham.CurrentRow.Cells[0].Value.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// <summary>
        /// Bắt lỗi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void txtMaLoaiKham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaLoaiKham.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã loại khám quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenLoaiKham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenLoaiKham.Text.Length > 199 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tên loại khám quá 200 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
