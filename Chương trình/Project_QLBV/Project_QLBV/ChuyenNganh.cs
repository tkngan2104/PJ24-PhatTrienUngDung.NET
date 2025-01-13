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
    public partial class ChuyenNganh : Form
    {
        public ChuyenNganh()
        {
            InitializeComponent();
        }

        private void ChuyenNganh_Load(object sender, EventArgs e)
        {
            BUS_ChuyenNganh.Instance.ListCN(dgvDanhSachChuyenNganh);
            cboKhoa.Items.Clear();
            BUS_ChuyenNganh.Instance.DoDuLieuKhoa(cboKhoa);
            dgvDanhSachChuyenNganh.Columns[3].Visible = false;
        }

        public bool KTraMa(string maCN)
        {
            if (maCN.Equals(dgvDanhSachChuyenNganh.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaCN.Text.Length == 0 || txtTenCN.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void dgvDanhSachChuyenNganh_Click(object sender, EventArgs e)
        {
            int a = dgvDanhSachChuyenNganh.CurrentCell.RowIndex;
            txtMaCN.Text = dgvDanhSachChuyenNganh.Rows[a].Cells[0].Value?.ToString()?? "";
            txtTenCN.Text = dgvDanhSachChuyenNganh.Rows[a].Cells[1].Value?.ToString()??"";
            cboKhoa.SelectedValue = dgvDanhSachChuyenNganh.Rows[a].Cells[2].Value?.ToString()??"";
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
                    BUS_ChuyenNganh.Instance.ThemCN(new ET_ChuyenNganh(txtMaCN.Text, txtTenCN.Text, cboKhoa.SelectedValue.ToString()));
                    BUS_ChuyenNganh.Instance.ListCN(dgvDanhSachChuyenNganh);
                }
                else
                {
                    MessageBox.Show("Không được để trống bất kỳ trường dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachChuyenNganh.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaCN.Text) == true)
                        {
                            BUS_ChuyenNganh.Instance.SuaCN(new ET_ChuyenNganh(txtMaCN.Text, txtTenCN.Text, cboKhoa.SelectedValue.ToString()));
                            BUS_ChuyenNganh.Instance.ListCN(dgvDanhSachChuyenNganh);
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa mã chuyên ngành !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaCN.Text = dgvDanhSachChuyenNganh.CurrentRow.Cells[0].Value.ToString();
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
                MessageBox.Show("Vui lòng không chọn dòng dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtMaCN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaCN.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã chuyên ngành quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenCN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenCN.Text.Length > 119 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tên chuyên ngành quá 120 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachChuyenNganh.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BUS_ChuyenNganh.Instance.XoaCN(dgvDanhSachChuyenNganh);

                    BUS_ChuyenNganh.Instance.ListCN(dgvDanhSachChuyenNganh);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không chọn dòng dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
