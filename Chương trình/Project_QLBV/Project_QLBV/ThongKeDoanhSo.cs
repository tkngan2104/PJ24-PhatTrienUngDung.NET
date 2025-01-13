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
    public partial class ThongKeDoanhSo : Form
    {
        public ThongKeDoanhSo()
        {
            InitializeComponent();
        }

        private void ThongKeDoanhSo_Load(object sender, EventArgs e)
        {
            this.rptThongKeTheoNgay.RefreshReport();
            this.rptDoanhThuTheoThang.RefreshReport();
            this.rptDoanhThuTheoNam.RefreshReport();
            this.rptThongKeTheoNgay.RefreshReport();
            this.rptThongKeTheoNgay.RefreshReport();
            this.rptDoanhThuTheoThang.RefreshReport();
            this.rptDoanhThuTheoNam.RefreshReport();
        }

        private void dgvDSDoanhThu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDSDoanhThu.Columns["TongTienThuoc"].DefaultCellStyle.Format = "#,##";
            dgvDSDoanhThu.Columns["TongTienPT_XNCC"].DefaultCellStyle.Format = "#,##";
            dgvDSDoanhThu.Columns["TongTienGB"].DefaultCellStyle.Format = "#,##";
            dgvDSDoanhThu.Columns["TongTienKham"].DefaultCellStyle.Format = "#,##";
            dgvDSDoanhThu.Columns["TienBHYTChiTra"].DefaultCellStyle.Format = "#,##";
            dgvDSDoanhThu.Columns["TongTien"].DefaultCellStyle.Format = "#,##";
            dgvDSDoanhThu.Columns["TongTienSauKhiDaGiam"].DefaultCellStyle.Format = "#,##";
        }

        private void dgvDSDoanhThuCuaPKB_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDSDoanhThuCuaPKB.Columns["TienPT_XNCC"].DefaultCellStyle.Format = "#,##";
            dgvDSDoanhThuCuaPKB.Columns["TienThuoc"].DefaultCellStyle.Format = "#,##";
            dgvDSDoanhThuCuaPKB.Columns["TienGiuong"].DefaultCellStyle.Format = "#,##";
            dgvDSDoanhThuCuaPKB.Columns["TienKham"].DefaultCellStyle.Format = "#,##";
            dgvDSDoanhThuCuaPKB.Columns["TienBHYTChiTra"].DefaultCellStyle.Format = "#,##";
            dgvDSDoanhThuCuaPKB.Columns["TongTienTamThoi"].DefaultCellStyle.Format = "#,##";
            dgvDSDoanhThuCuaPKB.Columns["TongTienSauKhiDaGiam"].DefaultCellStyle.Format = "#,##";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked == true)
            {
                BUS__ThongKeDoanhThu.Instance.LayDSThongKeDoanhThuNhoPKBTheoNgay(dgvDSDoanhThuCuaPKB, dtpNgay.Value);
                BUS__ThongKeDoanhThu.Instance.LayTongDoanhThuTheoNgay(dgvDSDoanhThu, dtpNgay.Value);
            }
            if (radThang.Checked == true)
            {

                BUS__ThongKeDoanhThu.Instance.LayDSThongKeDoanhThuNhoPKBTheoThang(dgvDSDoanhThuCuaPKB, dtpNgay.Value);
                BUS__ThongKeDoanhThu.Instance.LayTongDoanhThuTheoThang(dgvDSDoanhThu, dtpNgay.Value);
            }
            if (radNam.Checked == true)
            {
                BUS__ThongKeDoanhThu.Instance.LayDSThongKeDoanhThuNhoPKBTheoNam(dgvDSDoanhThuCuaPKB, dtpNgay.Value);
                BUS__ThongKeDoanhThu.Instance.LayTongDoanhThuTheoNam(dgvDSDoanhThu, dtpNgay.Value);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked == true)
            {

                var data1 = BUS_TongDoanhThu.Instance.XuatTienCuaTatCaCacPKBTheoNgay(dtpNgay.Value);
                var data2 = BUS_TongDoanhThu.Instance.ThongKeDoanhThuTheoNgay(dtpNgay.Value);
                try
                {
                    // Clear previous data sources
                    rptThongKeTheoNgay.LocalReport.DataSources.Clear();

                    // Setup new data sources
                    ReportDataSource rds1 = new ReportDataSource("DataSet2", data1);
                    ReportDataSource rds2 = new ReportDataSource("DataSet1", data2);
                    ReportParameter[] reportParameters = new ReportParameter[1];
                    reportParameters[0] = new ReportParameter("NgayHienTai", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                    rptThongKeTheoNgay.LocalReport.SetParameters(reportParameters);
                    rptThongKeTheoNgay.LocalReport.DataSources.Add(rds1);
                    rptThongKeTheoNgay.LocalReport.DataSources.Add(rds2);

                    // Refresh and show the report
                    rptThongKeTheoNgay.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
            if (radThang.Checked)
            {
                var data1 = BUS_TongDoanhThu.Instance.XuatTienCuaTatCaCacPKBTheoThang(dtpNgay.Value.Month, dtpNgay.Value.Year);
                var data2 = BUS_TongDoanhThu.Instance.ThongKeDoanhThuTheoThang(dtpNgay.Value.Month, dtpNgay.Value.Year);
                if (data1 == null || data2 == null)
                {
                    MessageBox.Show("Dữ liệu trả về là null, xin kiểm tra lại các hàm lấy dữ liệu.");
                    return;
                }
                try
                {
                    // Clear previous data sources
                    rptDoanhThuTheoThang.LocalReport.DataSources.Clear();

                    // Setup new data sources
                    ReportDataSource rds1 = new ReportDataSource("DataSet2", data1);
                    ReportDataSource rds2 = new ReportDataSource("DataSet1", data2);


                    rptDoanhThuTheoThang.LocalReport.DataSources.Add(rds1);
                    rptDoanhThuTheoThang.LocalReport.DataSources.Add(rds2);

                    // Refresh and show the report
                    rptDoanhThuTheoThang.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                    MessageBox.Show("An error occurred: " + ex.Message + "\nStack Trace: " + ex.StackTrace);
                }
            }
            if (radNam.Checked)
            {

                var data1 = BUS_TongDoanhThu.Instance.XuatTienCuaTatCaCacPKBTheoThang(dtpNgay.Value.Month, dtpNgay.Value.Year);
                var data2 = BUS_TongDoanhThu.Instance.ThongKeDoanhThuTheoThang(dtpNgay.Value.Month, dtpNgay.Value.Year);
                try
                {
                    // Clear previous data sources
                    rptDoanhThuTheoNam.LocalReport.DataSources.Clear();

                    // Setup new data sources
                    ReportDataSource rds1 = new ReportDataSource("DataSet2", data1);
                    ReportDataSource rds2 = new ReportDataSource("DataSet1", data2);

                    rptDoanhThuTheoNam.LocalReport.DataSources.Add(rds1);
                    rptDoanhThuTheoNam.LocalReport.DataSources.Add(rds2);

                    // Refresh and show the report
                    rptDoanhThuTheoNam.RefreshReport();
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
