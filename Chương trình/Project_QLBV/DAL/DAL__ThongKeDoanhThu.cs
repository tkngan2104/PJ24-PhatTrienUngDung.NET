using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL__ThongKeDoanhThu
    {
        //Khai báo biến tĩnh
        private static DAL__ThongKeDoanhThu instance;


        public static DAL__ThongKeDoanhThu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL__ThongKeDoanhThu();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        // Thống kê doanh thu của từng phiếu khám bệnh theo ngày
        public IQueryable<ET__DoanhThu> LayDSThongKeDoanhThuNhoPKBTheoNgay(DateTime dtpNgay)
        {
            var ds = from pk in db.PhieuKhamBenhs//Truy vấn dữ liệu từ PhieuKhamBenh
                     join hd in db.HoaDons// Kết thêm bảng HoaDon
                     on pk.MSPhieuKhamBenh equals hd.MSPhieuKhamBenh
                     where hd.NgayXuatHD.Date == dtpNgay.Date//Lọc theo ngày được cung cấp
                     group hd by pk.MSPhieuKhamBenh into grouped// Nhóm theo mã số phiếu khám bệnh
                     select new ET__DoanhThu(
                         grouped.Key, // Giả sử MSPhieuKhamBenh là một chuỗi
                         grouped.Select(x => x.MSPhieuKhamBenh).Distinct().Count(),
                         (float)(grouped.Sum(hd => hd.TienPT_XNCC) ?? 0), // Chuyển đổi từ double? sang float và format số
                         (float)(grouped.Sum(hd => hd.TienThuoc) ?? 0), // Chuyển đổi và format số
                         (float)(grouped.Sum(hd => hd.TienGiuong) ?? 0), // Chuyển đổi và format số
                         (float)(grouped.Sum(hd => hd.TienKham) ?? 0), // Chuyển đổi và format số
                         (float)(grouped.Sum(hd => hd.TienBHYTChiTra) ?? 0), // Chuyển đổi và format số
                         (float)(grouped.Sum(hd => hd.TongTien) ?? 0), // Chuyển đổi và format số
                         (float)(grouped.Sum(hd => hd.TongTienSauKhiDaGiam) ?? 0) // Chuyển đổi và format số
                     );

            return ds;
        }
        // Tổng doanh thu theo ngày
        public List<ET__ThongKeDoanhThu> LayTongDoanhThuTheoNgay(DateTime dtp)
        {
            // Tính toán các tổng số tiền từ tất cả hóa đơn
            // Lọc hóa đơn theo ngày chỉ định, so sánh chỉ ngày mà không so giờ
            var hoaDonsThang = db.HoaDons
            .Where(hd => hd.NgayXuatHD.Date == dtp.Date);
            //Tính tổng tiền thuốc
            float tongTienThuoc = (float)(hoaDonsThang.Sum(hd => hd.TienThuoc) ?? 0);
            //Tính tổng tiền PT_XNCC
            float tongTienPT_XNCC = (float)(hoaDonsThang.Sum(hd => hd.TienPT_XNCC) ?? 0);
            //Tính tổng tiền viện phí
            float tongTienGB = (float)(hoaDonsThang.Sum(hd => hd.TienGiuong) ?? 0);
            //Tính tổng tiền khám
            float tongTienKham = (float)(hoaDonsThang.Sum(hd => hd.TienKham) ?? 0);
            //Tính tiền BHYT chi trả
            float tienBHYTChiTra = (float)(hoaDonsThang.Sum(hd => hd.TienBHYTChiTra) ?? 0);
            //Tính tổng tiền
            float tongTien = (float)(hoaDonsThang.Sum(hd => hd.TongTien) ?? 0);
            //Tính tổng tiền sau khi đã giảm
            float tongTienSauKhiDaGiam = (float)(hoaDonsThang.Sum(hd => hd.TongTienSauKhiDaGiam) ?? 0);
            // Tạo đối tượng thống kê doanh thu mới với các tổng tiền tính toán được
            ET__ThongKeDoanhThu doanhThu = new ET__ThongKeDoanhThu(
            tongTienThuoc,
                tongTienPT_XNCC,
                tongTienGB,
                tongTienKham,
                tienBHYTChiTra,
                tongTien,
                tongTienSauKhiDaGiam
            );
            // Tạo một danh sách và thêm thể hiện ET_TKDoanhThu mới tạo vào đó
            List<ET__ThongKeDoanhThu> doanhThuList = new List<ET__ThongKeDoanhThu>();
            doanhThuList.Add(doanhThu);

            return doanhThuList;
        }

        // Tổng doanh thu theo tháng
        public List<ET__ThongKeDoanhThu> LayTongDoanhThuTheoThang(DateTime dtp)
        {
            // Tính toán các tổng số tiền từ tất cả hóa đơn
            // Lọc hóa đơn theo tháng + năm chỉ định
            var hoaDonsThang = db.HoaDons
            .Where(hd => hd.NgayXuatHD.Month == dtp.Month && hd.NgayXuatHD.Year == dtp.Year);
            //Tính tổng tiền thuốc
            float tongTienThuoc = (float)(hoaDonsThang.Sum(hd => hd.TienThuoc) ?? 0);
            //Tính tổng tiền PT_XNCC
            float tongTienPT_XNCC = (float)(hoaDonsThang.Sum(hd => hd.TienPT_XNCC) ?? 0);
            //Tính tổng tiền viện phí
            float tongTienGB = (float)(hoaDonsThang.Sum(hd => hd.TienGiuong) ?? 0);
            //Tính tổng tiền khám
            float tongTienKham = (float)(hoaDonsThang.Sum(hd => hd.TienKham) ?? 0);
            //Tính tiền BHYT chi trả
            float tienBHYTChiTra = (float)(hoaDonsThang.Sum(hd => hd.TienBHYTChiTra) ?? 0);
            //Tính tổng tiền
            float tongTien = (float)(hoaDonsThang.Sum(hd => hd.TongTien) ?? 0);
            //Tính tổng tiền sau khi đã giảm
            float tongTienSauKhiDaGiam = (float)(hoaDonsThang.Sum(hd => hd.TongTienSauKhiDaGiam) ?? 0);
            // Tạo đối tượng thống kê doanh thu mới với các tổng tiền tính toán được
            ET__ThongKeDoanhThu doanhThu = new ET__ThongKeDoanhThu(
            tongTienThuoc,
                tongTienPT_XNCC,
                tongTienGB,
                tongTienKham,
                tienBHYTChiTra,
                tongTien,
                tongTienSauKhiDaGiam
            );

            // Tạo một danh sách và thêm thể hiện ET_TKDoanhThu mới tạo vào đó
            List<ET__ThongKeDoanhThu> doanhThuList = new List<ET__ThongKeDoanhThu>();
            doanhThuList.Add(doanhThu);

            return doanhThuList;
        }
        // Thống kê doanh thu theo năm
        public List<ET__ThongKeDoanhThu> LayTongDoanhThuTheoNam(DateTime dtp)
        {
            // Tính toán các tổng số tiền từ tất cả hóa đơn
            // Lọc hóa đơn theo năm chỉ định
            var hoaDonsThang = db.HoaDons
            .Where(hd => hd.NgayXuatHD.Year == dtp.Year);
            //Tính tổng tiền thuốc
            float tongTienThuoc = (float)(hoaDonsThang.Sum(hd => hd.TienThuoc) ?? 0);
            //Tính tổng tiền PT_XNCC
            float tongTienPT_XNCC = (float)(hoaDonsThang.Sum(hd => hd.TienPT_XNCC) ?? 0);
            //Tính tổng tiền viện phí
            float tongTienGB = (float)(hoaDonsThang.Sum(hd => hd.TienGiuong) ?? 0);
            //Tính tổng tiền khám
            float tongTienKham = (float)(hoaDonsThang.Sum(hd => hd.TienKham) ?? 0);
            //Tính tiền BHYT chi trả
            float tienBHYTChiTra = (float)(hoaDonsThang.Sum(hd => hd.TienBHYTChiTra) ?? 0);
            //Tính tổng tiền
            float tongTien = (float)(hoaDonsThang.Sum(hd => hd.TongTien) ?? 0);
            //Tính tổng tiền sau khi đã giảm
            float tongTienSauKhiDaGiam = (float)(hoaDonsThang.Sum(hd => hd.TongTienSauKhiDaGiam) ?? 0);
            // Tạo đối tượng thống kê doanh thu mới với các tổng tiền tính toán được
            ET__ThongKeDoanhThu doanhThu = new ET__ThongKeDoanhThu(
            tongTienThuoc,
                tongTienPT_XNCC,
                tongTienGB,
                tongTienKham,
                tienBHYTChiTra,
                tongTien,
                tongTienSauKhiDaGiam
            );

            // Tạo một danh sách và thêm thể hiện ET_TKDoanhThu mới tạo vào đó
            List<ET__ThongKeDoanhThu> doanhThuList = new List<ET__ThongKeDoanhThu>();
            doanhThuList.Add(doanhThu);

            return doanhThuList;
        }
        //Lấy thống kê doanh thu của phiếu khám bệnh theo tháng
        public IQueryable<ET__DoanhThu> LayDSThongKeDoanhThuNhoPKBTheoThang(DateTime dtpNgay)
        {
            
            var ds = from pk in db.PhieuKhamBenhs//truy vấn dữ liệu từ PhieuKhamBenh
                     join hd in db.HoaDons//Kết thêm bảng HoaDon
                     on pk.MSPhieuKhamBenh equals hd.MSPhieuKhamBenh
                     where hd.NgayXuatHD.Date.Month == dtpNgay.Month && hd.NgayXuatHD.Year == dtpNgay.Year// Lọc hóa đơn theo năm,tháng chỉ định
                     group hd by pk.MSPhieuKhamBenh into grouped// Nhóm theo MSPhieuKhamBenh
                     select new ET__DoanhThu(
                                  grouped.Key, // Giả sử MSPhieuKhamBenh là một chuỗi
                                  grouped.Select(x => x.MSPhieuKhamBenh).Distinct().Count(),
                                  (float)(grouped.Sum(hd => hd.TienPT_XNCC) ?? 0), // Chuyển đổi từ double? sang float và format số
                                  (float)(grouped.Sum(hd => hd.TienThuoc) ?? 0), // Chuyển đổi và format số
                                  (float)(grouped.Sum(hd => hd.TienGiuong) ?? 0), // Chuyển đổi và format số
                                  (float)(grouped.Sum(hd => hd.TienKham) ?? 0), // Chuyển đổi và format số
                                  (float)(grouped.Sum(hd => hd.TienBHYTChiTra) ?? 0), // Chuyển đổi và format số
                                  (float)(grouped.Sum(hd => hd.TongTien) ?? 0), // Chuyển đổi và format số
                                  (float)(grouped.Sum(hd => hd.TongTienSauKhiDaGiam) ?? 0) // Chuyển đổi và format số
                              );

            //Trả về kết quả truy vấn
            return ds;
        }

        //Lấy doanh thu theo năm
        public IQueryable<ET__DoanhThu> LayDSThongKeDoanhThuNhoPKBTheoNam(DateTime dtpNgay)
        {
            var ds = from pk in db.PhieuKhamBenhs//Truy vấn dữ liệu bảng PhieuKhamBenh
                     join hd in db.HoaDons//Kết thêm bảng HoaDon
                     on pk.MSPhieuKhamBenh equals hd.MSPhieuKhamBenh
                     where hd.NgayXuatHD.Year == dtpNgay.Year//Lọc theo năm được cung cấp
                     group hd by pk.MSPhieuKhamBenh into grouped//Nhóm theo MSPhieuKhamBenh theo nhóm
                     select new ET__DoanhThu(
                                  grouped.Key, // Giả sử MSPhieuKhamBenh là một chuỗi
                                  grouped.Select(x => x.MSPhieuKhamBenh).Distinct().Count(),
                                  (float)(grouped.Sum(hd => hd.TienPT_XNCC) ?? 0), // Chuyển đổi từ double? sang float và format số
                                  (float)(grouped.Sum(hd => hd.TienThuoc) ?? 0), // Chuyển đổi và format số
                                  (float)(grouped.Sum(hd => hd.TienGiuong) ?? 0), // Chuyển đổi và format số
                                  (float)(grouped.Sum(hd => hd.TienKham) ?? 0), // Chuyển đổi và format số
                                  (float)(grouped.Sum(hd => hd.TienBHYTChiTra) ?? 0), // Chuyển đổi và format số
                                  (float)(grouped.Sum(hd => hd.TongTien) ?? 0), // Chuyển đổi và format số
                                  (float)(grouped.Sum(hd => hd.TongTienSauKhiDaGiam) ?? 0) // Chuyển đổi và format số
                              );
            //Trả về kết quả truy vấn
            return ds;
        }
    }
}
