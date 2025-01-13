using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TheoDoiSucKhoe
    {
        //Khai báo biến tĩnh
        private static DAL_TheoDoiSucKhoe instance;
        

        public static DAL_TheoDoiSucKhoe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_TheoDoiSucKhoe();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xem danh sách theo dõi theo phiếu khám bệnh
        public IQueryable XemDSTheoDoi(string maPKB)
        {
            IQueryable ds = from t in db.TheoDoiSucKhoes
                            where t.MSPhieuKhamBenh == maPKB
                            select t;
            return ds;
        }
        //Thêm theo dõi
        public bool ThemTheoDoi(ET_TheoDoiSucKhoe etTheoDoiSK)
        {
            if (db.TheoDoiSucKhoes.Any(t => t.MaTheoDoi == etTheoDoiSK.MaTheoDoi))
            {
                return false;
            }
            else
            {
                try
                {
                    TheoDoiSucKhoe td = new TheoDoiSucKhoe
                    {
                        MaTheoDoi = etTheoDoiSK.MaTheoDoi,
                        MaYeuCau = etTheoDoiSK.MaYC,
                        MSPhieuKhamBenh = etTheoDoiSK.MaSoPKB,
                        MaNV = etTheoDoiSK.MaNV,
                        NgayTheoDoi = etTheoDoiSK.NgayTheoDoi,
                        TinhTrangSK = etTheoDoiSK.TinhTrangSK,
                        GhiChu = etTheoDoiSK.GhiChu
                    };
                    db.TheoDoiSucKhoes.InsertOnSubmit(td);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
        //Xóa theo dõi
        public bool XoaTheoDoiSK(string maTheoDoi)
        {
            try
            {
                var xoa = from td in db.TheoDoiSucKhoes
                          where td.MaTheoDoi == maTheoDoi
                          select td;
                foreach (var x in xoa)
                {
                    db.TheoDoiSucKhoes.DeleteOnSubmit(x);
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
        //Sửa theo dõi
        public void SuaTheoDoiSK(ET_TheoDoiSucKhoe etTD)
        {
            //update từ mã thuốc.
            var update = db.TheoDoiSucKhoes.Single(t => t.MaTheoDoi == etTD.MaTheoDoi);
            var nhanVienMoi = db.NhanViens.SingleOrDefault(nv => nv.MaNV == etTD.MaNV);
            if (nhanVienMoi != null)
            {
                update.NhanVien = nhanVienMoi;
            }
            update.NgayTheoDoi = etTD.NgayTheoDoi;
            update.TinhTrangSK = etTD.TinhTrangSK;
            update.GhiChu = etTD.GhiChu;
            db.SubmitChanges();
        }
        //Kiểm tra ngày theo dõi trong phạn vị
        public bool KiemTraNgayTD(DateTime dtp, string maPKB)
        {
            var truyVan = (from dl in db.PhanGiuongs
                           where dl.MSPhieuKhamBenh == maPKB
                           select dl).FirstOrDefault();

            // Kiểm tra trường hợp dữ liệu không tồn tại
            if (truyVan == null)
                return false;

            // Kiểm tra nếu NgayTraGiuong là null, chỉ cần ngày dtp sau hoặc bằng NgayNhanGiuong
            if (!truyVan.NgayTraGiuong.HasValue)
            {
                return dtp.Date >= truyVan.NgayNhanGiuong.Value.Date;
            }
            // Kiểm tra khi NgayTraGiuong có giá trị, dtp phải nằm trong khoảng NgayNhanGiuong và NgayTraGiuong
            if (dtp.Date >= truyVan.NgayNhanGiuong.Value.Date && dtp.Date <= truyVan.NgayTraGiuong.Value.Date)
            {
                return true;
            }
            return false;
        }

       //Lấy dah sách nhân viên cùng khoa với nhân viên phụ trách
        public IQueryable LayDSNVCungKhoaVoiNVPhuTrach(string maNVPhuTrach)
        {
            // Trước tiên lấy MaKhoa của nhân viên phụ trách
            var maKhoa = db.NhanViens.Where(nv => nv.MaNV == maNVPhuTrach).Select(nv => nv.MaKhoa).FirstOrDefault();

            // Sau đó truy vấn lấy tất cả nhân viên trong cùng khoa
            IQueryable truyVan = from nv in db.NhanViens
                                 where nv.MaKhoa == maKhoa && nv.MaCV == "CV02"
                                 select nv;

            return truyVan;
        }
        //Lấy ngày nhận giường
        public DateTime? LayNgayNhanGiuong(string maPKB)
        {
            // Ensure the query returns a nullable DateTime directly
            var truyVan = (from dl in db.PhanGiuongs
                           where dl.MSPhieuKhamBenh == maPKB
                           select dl.NgayNhanGiuong).FirstOrDefault();  // This should naturally be DateTime?

            return truyVan;  // This is already a DateTime? from the LINQ query
        }
        //Lấy ngày trả giường
        public DateTime? LayNgayTraGiuong(string maPKB)
        {
            // Ensure the query returns a nullable DateTime directly
            var truyVan = (from dl in db.PhanGiuongs
                           where dl.MSPhieuKhamBenh == maPKB
                           select dl.NgayTraGiuong).FirstOrDefault();  // This should naturally be DateTime?

            return truyVan;  // This is already a DateTime? from the LINQ query
        }
        //Tạo mã theo dõi tự động
        public string GenerateTheoDoiSucKhoeCode(string maPK)
        {
            // Lấy ngày hiện tại với định dạng yyyyMMdd
            string datePrefix = maPK;

            // Chuỗi định danh bắt đầu của mã hồ sơ để query
            string queryPrefix = $"TD-{datePrefix}";

            // Đếm số lượng mã hồ sơ bệnh án trong ngày hôm nay bắt đầu bằng queryPrefix
            int countToday = db.PhieuKhamBenhs.Count(h => h.MSPhieuKhamBenh.StartsWith(queryPrefix));

            // Tạo mã mới, nên có ký tự phân cách dấu '-' giữa các phần
            string newCode = $"TD-{(countToday + 1).ToString("D1")}-{maPK}";

            return newCode;
        }
    }
}
