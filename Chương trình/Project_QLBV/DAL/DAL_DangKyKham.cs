using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DangKyKham
    {
        //Khai báo biến tĩnh
        private static DAL_DangKyKham instance;


        public static DAL_DangKyKham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_DangKyKham();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xem danh sách đăng ký khám theo ngày
        public IQueryable XemDSDKyKhamTheoNgay(DateTime dtp)
        {
            IQueryable ds = from dk in db.Khams
                            join pk in db.PhieuKhamBenhs
                            on dk.MSPhieuKhamBenh equals pk.MSPhieuKhamBenh
                            where pk.NgayKham.Value.Date == dtp.Date
                            select dk;
            return ds;
        }

        //Thêm đăng ký
        public bool ThemDKyKham(ET_DangKyKham etKham)
        {
            if (db.Khams.Any(kham => kham.MaYeuCau == etKham.MaYeuCau))
            {
                return false;
            }
            else
            {
                try
                {
                    Kham kham = new Kham
                    {
                        MaYeuCau = etKham.MaYeuCau,
                        MSPhieuKhamBenh = etKham.MaPhieuKham,
                        MSPhong = etKham.MaPhong,
                        MaNV = string.IsNullOrEmpty(etKham.MaNgPhuTrach) ? null : etKham.MaNgPhuTrach,
                        MaNguoiYC = etKham.MaNVYeuCau
                    };
                    db.Khams.InsertOnSubmit(kham);

                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
        //Kiểm tra trạng thái khám: yêu cầu đó có được khám chưa
        public bool KiemTraTrangThaiKham(string maKham)
        {
            var kiemTra = (from kham in db.Khams
                           where kham.MaYeuCau == maKham && kham.MaNV == null
                           select kham).Any();
            return kiemTra;
        }
        //Xóa đăng ký khám
        public bool XoaDKyKham(string maKham)
        {
            try
            {
                var xoa = from kham in db.Khams
                          where kham.MaYeuCau == maKham
                          select kham;
                foreach (var x in xoa)
                {
                    db.Khams.DeleteOnSubmit(x);
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
                return false;
            }
        }
        //Sửa đăng ký khám
        public void SuaDangKyKham(ET_DangKyKham etDKyKham)
        {
            var capNhap = db.Khams.Single(k => k.MaYeuCau == etDKyKham.MaYeuCau);
            var phieuKhamBenhMoi = db.PhieuKhamBenhs.SingleOrDefault(pkb => pkb.MSPhieuKhamBenh == etDKyKham.MaPhieuKham);
            if (phieuKhamBenhMoi != null)
            {
                capNhap.PhieuKhamBenh = phieuKhamBenhMoi;
            }
            var nvPhuTrachMoi = db.NhanViens.SingleOrDefault(nvpt => nvpt.MaNV == etDKyKham.MaNgPhuTrach);
            if (nvPhuTrachMoi != null)
            {
                capNhap.NhanVien1 = nvPhuTrachMoi;
            }

            var nvYCauMoi = db.NhanViens.SingleOrDefault(nvpt => nvpt.MaNV == etDKyKham.MaNVYeuCau);
            if (nvYCauMoi != null)
            {
                capNhap.NhanVien = nvYCauMoi;
            }
            var phongMoi = db.PhongKhams.SingleOrDefault(p => p.MSPhong == etDKyKham.MaPhong);
            if (phongMoi != null)
            {
                // Cập nhật tham chiếu đối tượng Phòng
                capNhap.PhongKham = phongMoi;
            }
            db.SubmitChanges();
        }
        //Lấy danh sách nhân viên
        public IQueryable DoDLLenNV()
        {
            IQueryable nv = from nvien in db.NhanViens
                            select nvien;
            return nv;
        }
        //Lấy danh sách nhân viên yêu cầu
        public IQueryable DoDLLenNVYeuCau(string msPhieuKham)
        {
            var soLuong = (from pk in db.Khams
                           where pk.MSPhieuKhamBenh == msPhieuKham
                           select new { pk.MaYeuCau }).Count();

            IQueryable ds = null;

            if (soLuong == 0)
            {
                ds = from nv in db.NhanViens
                     where nv.MaKhoa == "K30"
                     select nv;
            }
            else
            {

                ds = from nv in db.NhanViens
                     where nv.MaKhoa != "K30" && nv.MaKhoa != "K20" && nv.MaKhoa != "K28"
                     select nv;
            }
            return ds;
        }
        //Lấy mã phòng nhờ tên phòng
        public string LayMaPhongNhoTenPhong(string tenPhong)
        {
            return db.PhongKhams.FirstOrDefault(p => p.TenPhong == tenPhong)?.MSPhong;
        }
        //Đổ dữ liệu nhân vật phụ trách theo mã phòng từ mã phòng sẽ so sánh khoa và lấy ra nhân viên
        public IQueryable DoDLLenNVPhuTrach(string msPhong)
        {
            IQueryable ds = from pk in db.NhanViens
                            join p in db.PhongKhams on pk.MaKhoa equals p.MaKhoa
                            where pk.MaKhoa != "K30" && pk.MaKhoa != "K17" && p.MSPhong == msPhong
                            select pk;
            return ds;
        }
        //Lấy tên nhân viên nhờ mã nhân viên
        public string layTenNVNhoMaNV(string maNV)
        {
            var truyvan = (from ten in db.NhanViens
                           where ten.MaNV == maNV
                           select ten.TenNV).FirstOrDefault();
            return truyvan;
        }

        //Lấy mã bệnh nhân nhờ mã phiếu khám bệnh
        public string layMaBNhoMaPKB(string maPKB)
        {
            var ds = (from pkb in db.PhieuKhamBenhs
                      join hs in db.HoSoBenhAns
                      on pkb.MaHoSoBA equals hs.MaHoSoBA
                      join bn in db.BenhNhans
                      on hs.MSBN equals bn.MSBN
                      where pkb.MSPhieuKhamBenh == maPKB
                      select hs.MSBN).FirstOrDefault();
            return ds;
        }
        //Lấy tên bệnh nhân nhờ mã bệnh nhân
        public string layTenBNNhoMaBN(string maBN)
        {
            var ds = (from dl in db.BenhNhans
                      where dl.MSBN == maBN
                      select dl.TenBN).FirstOrDefault();
            return ds;
        }
        //Lấy tên phòng nhờ mã phòng
        public string layTenPhongNhoMaPhong(string maPhong)
        {
            var ds = (from p in db.PhongKhams
                      where p.MSPhong == maPhong
                      select p.TenPhong).FirstOrDefault();
            return ds;
        }
        //Lấy triệu chứng nhờ phiếu khám bệnh
        public string layTrieuChungNhoPKB(string msPKB)
        {
            var ds = (from tt in db.PhieuKhamBenhs
                      where tt.MSPhieuKhamBenh == msPKB
                      select tt.TrieuChung).FirstOrDefault();
            return ds;
        }
        //Lấy danh sách khám theo ngày được chỉ định
        public IQueryable LayDSKhamTheoNgay(DateTime dtpNgay)
        {
            IQueryable ds = from tt in db.PhieuKhamBenhs
                            where tt.NgayKham == dtpNgay
                            select tt;
            return ds;
        }
        //Tạo mã khám tự động
        public string GenerateMaKhamCode(string maPKB)
        {
            // Lấy ngày hiện tại với định dạng MMddHHmmssfff
            string datePrefix = DateTime.Now.ToString("yyyyMMddHHmmssfff");

            // Tạo chuỗi query để lấy số lượng hồ sơ với ngày hôm nay
            string query = $"MK-{datePrefix}";

            // Đếm số lượng mã hồ sơ bệnh án trong ngày hôm nay
            int countToday = db.Khams.Count(h => h.MaYeuCau.StartsWith(query));

            // Tạo mã mới
            string newCode = $"MK-{datePrefix}{(countToday + 1).ToString("D4")}";

            return newCode;
        }
        //Lấy phiếu khám bệnh theo ngày
        public IQueryable LayPKBTheoNgayKham(DateTime dtp)
        {
            IQueryable ds = from dl in db.PhieuKhamBenhs
                            where dl.NgayKham.Value.Date == dtp.Date
                            select dl;
            return ds;
        }
        //Kiểm tra phiếu khám bệnh có chuẩn đoán không
        public bool KiemTraCoChuanDoanChua(string maPKB)
        {
            return db.ChuanDoans.Any(cd => cd.MSPhieuKhamBenh == maPKB);
        }
        //Kiểm tra phòng phẫu thuật
        public bool KiemTraPhong(string tenPhong)
        {
            return tenPhong.Contains("Phòng phẫu thuật");
        }
        //Kiểm tra xem bệnh nhân đi khám chưa
        public bool KiemTraDiKhamChua(string maPKB)
        {
            var soLuong = (from pk in db.Khams
                           where pk.MSPhieuKhamBenh == maPKB
                           select new { pk.MaYeuCau }).Count();
            if (soLuong > 0)
            {
                return true;
            }
            return false;
        }
        //Lấy danh sách tên phòng
        public List<string> LayDSTenPhong()
        {
            var ds = (from p in db.PhongKhams
                      select p.TenPhong).ToList();
            return ds;
        }
        //Lấy danh sách đang chờ làm PT_XNCC theo ngày
        public IQueryable LayDSDangChoPT_XNCCTheoNgay(DateTime dtp)
        {
            IQueryable ds = from k in db.Khams
                            join pk in db.PhieuKhamBenhs on k.MSPhieuKhamBenh equals pk.MSPhieuKhamBenh
                            join p in db.PhongKhams
                            on k.MSPhong equals p.MSPhong
                            where pk.NgayKham.Value.Date == dtp.Date
                                  && !db.LamPhauThuat_XNCCs.Any(x => x.MaYeuCau == k.MaYeuCau)
                                  && p.Loai == "Phòng chức năng"
                            select k;
            return ds;
        }
        //Kiểm tra xem phòng đó của mã khám có là phòng khám không
        public bool KiemTraTrangThaiKhamCuaPhongKham(string maKham)
        {
            var kiemTra = (from kham in db.Khams
                           join p in db.PhongKhams
                           on kham.MSPhong equals p.MSPhong
                           where p.Loai == "Phòng khám" && kham.MaYeuCau == maKham
                           select kham).Any();
            return kiemTra;
        }
        //Kiểm tra xem có phải lần đầu khám không

        public bool KiemTraLanKhamDauCuaPKKham(string maPK)
        {
            var soLanKham = (from kham in db.Khams
                             where kham.MSPhieuKhamBenh == maPK
                             select kham).Count();
            return soLanKham == 0;
        }
        //Kiểm tra xem phòng đó phải phòng bệnh hay phòng chức năng không
        public bool KiemTraLoaiPhong(string maPhong)
        {
            var kiemTra = (from p in db.PhongKhams
                           where (p.Loai == "Phòng bệnh" || p.Loai == "Phòng chức năng") && p.MSPhong == maPhong
                           select p).Any();
            return kiemTra;  // Trả về true nếu phòng là "Phòng bệnh" hoặc "Phòng chức năng"
        }
        //Kiểm tra xem đây có phải phòng bệnh không

        public bool KiemTraTrangThaiKhamCuaPhongBenh(string maKham)
        {
            var kiemTra = (from kham in db.Khams
                           join p in db.PhongKhams
                           on kham.MSPhong equals p.MSPhong
                           where p.Loai.Trim() == "Phòng bệnh" && kham.MaYeuCau.Trim() == maKham.Trim()
                           select kham).Any();
            Console.WriteLine($"Checking for MaYeuCau: {maKham}, Found: {kiemTra}");
            return kiemTra;
        }
    }
}
