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
    public partial class DSBNNoiTru : Form
    {
        public DSBNNoiTru()
        {
            InitializeComponent();
        }

        private void DSBNNoiTru_Load(object sender, EventArgs e)
        {
            this.rptDSBNTheoNgay.RefreshReport();

            this.rptDSBNTheoNgay.RefreshReport();
            this.rptDSBNTheoThang.RefreshReport();
            this.rptDSBNTheoNam.RefreshReport();
            this.rptDSBNTheoKhoangTG.RefreshReport();
            this.rptDSBNTheoKhoangTG.RefreshReport();
            this.rptDSBNTheoNgay.RefreshReport();
            this.rptDSBNTheoThang.RefreshReport();
            this.rptDSBNTheoNam.RefreshReport();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked)
            {
                BUS__TimKiemBenhNhanNoiTru.Instance.LayDSBenhNhanTheoNgay(dtpNgay.Value, dgvDSBN);
            }
            if (radThang.Checked)
            {
                BUS__TimKiemBenhNhanNoiTru.Instance.LayDSBenhNhanTheoThang(dtpNgay.Value, dgvDSBN);
            }
            if (radNam.Checked)
            {
                BUS__TimKiemBenhNhanNoiTru.Instance.LayDSBenhNhanTheoNam(dtpNgay.Value, dgvDSBN);
            }
            if (radKhoangTG.Checked)
            {
                BUS__TimKiemBenhNhanNoiTru.Instance.LayDSBenhNhanTheoKhoangTG(dtpNgay.Value, dtpDenNgay.Value, dgvDSBN);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked)
            {
                var data3 = BUS__XuatDSBenhNhanNoiTru.Instance.XuatDSBNTheoNgay(dtpNgay.Value);
                try
                {
                    // Clear previous data sources
                    rptDSBNTheoNgay.LocalReport.DataSources.Clear();

                    // Setup new data sources

                    ReportDataSource rds3 = new ReportDataSource("DataSet1", data3);

                    ReportParameter[] reportParameters = new ReportParameter[1];
                    reportParameters[0] = new ReportParameter("NgayHienTai", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                    rptDSBNTheoNgay.LocalReport.SetParameters(reportParameters);
                    rptDSBNTheoNgay.LocalReport.DataSources.Add(rds3);



                    rptDSBNTheoNgay.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
            if (radThang.Checked)
            {
                var data3 = BUS__XuatDSBenhNhanNoiTru.Instance.XuatDSBNTheoThang(dtpNgay.Value.Month, dtpNgay.Value.Year);
                try
                {
                    // Clear previous data sources
                    rptDSBNTheoThang.LocalReport.DataSources.Clear();

                    // Setup new data sources

                    ReportDataSource rds3 = new ReportDataSource("DataSet1", data3);

                    ReportParameter[] reportParameters = new ReportParameter[1];
                    reportParameters[0] = new ReportParameter("NgayHienTai", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                    rptDSBNTheoThang.LocalReport.SetParameters(reportParameters);
                    rptDSBNTheoThang.LocalReport.DataSources.Add(rds3);
                    rptDSBNTheoThang.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
            if (radNam.Checked)
            {
                var data3 = BUS__XuatDSBenhNhanNoiTru.Instance.XuatDSBNTheoNam(dtpNgay.Value.Year);
                try
                {
                    // Clear previous data sources
                    rptDSBNTheoNam.LocalReport.DataSources.Clear();

                    // Setup new data sources

                    ReportDataSource rds3 = new ReportDataSource("DataSet1", data3);

                    ReportParameter[] reportParameters = new ReportParameter[1];
                    reportParameters[0] = new ReportParameter("NgayHienTai", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                    rptDSBNTheoNam.LocalReport.SetParameters(reportParameters);
                    rptDSBNTheoNam.LocalReport.DataSources.Add(rds3);
                    rptDSBNTheoNam.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
            if (radKhoangTG.Checked)
            {
                var data3 = BUS__XuatDSBenhNhanNoiTru.Instance.XuatDSBNTheoKhoangThoiGian(dtpNgay.Value, dtpDenNgay.Value);
                try
                {
                    // Clear previous data sources
                    rptDSBNTheoKhoangTG.LocalReport.DataSources.Clear();

                    // Setup new data sources

                    ReportDataSource rds3 = new ReportDataSource("DataSet1", data3);

                    ReportParameter[] reportParameters = new ReportParameter[1];
                    reportParameters[0] = new ReportParameter("NgayHienTai", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                    rptDSBNTheoKhoangTG.LocalReport.SetParameters(reportParameters);
                    rptDSBNTheoKhoangTG.LocalReport.DataSources.Add(rds3);
                    rptDSBNTheoKhoangTG.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
        }
    }
}
