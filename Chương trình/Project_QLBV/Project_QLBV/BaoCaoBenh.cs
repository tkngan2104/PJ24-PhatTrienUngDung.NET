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
    public partial class BaoCaoBenh : Form
    {
        public BaoCaoBenh()
        {
            InitializeComponent();
        }
        //Cấu hình chức năng tự động hoàn thành cho trường nhập liệu (txtMaBenh)
        private void SetupAutoComplete()
        {
            try
            {
                List<string> danhSachBenhLy = BUS_ChuanDoan.Instance.LayDSTenBenhLy();

                txtMaBenh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMaBenh.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                data.AddRange(danhSachBenhLy.ToArray());

                txtMaBenh.AutoCompleteCustomSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách bệnh lý: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Load form
        private void BaoCaoBenh_Load(object sender, EventArgs e)
        {
            SetupAutoComplete();
            this.rptBaoCaoBenhCuThe.RefreshReport();
            this.rptBaoCaoDSBenh.RefreshReport();
            this.rptBaoCaoBenhCuThe.RefreshReport();
            this.rptBaoCaoDSBenh.RefreshReport();
        }
        //Tìm
        private void btnTim_Click(object sender, EventArgs e)
        {
            DateTime dtp = dtpNgay.Value;
            if (!string.IsNullOrEmpty(txtMaBenh.Text))
            {
                DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện báo cáo bệnh của bệnh "+ txtMaBenh.Text+ " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ret == DialogResult.Yes)
                {
                    string maBenh = BUS_ChuanDoan.Instance.LayMaBenhNhoTenBenh(txtMaBenh.Text);
                    BUS__BaoCaoBenh.Instance.HienThiDSThongKeNhoTen(maBenh, dgvDSTKBenh, dtp);
                }
            }
            else
            {
                DialogResult ret = MessageBox.Show("Bạn có muốn thực hiện báo cáo bệnh của danh sách bệnh ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ret == DialogResult.Yes)
                {
                    BUS__BaoCaoBenh.Instance.HienThiDSThongKe(dgvDSTKBenh, dtp);
                }                
            }
        }
        //In
        private void btnIn_Click(object sender, EventArgs e)
        {
            DateTime dtp = dtpNgay.Value;
            if (!string.IsNullOrEmpty(txtMaBenh.Text))
            {
                var data1 = BUS__LayThongKeBenhCuThe.Instance.XuatTKCuaBenhCuThe(dgvDSTKBenh.CurrentRow.Cells[0].Value.ToString(), dtp.Year);
                var data2 = BUS__LayThongKeBenhCuThe.Instance.LayTinhTrangSKCuaBenhNhan(dgvDSTKBenh.CurrentRow.Cells[0].Value.ToString(), dtp.Year);
                try
                {
                    // Clear previous data sources
                    rptBaoCaoBenhCuThe.LocalReport.DataSources.Clear();

                    // Setup new data sources
                    ReportDataSource rds1 = new ReportDataSource("DataSet1", data1);
                    ReportDataSource rds2 = new ReportDataSource("DataSet2", data2);
                    
                    rptBaoCaoBenhCuThe.LocalReport.DataSources.Add(rds1);
                    rptBaoCaoBenhCuThe.LocalReport.DataSources.Add(rds2);
                    ReportParameter[] reportParameters = new ReportParameter[1];
                    reportParameters[0] = new ReportParameter("NgayHienTai", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                    rptBaoCaoBenhCuThe.LocalReport.SetParameters(reportParameters);
                    // Refresh and show the report
                    rptBaoCaoBenhCuThe.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
            else
            {
                string maBenh = BUS_ChuanDoan.Instance.LayMaBenhNhoTenBenh(txtMaBenh.Text);
                var data1 = BUS__LayThongKeBenhCuThe.Instance.XuatTKCuaDSBenh(dtp.Year);
                var maBenhList = data1.Select(b => b.MaBenh).ToList();
                List<object> allData2 = new List<object>(); // Thay đổi kiểu dữ liệu cho phù hợp với loại dữ liệu trả về của LayTinhTrangSKCuaBenhNhan

                foreach (var mb in maBenhList)
                {
                    var data2 = BUS__LayThongKeBenhCuThe.Instance.LayTinhTrangSKCuaBenhNhan(mb, dtp.Year);
                    allData2.AddRange(data2); // Lưu trữ tất cả các kết quả vào danh sách
                }
                try
                {
                    // Clear previous data sources
                    rptBaoCaoDSBenh.LocalReport.DataSources.Clear();

                    // Setup new data sources
                    ReportDataSource rds1 = new ReportDataSource("DataSet1", data1);
                    ReportDataSource rds2 = new ReportDataSource("DataSet2", allData2);


                    rptBaoCaoDSBenh.LocalReport.DataSources.Add(rds1);
                    rptBaoCaoDSBenh.LocalReport.DataSources.Add(rds2);

                    // Refresh and show the report
                    rptBaoCaoDSBenh.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
        }

        private void dgvDSTKBenh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSTKBenh_Click(object sender, EventArgs e)
        {
            int dong = dgvDSTKBenh.CurrentCell.RowIndex;
            txtMaBenh.Text = dgvDSTKBenh.Rows[dong].Cells[0].Value.ToString();
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
