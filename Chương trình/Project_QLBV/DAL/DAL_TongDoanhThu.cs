using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TongDoanhThu
    {
        //Khai báo biến tĩnh
        private static DAL_TongDoanhThu instance;
        

        public static DAL_TongDoanhThu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_TongDoanhThu();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);

        //Lấy tiền của tất cả phiếu khám theo ngày
        public List<ET__XHDTatCaPKBTheoTime> XuatTienCuaTatCaCacPKBTheoNgay(DateTime dtp)
        {
            var results = db.XuatTienHDCuaTatCaPKBTheoNgay(dtp);
            return results.Select(r => new ET__XHDTatCaPKBTheoTime(
              r.MaHD,
              r.MSPhieuKhamBenh,
              r.NgayXuatHD,
              (float)(r.TienThuoc ?? 0),
              (float)(r.TienKham ?? 0),
              (float)(r.TienGiuong ?? 0),
              (float)(r.TienPT_XNCC ?? 0),
              (float)(r.TongTien ?? 0),
              (float)(r.TienBHYTChiTra ?? 0),
              (float)(r.TongTien ?? 0))).ToList();
        }

        //Lấy tổng doanh thu theo ngày
        public List<ET__TongDoanhThu> ThongKeDoanhThuTheoNgay(DateTime dtp)
        {
            var results = db.ThongKeDoanhSoCuaTatCaPKBTheoNgay(dtp);
            return results.Select(r => new ET__TongDoanhThu(
              (float)(r.TongDoanhThuThuoc ?? 0),
              (float)(r.TongDoanhThuPT_XNCC ?? 0),
              (float)(r.TongDoanhThuVienPhi ?? 0),
              (float)(r.TongDoanhThuTienKham ?? 0),
              (float)(r.TongTien ?? 0),
              (float)(r.TongTienBHYTChiTra ?? 0),
              (float)(r.TongTienConLai ?? 0),
              r.NgayXuatTK)).ToList();
        }

        //Theo tháng
        //Lấy tiền tất cả của phiếu khám bệnh theo tháng
        public List<ET__XHDTatCaPKBTheoTime> XuatTienCuaTatCaCacPKBTheoThang(int ngay, int nam)
        {
            var results = db.XuatTienHDCuaTatCaPKBTheoThang(ngay, nam);
            return results.Select(r => new ET__XHDTatCaPKBTheoTime(
              r.MaHD,
              r.MSPhieuKhamBenh,
              r.NgayXuatHD,
              (float)(r.TienThuoc ?? 0),
              (float)(r.TienKham ?? 0),
              (float)(r.TienGiuong ?? 0),
              (float)(r.TienPT_XNCC ?? 0),
              (float)(r.TongTien ?? 0),
              (float)(r.TienBHYTChiTra ?? 0),
              (float)(r.TongTien ?? 0))).ToList();
        }

        //Tổng doanh thu theo tháng
        public List<ET__TongDoanhThu> ThongKeDoanhThuTheoThang(int thang, int nam)
        {
            var results = db.ThongKeDoanhSoCuaTatCaPKBTheoThang(thang, nam);
            return results.Select(r => new ET__TongDoanhThu(
              (float)r.TongDoanhThuThuoc,
              (float)r.TongDoanhThuPT_XNCC,
              (float)r.TongDoanhThuVienPhi,
              (float)r.TongDoanhThuTienKham,
              (float)r.TongTien,
              (float)r.TongTienBHYTChiTra,
              (float)r.TongTienConLai,
              r.NgayXuatTK)).ToList();
        }

        //Theo năm:
        //Xuất tiền hóa đơn của tất cả các phiếu khám bệnh theo năm
        public List<ET__XHDTatCaPKBTheoTime> XuatTienCuaTatCaCacPKBTheoNam(int nam)
        {
            var results = db.XuatTienHDCuaTatCaPKBTheoNam(nam);
            return results.Select(r => new ET__XHDTatCaPKBTheoTime(
              r.MaHD,
              r.MSPhieuKhamBenh,
              r.NgayXuatHD,
              (float)r.TienThuoc,
              (float)r.TienKham,
              (float)r.TienGiuong,
              (float)r.TienPT_XNCC,
              (float)r.TongTien,
              (float)r.TienBHYTChiTra,
              (float)r.TongTien)).ToList();
        }

        //Tổng doanh thu theo năm
        public List<ET__TongDoanhThu> ThongKeDoanhThuTheoNam(int nam)
        {
            var results = db.ThongKeDoanhSoCuaTatCaPKBTheoNam(nam);
            return results.Select(r => new ET__TongDoanhThu(
              (float)r.TongDoanhThuThuoc,
              (float)r.TongDoanhThuPT_XNCC,
              (float)r.TongDoanhThuVienPhi,
              (float)r.TongDoanhThuTienKham,
              (float)r.TongTien,
              (float)r.TongTienBHYTChiTra,
              (float)r.TongTienConLai,
              r.NgayXuatTK)).ToList();
        }
    }
}
