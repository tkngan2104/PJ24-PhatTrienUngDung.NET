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
    public partial class ChuanDoan : Form
    {
        public ChuanDoan()
        {
            InitializeComponent();
        }
        private _menu mainForm;

        public ChuanDoan(_menu form)
        {
            InitializeComponent();
            if (form == null)
                throw new ArgumentNullException(nameof(form));
            this.mainForm = form; // Lưu tham chiếu MainForm
        }
        private DangKyKham dky;
        public ChuanDoan(DangKyKham form)
        {
            InitializeComponent();
            if (form == null)
                throw new ArgumentNullException(nameof(form));
            this.dky = form; // Lưu tham chiếu MainForm
        }
        public string Data { get; set; }
        public string Data1 { get; set; }
        public ChuanDoan(string data, string data1)
        {

            InitializeComponent();
            Data = data;
            Data1 = data1;
            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
            txtMSPhieuKhamBenh.Text = Data;
            txtMaYC.Text = Data1;

        }
        public bool KTraMa(string maCD)
        {
            if (maCD.Equals(dgvChuanDoan.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaCD.Text.Length == 0 || txtMaBenh.Text.Length == 0 || txtKetLuan.Text.Length == 0 || rtfLoiKhuyen.Text.Length == 0 || txtNVYC.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void SetupAutoComplete()
        {
            try
            {
                List<string> danhSachBenhLy = BUS_ChuanDoan.Instance.LayDSTenBenhLy();

                txtMaBenh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMaBenh.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                data.AddRange(danhSachBenhLy.ToArray());

                txtMaBenh.AutoCompleteCustomSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách bệnh lý: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChuanDoan_Load(object sender, EventArgs e)
        {
            BUS_ChuanDoan.Instance.XemDSChuanDoan(dgvChuanDoan, dtpNgay.Value);
            txtMaCD.Text = BUS_ChuanDoan.Instance.GenerateChuanDoanCode(txtMSPhieuKhamBenh.Text);

            cboLoaiBA.Items.Clear();
            BUS_ChuanDoan.Instance.DoDLLoaiBALenCB(cboLoaiBA);
            dgvChuanDoan.Columns[8].Visible = false;
            dgvChuanDoan.Columns[9].Visible = false;
            dgvChuanDoan.Columns[10].Visible = false;
            dgvChuanDoan.Columns[11].Visible = false;
            dgvChuanDoan.Columns[12].Visible = false;
            rtfTrieuChung.Text = BUS_DangKyKham.Instance.LayTrieuChung(txtMSPhieuKhamBenh.Text);
            txtNVYC.Text = BUS_ChuanDoan.Instance.layMaNVNhoMaNVYCau(txtMaYC.Text);
            txtTenNV.Text = BUS_DangKyKham.Instance.LayTenNV(txtNVYC.Text);
            SetupAutoComplete();
        }

        private void dgvChuanDoan_Click(object sender, EventArgs e)
        {
            int dong = dgvChuanDoan.CurrentCell.RowIndex;
            txtMaCD.Text = dgvChuanDoan.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtMaYC.Text = dgvChuanDoan.Rows[dong].Cells[1].Value?.ToString() ?? "";
            string maBenh = dgvChuanDoan.Rows[dong].Cells[2].Value?.ToString() ?? "";
            if (maBenh != null)
            {
                txtMaBenh.Text = BUS_ChuanDoan.Instance.LayTenBenhNhoMaBenh(maBenh);
            }
            else
            {
                txtMaBenh.Text = "";
            }
            txtMSPhieuKhamBenh.Text = dgvChuanDoan.Rows[dong].Cells[3].Value?.ToString() ?? "";
            if(txtMSPhieuKhamBenh.Text != null)
            {
                rtfTrieuChung.Text = BUS_DangKyKham.Instance.LayTrieuChung(txtMSPhieuKhamBenh.Text);
            }
            else
            {
                rtfTrieuChung.Text = String.Empty;
            }
            txtNVYC.Text = dgvChuanDoan.Rows[dong].Cells[4].Value?.ToString() ?? "";
            txtKetLuan.Text = dgvChuanDoan.Rows[dong].Cells[5].Value?.ToString() ?? "";
            rtfLoiKhuyen.Text = dgvChuanDoan.Rows[dong].Cells[6].Value?.ToString() ?? "";
            cboLoaiBA.SelectedValue = dgvChuanDoan.Rows[dong].Cells[7].Value?.ToString() ?? "";
        }
        /// <summary>
        /// Thanh công cụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    string maBenh = BUS_ChuanDoan.Instance.LayMaBenhNhoTenBenh(txtMaBenh.Text);
                    BUS_ChuanDoan.Instance.ThemChuanDoan(new ET_ChuanDoan(txtMaCD.Text, txtMaYC.Text, maBenh, txtMSPhieuKhamBenh.Text, txtNVYC.Text, txtKetLuan.Text, rtfLoiKhuyen.Text, cboLoaiBA.SelectedValue.ToString()));
                    BUS_ChuanDoan.Instance.XemDSChuanDoan(dgvChuanDoan, dtpNgay.Value);

                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ nghề nghiệp!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvChuanDoan.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_ChuanDoan.Instance.XoaChuanDoan(dgvChuanDoan);
                    BUS_ChuanDoan.Instance.XemDSChuanDoan(dgvChuanDoan, dtpNgay.Value);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvChuanDoan.SelectedRows.Count > 0){
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaCD.Text) == true)
                        {
                            string maBenh = BUS_ChuanDoan.Instance.LayMaBenhNhoTenBenh(txtMaBenh.Text);
                            BUS_ChuanDoan.Instance.SuaChuanDoan(new ET_ChuanDoan(txtMaCD.Text, txtMaYC.Text, maBenh, txtMSPhieuKhamBenh.Text, txtNVYC.Text, txtKetLuan.Text, rtfLoiKhuyen.Text, cboLoaiBA.SelectedValue.ToString()));
                            BUS_ChuanDoan.Instance.XemDSChuanDoan(dgvChuanDoan, dtpNgay.Value);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng không sửa mã " + dgvChuanDoan.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaCD.Text = dgvChuanDoan.CurrentRow.Cells[0].Value.ToString();
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
        private void txtMaCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaCD.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã chuẩn đoán quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKetLuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtKetLuan.Text.Length > 299 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kết luận quá 300 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtfLoiKhuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rtfLoiKhuyen.Text.Length > 499 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập lời khuyên quá 500 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKeToaThuoc_Click(object sender, EventArgs e)
        {
            if (isTimKiem && dgvChuanDoan.SelectedRows.Count > 0)
            {
                string data = dgvChuanDoan.CurrentRow.Cells[0].Value.ToString();
                _menu frmMain = (_menu)this.ParentForm;
                frmMain.openChildForm(new ToaThuoc(data));
            }
            else
            {
                MessageBox.Show("Vui lòng tìm kiếm phiếu khám bệnh đã kê và chưa kê toa thuốc theo ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            BUS_ChuanDoan.Instance.XemDSChuanDoan(dgvChuanDoan, dtpNgay.Value);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaYC_TextChanged(object sender, EventArgs e)
        {
            txtTenPhong.Text = BUS_ChuanDoan.Instance.layTenPhongNhoMaYCau(txtMaYC.Text);
            txtNVYC.Text = BUS_ChuanDoan.Instance.layMaNVNhoMaNVYCau(txtMaYC.Text);
            rtfTrieuChung.Text = BUS_DangKyKham.Instance.LayTrieuChung(txtMSPhieuKhamBenh.Text);
        }

        private void txtNVYC_TextChanged(object sender, EventArgs e)
        {
            txtTenNV.Text = BUS_DangKyKham.Instance.LayTenNV(txtNVYC.Text);
        }

        private bool isTimKiem = false;

        private void btnTimDaKeTT_Click(object sender, EventArgs e)
        {
            BUS_ChuanDoan.Instance.TimDSCoToaThuoc(dgvChuanDoan, dtpNgay.Value);
            isTimKiem = true;
            dgvChuanDoan.Columns[6].Visible = false;
            dgvChuanDoan.Columns[7].Visible = false;
        }

        private void btnTimChuaKeTT_Click(object sender, EventArgs e)
        {
            BUS_ChuanDoan.Instance.TimDSChuaToaThuoc(dgvChuanDoan, dtpNgay.Value);
            isTimKiem = true;

            dgvChuanDoan.Columns[6].Visible = false;
            dgvChuanDoan.Columns[7].Visible = false;
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            BUS_ChuanDoan.Instance.XemDSChuanDoan(dgvChuanDoan, dtpNgay.Value);

            dgvChuanDoan.Columns[8].Visible = false;
            dgvChuanDoan.Columns[9].Visible = false;
            dgvChuanDoan.Columns[10].Visible = false;
            dgvChuanDoan.Columns[11].Visible = false;
            dgvChuanDoan.Columns[12].Visible = false;
        }
    }
}
