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
    public partial class BangGia : Form
    {
        public BangGia()
        {
            InitializeComponent();
        }
        //Bảng giá
        private void BangGia_Load(object sender, EventArgs e)
        {
            BUS_BangGia.Instance.XemDSBangGia(dgvDSBangGia);
            cboKhoa.Items.Clear();
            cboLoai.Items.Clear();
            BUS_PhongKham.Instance.DoDLKhoaLenCB(cboKhoa);
            BUS_BangGia.Instance.DoDLLoaiPT_XNCCVaoCB(cboLoai);
            dgvDSBangGia.Columns[5].Visible = false;
            dgvDSBangGia.Columns[6].Visible = false;
            cboLoai.SelectedIndex = -1;
        }
        //Dgv_Click
        private void dgvDSBangGia_Click(object sender, EventArgs e)
        {
            int dong = dgvDSBangGia.CurrentCell.RowIndex;
            txtMaDV.Text = dgvDSBangGia.Rows[dong].Cells[0].Value?.ToString()?? "";
            txtTenDV.Text = dgvDSBangGia.Rows[dong].Cells[1].Value?.ToString()??"";
            txtGiaDV.Text = dgvDSBangGia.Rows[dong].Cells[2].Value?.ToString()??"";
            if (dgvDSBangGia.Rows[dong].Cells[3].Value != null)
            {
                cboKhoa.SelectedValue = dgvDSBangGia.Rows[dong].Cells[3].Value;
            }
            else
            {
                cboKhoa.SelectedIndex = -1;
            }

            if (dgvDSBangGia.Rows[dong].Cells[4].Value != null)
            {
                cboLoai.SelectedValue = dgvDSBangGia.Rows[dong].Cells[4].Value;
            }
            else
            {
                cboLoai.SelectedIndex = -1;
            }
        }
        //Kiểm tra mã
        public bool KTraMa(string maDV)
        {
            if (maDV.Equals(dgvDSBangGia.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }
        //Kiểm tra trống
        public bool KtraBoTrong()
        {
            if (txtMaDV.Text.Length == 0 || txtTenDV.Text.Length == 0 || txtGiaDV.Text.Length == 0)
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
        //Thêm bảng giá
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    if(cboLoai.SelectedIndex != -1)
                    {
                        BUS_BangGia.Instance.ThemBangGia(new ET_BangGia(txtMaDV.Text, txtTenDV.Text, float.Parse(txtGiaDV.Text), cboKhoa.SelectedValue.ToString(), cboLoai.SelectedValue.ToString()));
                        BUS_BangGia.Instance.XemDSBangGia(dgvDSBangGia);
                    }
                    else
                    {
                        MessageBox.Show("Quên chọn loại dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống bất kỳ trường dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDSBangGia.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_BangGia.Instance.XoaDichVu(dgvDSBangGia);
                    BUS_BangGia.Instance.XemDSBangGia(dgvDSBangGia);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Sửa bảng giá
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSBangGia.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaDV.Text) == true)
                        {
                            BUS_BangGia.Instance.SuaBangGia(new ET_BangGia(txtMaDV.Text, txtTenDV.Text, float.Parse(txtGiaDV.Text), cboKhoa.SelectedValue.ToString(), cboLoai.SelectedValue.ToString()));
                            BUS_BangGia.Instance.XemDSBangGia(dgvDSBangGia);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng không sửa mã " + dgvDSBangGia.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaDV.Text = dgvDSBangGia.CurrentRow.Cells[0].Value.ToString();
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
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Thoát màn hình
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
        private void txtMaDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaDV.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã dịch vụ quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenDV.Text.Length > 99 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tên dịch vụ quá 100 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGiaDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
