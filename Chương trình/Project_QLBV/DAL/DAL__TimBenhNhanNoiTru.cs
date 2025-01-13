using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL__TimBenhNhanNoiTru
    {
        //Khai báo biến tĩnh
        private static DAL__TimBenhNhanNoiTru instance;


        public static DAL__TimBenhNhanNoiTru Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL__TimBenhNhanNoiTru();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);

        //Lấy danh sách  bệnh nhân theo ngày
        public IQueryable LayDSBenhNhanTheoNgay(DateTime dtp)
        {
            IQueryable ds = from dl in db.BenhNhans//Truy vấn dữ liệu từ bảng BenhNhan
                            join hs in db.HoSoBenhAns//Kết thêm bảng HoSoBenhAn
                            on dl.MSBN equals hs.MSBN
                            join pk in db.PhieuKhamBenhs//Kết thêm bảng PhieuKhamBenh
                            on hs.MaHoSoBA equals pk.MaHoSoBA
                            join cd in db.ChuanDoans//Kết thêm bảng ChuanDoan
                            on pk.MSPhieuKhamBenh equals cd.MSPhieuKhamBenh
                            join b in db.BenhLies//Kết thêm bảng BenhLy
                            on cd.MaBenh equals b.MaBenh
                            join pg in db.PhanGiuongs//Kết thêm bảng PhanGiuong
                            on pk.MSPhieuKhamBenh equals pg.MSPhieuKhamBenh
                            join g in db.GiuongBenhs//Kết thêm bảng GiuongBenh
                            on pg.MaGiuong equals g.MaGiuong
                            join p in db.PhongKhams//Kết thêm bảng PhongKham
                            on g.MSPhong equals p.MSPhong
                            join kh in db.Khams//Kết thêm bảng Kham
                            on pg.MaYeuCau equals kh.MaYeuCau
                            where pg.NgayNhanGiuong.Value.Date == dtp.Date//Lọc theo ngày được chỉ được
                            select new
                            {
                                pk.MSPhieuKhamBenh,
                                dl.MSBN,
                                dl.TenBN,
                                b.TenBenh,
                                pg.NgayNhanGiuong,
                                pg.NgayTraGiuong,
                                g.MaGiuong,
                                p.TenPhong,
                                kh.MaNV
                            };
            //Trả về kết quả truy vấn
            return ds;
        }

        // Lấy danh sách bệnh nhân theo tháng
        public IQueryable LayDSBenhNhanTheoThang(DateTime dtp)
        {
            IQueryable ds = from dl in db.BenhNhans//Truy vấn dữ liệu từ BenhNhan
                            join hs in db.HoSoBenhAns//Kết thêm bảng HoSoBenhAn
                            on dl.MSBN equals hs.MSBN
                            join pk in db.PhieuKhamBenhs//Kết thêm bảng PhieuKhamBenh
                            on hs.MaHoSoBA equals pk.MaHoSoBA
                            join cd in db.ChuanDoans//Kết thêm bảng ChuanDoan
                            on pk.MSPhieuKhamBenh equals cd.MSPhieuKhamBenh
                            join b in db.BenhLies//Kết thêm bảng BenhLy
                            on cd.MaBenh equals b.MaBenh
                            join pg in db.PhanGiuongs//Kết thêm bảng PhanGiuong
                            on pk.MSPhieuKhamBenh equals pg.MSPhieuKhamBenh
                            join g in db.GiuongBenhs//Kết thêm bảng GiuongBenh
                            on pg.MaGiuong equals g.MaGiuong
                            join p in db.PhongKhams//Kết thêm bảng PhongKham
                            on g.MSPhong equals p.MSPhong
                            join kh in db.Khams//Kết thêm bảng Kham
                            on pg.MaYeuCau equals kh.MaYeuCau
                            where pg.NgayNhanGiuong.Value.Month == dtp.Month && pg.NgayNhanGiuong.Value.Year == dtp.Year
                            select new
                            {
                                pk.MSPhieuKhamBenh,
                                dl.MSBN,
                                dl.TenBN,
                                b.TenBenh,
                                pg.NgayNhanGiuong,
                                pg.NgayTraGiuong,
                                g.MaGiuong,
                                p.TenPhong,
                                kh.MaNV
                            };
            //Trà về kết quả truy vấn
            return ds;
        }
        // Lấy danh sách bệnh nhân theo năm
        public IQueryable LayDSBenhNhanTheoNam(DateTime dtp)
        {
            IQueryable ds = from dl in db.BenhNhans//Truy vấn dữ liệu từ bảng BenhNhan
                            join hs in db.HoSoBenhAns//Kết thêm bảng HoSoBenhAn
                            on dl.MSBN equals hs.MSBN
                            join pk in db.PhieuKhamBenhs//Kết thêm bảng PhieuKhamBenh
                            on hs.MaHoSoBA equals pk.MaHoSoBA
                            join cd in db.ChuanDoans//Kết thêm bảng ChuanDoan
                            on pk.MSPhieuKhamBenh equals cd.MSPhieuKhamBenh
                            join b in db.BenhLies//Kết thêm bảng BenhLy
                            on cd.MaBenh equals b.MaBenh
                            join pg in db.PhanGiuongs//Kết thêm bảng PhanGiuong
                            on pk.MSPhieuKhamBenh equals pg.MSPhieuKhamBenh
                            join g in db.GiuongBenhs//Kết thêm bảng GiuongBenh
                            on pg.MaGiuong equals g.MaGiuong
                            join p in db.PhongKhams//Kết thêm bảng PhongKham
                            on g.MSPhong equals p.MSPhong
                            join kh in db.Khams//Kết thêm bảng Kham
                            on pg.MaYeuCau equals kh.MaYeuCau
                            where pg.NgayNhanGiuong.Value.Year == dtp.Year//Lọc theo năm được chỉ định
                            select new
                            {
                                pk.MSPhieuKhamBenh,
                                dl.MSBN,
                                dl.TenBN,
                                b.TenBenh,
                                pg.NgayNhanGiuong,
                                pg.NgayTraGiuong,
                                g.MaGiuong,
                                p.TenPhong,
                                kh.MaNV
                            };
            //Trả về kết quả được truy vấn
            return ds;
        }
        // Lấy danh sách bệnh nhân theo khoảng thời gian
        public IQueryable LayDSBenhNhanTheoKhoangTG(DateTime dtpTuNgay, DateTime dtpDenNgay)
        {
            IQueryable ds = from dl in db.BenhNhans//Truy vấn dữ liệu từ bảng BenhNhan
                            join hs in db.HoSoBenhAns//Kết thêm bảng HoSoBenhAn
                            on dl.MSBN equals hs.MSBN
                            join pk in db.PhieuKhamBenhs//Kết thêm bảng PhieuKhamBenh
                            on hs.MaHoSoBA equals pk.MaHoSoBA
                            join cd in db.ChuanDoans//Kết thêm bảng ChuanDoan
                            on pk.MSPhieuKhamBenh equals cd.MSPhieuKhamBenh
                            join b in db.BenhLies//Kết thêm bảng BenhLy
                            on cd.MaBenh equals b.MaBenh
                            join pg in db.PhanGiuongs//Kết thêm bảng PhanGiuong
                            on pk.MSPhieuKhamBenh equals pg.MSPhieuKhamBenh
                            join g in db.GiuongBenhs//Kết thêm bảng GiuongBenh
                            on pg.MaGiuong equals g.MaGiuong
                            join p in db.PhongKhams//Kết thêm bảng PhongKham
                            on g.MSPhong equals p.MSPhong
                            join kh in db.Khams//Kết thêm bảng Kham
                            on pg.MaYeuCau equals kh.MaYeuCau
                            where pg.NgayNhanGiuong.Value.Date >= dtpTuNgay.Date && pg.NgayNhanGiuong.Value.Date <= dtpDenNgay.Date// Lọc theo ngày nhận giường trong 1 khoảng thời gian được chỉ định
                            select new
                            {
                                pk.MSPhieuKhamBenh,
                                dl.MSBN,
                                dl.TenBN,
                                b.TenBenh,
                                pg.NgayNhanGiuong,
                                pg.NgayTraGiuong,
                                g.MaGiuong,
                                p.TenPhong,
                                kh.MaNV
                            };
            //Trả về kết quả truy vấn
            return ds;
        }
    }
}
