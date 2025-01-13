using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL__BaoCaoMatDoKhamCuaPK
    {
        // Khai báo biến tĩnh
        private static DAL__BaoCaoMatDoKhamCuaPK instance;

        public static DAL__BaoCaoMatDoKhamCuaPK Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL__BaoCaoMatDoKhamCuaPK();
                }
                return instance;
            }
        }
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        public IQueryable LayDSPK()
        {
            // Truy vấn để lấy danh sách phòng khám
            IQueryable ds = from dl in db.PhongKhams
                            select dl;
            return ds;
        }

        public IQueryable ThongKeDSTheoNgay(DateTime dtpNgay)
        {
            IQueryable ds = from dl in db.Khams// Truy vấn từ bảng Kham
                            join p in db.PhongKhams// Nối với bảng PhongKham
                            on dl.MSPhong equals p.MSPhong
                            join pk in db.PhieuKhamBenhs// Nối thêm với bảng PhieuKhamBenh
                            on dl.MSPhieuKhamBenh equals pk.MSPhieuKhamBenh
                            where pk.NgayKham.Value.Date == dtpNgay.Date// Lọc dữ liệu theo ngày khám giống với ngày của DateTimePicker
                            group dl by p.MSPhong into g// Nhóm kết quả theo mã phòng
                            select new
                            {
                                g.Key,
                                SoLuong = g.Count()// Đếm số lượng khám trong mỗi nhóm (tức mỗi phòng)
                            };
            // Trả về kết quả truy vấn
            return ds;
        }
        // Thống kê danh sách bệnh nhân khám của các phòng theo tháng
        public IQueryable ThongKeDSTheoThang(DateTime dtpNgay)
        {
            IQueryable ds = from dl in db.Khams// lấy dữ liệu từ bảng Kham
                            join p in db.PhongKhams// nối với bảng PhongKham
                            on dl.MSPhong equals p.MSPhong
                            join pk in db.PhieuKhamBenhs//nối thêm với bảng PhieuKhamBenh
                            on dl.MSPhieuKhamBenh equals pk.MSPhieuKhamBenh
                            where pk.NgayKham.Value.Month == dtpNgay.Month && pk.NgayKham.Value.Year == dtpNgay.Year// lấy tháng + năm của ngày khám phiếu khám bệnh với ngày + tháng được lấy dừ DateTimePicker
                            group dl by p.MSPhong into g// Nhóm kết quả theo mã phòng
                            select new
                            {
                                g.Key,
                                SoLuong = g.Count()// Đếm số lượng khám trong mỗi nhóm (tức mỗi phòng)
                            };
            // Trà về kết quả
            return ds;
        }
        // Thống kê danh sách theo năm
        public IQueryable ThongKeDSTheoNam(DateTime dtpNgay)
        {
            IQueryable ds = from dl in db.Khams// Truy vấn từ bảng khám
                            join p in db.PhongKhams// Kết thêm PhongKham
                            on dl.MSPhong equals p.MSPhong
                            join pk in db.PhieuKhamBenhs
                            on dl.MSPhieuKhamBenh equals pk.MSPhieuKhamBenh// Kết thêm PhieuKhamBenh
                            where pk.NgayKham.Value.Year == dtpNgay.Year// Lọc kết quả theo năm của ngày khám của PKB phải bằng với năm của DateTimePicker
                            group dl by p.MSPhong into g
                            select new
                            {
                                g.Key,
                                SoLuong = g.Count()// Đếm số lượng khám trong mỗi nhóm (tức mỗi phòng)
                            };
            return ds;
        }
    }
}
