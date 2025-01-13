using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon
    {
        //Khai báo biến tĩnh
        private static DAL_HoaDon instance;


        public static DAL_HoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_HoaDon();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        // Xem danh sách hóa đơn
        public IQueryable XemDSHoaDon(DateTime dtpNgay)
        {
            IQueryable ds = from dl in db.HoaDons
                            where dl.NgayXuatHD.Date == dtpNgay.Date
                            select dl;
            return ds;
        }
        // Thêm hóa đơn
        public bool ThemHoaDon(ET_HoaDon etHD)
        {
            if (db.HoaDons.Any(t => t.MaHD == etHD.MaHD && t.MSPhieuKhamBenh == etHD.MSPhieuKhamBenh))
            {
                return false;
            }
            else
            {
                try
                {
                    HoaDon hd = new HoaDon
                    {
                        MaHD = etHD.MaHD,
                        MSPhieuKhamBenh = etHD.MSPhieuKhamBenh,
                        NgayXuatHD = etHD.NgayXuatHD,
                        TienThuoc = etHD.TienThuoc,
                        TienKham = etHD.TienKham,
                        TienGiuong = etHD.TienGiuong,
                        TienPT_XNCC = etHD.TienPT_XNCC,
                        TongTien = etHD.TongTien,
                        TienBHYTChiTra = etHD.TienBHYTChiTra,
                        TongTienSauKhiDaGiam = etHD.TongTienSauKhiGiam
                    
                    };
                    db.HoaDons.InsertOnSubmit(hd);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
        // Xóa hóa đơn
        public bool XoaHoaDon(string maHD)
        {
            try
            {
                var xoa = from t in db.HoaDons
                          where t.MaHD == maHD
                          select t;
                foreach (var x in xoa)
                {
                    db.HoaDons.DeleteOnSubmit(x);
                    db.SubmitChanges();
                }
                return true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }
        // Sửa hóa đơn
        public void SuaHoaDon(ET_HoaDon etHD)
        {
            //update từ mã thuốc.
            var update = db.HoaDons.Single(t => t.MaHD == etHD.MaHD && t.MSPhieuKhamBenh == etHD.MSPhieuKhamBenh);
            update.NgayXuatHD = etHD.NgayXuatHD;
            db.SubmitChanges();
        }
        // Kiểm tra ngày xuất hóa đơn
        public bool KiemTraNgayXuatHD(DateTime ngayXuatHD, string maPKB)
        {
            return true;
        }
        //Tính tiền thuốc
        public float TinhTienThuoc(string maTT, string maPKB)
        {
            float tienThuoc;
            var toaThuoc = from dl in db.ToaThuocs
                           where dl.MaToaThuoc == maTT && dl.MSPhieuKhamBenh == maPKB
                           select dl;

            var hoaDonTienThuoc = db.HoaDons.FirstOrDefault(hd => hd.MSPhieuKhamBenh == maPKB);

            if (hoaDonTienThuoc != null)
            {
                if (toaThuoc.Any())
                {
                    hoaDonTienThuoc.TienThuoc = 0;
                    foreach (var item in toaThuoc)
                    {
                        hoaDonTienThuoc.TienThuoc += item.Tien;
                    }
                }
            }

            return Convert.ToSingle(hoaDonTienThuoc?.TienThuoc ?? 0);
        }
        //Tính tiền khám
        public float TinhTienKham(string maPKB)
        {

            var phieuKham = (from k in db.PhieuKhamBenhs
                             where k.MSPhieuKhamBenh == maPKB
                             select k).SingleOrDefault();

            var hoaDonTienKham = db.HoaDons.FirstOrDefault(hd => hd.MSPhieuKhamBenh == maPKB);

            if (hoaDonTienKham != null && phieuKham != null)
            {

                hoaDonTienKham.TienKham = phieuKham.LoaiKham.Gia;
            }

            db.SubmitChanges();
            return Convert.ToSingle(hoaDonTienKham?.TienKham ?? 0);
        }
        //Tính tiền giường bệnh
        public float TinhGiuongBenh(string maPKB)
        {
            var dl = from pg in db.PhanGiuongs
                     join dv in db.BangGias
                     on pg.MaLoaiChiTietDV equals dv.MaLoaiChiTietDV
                     where pg.MSPhieuKhamBenh == maPKB
                     select new { pg, dv.Gia };

            var hoaDonTienGB = db.HoaDons.FirstOrDefault(hd => hd.MSPhieuKhamBenh == maPKB);

            if (hoaDonTienGB != null)
            {
                hoaDonTienGB.TienGiuong = 0;
                foreach (var item in dl)
                {
                    if (dl != null)
                    {
                        double giaPhuThu = (float)(item.pg.BangGia.Gia * 0.2);
                        hoaDonTienGB.TienGiuong = item.Gia + giaPhuThu;
                    }
                }
            }
            db.SubmitChanges();
            return Convert.ToSingle(hoaDonTienGB?.TienGiuong ?? 0);
        }
        //Tính tiền phẫu thuật
        public float TinhPhauThuat(string maPKB)
        {
            var pkbLamPT_XNCC = from pt in db.LamPhauThuat_XNCCs
                                join dv in db.BangGias
                                on pt.MaLoaiChiTietDV equals dv.MaLoaiChiTietDV
                                where pt.MSPhieuKhamBenh == maPKB
                                select new { pt, dv.Gia };

            var hoaDonTienGB = db.HoaDons.FirstOrDefault(hd => hd.MSPhieuKhamBenh == maPKB);

            if (hoaDonTienGB != null)
            {
                hoaDonTienGB.TienPT_XNCC = 0;
                foreach (var item in pkbLamPT_XNCC)
                {
                    double giaPhuThu = (double)(item.pt.PhieuKhamBenh.MaLoaiKham == "LK01" ? item.Gia * 0.2 : 0);
                    hoaDonTienGB.TienPT_XNCC += item.Gia + giaPhuThu;
                }
            }

            db.SubmitChanges();
            return Convert.ToSingle(hoaDonTienGB?.TienPT_XNCC ?? 0);
        }
        //Tính tiền tổng cộng
        public float TinhTienTongCong(string maTT, string maPKB)
        {
            var hoaDonTienGB = db.HoaDons.FirstOrDefault(hd => hd.MSPhieuKhamBenh == maPKB);
            if (hoaDonTienGB != null)
            {
                hoaDonTienGB.TongTien = TinhTienThuoc(maTT, maPKB) + TinhTienKham(maPKB) + TinhGiuongBenh(maPKB) + TinhPhauThuat(maPKB);
            }
            db.SubmitChanges();
            return Convert.ToSingle(hoaDonTienGB?.TongTien ?? 0);
        }
        //Đổ dữ liệu phiếu khám bệnh
        public IQueryable DoDLPKB()
        {
            IQueryable truyVan = from dl in db.PhieuKhamBenhs
                                 select dl;
            return truyVan;
        }
        //Lấy mã toa thuốc nhờ phiếu khám bệnh
        public string LayMaTTNhoPKB(string maPKB)
        {
            var truyVan = (from dl in db.ToaThuocs
                           where dl.MSPhieuKhamBenh == maPKB
                           select dl.MaToaThuoc).FirstOrDefault();
            return truyVan;
        }
        // Cập nhập tiền thuốc của PKB
        public void CapNhapTienThuocCuaPKB()
        {
            var dsHD = from ds in db.HoaDons
                       select ds;

            foreach (var hoaDon in dsHD)
            {
                float tienThuocTong = 0;
                foreach (var toaThuoc in hoaDon.PhieuKhamBenh.ToaThuocs)
                {

                    tienThuocTong += Convert.ToSingle(toaThuoc.Tien);
                }
                hoaDon.TienThuoc = tienThuocTong;
            }

            db.SubmitChanges();
        }
        // Cập nhập tiền khám của PKB
        public void CapNhapTienKhamCuaPKB()
        {
            float tien = 0;
            var dsHD = from ds in db.HoaDons
                       select ds;
            foreach (var item in dsHD)
            {
                tien = 0;
                tien = TinhTienKham(item.PhieuKhamBenh.MSPhieuKhamBenh);
                item.TienKham = tien;
            }
            db.SubmitChanges();
        }

        // Cập nhập tiền giường của PKB
        public void CapNhapTienGiuongCuaPKB()
        {
            float tien = 0;
            var dsHD = from ds in db.HoaDons
                       select ds;
            foreach (var item in dsHD)
            {
                tien = TinhGiuongBenh(item.PhieuKhamBenh.MSPhieuKhamBenh);
                item.TienGiuong = tien;
            }
            db.SubmitChanges();
        }
        // Cập nhập tiền phẫu thuật của PKB
        public void CapNhapTienPhauThuatCuaPKB()
        {
            float tien = 0;
            var dsHD = from ds in db.HoaDons
                       select ds;
            foreach (var item in dsHD)
            {
                tien = TinhPhauThuat(item.PhieuKhamBenh.MSPhieuKhamBenh);
                item.TienPT_XNCC = tien;
            }
            db.SubmitChanges();
        }
        // Cập nhập tổng tiền của PKB
        public void CapNhapTongTienCuaPKB()
        {
            float tien = 0;
            var dsHD = from ds in db.HoaDons
                       select ds;
            foreach (var item in dsHD)
            {
                var tt = item.PhieuKhamBenh.ToaThuocs.FirstOrDefault();
                if (tt != null)
                {
                    tien = TinhTienTongCong(tt.MaToaThuoc, item.MSPhieuKhamBenh);
                    item.TongTien = tien;
                }
            }
            db.SubmitChanges();
        }
        // Kiểm tra xem bệnh nhân có BHYT không
        public bool KiemTraBNCoBHYTKhong(string maPKB)
        {
            var truyVan = from dl in db.PhieuKhamBenhs
                          join hs in db.HoSoBenhAns
                          on dl.MaHoSoBA equals hs.MaHoSoBA
                          join bn in db.BenhNhans
                          on hs.MSBN equals bn.MSBN
                          join bh in db.BHYTs
                          on bn.MSBN equals bh.MSBN
                          where dl.MSPhieuKhamBenh == maPKB
                          select dl.MSPhieuKhamBenh;
            return truyVan.Any();
        }
        // Tính tiền BHYT chi trả
        public float TinhTienBHYTChiTra(string maPKB)
        {

            var phieuKham = (from k in db.PhieuKhamBenhs
                             where k.MSPhieuKhamBenh == maPKB
                             select k).SingleOrDefault();

            var hoaDonTienBHYT = db.HoaDons.FirstOrDefault(hd => hd.MSPhieuKhamBenh == maPKB);

            if (hoaDonTienBHYT != null && phieuKham != null)
            {

                if (KiemTraBNCoBHYTKhong(maPKB) == true)
                {
                    hoaDonTienBHYT.TienBHYTChiTra = (hoaDonTienBHYT.TongTien) * 0.2;
                }
            }

            db.SubmitChanges();
            return Convert.ToSingle(hoaDonTienBHYT?.TienBHYTChiTra ?? 0);
        }

        //Cập nhập tiền BHYT chi trả
        public void CapNhapTienBHYTChiTra()
        {
            float tien = 0;
            var dsHD = from ds in db.HoaDons
                       select ds;
            foreach (var item in dsHD)
            {
                tien = TinhTienBHYTChiTra(item.MSPhieuKhamBenh);
                item.TienBHYTChiTra = tien;
            }
            db.SubmitChanges();
        }
        //Tạo mã hóa đơn tự động
        public string GenerateHoaDonCode(string maPK)
        {
            // Lấy ngày hiện tại với định dạng yyyMMdd
            string datePrefix = maPK;

            // Tạo chuỗi query để lấy số lượng hồ sơ với ngày hôm nay
            string query = $"HD-{datePrefix}";

            // Đếm số lượng mã hồ sơ bệnh án trong ngày hôm nay
            int countToday = db.PhieuKhamBenhs.Count(h => h.MSPhieuKhamBenh.StartsWith(query));

            // Tạo mã mới
            string newCode = $"CD{datePrefix}{(countToday + 1)}";

            return newCode;
        }


        //Tính tổng tiền sau khi BHYT chi trả
        public float TinhTongTienSauKhiTienBHYTChiTra(string maPKB)
        {

            var phieuKham = (from k in db.PhieuKhamBenhs
                             where k.MSPhieuKhamBenh == maPKB
                             select k).SingleOrDefault();

            var hoaDonTT = db.HoaDons.FirstOrDefault(hd => hd.MSPhieuKhamBenh == maPKB);

            if (hoaDonTT != null && phieuKham != null)
            {
                var tt = hoaDonTT.PhieuKhamBenh.ToaThuocs.FirstOrDefault();
                if (tt != null)
                {
                    hoaDonTT.TongTienSauKhiDaGiam = TinhTienTongCong(tt.MaToaThuoc, maPKB) - TinhTienBHYTChiTra(maPKB);
                }
            }

            db.SubmitChanges();
            return Convert.ToSingle(hoaDonTT?.TongTienSauKhiDaGiam ?? 0);
        }
        // Tính tổng tiền sau khi BHYT chi trả
        public void CapNhapTienSauKhiBHYTChiTra()
        {
            float tien = 0;
            var dsHD = from ds in db.HoaDons
                       select ds;
            foreach (var item in dsHD)
            {
                tien = TinhTongTienSauKhiTienBHYTChiTra(item.MSPhieuKhamBenh);
                item.TongTienSauKhiDaGiam = tien;
            }
            db.SubmitChanges();
        }
        //Kiem tra xem benh nhan co hoa don chua
        public bool KiemTraCoHoaDonChua(string maPKB)
        {
            return db.HoaDons.Any(pkb => pkb.MSPhieuKhamBenh == maPKB);
        }
    }
}
