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
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            BUS_Khoa.Instance.XemDSKhoa(dgvDanhSachKhoa);
        }

        public bool KtraBoTrong()
        {
            if (txtMaKhoa.Text.Length == 0 || txtTenKhoa.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        public bool KTraMa(string maKhoa)
        {
            if (maKhoa.Equals(dgvDanhSachKhoa.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Thanh công cụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    BUS_Khoa.Instance.ThemKhoa(new ET_Khoa(txtMaKhoa.Text, txtTenKhoa.Text));
                    BUS_Khoa.Instance.XemDSKhoa(dgvDanhSachKhoa);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    if (KTraMa(txtMaKhoa.Text) == true)
                    {
                        BUS_Khoa.Instance.SuaKhoa(new ET_Khoa(txtMaKhoa.Text, txtTenKhoa.Text));
                        BUS_Khoa.Instance.XemDSKhoa(dgvDanhSachKhoa);
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa mã khoa !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaKhoa.Text = dgvDanhSachKhoa.CurrentRow.Cells[0].Value.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachKhoa.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BUS_Khoa.Instance.XoaKhoa(dgvDanhSachKhoa);
                    BUS_Khoa.Instance.XemDSKhoa(dgvDanhSachKhoa);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvDanhSachKhoa_Click(object sender, EventArgs e)
        {
            int dong = dgvDanhSachKhoa.CurrentCell.RowIndex;
            txtMaKhoa.Text = dgvDanhSachKhoa.Rows[dong].Cells[0].Value?.ToString()?? "";
            txtTenKhoa.Text = dgvDanhSachKhoa.Rows[dong].Cells[1].Value?.ToString()?? "";
        }

        private void txtMaKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaKhoa.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã khoa quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' || txtMaKhoa.Text.Length >= 90)
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenKhoa.Text.Length > 89 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã khoa quá 90 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
