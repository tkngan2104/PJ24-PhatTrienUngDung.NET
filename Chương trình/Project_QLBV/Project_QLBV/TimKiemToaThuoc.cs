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
    public partial class TimKiemToaThuoc : Form
    {
        public TimKiemToaThuoc()
        {
            InitializeComponent();
        }

        private void TimKiemToaThuoc_Load(object sender, EventArgs e)
        {
            this.rptTimKiemToaThuoc.RefreshReport();
            this.rptTimKiemToaThuoc.RefreshReport();
            this.rptTimKiemToaThuoc.RefreshReport();
            this.rptDSToaThuocNhoMaTT.RefreshReport();
            this.rptDSToaThuocNhoMaTT.RefreshReport();
            this.rptTimKiemToaThuoc.RefreshReport();
            

        }


        private void dgvDSBN_SelectionChanged(object sender, EventArgs e)
        {
            if (radTenBN.Checked)
            {
                // Check if CurrentRow is not null and if there are selected rows
                if (dgvDSBN.CurrentRow != null && dgvDSBN.SelectedRows.Count > 0)
                {
                    // Ensure that the cell you are trying to access exists
                    if (dgvDSBN.CurrentRow.Cells.Count > 0)
                    {
                        var cellValue = dgvDSBN.CurrentRow.Cells[0].Value?.ToString();
                        if (!string.IsNullOrEmpty(cellValue))
                        {
                            BUS__TimKiemHoaDon.Instance.LayDSPKB(cellValue, dgvDSPK);
                            dgvDSPK.Columns[6].Visible = false;
                            dgvDSPK.Columns[7].Visible = false;
                            dgvDSTimKiemToaThuoc.Columns[10].Visible = false;
                            dgvDSTimKiemToaThuoc.Columns[11].Visible = false;
                            dgvDSTimKiemToaThuoc.Columns[12].Visible = false;
                            dgvDSTimKiemToaThuoc.Columns[13].Visible = false;
                        }
                    }
                }
            }
        }

        private void dgvDSPK_SelectionChanged(object sender, EventArgs e)
        {
            if (radTenBN.Checked)
            {
                if (dgvDSPK.CurrentRow != null && dgvDSPK.SelectedRows.Count > 0)
                {

                    if (dgvDSPK.CurrentRow.Cells.Count > 0)
                    {
                        var maPKB = dgvDSPK.CurrentRow.Cells[0].Value?.ToString();
                        if (!string.IsNullOrEmpty(maPKB))
                        {
                            BUS__TimKhiemToaThuoc.Instance.XemDSToaThuocNhoMaPKB(maPKB, dgvDSTimKiemToaThuoc);
                        }
                    }
                }
            }
        }

        private void btnTimTT_Click(object sender, EventArgs e)
        {
            if (radPKB.Checked)
            {
                BUS__TimKhiemToaThuoc.Instance.XemDSToaThuocNhoMaPKB(txtTimKiem.Text, dgvDSTimKiemToaThuoc);
            }
            if (radMaToaThuoc.Checked)
            {
                BUS__TimKhiemToaThuoc.Instance.XemDSToaThuocNhoMaToaThuoc(txtTimKiem.Text, dgvDSTimKiemToaThuoc);
                dgvDSTimKiemToaThuoc.Columns[10].Visible = false;
                dgvDSTimKiemToaThuoc.Columns[11].Visible = false;
                dgvDSTimKiemToaThuoc.Columns[12].Visible = false;
                dgvDSTimKiemToaThuoc.Columns[13].Visible = false;
            }
            if (radTenBN.Checked)
            {
                BUS__TimKiemHoaDon.Instance.LayDSBenhNhan(txtTimKiem.Text, dgvDSBN);
            }
        }

        private void btnInTT_Click(object sender, EventArgs e)
        {
            if (radPKB.Checked)
            {
                string maPKB = txtTimKiem.Text;

                // Fetching data
                var data3 = BUS__XuatHoaDon.Instance.LayToaThuoc(maPKB);
                var data5 = BUS__XuatHoaDon.Instance.LayTTBN(maPKB);

                try
                {
                    // Clear previous data sources
                    rptTimKiemToaThuoc.LocalReport.DataSources.Clear();

                    // Setup new data sources

                    ReportDataSource rds3 = new ReportDataSource("DataSet1", data3);
                    ReportDataSource rds5 = new ReportDataSource("DataSet2", data5);
                    ReportParameter[] reportParameters = new ReportParameter[1];
                    reportParameters[0] = new ReportParameter("NgayHienTai", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                    rptTimKiemToaThuoc.LocalReport.SetParameters(reportParameters);
                    rptTimKiemToaThuoc.LocalReport.DataSources.Add(rds3);
                    rptTimKiemToaThuoc.LocalReport.DataSources.Add(rds5);


                    rptTimKiemToaThuoc.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
            if (radMaToaThuoc.Checked)
            {
                string maTT = txtTimKiem.Text;
                var maPKB = dgvDSTimKiemToaThuoc.CurrentRow.Cells[2].Value?.ToString();


                // Fetching data
                var data3 = BUS__XuatHoaDon.Instance.LayToaThuocNhoMaTT(maTT);
                var data5 = BUS__XuatHoaDon.Instance.LayTTBN(maPKB);

                try
                {
                    // Clear previous data sources
                    rptDSToaThuocNhoMaTT.LocalReport.DataSources.Clear();

                    // Setup new data sources

                    ReportDataSource rds3 = new ReportDataSource("DataSet1", data3);
                    ReportDataSource rds5 = new ReportDataSource("DataSet2", data5);
                    ReportParameter[] reportParameters = new ReportParameter[1];
                    reportParameters[0] = new ReportParameter("NgayHienTai", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                    rptDSToaThuocNhoMaTT.LocalReport.SetParameters(reportParameters);
                    rptDSToaThuocNhoMaTT.LocalReport.DataSources.Add(rds3);
                    rptDSToaThuocNhoMaTT.LocalReport.DataSources.Add(rds5);


                    rptDSToaThuocNhoMaTT.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
            if (radTenBN.Checked)
            {
                string maPKB = dgvDSPK.CurrentRow.Cells[0].Value.ToString();

                // Fetching data
                var data3 = BUS__XuatHoaDon.Instance.LayToaThuoc(maPKB);
                var data5 = BUS__XuatHoaDon.Instance.LayTTBN(maPKB);

                try
                {
                    // Clear previous data sources
                    rptTimKiemToaThuoc.LocalReport.DataSources.Clear();

                    // Setup new data sources

                    ReportDataSource rds3 = new ReportDataSource("DataSet1", data3);
                    ReportDataSource rds5 = new ReportDataSource("DataSet2", data5);
                    ReportParameter[] reportParameters = new ReportParameter[1];
                    reportParameters[0] = new ReportParameter("NgayHienTai", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                    rptTimKiemToaThuoc.LocalReport.SetParameters(reportParameters);
                    rptTimKiemToaThuoc.LocalReport.DataSources.Add(rds3);
                    rptTimKiemToaThuoc.LocalReport.DataSources.Add(rds5);


                    rptTimKiemToaThuoc.RefreshReport();
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
