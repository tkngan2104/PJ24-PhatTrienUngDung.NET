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
    public partial class GiuongBenh : Form
    {
        public GiuongBenh()
        {
            InitializeComponent();
        }

        private void GiuongBenh_Load(object sender, EventArgs e)
        {
            cboPhong.Items.Clear();
            BUS_GiuongBenh.Instance.DoDLPhongLenCB(cboPhong);
            BUS_GiuongBenh.Instance.XemDSGiuongBenh(dgvDanhSachGiuongBenh, cboPhong.SelectedValue.ToString());
            dgvDanhSachGiuongBenh.Columns[3].Visible = false;
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboPhong.SelectedIndex != -1)
            {
                BUS_GiuongBenh.Instance.XemDSGiuongBenh(dgvDanhSachGiuongBenh, cboPhong.SelectedValue.ToString());
            }
        }

        private void dgvDanhSachGiuongBenh_Click(object sender, EventArgs e)
        {
            int dong = dgvDanhSachGiuongBenh.CurrentCell.RowIndex;
            txtMaGiuong.Text = dgvDanhSachGiuongBenh.Rows[dong].Cells[0].Value?.ToString()?? "";
            numSoGiuong.Value = Convert.ToInt32(dgvDanhSachGiuongBenh.Rows[dong].Cells[1].Value ?? 0);
            cboPhong.SelectedValue = dgvDanhSachGiuongBenh.Rows[dong].Cells[2].Value?.ToString()??"";

            cboPhong.SelectedIndexChanged -= cboPhong_SelectedIndexChanged;
        }

        public bool KTraMa(string maGB)
        {
            if (maGB.Equals(dgvDanhSachGiuongBenh.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaGiuong.Text.Length == 0)
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
                    BUS_GiuongBenh.Instance.ThemGiuongBenh(new ET_GiuongBenh(txtMaGiuong.Text, Convert.ToInt32(numSoGiuong.Value), cboPhong.SelectedValue.ToString()));
                    BUS_GiuongBenh.Instance.XemDSGiuongBenh(dgvDanhSachGiuongBenh, cboPhong.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachGiuongBenh.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_GiuongBenh.Instance.XoaGiuongBenh(dgvDanhSachGiuongBenh);
                    BUS_GiuongBenh.Instance.XemDSGiuongBenh(dgvDanhSachGiuongBenh, cboPhong.SelectedValue.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachGiuongBenh.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaGiuong.Text) == true)
                        {
                            cboPhong.SelectedIndexChanged -= cboPhong_SelectedIndexChanged;
                            // Gọi BUS để cập nhật
                            BUS_GiuongBenh.Instance.SuaGiuongBenh(new ET_GiuongBenh(txtMaGiuong.Text, Convert.ToInt32(numSoGiuong.Value), cboPhong.SelectedValue.ToString()));
                            BUS_GiuongBenh.Instance.XemDSGiuongBenh(dgvDanhSachGiuongBenh, cboPhong.SelectedValue.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa mã giường !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaGiuong.Text = dgvDanhSachGiuongBenh.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cboPhong.SelectedIndexChanged += cboPhong_SelectedIndexChanged;
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

        private void txtMaGiuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaGiuong.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã giường quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
