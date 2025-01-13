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
    public partial class TheoDoiSucKhoe : Form
    {
        public TheoDoiSucKhoe()
        {
            InitializeComponent();
        }
        public string Data { get; set; }
        public string Data1 { get; set; }
        public TheoDoiSucKhoe(string data,string data1)
        {

            InitializeComponent();
            Data = data;
            Data1 = data1;
            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
            txtMaYeuCau.Text = Data;
            txtMaPKB.Text = Data1;
        }

        public bool KTraMa(string maTD)
        {
            if (maTD.Equals(dgvTDSK.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaTD.Text.Length == 0 || rtfTTSK.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void TheoDoiSucKhoe_Load(object sender, EventArgs e)
        {
            txtMaTD.Text = BUS_TheoDoiSucKhoe.Instance.GenerateTheoDoiSucKhoeCode(txtMaPKB.Text);
            txtMaPhong.Text = BUS_ChuanDoan.Instance.layTenPhongNhoMaYCau(txtMaYeuCau.Text);
            BUS_TheoDoiSucKhoe.Instance.XemDSTheoDoiSK(dgvTDSK, txtMaPKB.Text);
            txtNVPhuTrach.Text = BUS_XetNghiemPhauThuat.Instance.layMaNVTuYC(txtMaYeuCau.Text);
            dgvTDSK.Columns[7].Visible = false;
            dgvTDSK.Columns[8].Visible = false;
            dgvTDSK.Columns[9].Visible = false;
        }

        private void dgvTDSK_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void dgvTDSK_Click(object sender, EventArgs e)
        {
            int dong = dgvTDSK.CurrentCell.RowIndex;
            txtMaTD.Text = dgvTDSK.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtMaYeuCau.Text = dgvTDSK.Rows[dong].Cells[1].Value?.ToString() ?? "";          
            cboMaNV.SelectedValue = dgvTDSK.Rows[dong].Cells[3].Value?.ToString() ?? "";
            dtpNgayTD.Text = dgvTDSK.Rows[dong].Cells[4].Value?.ToString() ?? DateTime.Now.ToString();
            rtfTTSK.Text = dgvTDSK.Rows[dong].Cells[5].Value?.ToString() ?? "";
            if (dgvTDSK.Rows[dong].Cells[6].Value != null)
            {
                rtfGhiChu.Text = dgvTDSK.Rows[dong].Cells[6].Value.ToString();
            }
            else
            {
                rtfGhiChu.Text = string.Empty; // Đặt txtGhiChu thành rỗng nếu Value là null
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {

                    if (BUS_TheoDoiSucKhoe.Instance.KiemTraNgayTD(dtpNgayTD.Value, txtMaPKB.Text) == false)
                    {
                        MessageBox.Show("Ngày theo dõi phải trong khoảng thời gian cùng ngày với ngày nằm viện !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BUS_TheoDoiSucKhoe.Instance.ThemTheoDoi(new ET_TheoDoiSucKhoe(txtMaTD.Text, txtMaYeuCau.Text, txtMaPKB.Text, cboMaNV.SelectedValue.ToString(), dtpNgayTD.Value, rtfTTSK.Text, rtfGhiChu.Text));
                        BUS_TheoDoiSucKhoe.Instance.XemDSTheoDoiSK(dgvTDSK, txtMaPKB.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ SĐT và Email!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvTDSK.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_TheoDoiSucKhoe.Instance.XoaTheoDoiSK(dgvTDSK);
                    BUS_TheoDoiSucKhoe.Instance.XemDSTheoDoiSK(dgvTDSK, txtMaPKB.Text);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvTDSK.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaTD.Text) == true)
                        {
                            BUS_TheoDoiSucKhoe.Instance.SuaTheoDoiSK(new ET_TheoDoiSucKhoe(txtMaTD.Text, txtMaYeuCau.Text, txtMaPKB.Text, cboMaNV.SelectedValue.ToString(), dtpNgayTD.Value, rtfTTSK.Text, rtfGhiChu.Text));
                            BUS_TheoDoiSucKhoe.Instance.XemDSTheoDoiSK(dgvTDSK, txtMaPKB.Text);
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa mã bệnh nhân " + dgvTDSK.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaTD.Text = dgvTDSK.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ SĐT và Email!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtMaTD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.') || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay khoảng trắng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaTD.Text.Length > 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập mã theo dõi quá 12 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtfTTSK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rtfTTSK.Text.Length > 1999 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tình trạng sức khỏe quá 2000 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtfGhiChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rtfGhiChu.Text.Length > 1999 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập ghi chú quá 2000 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboMaYC_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaPhong.Text = BUS_ChuanDoan.Instance.layTenPhongNhoMaYCau(txtMaYeuCau.Text);
            txtMaPKB.Text = BUS_PhanGiuong.Instance.LayPKBTuMaYC(txtMaYeuCau.Text);
            BUS_TheoDoiSucKhoe.Instance.XemDSTheoDoiSK(dgvTDSK, txtMaPKB.Text);
            txtNVPhuTrach.Text = BUS_XetNghiemPhauThuat.Instance.layMaNVTuYC(txtMaYeuCau.Text);
            BUS_TheoDoiSucKhoe.Instance.LayNVTuNVPhuTrach(cboMaNV, txtNVPhuTrach.Text);
        }

        private void txtNVPhuTrach_TextChanged(object sender, EventArgs e)
        {
            BUS_TheoDoiSucKhoe.Instance.LayNVTuNVPhuTrach(cboMaNV, txtNVPhuTrach.Text);
        }

        private void dtpNgayTD_ValueChanged(object sender, EventArgs e)
        {
            if (BUS_TheoDoiSucKhoe.Instance.KiemTraNgayTD(dtpNgayTD.Value, txtMaPKB.Text) == false)
            {
                MessageBox.Show("Ngày theo dõi phải trong khoảng thời gian cùng ngày với ngày nằm viện !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaPKB_TextChanged(object sender, EventArgs e)
        {
            if(txtMaPKB.Text != null)
            {
                txtNgNG.Text = Convert.ToString(BUS_TheoDoiSucKhoe.Instance.LayNgayNhanGiuong(txtMaPKB.Text));
                txtNgTG.Text = Convert.ToString(BUS_TheoDoiSucKhoe.Instance.LayNgayTraGiuong(txtMaPKB.Text));
            }
            else
            {
                txtNgNG.Text = String.Empty;
                txtNgTG.Text = String.Empty;
            }
        }

        private void dtpNgayTD_Validating(object sender, CancelEventArgs e)
        {
            if (BUS_TheoDoiSucKhoe.Instance.KiemTraNgayTD(dtpNgayTD.Value, txtMaPKB.Text) == false)
            {
                MessageBox.Show("Ngày theo dõi phải trong khoảng thời gian cùng ngày với ngày nằm viện !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaTD_TextChanged(object sender, EventArgs e)
        {
            txtMaPhong.Text = BUS_ChuanDoan.Instance.layTenPhongNhoMaYCau(txtMaYeuCau.Text);
            BUS_TheoDoiSucKhoe.Instance.XemDSTheoDoiSK(dgvTDSK, txtMaPKB.Text);
            txtNVPhuTrach.Text = BUS_XetNghiemPhauThuat.Instance.layMaNVTuYC(txtMaYeuCau.Text);
        }

        private void dgvTDSK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dgvTDSK_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            BUS_TheoDoiSucKhoe.Instance.XemDSTheoDoiSK(dgvTDSK, txtMaPKB.Text);
        }
    }
}
