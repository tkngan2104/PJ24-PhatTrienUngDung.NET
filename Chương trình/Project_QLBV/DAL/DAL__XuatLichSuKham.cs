using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL__XuatLichSuKham
    {
        //Khai báo biến tĩnh
        private static DAL__XuatLichSuKham instance;


        public static DAL__XuatLichSuKham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL__XuatLichSuKham();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Lấy danh sách lịch sử khám
        public List<ET__LichSuKham> LayDSLichSuKham(string maPKB)
        {
            //Thực thi stored proceduce có tên 'XuatLSKhamCuaPKB', truyền vào mã phiếu khám bệnh.
            var results = db.XuatLSKhamCuaPKB(maPKB);
            // Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__LichSuKham
            return results.Select(r => new ET__LichSuKham(
              r.TenPhong, r.MaNV, r.MaNguoiYC)).ToList();
        }
        //Lấy danh sách bệnh nhân chữa trị
        public List<ET__DSBenhNhanChuaTri> LayDSBNChuaTri(string maPKB)
        {
            //Thực thi stored proceduce có tên 'LayTKCuaBenhCuThe', truyền vào mã phiếu khám bệnh.
            var results = db.XuatLSTTCuaBN(maPKB);
            // Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__DSBenhNhanChuaTri
            return results.Select(r => new ET__DSBenhNhanChuaTri(
              r.MSBN, r.TenBenh, r.DiaChi, r.MaSoBHYT,
              r.GioiTinh, r.TrieuChung, r.BenhNen, r.TenBenh,
              r.KetLuan, r.LoiKhuyen)).ToList();
        }

        //Lấy danh sách tiền GB
        public List<ET__XHDGiuongBenh> XuatTienGB(string maPKB)
        {
            //Thực thi stored proceduce có tên 'XuatTienGBNhoTenBN', truyền vào mã phiếu khám bệnh.
            var results = db.XuatTienGBNhoTenBN(maPKB);
            // Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XHDGiuongBenh
            return results.Select(r => new ET__XHDGiuongBenh(
                r.TenPhongBenh,
                (int)r.SoGiuongBenh,
                r.NgayNhanGiuong ?? DateTime.Now,
                r.NgayTraGiuong ?? DateTime.Now,
                (float)(r.Gia ?? 0),
                (float)(r.TienGiuong ?? 0), r.MSPhieuKhamBenh)).ToList();
        }
        //Xuất toa thuốc nhờ PKB
        public List<ET__XHDToaThuoc> XuatToaThuoc(string maPKB)
        {
            //Thực thi stored proceduce có tên 'XuatToaThuocNhoTenBN', truyền vào mã phiếu khám bệnh
            var results = db.XuatToaThuocNhoTenBN(maPKB);
            //Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XHDToaThuoc
            return results.Select(r => new ET__XHDToaThuoc(
             r.TenThuoc, (int)r.SoLuong, (float)r.DonGia,
            (float)r.Tien, (float)r.TienThuoc, r.MaNV, r.HDSuDung, r.MSPhieuKhamBenh)).ToList();
        }
        //Xuất toa thuốc nhờ phiếu khám bệnh
        public List<ET__XHDToaThuoc> XuatToaThuocCuaPKB(string maPKB)
        {
            //Thực thi stored proceduce có tên 'XuatToaThuoc', truyền vào mã phiếu khám bệnh
            var results = db.XuatToaThuoc(maPKB);
            //Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XHDToaThuoc
            return results.Select(r => new ET__XHDToaThuoc(
             r.TenThuoc, (int)r.SoLuong, (float)r.DonGia,
             (float)r.Tien, (float)r.TienThuoc, r.MaNV, r.HDSuDung)).ToList();
        }
        //Xuất tiền PT_XNCC
        public List<ET__XHDXetNghiemPhauThuat> XuatTienPT_XNCC(string maPKB)
        {
            //Thực thi stored proceduce có tên 'XuatTienLamPT_XNCCNhoTenBN', truyền vào mã phiếu khám bệnh
            var results = db.XuatTienLamPT_XNCCNhoTenBN(maPKB);
            //Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XHDXetNghiemPhauThuat
            return results.Select(r => new ET__XHDXetNghiemPhauThuat(
              r.TenPhongPT_XNCC, r.ThoiGianThucHien ?? DateTime.Now,
              r.KetQua, (float)r.Gia, r.TenLoaiChiTietDV,
              (float)r.TienPT_XNCC, r.MSPhieuKhamBenh)).ToList();
        }
        //Lấy danh sách lịch sử khám nhờ tên bệnh nhân
        public List<ET__LichSuKham> LayDSLichSuKhamNhoTenBN(string maPKB)
        {
            //Thực thi stored proceduce có tên 'XuatLSKhamNhoTenBN', truyền vào mã phiếu khám bệnh
            var results = db.XuatLSKhamNhoTenBN(maPKB);
            //Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__LichSuKham
            return results.Select(r => new ET__LichSuKham(
              r.TenPhong, r.MaNV, r.MaNguoiYC, r.MSPhieuKhamBenh)).ToList();
        }
        //Lấy danh sách chữa trị nhờ tên bệnh nhân
        public List<ET__DSBenhNhanChuaTri> LayDSBNChuaTriNhoTenBN(string maPKB)
        {
            //Thực thi stored proceduce có tên 'XuatLSTTCuaBNNhoTenBN', truyền vào mã phiếu khám bệnh
            var results = db.XuatLSTTCuaBNNhoTenBN(maPKB);
            //Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__DSBenhNhanChuaTri
            return results.Select(r => new ET__DSBenhNhanChuaTri(
              r.MSBN, r.TenBenh, r.DiaChi, r.MaSoBHYT,
              r.GioiTinh, r.TrieuChung, r.BenhNen, r.TenBenh,
              r.KetLuan, r.LoiKhuyen, r.MSPhieuKhamBenh)).ToList();
        }
    }
}
