using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Project_QLBV
{
    public partial class _menu : Form
    {
        public _menu()
        {
            InitializeComponent();
            toogglePnlDVTK();
            toogglePnlDLHS();
            toogglePnlVTYT();
            toogglePnlCCYT();
            toogglePnlBCTK();
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {

            try
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel1.Controls.Add(childForm);
                panel1.Tag = childForm;
                // Code để thêm và hiển thị form con
                this.panel1.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                // Ghi lại hoặc hiển thị lỗi
                Console.WriteLine("Error opening child form: " + ex.Message);
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private Boolean showPnl = false;
        public Panel PanelMain
        {
            get { return panel1; }
            set { panel1 = value; }
        }

        private static _menu instance;

        public static _menu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new _menu();
                }
                return instance;
            }
        }
        private void toogglePnlDVTK()
        {
            if (showPnl)
            {
                pnlDichVuThamKham.Height = 120;
            }
            else
            {
                pnlDichVuThamKham.Height = 0;
            }
        }

        private void toogglePnlDLHS()
        {
            if (showPnl)
            {
                pnlDLHS.Height = 550;
            }
            else
            {
                pnlDLHS.Height = 0;
            }
        }

        private void toogglePnlVTYT()
        {
            if (showPnl)
            {
                pnlVTYT.Height = 80;
            }
            else
            {
                pnlVTYT.Height = 0;
            }
        }

        private void toogglePnlCCYT()
        {
            if (showPnl)
            {
                pnlCoCauBenhVien.Height = 160;
            }
            else
            {
                pnlCoCauBenhVien.Height = 0;
            }
        }

        private void toogglePnlBCTK()
        {
            if (showPnl)
            {
                pnlBCTK.Height = 320;
                //6
            }
            else
            {
                pnlBCTK.Height = 0;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDichVuThamKham_Click(object sender, EventArgs e)
        {
            showPnl = !showPnl;
            toogglePnlDVTK();
        }

        private void btnDuLieuHoSo_Click(object sender, EventArgs e)
        {
            showPnl = !showPnl;
            toogglePnlDLHS();
        }

        private void btnVatTuYTe_Click(object sender, EventArgs e)
        {
            showPnl = !showPnl;
            toogglePnlVTYT();
        }

        private void btnCoCauBenhVien_Click(object sender, EventArgs e)
        {
            showPnl = !showPnl;
            toogglePnlCCYT();
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            showPnl = !showPnl;
            toogglePnlBCTK();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát chương trình !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// DỊCH VỤ THĂM KHÁM.
        /// </summary>

        private PhieuKhamBenh pkb;

        private void btnPhieuKhamBenh_Click(object sender, EventArgs e)
        {
            if (pkb == null || pkb.IsDisposed)
            {
                openChildForm(new PhieuKhamBenh(this));
            }
            else
            {
                pkb.BringToFront();
            }
        }

        private XNghiem_PThuat xnpt;

        private void btnXNPT_Click(object sender, EventArgs e)
        {
            if (xnpt == null || xnpt.IsDisposed)
            {
                openChildForm(new XNghiem_PThuat());
            }
            else
            {
                xnpt.BringToFront();
            }
        }
        private DangKyKham dkkham;

        private void btnDKKham_Click(object sender, EventArgs e)
        {
            if (dkkham == null || dkkham.IsDisposed)
            {
                openChildForm(new DangKyKham(this));
            }
            else
            {
                dkkham.BringToFront();
            }
        }

        /// <summary>
        /// DỮ LIỆU HỒ SƠ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private TTBenhNhan ttbn;

        private void btnTTBenhNhan_Click(object sender, EventArgs e)
        {
            if (ttbn == null || ttbn.IsDisposed)
            {
                openChildForm(new TTBenhNhan(this));
            }
            else
            {
                ttbn.BringToFront();
            }
        }

        private HoSoBenhAn hsba;

        private void btnHSBenhAn_Click(object sender, EventArgs e)
        {
            if (hsba == null || hsba.IsDisposed)
            {
                hsba = new HoSoBenhAn(this);  // Khởi tạo và gán cho hsba

                openChildForm(hsba);
            }
            else
            {
                hsba.BringToFront();
            }
        }

        private BaoHiemYTe bhyt;

        private void btnBaoHiemYTe_Click(object sender, EventArgs e)
        {
            if (bhyt == null || bhyt.IsDisposed)
            {
                openChildForm(new BaoHiemYTe());
            }
            else
            {
                bhyt.BringToFront();
            }
        }

        private ChuanDoan chuandoan;

        private void btnChuanDoan_Click(object sender, EventArgs e)
        {
            if (chuandoan == null || chuandoan.IsDisposed)
            {
                openChildForm(new ChuanDoan(this));
            }
            else
            {
                chuandoan.BringToFront();
            }
        }

        private ToaThuoc tthuoc;

        private void btnToaThuoc_Click(object sender, EventArgs e)
        {
            if (tthuoc == null || tthuoc.IsDisposed)
            {
                openChildForm(new ToaThuoc(this));
            }
            else
            {
                tthuoc.BringToFront();
            }
        }

        private PhanGiuong pgiuong;

        private void btnPhanGiuong_Click(object sender, EventArgs e)
        {
            if (pgiuong == null || pgiuong.IsDisposed)
            {
                openChildForm(new PhanGiuong());
            }
            else
            {
                pgiuong.BringToFront();
            }
        }

        private TheoDoiSucKhoe TheoDoiSucKhoe;

        private void btnTheoDoiSucKhoe_Click(object sender, EventArgs e)
        {
            if (TheoDoiSucKhoe == null || TheoDoiSucKhoe.IsDisposed)
            {
                openChildForm(new TheoDoiSucKhoe());
            }
            else
            {
                TheoDoiSucKhoe.BringToFront();
            }
        }

        private HoaDon hd;

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (hd == null || hd.IsDisposed)
            {
                openChildForm(new HoaDon());
            }
            else
            {
                hd.BringToFront();
            }
        }

        private TTNhanVien nvien;

        private void btnTTNhanVien_Click(object sender, EventArgs e)
        {
            if(nvien == null || nvien.IsDisposed)
            {
                openChildForm(new TTNhanVien());
            }
            else
            {
                nvien.BringToFront();
            }
        }

        private DamNhanChuyenMon dncm;

        private void btnDNChuyenMon_Click(object sender, EventArgs e)
        {
            if (dncm == null || dncm.IsDisposed)
            {
                openChildForm(new DamNhanChuyenMon());
            }
            else
            {
                dncm.BringToFront();
            }
        }

        private BangGia bg;

        private void btnBangGia_Click(object sender, EventArgs e)
        {
            if (bg == null || bg.IsDisposed)
            {
                openChildForm(new BangGia());
            }
            else
            {
                bg.BringToFront();
            }
        }

        private BenhLy bly;

        private void btnBenhLy_Click(object sender, EventArgs e)
        {
            if (bly == null || bly.IsDisposed)
            {
                openChildForm(new BenhLy());
            }
            else
            {
                bly.BringToFront();
            }
        }

        private LoaiBenhAn lba;

        private void btnLoaiBA_Click(object sender, EventArgs e)
        {
            if (lba == null || lba.IsDisposed)
            {
                openChildForm(new LoaiBenhAn());
            }
            else
            {
                lba.BringToFront();
            }
        }

        private LoaiKham lkham;

        private void btnLoaiKham_Click(object sender, EventArgs e)
        {
            if (lkham == null || lkham.IsDisposed)
            {
                openChildForm(new LoaiKham());
            }
            else
            {
                lkham.BringToFront();
            }
        }

        private LoaiPTXNCC lxnpt;

        private void btnLXNPT_Click(object sender, EventArgs e)
        {
            if (lxnpt == null || lxnpt.IsDisposed)
            {
                openChildForm(new LoaiPTXNCC());
            }
            else
            {
                lxnpt.BringToFront();
            }
        }

        /// <summary>
        /// Báo Cáo Thống Kê.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private InHoaDon ihd;

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (ihd == null || ihd.IsDisposed)
            {
                openChildForm(new InHoaDon());
            }
            else
            {
                ihd.BringToFront();
            }
        }

        private TimKiemToaThuoc tktt;

        private void btnTimKiemToaThuoc_Click(object sender, EventArgs e)
        {
            if (tktt == null || tktt.IsDisposed)
            {
                openChildForm(new TimKiemToaThuoc());
            }
            else
            {
                tktt.BringToFront();
            }
        }

        private LichSuChuaTri lsct;

        private void btnTKLSCT_Click(object sender, EventArgs e)
        {
            if (lsct == null || lsct.IsDisposed)
            {
                openChildForm(new LichSuChuaTri());
            }
            else
            {
                lsct.BringToFront();
            }
        }

        private ThongKeDoanhSo tkds;

        private void btnThongKeDoanhSo_Click(object sender, EventArgs e)
        {
            if (tkds == null || tkds.IsDisposed)
            {
                openChildForm(new ThongKeDoanhSo());
            }
            else
            {
                tkds.BringToFront();
            }
        }
        private ThongKeDSBenhNhan tkdsbn;
        private void btnTKDSBenhNhan_Click(object sender, EventArgs e)
        {
            if (tkdsbn == null || tkdsbn.IsDisposed)
            {
                openChildForm(new ThongKeDSBenhNhan());
            }
            else
            {
                tkdsbn.BringToFront();
            }
        }

        private DSBNNoiTru dsbnnt;

        private void btnDSBNNT_Click(object sender, EventArgs e)
        {
            if (dsbnnt == null || dsbnnt.IsDisposed)
            {
                openChildForm(new DSBNNoiTru());
            }
            else
            {
                dsbnnt.BringToFront();
            }
        }

        private BaoCaoBenh bcb;

        private void btnBaoCaoThongKeBenh_Click(object sender, EventArgs e)
        {
            if (bcb == null || bcb.IsDisposed)
            {
                openChildForm(new BaoCaoBenh());
            }
            else
            {
                bcb.BringToFront();
            }
        }
        /// <summary>
        /// VẬT TƯ Y TẾ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private Thuoc thuoc;
        private void btnThuoc_Click(object sender, EventArgs e)
        {
            if (thuoc == null || thuoc.IsDisposed)
            {
                openChildForm(new Thuoc());
            }
            else
            {
                thuoc.BringToFront();
            }
        }
        private GiuongBenh gb;
        private void btnGiuongBenh_Click(object sender, EventArgs e)
        {
            if (gb == null || gb.IsDisposed)
            {
                openChildForm(new GiuongBenh());
            }
            else
            {
                gb.BringToFront();
            }
        }

        /// <summary>
        /// CƠ CẤU BỆNH VIỆN.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private PhongKham pk;

        private void btnPhongKham_Click(object sender, EventArgs e)
        {
            if (pk == null || pk.IsDisposed)
            {
                openChildForm(new PhongKham());
            }
            else
            {
                pk.BringToFront();
            }
        }
        private ChuyenNganh cn;

        private void btnChuyenNganh_Click(object sender, EventArgs e)
        {
            if (cn == null || cn.IsDisposed)
            {
                openChildForm(new ChuyenNganh());
            }
            else
            {
                cn.BringToFront();
            }
        }

        private Khoa khoa;

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (khoa == null || khoa.IsDisposed)
            {
                openChildForm(new Khoa());
            }
            else
            {
                khoa.BringToFront();
            }
        }

        private ChucVu cv;

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            if (cv == null || cv.IsDisposed)
            {
                openChildForm(new ChucVu());
            }
            else
            {
                cv.BringToFront();
            }
        }
    }
}
