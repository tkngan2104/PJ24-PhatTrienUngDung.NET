using BUS;
using Microsoft.Reporting.WinForms;
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
    public partial class ThongKeDSBenhNhan : Form
    {
        public ThongKeDSBenhNhan()
        {
            InitializeComponent();
        }

        private void ThongKeDSBenhNhan_Load(object sender, EventArgs e)
        {
            cboPhong.Items.Clear();
            cboPhong.Visible = false;
            BUS__ThongKeMatDoKhamCuaBN.Instance.DoDuLieuCBPhongKham(cboPhong);
            dgvDSBenhNhanDiKham.Visible = true;
            this.rptDSTheoNgay.RefreshReport();

            this.rptDSTheoThang.RefreshReport();
            this.rptDSKhamTheoNam.RefreshReport();
            this.rptDSTheoNgay.RefreshReport();
            this.rptDSTheoThang.RefreshReport();
            this.rptDSKhamTheoNam.RefreshReport();
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgay.Value > DateTime.Now)
            {
                MessageBox.Show("Không được chỉnh lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgay.Value = DateTime.Now;
            }
        }

        private void dtpNgay_Validating(object sender, CancelEventArgs e)
        {
            if (dtpNgay.Value > DateTime.Now)
            {
                MessageBox.Show("Không được chỉnh lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgay.Value = DateTime.Now;
            }
        }

        private void dgvDSBenhNhanDiKham_Click(object sender, EventArgs e)
        {
            int dong = dgvDSBenhNhanDiKham.CurrentCell.RowIndex;
            cboPhong.SelectedValue = dgvDSBenhNhanDiKham.Rows[dong].Cells[0].Value.ToString();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            cboPhong.Visible = false;
            if (radNgay.Checked)
            {
                BUS__ThongKeMatDoKhamCuaBN.Instance.ThongKeDSTheoNgay(dtpNgay.Value, dgvDSBenhNhanDiKham);
            }
            if (radThang.Checked)
            {
                BUS__ThongKeMatDoKhamCuaBN.Instance.ThongKeDSTheoThang(dtpNgay.Value, dgvDSBenhNhanDiKham);
            }
            if (radNam.Checked)
            {
                BUS__ThongKeMatDoKhamCuaBN.Instance.ThongKeDSTheoNam(dtpNgay.Value, dgvDSBenhNhanDiKham);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            cboPhong.Visible = true;
            if (radNgay.Checked)
            {
                // Fetching data
                var data1 = BUS__XuatDSKhamTheoTime.Instance.LayDSLichSuKham(dtpNgay.Value);
                try
                {
                    // Clear previous data sources
                    rptDSTheoNgay.LocalReport.DataSources.Clear();

                    // Setup new data sources
                    ReportDataSource rds1 = new ReportDataSource("DataSet1", data1);

                    rptDSTheoNgay.LocalReport.DataSources.Add(rds1);

                    // Refresh and show the report
                    rptDSTheoNgay.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
            if (radThang.Checked)
            {
                int thang = dtpNgay.Value.Month;
                int nam = dtpNgay.Value.Year;
                var data1 = BUS__XuatDSKhamTheoTime.Instance.LayDSKhamTheoThang(thang, nam);
                try
                {
                    // Clear previous data sources
                    rptDSTheoThang.LocalReport.DataSources.Clear();

                    // Setup new data sources
                    ReportDataSource rds1 = new ReportDataSource("DataSet1", data1);

                    rptDSTheoThang.LocalReport.DataSources.Add(rds1);

                    // Refresh and show the report
                    rptDSTheoThang.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
            if (radNam.Checked)
            {
                int nam = dtpNgay.Value.Year;
                var data1 = BUS__XuatDSKhamTheoTime.Instance.LayDSKhamTheoNam(nam);
                try
                {
                    // Clear previous data sources
                    rptDSKhamTheoNam.LocalReport.DataSources.Clear();

                    // Setup new data sources
                    ReportDataSource rds1 = new ReportDataSource("DataSet1", data1);

                    rptDSKhamTheoNam.LocalReport.DataSources.Add(rds1);

                    // Refresh and show the report
                    rptDSKhamTheoNam.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
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
    }
}
