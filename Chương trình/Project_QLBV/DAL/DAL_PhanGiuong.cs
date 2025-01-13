using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhanGiuong
    {
        //Khai báo biến tĩnh
        private static DAL_PhanGiuong instance;
        

        public static DAL_PhanGiuong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_PhanGiuong();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xem danh sách phân giường
        public IQueryable XemDSPhanGiuong(DateTime dtp)
        {
            IQueryable ds = from pg in db.PhanGiuongs
                            where pg.NgayNhanGiuong.Value.Date == dtp.Date
                            select pg;
            return ds;
        }

        //Kiểm tra trạng thái giường có đang trống không
        public bool KiemTraTrangThaiGiuong(string maGiuong, DateTime ngayNhanGiuong, DateTime ngayTraGiuong)
        {
            var conflicts = db.PhanGiuongs.Any(g =>
                g.MaGiuong == maGiuong &&
                (
                    (ngayNhanGiuong >= g.NgayNhanGiuong && ngayNhanGiuong <= g.NgayTraGiuong) || // Start date is within an existing reservation
                    (ngayTraGiuong >= g.NgayNhanGiuong && ngayTraGiuong <= g.NgayTraGiuong) || // End date is within an existing reservation
                    (ngayNhanGiuong <= g.NgayNhanGiuong && ngayTraGiuong >= g.NgayTraGiuong) // New reservation completely envelops an existing one
                )
            );

            return !conflicts;
        }
        //Thực hiện phân giường
        public bool PhanGiuong(ET_PhanGiuong etPG)
        {
            if (db.PhanGiuongs.Any(t => t.MaYeuCau == etPG.MaYC))
            {
                return false;
            }
            else
            {
                try
                {
                    PhanGiuong pg = new PhanGiuong
                    {
                        MaGiuong = etPG.MaGiuong,
                        MaYeuCau = etPG.MaYC,
                        NgayNhanGiuong = etPG.NgayNhanGiuong,
                        NgayTraGiuong = null,
                        MSPhieuKhamBenh = etPG.MsPhieuKhamBenh,
                        MaLoaiBA = etPG.MaLoaiBA,
                        MaLoaiChiTietDV = etPG.MaLoaiChiTietDV
                    };
                    db.PhanGiuongs.InsertOnSubmit(pg);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
        //Xóa phân giường
        public bool XoaPhanGiuong(string maPKB)
        {
            try
            {
                var xoa = from t in db.PhanGiuongs
                          where t.MSPhieuKhamBenh == maPKB
                          select t;
                foreach (var x in xoa)
                {
                    db.PhanGiuongs.DeleteOnSubmit(x);
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

        //Sửa phân giường
        public void SuaPhanGiuong(ET_PhanGiuong etPG)
        {
            var currentPhanGiuong = db.PhanGiuongs.Single(t => t.MSPhieuKhamBenh == etPG.MsPhieuKhamBenh && t.MaYeuCau == etPG.MaYC);
            var existingPhanGiuong = db.PhanGiuongs.SingleOrDefault(t => t.MaGiuong == etPG.MaGiuong && t.MSPhieuKhamBenh == etPG.MsPhieuKhamBenh && t.MaYeuCau == etPG.MaYC);
            if (existingPhanGiuong != null && existingPhanGiuong != currentPhanGiuong)
            {
                throw new InvalidOperationException("Another record with the same 'MaGiuong' already exists for the same MSPhieuKhamBenh and MaYeuCau.");
            }
            var newPhanGiuong = new PhanGiuong
            {
                MSPhieuKhamBenh = etPG.MsPhieuKhamBenh,
                MaYeuCau = etPG.MaYC,
                NgayNhanGiuong = etPG.NgayNhanGiuong,
                NgayTraGiuong = etPG.NgayTraGiuong,
                MaGiuong = etPG.MaGiuong,
                LoaiBenhAn = db.LoaiBenhAns.SingleOrDefault(ba => ba.MaLoaiBA == etPG.MaLoaiBA),
                MaLoaiChiTietDV = etPG.MaLoaiChiTietDV
            };
            db.PhanGiuongs.InsertOnSubmit(newPhanGiuong);
            db.PhanGiuongs.DeleteOnSubmit(currentPhanGiuong);
            db.SubmitChanges();
        }
        //Lấy phiếu khám bệnh nhờ yêu cầu
        public string LayPhieuKhamBenhNhoYC(string maYC)
        {
            var truyVan = (from dl in db.Khams
                           where dl.MaYeuCau == maYC
                           select dl.MSPhieuKhamBenh).FirstOrDefault();
            return truyVan;
        }
        //Lấy danh giường nhờ mã phòng
        public IQueryable LayDSGiuongNhoPhong(string maPhong)
        {
            IQueryable truyVan = from dl in db.PhongKhams
                                 join g in db.GiuongBenhs
                                 on dl.MSPhong equals g.MSPhong
                                 where dl.MSPhong == maPhong
                                 select g;
            return truyVan;
        }

        //Lấy tên giường từ mã giường
        public int LayTenGiuongTuMaGiuong(string maGB)
        {
            var truyVan = (int)(from dl in db.GiuongBenhs
                                where dl.MaGiuong == maGB
                                select dl.SoGiuongBenh).FirstOrDefault();
            return truyVan;
        }
        //Kiểm tra ngày nhập giường phải lớn hơn hoặc bằng ngày khám của phiếu khám bệnh
        public bool KiemTraNgayNhapGiuong(DateTime ngayNhap, string maPKB)
        {
            var ngayKham = (from dl in db.PhieuKhamBenhs
                            where dl.MSPhieuKhamBenh == maPKB
                            select dl.NgayKham).FirstOrDefault();

            if (!ngayKham.HasValue)
            {
                return false;
            }


            return ngayNhap.Date >= ngayKham.Value.Date;
        }
        //Lấy ra ngày nhận giường của phiếu khám bệnh
        public DateTime? LayNgayNhanGiuong(string maPKB)
        {
            // Ensure the query returns a nullable DateTime directly
            var truyVan = (from dl in db.PhanGiuongs
                           where dl.MSPhieuKhamBenh == maPKB
                           select dl.NgayNhanGiuong).FirstOrDefault();  // This should naturally be DateTime?

            return truyVan;  // This is already a DateTime? from the LINQ query
        }
        //Lấy ra danh sách dịch vụ theo mã phòng
        public IQueryable LayDSDVTheoMaPhong(string maPhong)
        {
            IQueryable truyVan = from dl in db.PhongKhams
                                 join dv in db.BangGias
                                 on dl.MaKhoa equals dv.MaKhoa
                                 where dl.MSPhong == maPhong && dv.MaLoaiChiTietDV.Contains("DVCT12.")
                                 select dv;
            return truyVan;
        }
    }
}
