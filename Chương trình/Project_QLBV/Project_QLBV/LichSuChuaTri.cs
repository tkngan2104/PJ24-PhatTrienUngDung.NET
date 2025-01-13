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
    public partial class LichSuChuaTri : Form
    {
        public LichSuChuaTri()
        {
            InitializeComponent();
        }

        private void LichSuChuaTri_Load(object sender, EventArgs e)
        {
            this.rptLSKhamPKB.RefreshReport();
            this.rptXuatDSLS.RefreshReport();
            this.rptXuatDSLS.RefreshReport();
            this.rptLSKhamPKB.RefreshReport();
        }

        private void dgvDS1_SelectionChanged(object sender, EventArgs e)
        {
            if (radTenBN.Checked)
            {

                if (dgvDS1.CurrentRow != null && dgvDS1.SelectedRows.Count > 0)
                {

                    if (dgvDS1.CurrentRow.Cells.Count > 0)
                    {
                        var maBN = dgvDS1.CurrentRow.Cells[0].Value?.ToString();
                        if (!string.IsNullOrEmpty(maBN))
                        {
                            BUS__TimKiemLichSuChuaTri.Instance.TimTTNhoTenBN(maBN, dgvDS2);
                            var maBNCuaTT = dgvDS2.CurrentRow.Cells[1].Value?.ToString();
                            BUS__TimKiemLichSuChuaTri.Instance.TimLichKhamNhoTenBN(maBNCuaTT, dgvDS1);
                            BUS__TimKiemLichSuChuaTri.Instance.TimLichSuPT_XNCCTheoTenBN(maBNCuaTT, dgvDS3);
                            BUS__TimKiemLichSuChuaTri.Instance.TimLichNamVienNhoTenBN(maBNCuaTT, dgvDS4);
                            BUS__TimKiemLichSuChuaTri.Instance.XemDSToaThuoc(maBNCuaTT, dgvDS5);
                            dgvDS3.Enabled = false;
                            dgvDS1.Enabled = false;
                            dgvDS4.Enabled = false;
                            dgvDS5.Enabled = false;
                        }
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string maPKB = txtTimKiem.Text;
            if (radPKB.Checked)
            {

                // Fetching data
                var data1 = BUS__XuatDSLichSuKham.Instance.LayDSLichSuKham(maPKB);
                var data2 = BUS__XuatHoaDon.Instance.LayTTGiuongBenh(maPKB);
                var data3 = BUS__XuatDSLichSuKham.Instance.XuatToaThuocCuaPKB(maPKB);
                var data4 = BUS__XuatHoaDon.Instance.LayTTPT_XNCC(maPKB);
                var data5 = BUS__XuatDSLichSuKham.Instance.LayDSBNChuaTri(maPKB);

                try
                {
                    // Clear previous data sources
                    rptLSKhamPKB.LocalReport.DataSources.Clear();

                    // Setup new data sources
                    ReportDataSource rds1 = new ReportDataSource("DataSet1", data1);
                    ReportDataSource rds2 = new ReportDataSource("DataSet3", data2);
                    ReportDataSource rds3 = new ReportDataSource("DataSet5", data3);
                    ReportDataSource rds4 = new ReportDataSource("DataSet4", data4);
                    ReportDataSource rds5 = new ReportDataSource("DataSet2", data5);
                    ReportParameter[] reportParameters = new ReportParameter[1];
                    reportParameters[0] = new ReportParameter("NgayHienTai", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                    rptLSKhamPKB.LocalReport.SetParameters(reportParameters);
                    rptLSKhamPKB.LocalReport.DataSources.Add(rds1);
                    rptLSKhamPKB.LocalReport.DataSources.Add(rds2);
                    rptLSKhamPKB.LocalReport.DataSources.Add(rds3);
                    rptLSKhamPKB.LocalReport.DataSources.Add(rds4);
                    rptLSKhamPKB.LocalReport.DataSources.Add(rds5);

                    // Refresh and show the report
                    rptLSKhamPKB.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
            else
            {
                if (dgvDS2.SelectedRows.Count > 0)
                {
                    var maBNCuaTT = dgvDS2.CurrentRow.Cells[0].Value?.ToString();
                    var data1 = BUS__XuatDSLichSuKham.Instance.LayDSLichSuKham(maBNCuaTT);
                    var data2 = BUS__XuatHoaDon.Instance.LayTTGiuongBenh(maBNCuaTT);
                    var data3 = BUS__XuatDSLichSuKham.Instance.XuatToaThuocCuaPKB(maBNCuaTT);
                    var data4 = BUS__XuatHoaDon.Instance.LayTTPT_XNCC(maBNCuaTT);
                    var data5 = BUS__XuatDSLichSuKham.Instance.LayDSBNChuaTri(maBNCuaTT);

                    try
                    {
                        // Clear previous data sources
                        rptLSKhamPKB.LocalReport.DataSources.Clear();

                        // Setup new data sources
                        ReportDataSource rds1 = new ReportDataSource("DataSet1", data1);
                        ReportDataSource rds2 = new ReportDataSource("DataSet3", data2);
                        ReportDataSource rds3 = new ReportDataSource("DataSet5", data3);
                        ReportDataSource rds4 = new ReportDataSource("DataSet4", data4);
                        ReportDataSource rds5 = new ReportDataSource("DataSet2", data5);
                        ReportParameter[] reportParameters = new ReportParameter[1];
                        reportParameters[0] = new ReportParameter("NgayHienTai", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        rptLSKhamPKB.LocalReport.SetParameters(reportParameters);
                        rptLSKhamPKB.LocalReport.DataSources.Add(rds1);
                        rptLSKhamPKB.LocalReport.DataSources.Add(rds2);
                        rptLSKhamPKB.LocalReport.DataSources.Add(rds3);
                        rptLSKhamPKB.LocalReport.DataSources.Add(rds4);
                        rptLSKhamPKB.LocalReport.DataSources.Add(rds5);

                        // Refresh and show the report
                        rptLSKhamPKB.RefreshReport();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to load report: " + ex.Message);
                    }
                }
                else
                {
                    var maBNCuaTT = dgvDS2.CurrentRow.Cells[1].Value?.ToString();
                    var data1 = BUS__XuatDSLichSuKham.Instance.LayDSLichSuKhamNhoTenBN(maBNCuaTT);
                    var data2 = BUS__XuatDSLichSuKham.Instance.XuatTienGB(maBNCuaTT);
                    var data3 = BUS__XuatDSLichSuKham.Instance.XuatToaThuoc(maBNCuaTT);
                    var data4 = BUS__XuatDSLichSuKham.Instance.XuatTienPT_XNCC(maBNCuaTT);
                    var data5 = BUS__XuatDSLichSuKham.Instance.LayDSBNChuaTriNhoTenBN(maBNCuaTT);

                    try
                    {
                        // Clear previous data sources
                        rptXuatDSLS.LocalReport.DataSources.Clear();

                        // Setup new data sources
                        ReportDataSource rds1 = new ReportDataSource("DataSet1", data1);
                        ReportDataSource rds2 = new ReportDataSource("DataSet3", data2);
                        ReportDataSource rds3 = new ReportDataSource("DataSet5", data3);
                        ReportDataSource rds4 = new ReportDataSource("DataSet4", data4);
                        ReportDataSource rds5 = new ReportDataSource("DataSet2", data5);
                        ReportParameter[] reportParameters = new ReportParameter[1];
                        reportParameters[0] = new ReportParameter("NgayHienTai", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        rptXuatDSLS.LocalReport.SetParameters(reportParameters);
                        rptXuatDSLS.LocalReport.DataSources.Add(rds1);
                        rptXuatDSLS.LocalReport.DataSources.Add(rds2);
                        rptXuatDSLS.LocalReport.DataSources.Add(rds3);
                        rptXuatDSLS.LocalReport.DataSources.Add(rds4);
                        rptXuatDSLS.LocalReport.DataSources.Add(rds5);
                        //ReportParameter[] reportParameters = new ReportParameter[1];
                        //reportParameters[0] = new ReportParameter("NgayHienTai", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        //rptXuatDSLS.LocalReport.SetParameters(reportParameters);
                        // Refresh and show the report
                        rptXuatDSLS.RefreshReport();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to load report: " + ex.Message);
                    }
                }

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (radPKB.Checked)
            {
                BUS__TimKiemLichSuChuaTri.Instance.TimLichSuPT_XNCCCua1PKB(txtTimKiem.Text, dgvDS3);
                BUS__TimKiemLichSuChuaTri.Instance.TimLichNamVienCua1PKB(txtTimKiem.Text, dgvDS4);
                BUS__TimKiemLichSuChuaTri.Instance.TimLichKhamCua1PKB(txtTimKiem.Text, dgvDS2);
                BUS__TimKiemLichSuChuaTri.Instance.TimTTCua1PKB(txtTimKiem.Text, dgvDS1);
                BUS_ToaThuoc.Instance.XemDSTTThuoc(dgvDS5, txtTimKiem.Text);
            }
            if (radTenBN.Checked)
            {
                BUS__TimKiemHoaDon.Instance.LayDSBenhNhan(txtTimKiem.Text, dgvDS1);
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
