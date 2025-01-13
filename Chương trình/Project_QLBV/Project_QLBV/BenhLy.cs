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
    public partial class BenhLy : Form
    {
        public BenhLy()
        {
            InitializeComponent();
        }
        //Load form
        private void BenhLy_Load(object sender, EventArgs e)
        {
            BUS_BenhLy.Instance.XemDSBenhLy(dgvDSBenhLy);
        }
        //Lấy dữ liệu lên
        private void dgvDSBenhLy_Click(object sender, EventArgs e)
        {
            int dong = dgvDSBenhLy.CurrentCell.RowIndex;
            txtMaBL.Text = dgvDSBenhLy.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtTenBL.Text = dgvDSBenhLy.Rows[dong].Cells[1].Value?.ToString() ??"";
        }
        public bool KTraMa(string maBenh)
        {
            if (maBenh.Equals(dgvDSBenhLy.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaBL.Text.Length == 0 || txtTenBL.Text.Length == 0)
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
                    BUS_BenhLy.Instance.ThemBenhLy(new ET_BenhLy(txtMaBL.Text, txtTenBL.Text));
                    BUS_BenhLy.Instance.XemDSBenhLy(dgvDSBenhLy);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ nghề nghiệp!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDSBenhLy.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_BenhLy.Instance.XoaBenhLy(dgvDSBenhLy);
                    BUS_BenhLy.Instance.XemDSBenhLy(dgvDSBenhLy);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDSBenhLy.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaBL.Text) == true)
                        {

                            // Gọi BUS để cập nhật
                            BUS_BenhLy.Instance.SuaBenhLy(new ET_BenhLy(txtMaBL.Text, txtTenBL.Text));
                            BUS_BenhLy.Instance.XemDSBenhLy(dgvDSBenhLy);
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa mã " + dgvDSBenhLy.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaBL.Text = dgvDSBenhLy.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ nghề nghiệp!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
        private void txtMaBL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaBL.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã khoa quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenBL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt và chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenBL.Text.Length > 199 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tên bệnh lý quá 200 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
