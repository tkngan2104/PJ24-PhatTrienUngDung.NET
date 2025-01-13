using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL__XuatHoaDon
    {
        //Khai báo biến tĩnh
        private static DAL__XuatHoaDon instance;

        public static DAL__XuatHoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL__XuatHoaDon();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Lấy hóa đơn nhờ PKB
        public List<ET_HoaDon> LayTTHD(string maPKB)
        {
            // Thực thi stored proceduce có tên 'XuatTienHD', truyền vào mã phiếu khám bệnh.
            var results = db.XuatTienHD(maPKB);
            //Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET_HoaDon
            return results.Select(r => new ET_HoaDon(
              r.MSPhieuKhamBenh,
              r.MaHD,
              r.NgayXuatHD,
              (float)(r.TienThuoc ?? 0),
              (float)(r.TienKham ?? 0),
              (float)(r.TienGiuong ?? 0),
              (float)(r.TienPT_XNCC ?? 0),
              (float)(r.TongTien ?? 0),
              (float)(r.TienBHYTChiTra ?? 0),
              (float)(r.TongTienSauKhiDaGiam ?? 0))).ToList();
        }
        //Xuất thông tin giường bệnh
        public List<ET__XHDGiuongBenh> XuatTienGB(string maPKB)
        {
            // Thực thi stored proceduce có tên 'XuatTienGB', truyền vào mã phiếu khám bệnh
            var results = db.XuatTienGB(maPKB);
            // Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XHDGiuongBenh
            return results.Select(r => new ET__XHDGiuongBenh(
                r.TenPhongBenh,
                r.SoGiuongBenh,
                r.NgayNhanGiuong ?? DateTime.Now,
                r.NgayTraGiuong ?? DateTime.Now,
                (float)r.Gia,
                (float)r.TienGiuong)).ToList();
        }
        //Xuất toa thuốc
        public List<ET__XHDToaThuoc> XuatToaThuoc(string maPKB)
        {
            // Thực thi stored proceduce có tên 'XuatToaThuoc', truyền vào mã phiếu khám bệnh
            var results = db.XuatToaThuoc(maPKB);
            // Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XHDToaThuoc
            return results.Select(r => new ET__XHDToaThuoc(
              r.TenThuoc, (int)(r.SoLuong ?? 0), (float)r.DonGia
             , (float)(r.Tien ?? 0),
              (float)(r.TienThuoc ?? 0), r.MaNV, r.HDSuDung, r.TenBenh)).ToList();
        }
        //Xuất toa thuốc nhờ mã toa thuốc
        public List<ET__XHDToaThuoc> XuatToaThuocNhoMaTT(string maTT)
        {
            //Thực thi stored proceduce có tên 'XuatToaThuocNhoMaTT', truyền vào mã toa thuốc
            var results = db.XuatToaThuocNhoMaTT(maTT);
            // Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XHDToaThuoc
            return results.Select(r => new ET__XHDToaThuoc(
              r.TenThuoc, (int)(r.SoLuong ?? 0), (float)r.DonGia
             , (float)(r.Tien ?? 0),
              (float)(r.TienThuoc ?? 0), r.MaNV, r.HDSuDung, r.TenBenh)).ToList();
        }
        //Xuất tiền PT_XNCC
        public List<ET__XHDXetNghiemPhauThuat> XuatTienPT_XNCC(string maPKB)
        {
            //Thực thi stored proceduce có tên 'XuatTienLamPT_XNCC', truyền vào mã phiếu khám bệnh

            var results = db.XuatTienLamPT_XNCC(maPKB);
            // Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XHDXetNghiemPhauThuat
            return results.Select(r => new ET__XHDXetNghiemPhauThuat(
              r.TenPhongPT_XNCC, r.ThoiGianThucHien ?? DateTime.Now,
              r.KetQua, (float)r.Gia, r.TenLoaiChiTietDV,
              (float)r.TienPT_XNCC)).ToList();
        }

        public List<ET__LayThongTinBenhNhan> LayTTBenhNhan(string maPKB)
        {
            try
            {
                var results = db.XuatTTCuaBN(maPKB);
                return results.Select(r => new ET__LayThongTinBenhNhan(
                 r.MSBN, r.TenBN, r.DiaChi, r.MaSoBHYT, r.GioiTinh)).ToList();
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately
                throw new ApplicationException("Error fetching patient data", ex);
            }

        }
    }
}
