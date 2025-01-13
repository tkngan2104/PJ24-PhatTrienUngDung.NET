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
    public partial class ToaThuoc : Form
    {
        public ToaThuoc()
        {
            InitializeComponent();
        }
        public string Data { get; set; }
        private _menu mainForm;

        public ToaThuoc(_menu form)
        {
            InitializeComponent();
            this.mainForm = form; // Lưu tham chiếu MainForm
        }

        public ToaThuoc(string data)
        {
            InitializeComponent();
            this.Data = data; // Lưu data// Lưu tham chiếu MainForm
            txtMSPhieuKhamBenh.Text = Data; // Hiển thị dữ liệu lên control
        }


        private void SetupAutoComplete()
        {
            try
            {
                List<string> dsThuoc = BUS_ToaThuoc.Instance.LayDSTenThuoc();

                txtThuoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtThuoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                data.AddRange(dsThuoc.ToArray());

                txtThuoc.AutoCompleteCustomSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách phòng khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool KtraBoTrong()
        {
            if (txtMaTT.Text.Length == 0 || txtThuoc.Text.Length == 0 || txtGiaTien.Text.Length == 0 || rtfHDSD.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        private void ToaThuoc_Load(object sender, EventArgs e)
        {
            txtMaTT.Text = BUS_ToaThuoc.Instance.GenerateToaThuocCode(txtMSPhieuKhamBenh.Text);
            cboNV.Items.Clear();
            BUS_ToaThuoc.Instance.XemDSTTThuoc(dgvToaThuoc, txtMSPhieuKhamBenh.Text);
            txtChuanDoan.Text = BUS_ToaThuoc.Instance.LayChuanDoanNhoPKB(txtMSPhieuKhamBenh.Text);
            BUS_ToaThuoc.Instance.LayDSNVKhoaDuoc(cboNV);
            SetupAutoComplete();
            BUS_ToaThuoc.Instance.CapNhapTienCuaTThuoc();
            BUS_ToaThuoc.Instance.CapNhapGiaTien();
            dgvToaThuoc.Columns[8].Visible = false;
        }

        private void dgvToaThuoc_Click(object sender, EventArgs e)
        {
            int dong = dgvToaThuoc.CurrentCell.RowIndex;
            txtMaTT.Text = dgvToaThuoc.Rows[dong].Cells[0].Value?.ToString() ?? "";
            if (dgvToaThuoc.Rows[dong].Cells[0].Value != null)
            {
                string tenThuoc = BUS_ToaThuoc.Instance.LayTenThuocNhoMaThuoc(dgvToaThuoc.Rows[dong].Cells[1].Value.ToString());
                txtThuoc.Text = tenThuoc;
            }
            
            numSoLuong.Value = Convert.ToInt32(dgvToaThuoc.Rows[dong].Cells[3].Value ?? 0);
            txtGiaTien.Text = dgvToaThuoc.Rows[dong].Cells[4].Value?.ToString() ?? "";
            rtfHDSD.Text = dgvToaThuoc.Rows[dong].Cells[5].Value?.ToString() ?? "";
            dtpNgCap.Text = dgvToaThuoc.Rows[dong].Cells[7].Value?.ToString() ?? "";
            cboNV.SelectedValue = dgvToaThuoc.Rows[dong].Cells[8].Value?.ToString() ?? "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    string maThuoc = BUS_ToaThuoc.Instance.LayMaThuocNhoTenThuoc(txtThuoc.Text);
                    string maCD = BUS_ToaThuoc.Instance.LayMaCDNhoPKB(txtMSPhieuKhamBenh.Text);
                    BUS_ToaThuoc.Instance.ThemThuocVaoTT(new ET_ToaThuoc(txtMaTT.Text, maCD, txtMSPhieuKhamBenh.Text, maThuoc, Convert.ToInt32(numSoLuong.Value), float.Parse(txtGiaTien.Text), dtpNgCap.Value, rtfHDSD.Text, cboNV.SelectedValue.ToString()));
                    BUS_ToaThuoc.Instance.CapNhapTienCuaTThuoc();
                    BUS_ToaThuoc.Instance.XemDSTTThuoc(dgvToaThuoc, txtMSPhieuKhamBenh.Text);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ nghề nghiệp!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvToaThuoc.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_ToaThuoc.Instance.XoaThuoc(dgvToaThuoc);
                    BUS_ToaThuoc.Instance.XemDSTTThuoc(dgvToaThuoc, txtMSPhieuKhamBenh.Text);
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

        private void rtfHDSD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rtfHDSD.Text.Length > 499 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập hướng dẫn sử dụng quá 500 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpNgCap_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgCap.Value > DateTime.Now)
            {
                MessageBox.Show("Không thể chỉnh ngày lớn hơn ngày hiện tại !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgCap.Value = DateTime.Now;
            }
        }

        private void txtThuoc_TextChanged(object sender, EventArgs e)
        {
            string maThuoc = BUS_ToaThuoc.Instance.LayMaThuocNhoTenThuoc(txtThuoc.Text);
            float gia = (BUS_ToaThuoc.Instance.LayGiaTienNhoMaThuoc(maThuoc));
            txtGiaTien.Text = gia.ToString();
        }
        public bool KTraMa(string maTT)
        {
            if (maTT.Equals(dgvToaThuoc.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
           if(dgvToaThuoc.SelectedRows.Count > 0)
            {
                string dataToSend = txtMaTT.Text;
                string dataToSend1 = txtMSPhieuKhamBenh.Text;
                _menu frmMain = (_menu)this.ParentForm;
                frmMain.openChildForm(new HoaDon(dataToSend, dataToSend1));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
