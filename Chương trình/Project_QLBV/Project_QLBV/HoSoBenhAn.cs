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
    public partial class HoSoBenhAn : Form
    {
        public HoSoBenhAn()
        {
            InitializeComponent();
        }
        public string Data { get; set; }
        private _menu mainForm;

        public HoSoBenhAn(_menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            if (this.mainForm == null)
            {
                MessageBox.Show("mainForm is null inside TTBN constructor.");
            }

        }

        public HoSoBenhAn(string data)
        {
            InitializeComponent();
            Data = data;
            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
            txtMaBN.Text = Data;
        }
        private void HoSoBenhAn_Load(object sender, EventArgs e)
        {
            BUS_HoSoBenhAn.Instance.XemDSHoSoBA(dgvDSHSBA);
            txtMaHSBA.Text = BUS_HoSoBenhAn.Instance.taoMaHoSoBA(Data);
            string maBN = txtMaBN.Text;
            txtTenBN.Text = BUS_HoSoBenhAn.Instance.LayTenBNNhoMaBN(maBN);

            dgvDSHSBA.Columns[3].Visible = false;
            dtpNgTao.Value = DateTime.Now;
        }

        private void dgvDSHSBA_Click(object sender, EventArgs e)
        {
            int dong = dgvDSHSBA.CurrentCell.RowIndex;
            txtMaHSBA.Text = dgvDSHSBA.Rows[dong].Cells[0].Value?.ToString()??"";
            txtMaBN.Text = dgvDSHSBA.Rows[dong].Cells[1].Value?.ToString()??"";
            var dateValue = dgvDSHSBA.Rows[dong].Cells[2].Value;

            // Check if the cell value is not null and not DBNull; otherwise, use current date.
            if (dateValue != null && dateValue != DBNull.Value)
            {
                dtpNgTao.Value = Convert.ToDateTime(dateValue);
            }
            else
            {
                dtpNgTao.Value = DateTime.Now; // Set to current date if the value is null or DB null
            }
            if (txtMaBN.Text != null)
            {
                txtTenBN.Text = BUS_HoSoBenhAn.Instance.LayTenBNNhoMaBN(txtMaBN.Text);
            }
            else
            {
                txtTenBN.Text = String.Empty;
            }
        }

        public bool KTraMa(string msThuoc)
        {
            if (msThuoc.Equals(dgvDSHSBA.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaHSBA.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    BUS_HoSoBenhAn.Instance.ThemHoSoBA(new ET_HoSoBenhAn(txtMaHSBA.Text, txtMaBN.Text, dtpNgTao.Value));
                    BUS_HoSoBenhAn.Instance.XemDSHoSoBA(dgvDSHSBA);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if(dgvDSHSBA.SelectedRows.Count > 0)
            //{
            //    DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (ret == DialogResult.Yes)
            //    {
            //        BUS_HoSoBenhAn.Instance.XoaHoSoBA(dgvDSHSBA);
            //        BUS_HoSoBenhAn.Instance.XemDSHoSoBA(dgvDSHSBA);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //if(dgvDSHSBA.SelectedRows.Count > 0)
            //{
            //    DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (d == DialogResult.Yes)
            //    {
            //        if (KtraBoTrong() == true)
            //        {
            //            if (KTraMa(txtMaHSBA.Text) == true)
            //            {
            //                BUS_HoSoBenhAn.Instance.SuaHoSoBA(new ET_HoSoBenhAn(txtMaHSBA.Text, txtMaBN.Text, dtpNgTao.Value));
            //                BUS_HoSoBenhAn.Instance.XemDSHoSoBA(dgvDSHSBA);
            //            }
            //            else
            //            {
            //                MessageBox.Show("Không thể sửa mã thuốc !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                txtMaHSBA.Text = dgvDSHSBA.CurrentRow.Cells[0].Value.ToString();
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi trang này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDKyPhieuKhamBenh_Click(object sender, EventArgs e)
        {
            _menu frmMain = (_menu)this.ParentForm;
            frmMain.openChildForm(new PhieuKhamBenh());
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtpNgTao.Value = DateTime.Now;
        }

        /// <summary>
        /// Bắt lỗi.
        /// <param name="sender"></param>
        /// <param name="e"></param>

    }
}
