using BUS;
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
    public partial class LoaiBenhAn : Form
    {
        public LoaiBenhAn()
        {
            InitializeComponent();
        }

        private void LoaiBenhAn_Load(object sender, EventArgs e)
        {
            BUS_LoaiBenhAn.Instance.XemDanhSachLoaiBA(dgvDSLoaiBA);
        }

        private void dgvDSLoaiBA_Click(object sender, EventArgs e)
        {
            int dong = dgvDSLoaiBA.CurrentCell.RowIndex;
            txtMLBA.Text = dgvDSLoaiBA.Rows[dong].Cells[0].Value?.ToString()??"";
            txtTLBA.Text = dgvDSLoaiBA.Rows[dong].Cells[1].Value?.ToString()??"";
        }

        public bool KTraMa(string maCV)
        {
            if (maCV.Equals(dgvDSLoaiBA.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMLBA.Text.Length == 0 || txtTLBA.Text.Length == 0)
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
                    BUS_LoaiBenhAn.Instance.ThemLoaiBA(new ET.ET_LoaiBenhAn(txtMLBA.Text, txtTLBA.Text));
                    BUS_LoaiBenhAn.Instance.XemDanhSachLoaiBA(dgvDSLoaiBA);
                }
                else
                {
                    MessageBox.Show("Không được để trống bất kỳ trường dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDSLoaiBA.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_LoaiBenhAn.Instance.XoaLoaiBA(dgvDSLoaiBA);
                    BUS_LoaiBenhAn.Instance.XemDanhSachLoaiBA(dgvDSLoaiBA);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDSLoaiBA.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMLBA.Text) == true)
                        {
                            BUS_LoaiBenhAn.Instance.SuaLoaiBA(new ET.ET_LoaiBenhAn(txtMLBA.Text, txtTLBA.Text));
                            BUS_LoaiBenhAn.Instance.XemDanhSachLoaiBA(dgvDSLoaiBA);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng không sửa mã " + dgvDSLoaiBA.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMLBA.Text = dgvDSLoaiBA.CurrentRow.Cells[0].Value.ToString();
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
                MessageBox.Show("Vui lòng chọn dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void txtMLBA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMLBA.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã loại bệnh án quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTLBA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTLBA.Text.Length > 119 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tên loại bệnh án quá 120 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
