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
    public partial class XNghiem_PThuat : Form
    {
        public XNghiem_PThuat()
        {
            InitializeComponent();
        }
        public string Data { get; set; }
        public XNghiem_PThuat(string data)
        {
            InitializeComponent();
            Data = data;
            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
            txtMaYC.Text = Data;
        }

        public bool KtraBoTrong()
        {
            if (txtKetQua.Text.Length == 0 || txtLoaiCTDV.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void SetupAutoComplete()
        {
            try
            {
                List<string> dichVu = BUS_XetNghiemPhauThuat.Instance.LayDSTenDV(txtLoaiCTDV.Text);

                txtLoaiCTDV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtLoaiCTDV.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                data.AddRange(dichVu.ToArray());

                txtLoaiCTDV.AutoCompleteCustomSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách phòng khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string layLoaiLam()
        {
            string loai = null;
            if (radPhauThuat.Checked == true)
            {
                loai = radPhauThuat.Text;
            }
            if (radXNCC.Checked == true)
            {
                loai = radXNCC.Text;
            }
            return loai;

        }

        private void XNghiem_PThuat_Load(object sender, EventArgs e)
        {
            cboMaLoaiBA.Items.Clear();
            BUS_XetNghiemPhauThuat.Instance.XemDSLamPTXNCC(dgvDSXNPT);
            BUS_XetNghiemPhauThuat.Instance.doDLLoaiBA(cboMaLoaiBA);
            string maYC = txtMaYC.Text.Trim();
            txtMaPKB.Text = BUS_XetNghiemPhauThuat.Instance.layMSPhieuKhamBenh(maYC);
            //txtMaPKB.Text = BUS_XetNghiemPhauThuat.Instance.layMSPhieuKhamBenh("MK-202405080001");

            string maPhong = BUS_XetNghiemPhauThuat.Instance.layMaPhongTuYC(maYC);
            txtTenPhong.Text = BUS_DangKyKham.Instance.layTenPhongNhoMaPhong(maPhong);
            txtMaNV.Text = BUS_XetNghiemPhauThuat.Instance.layMaNVTuYC(maYC);
            txtTenNV.Text = BUS_DangKyKham.Instance.LayTenNV(txtMaNV.Text);
            SetupAutoComplete();
            dgvDSXNPT.Columns[10].Visible = false;
            dgvDSXNPT.Columns[11].Visible = false;
            dgvDSXNPT.Columns[12].Visible = false;
            dgvDSXNPT.Columns[13].Visible = false;
            dgvDSXNPT.Columns[14].Visible = false;
            dgvDSXNPT.Columns[15].Visible = false;
        }

        private void dgvDSXNPT_Click(object sender, EventArgs e)
        {
            int dong = dgvDSXNPT.CurrentCell.RowIndex;
            txtMaPKB.Text = dgvDSXNPT.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtMaYC.Text = dgvDSXNPT.Rows[dong].Cells[1].Value?.ToString() ?? "";
            txtMaNV.Text = dgvDSXNPT.Rows[dong].Cells[2].Value?.ToString() ?? "";
            if (dgvDSXNPT.Rows[dong].Cells[3].Value != null)
            {
                string maPhong = dgvDSXNPT.Rows[dong].Cells[3].Value.ToString();
                string tenPhong = BUS_DangKyKham.Instance.layTenPhongNhoMaPhong(maPhong);
                txtTenPhong.Text = tenPhong;
            }
            else
            {
                txtTenPhong.Text = ""; // or any appropriate default/fallback value
            }

            if (dgvDSXNPT.Rows[dong].Cells[4].Value != null)
            {
                string maDVDV = dgvDSXNPT.Rows[dong].Cells[4].Value.ToString();
                string tenChiTietDV = BUS_XetNghiemPhauThuat.Instance.layTenDVTuMaDVDV(maDVDV);
                txtLoaiCTDV.Text = tenChiTietDV;
            }
            else
            {
                txtLoaiCTDV.Text = ""; // or any appropriate default/fallback value
            }

            dtpNgTH.Text = dgvDSXNPT.Rows[dong].Cells[5].Value?.ToString() ?? "";
            txtKetQua.Text = dgvDSXNPT.Rows[dong].Cells[6].Value?.ToString() ?? "";
            txtMucDoRuiRo.Text = dgvDSXNPT.Rows[dong].Cells[7].Value?.ToString() ?? "";
            string cellValue = "";

            // Check if the cell value is not null before assigning
            if (dgvDSXNPT.Rows[dong].Cells[8].Value != null)
            {
                cellValue = dgvDSXNPT.Rows[dong].Cells[8].Value.ToString();
            }

            // Use cellValue to determine which radio button to check
            if (cellValue == "Phẫu thuật")
            {
                radPhauThuat.Checked = true;
            }
            else if (cellValue == "XNCC")
            {
                radXNCC.Checked = true;
            }
            else
            {
                radPhauThuat.Checked = false;
                radXNCC.Checked = false;
            }

            cboMaLoaiBA.SelectedValue = dgvDSXNPT.Rows[dong].Cells[9].Value?.ToString() ?? "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    string maPhong = BUS_XetNghiemPhauThuat.Instance.layMaPhongTuYC(txtMaYC.Text);
                    string maDV = BUS_XetNghiemPhauThuat.Instance.layMaDVTuTenDV(txtLoaiCTDV.Text);
                    if (radPhauThuat.Checked == true)
                    {
                        if (BUS_XetNghiemPhauThuat.Instance.KiemTra(txtMaPKB.Text))
                        {
                            BUS_XetNghiemPhauThuat.Instance.ThemDSLamPTXNCC(new ET_XetNghiemPhauThuat(txtMaPKB.Text, txtMaYC.Text, txtMaNV.Text, maPhong, maDV, dtpNgTH.Value, txtKetQua.Text, txtMucDoRuiRo.Text, layLoaiLam(), cboMaLoaiBA.SelectedValue.ToString()));
                            BUS_XetNghiemPhauThuat.Instance.XemDSLamPTXNCC(dgvDSXNPT);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chuẩn đoán trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        BUS_XetNghiemPhauThuat.Instance.ThemDSLamPTXNCC(new ET_XetNghiemPhauThuat(txtMaPKB.Text, txtMaYC.Text, txtMaNV.Text, maPhong, maDV, dtpNgTH.Value, txtKetQua.Text, txtMucDoRuiRo.Text, layLoaiLam(), cboMaLoaiBA.SelectedValue.ToString()));
                        BUS_XetNghiemPhauThuat.Instance.XemDSLamPTXNCC(dgvDSXNPT);
                    }

                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Xác nhận sửa dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    string maPhong = BUS_XetNghiemPhauThuat.Instance.layMaPhongTuYC(txtMaYC.Text);
                    string maDV = BUS_XetNghiemPhauThuat.Instance.layMaDVTuTenDV(txtLoaiCTDV.Text);
                    if (radPhauThuat.Checked == true)
                    {
                        if (BUS_XetNghiemPhauThuat.Instance.KiemTra(txtMaPKB.Text))
                        {
                            BUS_XetNghiemPhauThuat.Instance.SuaDSLamPTXNCC(new ET_XetNghiemPhauThuat(txtMaPKB.Text, txtMaYC.Text, txtMaNV.Text, maPhong, maDV, dtpNgTH.Value, txtKetQua.Text, txtMucDoRuiRo.Text, layLoaiLam(), cboMaLoaiBA.SelectedValue.ToString()));
                            BUS_XetNghiemPhauThuat.Instance.XemDSLamPTXNCC(dgvDSXNPT);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chuẩn đoán trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        BUS_XetNghiemPhauThuat.Instance.SuaDSLamPTXNCC(new ET_XetNghiemPhauThuat(txtMaPKB.Text, txtMaYC.Text, txtMaNV.Text, maPhong, maDV, dtpNgTH.Value, txtKetQua.Text, txtMucDoRuiRo.Text, layLoaiLam(), cboMaLoaiBA.SelectedValue.ToString()));
                        BUS_XetNghiemPhauThuat.Instance.XemDSLamPTXNCC(dgvDSXNPT);
                    }

                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void txtKetQua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtKetQua.Text.Length > 199 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kết quả quá 200 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMucDoRuiRo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMucDoRuiRo.Text.Length > 199 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mức độ rủi ro quá 200 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaYC_TextChanged(object sender, EventArgs e)
        {
            txtMaPKB.Text = BUS_XetNghiemPhauThuat.Instance.layMSPhieuKhamBenh(txtMaYC.Text);
            string maPhong = BUS_XetNghiemPhauThuat.Instance.layMaPhongTuYC(txtMaYC.Text);
            txtTenPhong.Text = BUS_DangKyKham.Instance.layTenPhongNhoMaPhong(maPhong);
            txtMaNV.Text = BUS_XetNghiemPhauThuat.Instance.layMaNVTuYC(txtMaYC.Text);
            txtTenNV.Text = BUS_DangKyKham.Instance.LayTenNV(txtMaNV.Text);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (BUS_XetNghiemPhauThuat.Instance.KiemTra(txtMaPKB.Text))
            {
                string dataToSend1 = txtMaPKB.Text;
                _menu frmMain = (_menu)this.ParentForm;
                frmMain.openChildForm(new HoaDon(dataToSend1));
            }
            else
            {
                MessageBox.Show("Phải chuẩn đoán trước đã mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
