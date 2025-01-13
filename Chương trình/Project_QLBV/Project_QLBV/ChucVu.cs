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
    public partial class ChucVu : Form
    {
        public ChucVu()
        {
            InitializeComponent();
        }

        private void ChucVu_Load(object sender, EventArgs e)
        {
            BUS_ChucVu.Instance.ListCV(dgvDanhSachChucVu);
        }

        public bool KTraMa(string maCV)
        {
            if (maCV.Equals(dgvDanhSachChucVu.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaChucVu.Text.Length == 0 || txtTenChucVu.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void dgvDanhSachChucVu_Click(object sender, EventArgs e)
        {
            int dong = dgvDanhSachChucVu.CurrentCell.RowIndex;
            txtMaChucVu.Text = dgvDanhSachChucVu.Rows[dong].Cells[0].Value?.ToString()?? "";
            txtTenChucVu.Text = dgvDanhSachChucVu.Rows[dong].Cells[1].Value?.ToString()?? "";
        }



        /// <summary>
        /// Thanh công cụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    BUS_ChucVu.Instance.ThemCV(new ET_ChucVu(txtMaChucVu.Text, txtTenChucVu.Text));
                    BUS_ChucVu.Instance.ListCV(dgvDanhSachChucVu);
                }
                else
                {
                    MessageBox.Show("Không được để trống bất kỳ trường dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachChucVu.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaChucVu.Text) == true)
                        {
                            BUS_ChucVu.Instance.SuaCV(new ET_ChucVu(txtMaChucVu.Text, txtTenChucVu.Text));
                            BUS_ChucVu.Instance.ListCV(dgvDanhSachChucVu);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng không sửa mã " + dgvDanhSachChucVu.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaChucVu.Text = dgvDanhSachChucVu.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachChucVu.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_ChucVu.Instance.XoaCV(dgvDanhSachChucVu);
                    BUS_ChucVu.Instance.ListCV(dgvDanhSachChucVu);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void txtMaChucVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaChucVu.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã chức vụ quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenChucVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenChucVu.Text.Length > 149 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã chức vụ quá 150 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
