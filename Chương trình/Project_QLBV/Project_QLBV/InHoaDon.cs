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
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            dgvDSBenhNhan.ScrollBars = ScrollBars.Both;
            dgvHienThiPKB.ScrollBars = ScrollBars.Both;

           
            this.rptInHD.RefreshReport();
        }

        private void dgvDSBenhNhan_SelectionChanged(object sender, EventArgs e)
        {
            if (radTenBN.Checked)
            {
                // Check if CurrentRow is not null and if there are selected rows
                if (dgvDSBenhNhan.CurrentRow != null && dgvDSBenhNhan.SelectedRows.Count > 0)
                {
                    // Ensure that the cell you are trying to access exists
                    if (dgvDSBenhNhan.CurrentRow.Cells.Count > 0)
                    {
                        var cellValue = dgvDSBenhNhan.CurrentRow.Cells[0].Value?.ToString();
                        if (!string.IsNullOrEmpty(cellValue))
                        {
                            BUS__TimKiemHoaDon.Instance.LayDSPKB(cellValue, dgvHienThiPKB);
                            dgvHienThiPKB.Columns[6].Visible = false;
                            dgvHienThiPKB.Columns[7].Visible = false;
                        }
                    }
                }
            }
        }

        private void dgvHienThiPKB_SelectionChanged(object sender, EventArgs e)
        {
            if (radTenBN.Checked)
            {

                if (dgvHienThiPKB.CurrentRow != null && dgvHienThiPKB.SelectedRows.Count > 0)
                {

                    if (dgvHienThiPKB.CurrentRow.Cells.Count > 0)
                    {
                        var maPKB = dgvHienThiPKB.CurrentRow.Cells[0].Value?.ToString();
                        if (!string.IsNullOrEmpty(maPKB))
                        {
                            BUS__TimKiemHoaDon.Instance.TimKiemHoaDonNhoMaPKB(maPKB, dgvHoaDon);
                            dgvHoaDon.Columns[10].Visible = false;
                        }
                    }
                }
            }
        }

        private void btnTimHD_Click(object sender, EventArgs e)
        {
            dgvDSBenhNhan.DataSource = null;
            dgvHienThiPKB.DataSource = null;
            dgvHoaDon.DataSource = null;
            if (radPKB.Checked)
            {
                BUS__TimKiemHoaDon.Instance.TimKiemHoaDonNhoMaPKB(txtTimKiem.Text, dgvHoaDon);
            }
            else
            {
                BUS__TimKiemHoaDon.Instance.LayDSBenhNhan(txtTimKiem.Text, dgvDSBenhNhan);
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (radPKB.Checked)
            {
                string maPKB = txtTimKiem.Text;

                // Fetching data
                var data1 = BUS__XuatHoaDon.Instance.LayTTHoaDon(maPKB);
                var data2 = BUS__XuatHoaDon.Instance.LayTTGiuongBenh(maPKB);
                var data3 = BUS__XuatHoaDon.Instance.LayToaThuoc(maPKB);
                var data4 = BUS__XuatHoaDon.Instance.LayTTPT_XNCC(maPKB);
                var data5 = BUS__XuatHoaDon.Instance.LayTTBN(maPKB);

                try
                {
                    // Clear previous data sources
                    rptInHD.LocalReport.DataSources.Clear();

                    // Setup new data sources
                    ReportDataSource rds1 = new ReportDataSource("DataSet2", data1);
                    ReportDataSource rds2 = new ReportDataSource("DataSet1", data2);
                    ReportDataSource rds3 = new ReportDataSource("DataSet5", data3);
                    ReportDataSource rds4 = new ReportDataSource("DataSet3", data4);
                    ReportDataSource rds5 = new ReportDataSource("DataSet4", data5);

                    rptInHD.LocalReport.DataSources.Add(rds1);
                    rptInHD.LocalReport.DataSources.Add(rds2);
                    rptInHD.LocalReport.DataSources.Add(rds3);
                    rptInHD.LocalReport.DataSources.Add(rds4);
                    rptInHD.LocalReport.DataSources.Add(rds5);

                    // Refresh and show the report
                    rptInHD.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
            else
            {
                string maPKB = null;
                if (dgvHienThiPKB.SelectedRows.Count > 0)
                {
                    maPKB = dgvHienThiPKB.CurrentRow.Cells[0].Value.ToString();
                    // Fetching data
                    var data1 = BUS__XuatHoaDon.Instance.LayTTHoaDon(maPKB);
                    var data2 = BUS__XuatHoaDon.Instance.LayTTGiuongBenh(maPKB);
                    var data3 = BUS__XuatHoaDon.Instance.LayToaThuoc(maPKB);
                    var data4 = BUS__XuatHoaDon.Instance.LayTTPT_XNCC(maPKB);
                    var data5 = BUS__XuatHoaDon.Instance.LayTTBN(maPKB);

                    try
                    {
                        // Clear previous data sources
                        rptInHD.LocalReport.DataSources.Clear();

                        // Setup new data sources
                        ReportDataSource rds1 = new ReportDataSource("DataSet2", data1);
                        ReportDataSource rds2 = new ReportDataSource("DataSet1", data2);
                        ReportDataSource rds3 = new ReportDataSource("DataSet5", data3);
                        ReportDataSource rds4 = new ReportDataSource("DataSet3", data4);
                        ReportDataSource rds5 = new ReportDataSource("DataSet4", data5);

                        rptInHD.LocalReport.DataSources.Add(rds1);
                        rptInHD.LocalReport.DataSources.Add(rds2);
                        rptInHD.LocalReport.DataSources.Add(rds3);
                        rptInHD.LocalReport.DataSources.Add(rds4);
                        rptInHD.LocalReport.DataSources.Add(rds5);

                        // Refresh and show the report
                        rptInHD.RefreshReport();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to load report: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng phiếu khám bệnh muốn in");
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
