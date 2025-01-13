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
    public partial class LoaiPTXNCC : Form
    {
        public LoaiPTXNCC()
        {
            InitializeComponent();
        }

        private void LoaiPTXNCC_Load(object sender, EventArgs e)
        {
            BUS_LoaiXNPT.Instance.XemDSLoaiPT_XNCC(dgvDanhSachLXNPT);
        }

        private void dgvDanhSachLXNPT_Click(object sender, EventArgs e)
        {
            int dong = dgvDanhSachLXNPT.CurrentCell.RowIndex;
            txtLoaiXNPT.Text = dgvDanhSachLXNPT.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtTenLoaiXNPT.Text = dgvDanhSachLXNPT.Rows[dong].Cells[1].Value?.ToString() ?? "";
        }

        public bool KTraMa(string maLoaiPTXNCC)
        {
            if (maLoaiPTXNCC.Equals(dgvDanhSachLXNPT.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtLoaiXNPT.Text.Length == 0 || txtTenLoaiXNPT.Text.Length == 0)
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
        /// 
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    BUS_LoaiXNPT.Instance.ThemLoaiPT_XNCC(new ET_LoaiPTXN(txtLoaiXNPT.Text, txtTenLoaiXNPT.Text));
                    BUS_LoaiXNPT.Instance.XemDSLoaiPT_XNCC(dgvDanhSachLXNPT);
                }
                else
                {
                    MessageBox.Show("Không được để trống bất kỳ trường dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachLXNPT.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_LoaiXNPT.Instance.XoaLoaiPT_XNCC(dgvDanhSachLXNPT);
                    BUS_LoaiXNPT.Instance.XemDSLoaiPT_XNCC(dgvDanhSachLXNPT);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachLXNPT.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtLoaiXNPT.Text) == true)
                        {
                            BUS_LoaiXNPT.Instance.SuaLoaiPT_XNCC(new ET_LoaiPTXN(txtLoaiXNPT.Text, txtTenLoaiXNPT.Text));
                            BUS_LoaiXNPT.Instance.XemDSLoaiPT_XNCC(dgvDanhSachLXNPT);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng không sửa mã " + dgvDanhSachLXNPT.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtLoaiXNPT.Text = dgvDanhSachLXNPT.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void txtLoaiXNPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLoaiXNPT.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập loại xét nghiệm phẫu thuật quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenLoaiXNPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenLoaiXNPT.Text.Length > 999 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tên loại xét nghiệm phẫu thuật quá 1000 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLXNPT_Click(object sender, EventArgs e)
        {

        }
    }
}

