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
    public partial class BaoHiemYTe : Form
    {
        public BaoHiemYTe()
        {
            InitializeComponent();
        }
        public string Data { get; set; }
        public BaoHiemYTe(string data)
        {
            InitializeComponent();
            Data = data;
            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
            txtMaBN.Text = Data;
        }
        //Load form
        private void BaoHiemYTe_Load(object sender, EventArgs e)
        {
            BUS_BHYT.Instance.XemDSBHYT(dgvBHYT);
            txtTenBN.Text = BUS_HoSoBenhAn.Instance.LayTenBNNhoMaBN(txtMaBN.Text);
            BUS_BHYT.Instance.CapNhapNgayHH();
            dgvBHYT.Columns[4].Visible = false;
        }
        //Lấy dữ liệu lên
        private void dgvBHYT_Click(object sender, EventArgs e)
        {
            int dong = dgvBHYT.CurrentCell.RowIndex;
            txtMaBHYT.Text = dgvBHYT.Rows[dong].Cells[0].Value?.ToString() ?? "";
            var ngayCap = dgvBHYT.Rows[dong].Cells[1].Value;
            if (ngayCap != null && ngayCap != DBNull.Value)
            {
                dtpNgCap.Value = Convert.ToDateTime(ngayCap);
                dtpNgCap.Format = DateTimePickerFormat.Short; // Đặt định dạng hiển thị ngày thường
            }
            else
            {
                dtpNgCap.Format = DateTimePickerFormat.Custom; // Đặt định dạng tuỳ chỉnh
                dtpNgCap.CustomFormat = " "; // Đặt định dạng tuỳ chỉnh là chuỗi trống
            }
            var ngayHetHan = dgvBHYT.Rows[dong].Cells[2].Value;
            if (ngayCap != null && ngayCap != DBNull.Value)
            {
                dtpNgHetHan.Value = Convert.ToDateTime(ngayHetHan);
                dtpNgHetHan.Format = DateTimePickerFormat.Short; // Đặt định dạng hiển thị ngày thường
            }
            else
            {
                dtpNgHetHan.Format = DateTimePickerFormat.Custom; // Đặt định dạng tuỳ chỉnh
                dtpNgHetHan.CustomFormat = " "; // Đặt định dạng tuỳ chỉnh là chuỗi trống
            }

            txtMaBN.Text = dgvBHYT.Rows[dong].Cells[3].Value?.ToString() ?? "";
            if(txtMaBN.Text != null)
            {
                txtTenBN.Text = BUS_HoSoBenhAn.Instance.LayTenBNNhoMaBN(txtMaBN.Text);
            }
            else
            {
                txtMaBN.Text = null;
            }
        }
        //Kiểm tra mã
        public bool KTraMa(string maBN)
        {
            if (maBN.Equals(dgvBHYT.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }
        //Kiểm tra mã bệnh nhân
        public bool KTraBN(string maBN)
        {
            if (maBN.Equals(dgvBHYT.CurrentRow.Cells[3].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }
        //Kiểm tra bỏ trống
        public bool KtraBoTrong()
        {
            if (txtMaBHYT.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        private void dtpNgCap_ValueChanged(object sender, EventArgs e)
        {

            if (dtpNgCap.Value > DateTime.Now)
            {
                MessageBox.Show("Không thể đổi ngày cấp lớn hơn ngày " + DateTime.Now + "!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgCap.Value = DateTime.Now;
            }
            else
            {
                DateTime ngayCap = dtpNgCap.Value;
                DateTime ngayHetHan = ngayCap.AddYears(5);
                dtpNgHetHan.Value = ngayHetHan;
            }
        }



        /// <summary>
        /// Thanh công cụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (BUS_BHYT.Instance.KiemTraXemBHYTHetHanChua(txtMaBHYT.Text) == true)
            {
                DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        BUS_BHYT.Instance.Thembhyt(new ET_BHYT(txtMaBHYT.Text, dtpNgCap.Value, dtpNgHetHan.Value, txtMaBN.Text));
                        BUS_BHYT.Instance.XemDSBHYT(dgvBHYT);
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ nghề nghiệp!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bảo hiểm y tế đã hết hạn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBHYT.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_BHYT.Instance.XoaDSBHYT(dgvBHYT);
                    BUS_BHYT.Instance.XemDSBHYT(dgvBHYT);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (BUS_BHYT.Instance.KiemTraXemBHYTHetHanChua(txtMaBHYT.Text) == true)
            {
                if (dgvBHYT.SelectedRows.Count > 0)
                {
                    DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        if (KtraBoTrong() == true)
                        {
                            if (KTraMa(txtMaBHYT.Text) == true && KTraBN(txtMaBN.Text) == true)
                            {
                                BUS_BHYT.Instance.SuaDSBHYT(new ET_BHYT(txtMaBHYT.Text, dtpNgCap.Value, dtpNgHetHan.Value, txtMaBN.Text));
                                BUS_BHYT.Instance.XemDSBHYT(dgvBHYT);
                            }
                            else
                            {
                                MessageBox.Show("Không thể sửa mã bhyt hay bệnh nhân của ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMaBHYT.Text = dgvBHYT.CurrentRow.Cells[0].Value.ToString();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ nghề nghiệp", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bảo hiểm y tế đã hết hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void txtMaBHYT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaBHYT.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã BHYT quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
