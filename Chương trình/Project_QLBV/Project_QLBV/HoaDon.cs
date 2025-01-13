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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        public string Data { get; set; }
        public string Data1 { get; set; }
        public HoaDon(string data, string data1)
        {

            InitializeComponent();
            Data = data;
            Data1 = data1;
            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
            txtMaToaThuoc.Text = Data;
            txtMaPK.Text = Data1;
        }

        public HoaDon(string data)
        {
            InitializeComponent();
            Data = data;
            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
            txtMaPK.Text = Data;
        }
        public bool KiemTraMa(string maHD)
        {
            if (maHD.Equals(dgvHoaDon.CurrentRow.Cells[0].Value.ToString()))
            {
                return true;
            }
            return false;
        }

        public bool KiemTraMaPKB(string maPKB)
        {
            if (maPKB.Equals(dgvHoaDon.CurrentRow.Cells[1].Value.ToString()))
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaHD.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = BUS_HoaDon.Instance.GenerateHoaDonCode(txtMaPK.Text);
            txtMaToaThuoc.Text = BUS_HoaDon.Instance.layMaTTNhoPKB(txtMaPK.Text);
            BUS_HoaDon.Instance.XemDSHoaDon(dgvHoaDon, dtpNgay.Value);
            BUS_HoaDon.Instance.CapNhapTienThuocCuaPKB();
            BUS_HoaDon.Instance.CapNhapTienKhamCuaPKB();
            BUS_HoaDon.Instance.CapNhapTienGiuongCuaPKB();
            BUS_HoaDon.Instance.CapNhapTienPhauThuatCuaPKB();
            BUS_HoaDon.Instance.CapNhapTongTienCuaPKB();
            BUS_HoaDon.Instance.CapNhapTienBHYTChiTra();
            BUS_HoaDon.Instance.CapNhapTienSauKhiBHYTChiTra();

            dgvHoaDon.Columns[10].Visible = false;
            //ShowGrid();
            //this.rptHoaDon.RefreshReport();
        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            int row = dgvHoaDon.CurrentCell.RowIndex;
            txtMaHD.Text = dgvHoaDon.Rows[row].Cells[0].Value?.ToString() ?? "";
            txtMaToaThuoc.Text = dgvHoaDon.Rows[row].Cells[1].Value?.ToString() ?? "";
            //dtpNgXuatHD.Text = dgvHoaDon.Rows[row].Cells[2].Value?.ToString() ?? "";
            var ngayXuatHDValue = dgvHoaDon.Rows[row].Cells[2].Value;

            if (ngayXuatHDValue != null && ngayXuatHDValue != DBNull.Value)
            {
                DateTime ngayXuatHD = Convert.ToDateTime(ngayXuatHDValue);
                if (ngayXuatHD >= dtpNgXuatHD.MinDate && ngayXuatHD <= dtpNgXuatHD.MaxDate)
                {
                    dtpNgXuatHD.Value = ngayXuatHD;
                    dtpNgXuatHD.Format = DateTimePickerFormat.Short;
                }
                else
                {
                    // Nếu ngày không trong khoảng hợp lệ, bạn có thể thiết lập một giá trị mặc định hoặc thông báo lỗi
                    dtpNgXuatHD.Format = DateTimePickerFormat.Custom;
                    dtpNgXuatHD.CustomFormat = " "; // Không hiển thị ngày
                }
            }
            else
            {
                dtpNgXuatHD.Format = DateTimePickerFormat.Custom;
                dtpNgXuatHD.CustomFormat = " "; // Không hiển thị ngày
            }
            txtTienThuoc.Text = dgvHoaDon.Rows[row].Cells[3].Value?.ToString() ?? "0";
            txtTienKham.Text = dgvHoaDon.Rows[row].Cells[4].Value?.ToString() ?? "0";
            txtTienGiuong.Text = dgvHoaDon.Rows[row].Cells[5].Value?.ToString() ?? "0";
            txtTienPTXN.Text = dgvHoaDon.Rows[row].Cells[6].Value?.ToString() ?? "0";
            txtTongTien.Text = dgvHoaDon.Rows[row].Cells[7].Value?.ToString() ?? "0";
            txtBHYTCT.Text = dgvHoaDon.Rows[row].Cells[8].Value?.ToString() ?? "0";
            txtBNThanhToan.Text = dgvHoaDon.Rows[row].Cells[9].Value?.ToString() ?? "0";
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
                DateTime ngayXuat = dtpNgXuatHD.Value;
                if (BUS_HoaDon.Instance.KiemTraNgayXuatHD(ngayXuat, txtMaPK.Text) == true)
                {

                    if (KtraBoTrong() == true)
                    {
                        txtTienThuoc.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienThuoc(txtMaToaThuoc.Text, txtMaPK.Text));
                        txtTienKham.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienKham(txtMaPK.Text));
                        txtTienGiuong.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienGiuong(txtMaPK.Text));
                        txtTienPTXN.Text = Convert.ToString(BUS_HoaDon.Instance.TinhPhauThuat(txtMaPK.Text));
                        txtTongTien.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTongCong(txtMaToaThuoc.Text, txtMaPK.Text));
                        txtBHYTCT.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienBHYTChiTra(txtMaPK.Text));
                        txtBNThanhToan.Text = txtBHYTCT.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienSauKhiBHYTChiTra(txtMaPK.Text));
                        BUS_HoaDon.Instance.ThemHoaDon(new ET_HoaDon(txtMaPK.Text, txtMaHD.Text, dtpNgXuatHD.Value, float.Parse(txtTienThuoc.Text), float.Parse(txtTienKham.Text), float.Parse(txtTienGiuong.Text), float.Parse(txtTienPTXN.Text), float.Parse(txtTongTien.Text), float.Parse(txtBHYTCT.Text), float.Parse(txtBNThanhToan.Text)));
                        BUS_HoaDon.Instance.CapNhapTienThuocCuaPKB();
                        BUS_HoaDon.Instance.CapNhapTienKhamCuaPKB();
                        BUS_HoaDon.Instance.CapNhapTienGiuongCuaPKB();
                        BUS_HoaDon.Instance.CapNhapTienPhauThuatCuaPKB();
                        BUS_HoaDon.Instance.CapNhapTongTienCuaPKB();
                        BUS_HoaDon.Instance.CapNhapTienBHYTChiTra();
                        BUS_HoaDon.Instance.CapNhapTienSauKhiBHYTChiTra();
                        BUS_HoaDon.Instance.XemDSHoaDon(dgvHoaDon, dtpNgay.Value);
                    }
                    else
                    {
                        MessageBox.Show("Không được để trống bất kỳ trường dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ngày xuất hóa đơn phải lớn hơn hoặc bằng  !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvHoaDon.SelectedRows.Count > 0)
            {
                if (dgvHoaDon.SelectedRows.Count > 0)
                {
                    DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        BUS_HoaDon.Instance.XoaHoaDon(dgvHoaDon);
                        BUS_HoaDon.Instance.XemDSHoaDon(dgvHoaDon, dtpNgay.Value);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvHoaDon.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    DateTime ngayXuat = dtpNgXuatHD.Value;
                    if (BUS_HoaDon.Instance.KiemTraNgayXuatHD(ngayXuat, txtMaPK.Text) == true)
                    {
                        if (KtraBoTrong() == true)
                        {
                            if (KiemTraMa(txtMaHD.Text) == true)
                            {
                                if (KiemTraMaPKB(txtMaPK.Text))
                                {
                                    if (BUS_HoaDon.Instance.KiemTraNgayXuatHD(ngayXuat, txtMaPK.Text) == false)
                                    {
                                        MessageBox.Show("Ngày xuất hóa đơn phải lớn hơn hoặc bằng  !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        txtTienThuoc.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienThuoc(txtMaToaThuoc.Text, txtMaPK.Text));
                                        txtTienKham.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienKham(txtMaPK.Text));
                                        txtTienGiuong.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienGiuong(txtMaPK.Text));
                                        txtTienPTXN.Text = Convert.ToString(BUS_HoaDon.Instance.TinhPhauThuat(txtMaPK.Text));
                                        txtTongTien.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTongCong(txtMaToaThuoc.Text, txtMaPK.Text));
                                        txtBHYTCT.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienBHYTChiTra(txtMaPK.Text));
                                        txtBNThanhToan.Text = txtBNThanhToan.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienSauKhiBHYTChiTra(txtMaPK.Text));
                                        BUS_HoaDon.Instance.SuaHoaDon(new ET_HoaDon(txtMaPK.Text, txtMaHD.Text, dtpNgXuatHD.Value, float.Parse(txtTienThuoc.Text), float.Parse(txtTienKham.Text), float.Parse(txtTienGiuong.Text), float.Parse(txtTienPTXN.Text), float.Parse(txtTongTien.Text), float.Parse(txtBHYTCT.Text), float.Parse(txtBNThanhToan.Text)));
                                        BUS_HoaDon.Instance.XemDSHoaDon(dgvHoaDon, dtpNgay.Value);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng không sửa mã " + dgvHoaDon.CurrentRow.Cells[1].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng không sửa mã " + dgvHoaDon.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMaHD.Text = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không được để trống bất kỳ trường dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày xuất hóa đơn phải lớn hơn hoặc bằng ngày khám !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void txtMaToaThuoc_TextChanged(object sender, EventArgs e)
        {
            txtTienThuoc.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienThuoc(txtMaToaThuoc.Text, txtMaPK.Text));
            txtTienKham.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienKham(txtMaPK.Text));
            txtTienGiuong.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienGiuong(txtMaPK.Text));
            txtTienPTXN.Text = Convert.ToString(BUS_HoaDon.Instance.TinhPhauThuat(txtMaPK.Text));
            txtTongTien.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTongCong(txtMaToaThuoc.Text, txtMaPK.Text));
            txtBHYTCT.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienBHYTChiTra(txtMaPK.Text));
            txtBNThanhToan.Text = Convert.ToString(BUS_HoaDon.Instance.TinhTienSauKhiBHYTChiTra(txtMaPK.Text));
        }
        /// <summary>
        /// Bắt lỗi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void dtpNgXuatHD_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayXuat = dtpNgXuatHD.Value;
            if (BUS_HoaDon.Instance.KiemTraNgayXuatHD(ngayXuat, txtMaPK.Text) == false)
            {
                MessageBox.Show("Ngày xuất hóa đơn phải lớn hơn hoặc bằng ngày khám !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpNgXuatHD_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayXuat = dtpNgXuatHD.Value;
            if (BUS_HoaDon.Instance.KiemTraNgayXuatHD(ngayXuat, txtMaPK.Text) == false)
            {
                MessageBox.Show("Ngày xuất hóa đơn phải lớn hơn hoặc bằng  !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaHD.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã hóa đơn quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            BUS_HoaDon.Instance.XemDSHoaDon(dgvHoaDon, dtpNgay.Value);
        }
    }
}
