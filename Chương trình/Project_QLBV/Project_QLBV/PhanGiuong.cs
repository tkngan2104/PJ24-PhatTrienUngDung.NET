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
    public partial class PhanGiuong : Form
    {
        public PhanGiuong()
        {
            InitializeComponent();
        }
        public string Data { get; set; }
        public PhanGiuong(string data)
        {

            InitializeComponent();
            Data = data;
            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
            txtMaYeuCau.Text = Data;
        }
        private void PhanGiuong_Load(object sender, EventArgs e)
        {
            cboMaLBA.Items.Clear();
            dtpNgNhanGiuong.Value = DateTime.Now;
            
            txtPhong.Text = BUS_ChuanDoan.Instance.layTenPhongNhoMaYCau(txtMaYeuCau.Text);
            txtMaPKB.Text = BUS_PhanGiuong.Instance.LayPKBTuMaYC(txtMaYeuCau.Text);
            BUS_XetNghiemPhauThuat.Instance.doDLLoaiBA(cboMaLBA);
            string maPhong = BUS_XetNghiemPhauThuat.Instance.layMaPhongTuYC(txtMaYeuCau.Text);
           

           
            BUS_PhanGiuong.Instance.DoDLDVTuMaPhong(maPhong, cboMaLCT);
            dgvPhanGiuong.Columns[7].Visible = false;
            dgvPhanGiuong.Columns[8].Visible = false;
            dgvPhanGiuong.Columns[9].Visible = false;
            dgvPhanGiuong.Columns[10].Visible = false;
            dgvPhanGiuong.Columns[11].Visible = false;
        }

        private void dgvPhanGiuong_Click(object sender, EventArgs e)
        {
            int dong = dgvPhanGiuong.CurrentCell.RowIndex;
            txtMaYeuCau.Text = dgvPhanGiuong.Rows[dong].Cells[1].Value?.ToString() ?? "";
            cboMaGiuong.SelectedValue = dgvPhanGiuong.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtMaPKB.Text = dgvPhanGiuong.Rows[dong].Cells[4].Value?.ToString() ?? "";
            var dateValue = dgvPhanGiuong.Rows[dong].Cells[2].Value;


            if (dateValue != null && dateValue != DBNull.Value)
            {
                dtpNgNhanGiuong.Value = Convert.ToDateTime(dateValue);
            }
            else
            {
                dtpNgNhanGiuong.Value = DateTime.Now;
                
            }
            var dateValue1 = dgvPhanGiuong.Rows[dong].Cells[3].Value;
            if (dateValue1 != null && dateValue1 != DBNull.Value)
            {
                dtpNgTraGiuong.Value = Convert.ToDateTime(dateValue1);
            }
            else
            {
                dtpNgTraGiuong.Value = DateTime.Now;
            }
            cboMaLBA.SelectedValue = dgvPhanGiuong.Rows[dong].Cells[5].Value?.ToString() ?? "";
            string maPhong = BUS_XetNghiemPhauThuat.Instance.layMaPhongTuYC(txtMaYeuCau.Text);
            cboMaLCT.SelectedValue = dgvPhanGiuong.Rows[dong].Cells[6].Value?.ToString() ?? "";
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
                string maGiuong = txtMaPKB.Text;
                DateTime ngayNhan = dtpNgNhanGiuong.Value;
                DateTime ngayTra = dtpNgTraGiuong.Value;
                if (BUS_PhanGiuong.Instance.KiemTraTrangThaiGiuong(maGiuong, ngayNhan, ngayTra) == true)
                {
                    BUS_PhanGiuong.Instance.ThemPhanGiuong(new ET_PhanGiuong(txtMaYeuCau.Text, cboMaGiuong.SelectedValue.ToString(), dtpNgNhanGiuong.Value, dtpNgTraGiuong.Value, txtMaPKB.Text, cboMaLBA.SelectedValue.ToString(), cboMaLCT.SelectedValue.ToString()));
                    BUS_PhanGiuong.Instance.XemDSPhanGiuong(dgvPhanGiuong,dtpNgNhanGiuong.Value);
                }
                else
                {
                    MessageBox.Show("Giường đã có người !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvPhanGiuong.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_PhanGiuong.Instance.XoaPhanGiuo0ng(dgvPhanGiuong);
                    BUS_PhanGiuong.Instance.XemDSPhanGiuong(dgvPhanGiuong, dtpNgNhanGiuong.Value);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvPhanGiuong.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    string maGiuong = txtMaPKB.Text;
                    DateTime ngayNhan = dtpNgNhanGiuong.Value;
                    DateTime ngayTra = dtpNgTraGiuong.Value;
                    if (BUS_PhanGiuong.Instance.KiemTraTrangThaiGiuong(maGiuong, ngayNhan, ngayTra) == true)
                    {
                        BUS_PhanGiuong.Instance.SuaPhanGiuong(new ET_PhanGiuong(txtMaYeuCau.Text, cboMaGiuong.SelectedValue.ToString(), dtpNgNhanGiuong.Value, dtpNgTraGiuong.Value, txtMaPKB.Text, cboMaLBA.SelectedValue.ToString(), cboMaLCT.SelectedValue.ToString()));
                        BUS_PhanGiuong.Instance.XemDSPhanGiuong(dgvPhanGiuong,dtpNgNhanGiuong.Value);
                    }
                    else
                    {
                        MessageBox.Show("Giường đã có người !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtPhong_TextChanged(object sender, EventArgs e)
        {
            string maPhong = BUS_XetNghiemPhauThuat.Instance.layMaPhongTuYC(txtMaYeuCau.Text);
            BUS_PhanGiuong.Instance.LayGiuongTuPhong(maPhong, cboMaGiuong);
            if(cboMaGiuong.SelectedIndex != -1)
            {
                int soGiuong = BUS_PhanGiuong.Instance.LaySoGiuongTuMaGiuong(cboMaGiuong.SelectedValue.ToString());
                txtTenGiuong.Text = Convert.ToString(soGiuong);
            }
            
        }

        private void cboMaGiuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaGiuong.SelectedValue != null)
            {
                int soGiuong = BUS_PhanGiuong.Instance.LaySoGiuongTuMaGiuong(cboMaGiuong.SelectedValue.ToString());
                txtTenGiuong.Text = Convert.ToString(soGiuong);
            }
            else
            {
                int soGiuong = 0;
                txtTenGiuong.Text = Convert.ToString(soGiuong);
            }
        }

        private void dtpNgNhanGiuong_ValueChanged(object sender, EventArgs e)
        {
            BUS_PhanGiuong.Instance.XemDSPhanGiuong(dgvPhanGiuong, dtpNgNhanGiuong.Value);
        }

        private void dtpNgTraGiuong_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpNgNhanGiuong_Validating(object sender, CancelEventArgs e)
        {
            if (BUS_PhanGiuong.Instance.KiemTraNgayNhapGiuong(dtpNgNhanGiuong.Value, txtMaPKB.Text) == false)
            {
                MessageBox.Show("Ngày nhận giường không thể nhỏ hơn ngày của phiếu khám !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpNgTraGiuong_Validating(object sender, CancelEventArgs e)
        {
            if (dtpNgTraGiuong.Value < dtpNgNhanGiuong.Value)
            {
                MessageBox.Show("Ngày trả giường không thể nhỏ hơn ngày nhận giường!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var ngayNhanGiuong = BUS_PhanGiuong.Instance.LayNgayNhanGiuong(txtMaPKB.Text);

                if (ngayNhanGiuong.HasValue)
                {
                    // If there is a date, assign it
                    dtpNgNhanGiuong.Value = ngayNhanGiuong.Value;
                    dtpNgNhanGiuong.Format = DateTimePickerFormat.Short; // Ensuring the format displays the date
                }
                else
                {
                    // If no date is available, you might choose to handle it differently:
                    // 1. Set the DateTimePicker to a default value:
                    // dtpNgNhanGiuong.Value = DateTime.Today; // or any other appropriate default date

                    // 2. Or, you can clear the DateTimePicker by setting its format:
                    dtpNgNhanGiuong.Format = DateTimePickerFormat.Custom;
                    dtpNgNhanGiuong.CustomFormat = " "; // Sets the display to blank
                }
            }
        }

        private void txtMaPKB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if(BUS_HoaDon.Instance.KiemTraXemBenhNhanCoHoaDonChua(txtMaPKB.Text) == true)
            {
                if (BUS_XetNghiemPhauThuat.Instance.KiemTra(txtMaPKB.Text))
                {
                    if (dtpNgTraGiuong.Value != null)
                    {
                        string dataToSend1 = txtMaPKB.Text;
                        _menu frmMain = (_menu)this.ParentForm;
                        frmMain.openChildForm(new HoaDon(dataToSend1));
                    }
                    else
                    {
                        MessageBox.Show("Phải xuất viện đã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Phải chuẩn đoán trước đã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bệnh nhân đã xuất hóa đơn không thể phân giường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaYeuCau_TextChanged(object sender, EventArgs e)
        {
            txtPhong.Text = BUS_ChuanDoan.Instance.layTenPhongNhoMaYCau(txtMaYeuCau.Text);
            string maPhong = BUS_XetNghiemPhauThuat.Instance.layMaPhongTuYC(txtMaYeuCau.Text);
     
            BUS_PhanGiuong.Instance.DoDLDVTuMaPhong(maPhong, cboMaLCT);
        }

        private void btnTheoDoiSK_Click(object sender, EventArgs e)
        {
            if (dgvPhanGiuong.SelectedRows.Count > 0)
            {
                string data = txtMaYeuCau.Text;
                string data1 = txtMaPKB.Text;
                _menu frmMain = (_menu)this.ParentForm;
                frmMain.openChildForm(new TheoDoiSucKhoe(data, data1));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
