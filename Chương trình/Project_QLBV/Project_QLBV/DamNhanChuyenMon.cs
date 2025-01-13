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
    public partial class DamNhanChuyenMon : Form
    {
        public DamNhanChuyenMon()
        {
            InitializeComponent();
        }

        private void DamNhanChuyenMon_Load(object sender, EventArgs e)
        {
            BUS_DamNhanChuyenMon.Instance.XemDSDamNhan(dgvDSDNCM);

            cboNV.Items.Clear();
            cboCN.Items.Clear();
            BUS_DamNhanChuyenMon.Instance.DoDLNhanVien(cboNV);
            BUS_DamNhanChuyenMon.Instance.DoDLLenCBChuyenNganh(cboCN, cboNV.SelectedValue.ToString());
            BUS_DamNhanChuyenMon.Instance.TinhKinhNghiem(dtpNgayLam.Value, cboNV.SelectedValue.ToString(), cboCN.SelectedValue.ToString());
            //txtNV.Text = BUS_HoSoBenhAn.Instance.LayTenBNNhoMaBN(cboNV.SelectedValue.ToString());
            dgvDSDNCM.Columns[3].Visible = false;
            dgvDSDNCM.Columns[4].Visible = false;
        }

        private void dgvDSDNCM_Click(object sender, EventArgs e)
        {
            int dong = dgvDSDNCM.CurrentCell.RowIndex;
            cboNV.SelectedValue = dgvDSDNCM.Rows[dong].Cells[1].Value?.ToString() ?? "";
            cboCN.SelectedValue = dgvDSDNCM.Rows[dong].Cells[0].Value?.ToString() ?? "";
            if (dgvDSDNCM.Rows[dong].Cells[2].Value != null)
            {
                txtEXP.Text = dgvDSDNCM.Rows[dong].Cells[2].Value.ToString();
            }
            else
            {
                txtEXP.Text = String.Empty;
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
            DialogResult ret = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                BUS_DamNhanChuyenMon.Instance.ThemDamNhan(new ET_DamNhanChuyenMon(cboCN.SelectedValue.ToString(), cboNV.SelectedValue.ToString(), null));
                BUS_DamNhanChuyenMon.Instance.TinhKinhNghiem(dtpNgayLam.Value, cboNV.SelectedValue.ToString(), cboCN.SelectedValue.ToString());
                BUS_DamNhanChuyenMon.Instance.XemDSDamNhan(dgvDSDNCM);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDSDNCM.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Xác nhận xóa dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_DamNhanChuyenMon.Instance.XoaDamNhanChuyenMon(dgvDSDNCM);
                    BUS_DamNhanChuyenMon.Instance.TinhKinhNghiem(dtpNgayLam.Value, cboNV.SelectedValue.ToString(), cboCN.SelectedValue.ToString());
                    BUS_DamNhanChuyenMon.Instance.XemDSDamNhan(dgvDSDNCM);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvDSDNCM.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Xác nhận sửa dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    BUS_DamNhanChuyenMon.Instance.SuaDamNhanChuyenMon(new ET_DamNhanChuyenMon(cboCN.SelectedValue.ToString(), cboNV.SelectedValue.ToString(), null));
                    BUS_DamNhanChuyenMon.Instance.TinhKinhNghiem(dtpNgayLam.Value, cboNV.SelectedValue.ToString(), cboCN.SelectedValue.ToString());
                    BUS_DamNhanChuyenMon.Instance.XemDSDamNhan(dgvDSDNCM);
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

        private void cboNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboNV.SelectedValue != null)
            {
                BUS_DamNhanChuyenMon.Instance.DoDLLenCBChuyenNganh(cboCN, cboNV.SelectedValue.ToString());
            }
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
