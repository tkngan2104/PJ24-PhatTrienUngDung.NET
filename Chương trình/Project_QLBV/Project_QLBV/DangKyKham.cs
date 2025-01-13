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
    public partial class DangKyKham : Form
    {
        public DangKyKham()
        {
            InitializeComponent();
        }
        private _menu mainForm;

        public DangKyKham(_menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public bool KTraMa(string maKham)
        {
            if (maKham.Equals(dgvDKK.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtTenPhong.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        private void DangKyKham_Load(object sender, EventArgs e)
        {
            BUS_DangKyKham.Instance.XemDSDKyKham(dgvDKK, dtpNgay.Value);
            string tenPhong = txtTenPhong.Text;
            string maPhong = BUS_DangKyKham.Instance.LayMaPhongNhoTenPhong(tenPhong);

            cboPhieuKhamBenh.Items.Clear();
            cboNVYeuCau.Items.Clear();
            cboNVPhuTrach.Items.Clear();
            BUS_DangKyKham.Instance.LayPKBTheoNgayKham(dtpNgay.Value, cboPhieuKhamBenh);
            if (cboPhieuKhamBenh.SelectedValue != null)
            {
                BUS_DangKyKham.Instance.DoDLNVYeuCau(cboPhieuKhamBenh.SelectedValue.ToString(), cboNVYeuCau);
                BUS_DangKyKham.Instance.DoDLNVPhuTrach(cboNVPhuTrach, maPhong);
            }

            dgvDKK.Columns[5].Visible = false;
            dgvDKK.Columns[6].Visible = false;
            dgvDKK.Columns[7].Visible = false;
            dgvDKK.Columns[8].Visible = false;


            cboNVYeuCau.SelectedIndexChanged += cboNVYeuCau_SelectedIndexChanged;
            if (cboPhieuKhamBenh.SelectedValue != null)
            {
                txtMaBN.Text = BUS_DangKyKham.Instance.layMaBNNhoMaPKB(cboPhieuKhamBenh.SelectedValue.ToString());
                txtTenBN.Text = BUS_DangKyKham.Instance.layTenBNNhoMaBN(txtMaBN.Text);

                txtTrieuChung.Text = BUS_DangKyKham.Instance.LayTrieuChung(cboPhieuKhamBenh.SelectedValue.ToString());
            }
            SetupAutoComplete();

        }

        private void SetupAutoComplete()
        {
            try
            {
                List<string> phongKham = BUS_DangKyKham.Instance.LayDSTenPhong();

                txtTenPhong.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTenPhong.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                data.AddRange(phongKham.ToArray());

                txtTenPhong.AutoCompleteCustomSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách phòng khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DangKyKham_Click(object sender, EventArgs e)
        {

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
                    string tenPhong = txtTenPhong.Text;
                    string maPhong = BUS_DangKyKham.Instance.LayMaPhongNhoTenPhong(tenPhong);
                    string maNVPhuTrach = cboNVPhuTrach.SelectedValue?.ToString() ?? string.Empty;  // Null-coalescing operator để xử lý null
                    BUS_DangKyKham.Instance.DangKyKham(new ET_DangKyKham(txtMaKham.Text, cboPhieuKhamBenh.SelectedValue.ToString(), maPhong, cboNVYeuCau.SelectedValue.ToString(), maNVPhuTrach));
                    BUS_DangKyKham.Instance.XemDSDKyKham(dgvDKK, dtpNgay.Value);
                    if (BUS_DangKyKham.Instance.KiemTraTrangThaiKhamCuaPhongKham(txtMaKham.Text) == true)
                    {

                        DialogResult ret1 = MessageBox.Show("Bạn muốn thực hiện chuẩn đoán không ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ret1 == DialogResult.Yes)
                        {
                            if (cboNVPhuTrach.SelectedIndex != -1)
                            {
                                string dataToSend = cboPhieuKhamBenh.SelectedValue.ToString();  // Dữ liệu bạn muốn gửi
                                _menu frmMain = (_menu)this.ParentForm;
                                frmMain.openChildForm(new ChuanDoan(dataToSend, txtMaKham.Text));
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng điền người phụ trách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }



                    }
                    else if (BUS_DangKyKham.Instance.KiemTraTrangThaiKhamCuaPhongBenh(txtMaKham.Text) == true)
                    {
                        DialogResult ret1 = MessageBox.Show("Bạn muốn thực hiện phân giường không ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ret1 == DialogResult.Yes)
                        {
                            if (cboNVPhuTrach.SelectedIndex != -1)
                            {
                                _menu frmMain = (_menu)this.ParentForm;
                                frmMain.openChildForm(new PhanGiuong(txtMaKham.Text));
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng điền người phụ trách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }               
                cboNVPhuTrach.SelectedIndex = -1;
                }

                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDKK.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_DangKyKham.Instance.XoaDkyKham(dgvDKK, txtMaKham.Text);
                    BUS_DangKyKham.Instance.XemDSDKyKham(dgvDKK, dtpNgay.Value);
                    cboNVPhuTrach.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDKK.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaKham.Text) == true)
                        {
                            string tenPhong = txtTenPhong.Text;
                            string maPhong = BUS_DangKyKham.Instance.LayMaPhongNhoTenPhong(tenPhong);
                            string maNVPhuTrach = cboNVPhuTrach.SelectedValue?.ToString() ?? string.Empty;  // Null-coalescing operator để xử lý null
                            BUS_DangKyKham.Instance.SuaDSDkyKham(new ET_DangKyKham(txtMaKham.Text, cboPhieuKhamBenh.SelectedValue.ToString(), maPhong, cboNVYeuCau.SelectedValue.ToString(), maNVPhuTrach), txtNVYeuCau.Text, cboPhieuKhamBenh.SelectedValue.ToString(), maPhong);
                            BUS_DangKyKham.Instance.XemDSDKyKham(dgvDKK, dtpNgay.Value);
                            if (BUS_DangKyKham.Instance.KiemTraTrangThaiKhamCuaPhongKham(txtMaKham.Text) == true)
                            {

                                DialogResult ret1 = MessageBox.Show("Bạn muốn thực hiện chuẩn đoán không ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (ret1 == DialogResult.Yes)
                                {
                                    if (cboNVPhuTrach.SelectedIndex != -1)
                                    {
                                        string dataToSend = cboPhieuKhamBenh.SelectedValue.ToString();  // Dữ liệu bạn muốn gửi
                                        _menu frmMain = (_menu)this.ParentForm;
                                        frmMain.openChildForm(new ChuanDoan(dataToSend, txtMaKham.Text));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Vui lòng điền người phụ trách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }



                            }
                            else if (BUS_DangKyKham.Instance.KiemTraTrangThaiKhamCuaPhongBenh(txtMaKham.Text) == true)
                            {
                                DialogResult ret1 = MessageBox.Show("Bạn muốn thực hiện phân giường không ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (ret1 == DialogResult.Yes)
                                {
                                    if (cboNVPhuTrach.SelectedIndex != -1)
                                    {
                                        _menu frmMain = (_menu)this.ParentForm;
                                        frmMain.openChildForm(new PhanGiuong(txtMaKham.Text));
                                    }
                                    else
                                    {
                                        MessageBox.Show("Vui lòng điền người phụ trách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                            }

                        
                        cboNVPhuTrach.SelectedIndex = -1;
                            

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

        private void cboPhieuKhamBenh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaBN.Text = BUS_DangKyKham.Instance.layMaBNNhoMaPKB(cboPhieuKhamBenh.SelectedValue.ToString());
            txtTenBN.Text = BUS_DangKyKham.Instance.layTenBNNhoMaBN(txtMaBN.Text);
            string tenPhong = txtTenPhong.Text;
            string maPhong = BUS_DangKyKham.Instance.LayMaPhongNhoTenPhong(tenPhong);
            BUS_DangKyKham.Instance.DoDLNVYeuCau(cboPhieuKhamBenh.SelectedValue.ToString(), cboNVYeuCau);
            BUS_DangKyKham.Instance.DoDLNVPhuTrach(cboNVPhuTrach, maPhong);
            txtTrieuChung.Text = BUS_DangKyKham.Instance.LayTrieuChung(cboPhieuKhamBenh.SelectedValue.ToString());
            if (cboPhieuKhamBenh.SelectedValue != null)
            {
                txtMaKham.Text = BUS_DangKyKham.Instance.GenerateMaKhamCode(cboPhieuKhamBenh.SelectedValue.ToString());
            }
            else
            {
                txtMaKham.Text = "No selection"; // Hoặc bạn có thể xử lý theo một cách khác tùy thuộc vào yêu cầu của ứng dụng
            }
            SetupAutoComplete();
        }

        private void cboNVYeuCau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNVYeuCau.SelectedIndex >= 0)
            {
                txtNVYeuCau.Text = BUS_DangKyKham.Instance.LayTenNV(cboNVYeuCau.SelectedValue.ToString());
            }
            else
            {
                txtNVYeuCau.Text = null;
            }
        }

        private void cboNVPhuTrach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNVPhuTrach.SelectedIndex >= 0)
            {
                txtNVPhuTrach.Text = BUS_DangKyKham.Instance.LayTenNV(cboNVPhuTrach.SelectedValue.ToString());
            }
            else
            {
                txtNVPhuTrach.Text = null;
            }
        }

        private void txtTenPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tenPhong = txtTenPhong.Text;
            string maPhong = BUS_DangKyKham.Instance.LayMaPhongNhoTenPhong(tenPhong);
            BUS_DangKyKham.Instance.DoDLNVPhuTrach(cboNVPhuTrach, maPhong);
            cboNVPhuTrach.SelectedIndex = -1;
            if (cboNVYeuCau.SelectedValue != null)
            {
                txtNVYeuCau.Text = BUS_DangKyKham.Instance.LayTenNV(cboNVYeuCau.SelectedValue.ToString());
            }
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Length != 0)
            {
                txtTenPhong.Text = BUS_DangKyKham.Instance.layTenPhongNhoMaPhong(txtMaPhong.Text);
            }
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            BUS_DangKyKham.Instance.LayPKBTheoNgayKham(dtpNgay.Value, cboPhieuKhamBenh);
            BUS_DangKyKham.Instance.XemDSDKyKham(dgvDKK, dtpNgay.Value);
        }
        private bool isSearchButtonClicked = false;

        private void btnTim_Click(object sender, EventArgs e)
        {
            BUS_DangKyKham.Instance.LayDSDangChoPT_XNCCTheoNgay(dtpNgay.Value, dgvDKK);
            isSearchButtonClicked = true;
        }

        private void cboPhieuKhamBenh_SelectedValueChanged(object sender, EventArgs e)
        {
            SetupAutoComplete();
        }

        private void dgvDKK_SelectionChanged(object sender, EventArgs e)
        {
            if (isSearchButtonClicked == true)
            {
                int dong = dgvDKK.CurrentCell.RowIndex;
                if (dgvDKK.Rows[dong].Cells[0].Value.ToString() != null)
                {

                    _menu frmMain = (_menu)this.ParentForm;
                    frmMain.openChildForm(new XNghiem_PThuat(dgvDKK.Rows[dong].Cells[0].Value.ToString()));
                }
            }
        }



        /// <summary>
        /// Bắt lỗi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void txtTenPhong_Leave(object sender, EventArgs e)
        {
            string maPhong = BUS_DangKyKham.Instance.LayMaPhongNhoTenPhong(txtTenPhong.Text);
            if (!BUS_DangKyKham.Instance.KiemTraCoChuanDoanChua(cboPhieuKhamBenh.SelectedValue.ToString()) && BUS_DangKyKham.Instance.KiemTraPhong(txtTenPhong.Text) == true)
            {
                MessageBox.Show("Vui lòng có chuẩn đoán trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenPhong.Text = null;
            }

            bool isFirstVisit = BUS_DangKyKham.Instance.KiemTraLanKhamDauCuaPKKham(cboPhieuKhamBenh.SelectedValue.ToString());
            bool isRestrictedRoom = BUS_DangKyKham.Instance.KiemTraLoaiPhong(maPhong);
            if (BUS_DangKyKham.Instance.KiemTraDiKhamChua(cboPhieuKhamBenh.SelectedValue.ToString()) == false && isRestrictedRoom)
            {
                MessageBox.Show("Không được phép đăng ký phòng bệnh hoặc phòng chức năng trong lần khám đầu tiên!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenPhong.Text = null; // Xóa nhập liệu không hợp lệ
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnChuanDoan_Click(object sender, EventArgs e)
        {
            if(dgvDKK.SelectedRows.Count > 0)
            {
                if (dgvDKK.CurrentRow.Cells[3].Value != null)
                {
                    if (BUS_DangKyKham.Instance.KiemTraTrangThaiKhamCuaPhongKham(dgvDKK.CurrentRow.Cells[0].Value.ToString()) == true)
                    {
                        DialogResult ret1 = MessageBox.Show("Bạn muốn thực hiện chuẩn đoán không ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ret1 == DialogResult.Yes)
                        {
                            string dataToSend = cboPhieuKhamBenh.SelectedValue.ToString();  // Dữ liệu bạn muốn gửi
                            _menu frmMain = (_menu)this.ParentForm;
                            frmMain.openChildForm(new ChuanDoan(dataToSend, txtMaKham.Text));
                        }
                        else
                        {
                            MessageBox.Show("Phòng này không thực hiện được chức năng chuẩn đoán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn người phụ trách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKham.Text = BUS_DangKyKham.Instance.GenerateMaKhamCode(cboPhieuKhamBenh.SelectedValue.ToString());
        }

        private void btnPhanGiuong_Click(object sender, EventArgs e)
        {
            if(dgvDKK.SelectedRows.Count > 0)
            {
                if (dgvDKK.CurrentRow.Cells[3].Value != null)
                {
                    if (BUS_DangKyKham.Instance.KiemTraTrangThaiKhamCuaPhongBenh(txtMaKham.Text) == true)
                    {
                        DialogResult ret1 = MessageBox.Show("Bạn muốn thực hiện phân giường không ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ret1 == DialogResult.Yes)
                        {
                            _menu frmMain = (_menu)this.ParentForm;
                            frmMain.openChildForm(new PhanGiuong(txtMaKham.Text));

                        }

                    }
                    else
                    {
                        MessageBox.Show("Phòng này không thực hiện được chức năng nội trú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền người phụ trách vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDKK_Click(object sender, EventArgs e)
        {
            cboPhieuKhamBenh.SelectedIndexChanged -= cboPhieuKhamBenh_SelectedIndexChanged;
            BUS_DangKyKham.Instance.LayTatCaDSNV(cboNVYeuCau);
            if (dgvDKK.CurrentRow != null && dgvDKK.CurrentRow.Index >= 0 && dgvDKK.SelectedRows.Count > 0)
            {
                int dong = dgvDKK.CurrentCell.RowIndex;
                txtMaKham.Text = dgvDKK.Rows[dong].Cells[0].Value?.ToString() ?? "";
                cboPhieuKhamBenh.SelectedValue = dgvDKK.Rows[dong].Cells[1].Value?.ToString() ?? "";

                txtMaPhong.Text = dgvDKK.Rows[dong].Cells[2].Value?.ToString() ?? "";
                if (txtMaPhong.Text == dgvDKK.Rows[dong].Cells[2].Value?.ToString())
                {
                    BUS_DangKyKham.Instance.DoDLNVPhuTrach(cboNVPhuTrach, txtMaPhong.Text);
                }
                cboNVYeuCau.SelectedValue = dgvDKK.Rows[dong].Cells[4].Value?.ToString() ?? "";
                string tenPhong = txtTenPhong.Text;
                if (dgvDKK.CurrentRow != null)
                {
                    cboPhieuKhamBenh.SelectedValue = dgvDKK.Rows[dong].Cells[1].Value?.ToString() ?? "";
                    string msPhieuKham = dgvDKK.CurrentRow.Cells["MSPhieuKhamBenh"].Value?.ToString() ?? "";
                    BUS_DangKyKham.Instance.LayTatCaDSNV(cboNVYeuCau);
                    cboNVYeuCau.SelectedValue = dgvDKK.Rows[dong].Cells[4].Value?.ToString() ?? "";
                    if (dgvDKK.Rows[dong].Cells[3].Value != null && !string.IsNullOrWhiteSpace(dgvDKK.Rows[dong].Cells[3].Value.ToString()))
                    {
                        cboNVPhuTrach.SelectedValue = dgvDKK.Rows[dong].Cells[3].Value.ToString();
                    }
                    else
                    {
                        cboNVPhuTrach.SelectedIndex = -1;
                    }
                    if (cboPhieuKhamBenh.SelectedValue != null)
                    {
                        txtTrieuChung.Text = BUS_DangKyKham.Instance.LayTrieuChung(cboPhieuKhamBenh.SelectedValue.ToString());
                    }
                    else
                    {
                        txtTrieuChung.Text = null;
                    }
                }
            }
        }
    }

}
