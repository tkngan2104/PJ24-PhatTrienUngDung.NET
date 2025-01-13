using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL__TimKiemLichSuChuaTri
    {
        //Khai báo biến tĩnh
        private static DAL__TimKiemLichSuChuaTri instance;


        public static DAL__TimKiemLichSuChuaTri Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL__TimKiemLichSuChuaTri();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Tìm lịch sử  PT_XNCC của 1 PKB
        public IQueryable TimLichSuPT_XNCCCua1PKB(string maPKB)
        {
            IQueryable ds = from dl in db.LamPhauThuat_XNCCs//truy vấn dữ liệu từ bảng LamPT_XNCC
                            join dv in db.BangGias//Kết thêm bảng BangGia
                            on dl.MaLoaiChiTietDV equals dv.MaLoaiChiTietDV
                            join p in db.PhongKhams//Kết thêm bảng PhongKham
                            on dl.MSPhong equals p.MSPhong
                            where dl.MSPhieuKhamBenh == maPKB//Lọc theo mã phiếu khám bệnh được chỉ định
                            select new
                            {
                                p.TenPhong,
                                dv.TenLoaiChiTietDV,
                                dl.ThoiGianThucHien,
                                dl.KetQua,
                                dl.MucDoRuiRo
                            };
            //Trả về kết quả truy vấn
            return ds;
        }
        // Tìm lịch sử nằm viện của 1 PKB
        public IQueryable TimLichNamVienCua1PKB(string maPKB)
        {
            IQueryable ds = from dl in db.PhanGiuongs//Truy vấn dữ liệu từ bảng PhanGiuong
                            join dv in db.BangGias//Kết thêm bảng BangGia
                            on dl.MaLoaiChiTietDV equals dv.MaLoaiChiTietDV
                            join gb in db.GiuongBenhs//Kết thêm bảng GiuongBenh
                            on dl.MaGiuong equals gb.MaGiuong
                            join p in db.PhongKhams
                            on gb.MSPhong equals p.MSPhong
                            where dl.MSPhieuKhamBenh == maPKB// Lọc theo mã phiếu khám bệnh được chỉ định
                            select new
                            {
                                p.TenPhong,
                                dv.TenLoaiChiTietDV,
                                dl.MaGiuong,
                                dl.NgayNhanGiuong,
                                dl.NgayTraGiuong
                            };
            //Trả về kết quả truy vấn
            return ds;
        }

        // Tìm lịch khám của 1 PKB
        public IQueryable TimLichKhamCua1PKB(string maPKB)
        {
            IQueryable ds = from dl in db.Khams// Truy vấn dữ liệu từ bảng Kham
                            join pkb in db.PhieuKhamBenhs//Kết thêm bảng PhieuKhamBenh
                            on dl.MSPhieuKhamBenh equals pkb.MSPhieuKhamBenh
                            join p in db.PhongKhams//Kết thêm bảng PhongKham
                            on dl.MSPhong equals p.MSPhong
                            join nv in db.NhanViens//Kết thêm bảng NhanVien
                            on dl.MaNV equals nv.MaNV
                            where pkb.MSPhieuKhamBenh == maPKB//Lọc theo mã phiếu khám bệnh được chỉ định
                            select new
                            {
                                pkb.MSPhieuKhamBenh,
                                p.TenPhong,
                                dl.MaNV,
                                dl.MaNguoiYC
                            };
            //Trả về kết quả truy vấn
            return ds;
        }
        // Tìm toa thuốc của phiếu khám bệnh
        public IQueryable TimTTCua1PKB(string maPKB)
        {
            IQueryable ds = from pkb in db.PhieuKhamBenhs//Truy vấn dữ liệu từ bảng PhieuKhamBenh
                            join hs in db.HoSoBenhAns//Kết thêm bảng HoSoBenhAn
                            on pkb.MaHoSoBA equals hs.MaHoSoBA
                            join bn in db.BenhNhans//Kết thêm bảng BenhNhan
                            on hs.MSBN equals bn.MSBN
                            join cd in db.ChuanDoans//Kết thêm bảng ChuanDoan
                            on pkb.MSPhieuKhamBenh equals cd.MSPhieuKhamBenh
                            join benh in db.BenhLies//Kết thêm bảng BenhLy
                            on cd.MaBenh equals benh.MaBenh
                            join bhyt in db.BHYTs//Kết thêm bảng BHYT
                            on bn.MSBN equals bhyt.MSBN
                            where pkb.MSPhieuKhamBenh == maPKB//Lọc theo mã phiếu khám bệnh được chỉ định
                            select new
                            {
                                pkb.MSPhieuKhamBenh,
                                bn.MSBN,
                                bn.TenBN,
                                bn.GioiTinh,
                                bn.DiaChi,
                                bhyt.MaSoBHYT,
                                pkb.TrieuChung,
                                pkb.BenhNen,
                                benh.TenBenh,
                                cd.KetLuan,
                                cd.LoiKhuyen
                            };
            //Trả về kết quả truy vấn
            return ds;
        }

        //Tìm theo tên bệnh nhân:
        public IQueryable TimLichSuPT_XNCCTheoTenBN(string maBN)
        {
            IQueryable ds = from dl in db.LamPhauThuat_XNCCs//Truy vấn dữ liệu từ bảng LamPhauThuat_XNCC
                            join dv in db.BangGias//Kết thêm bảng BangGia
                            on dl.MaLoaiChiTietDV equals dv.MaLoaiChiTietDV
                            join p in db.PhongKhams//Kết thêm bảng PhongKham
                            on dl.MSPhong equals p.MSPhong
                            join pk in db.PhieuKhamBenhs//Kết thêm bảng PhieuKhamBenh
                            on dl.MSPhieuKhamBenh equals pk.MSPhieuKhamBenh
                            join hs in db.HoSoBenhAns//Kết thêm bảng HoSoBenhAn
                            on pk.MaHoSoBA equals hs.MaHoSoBA
                            join bn in db.BenhNhans//Kết thêm bảng BenhNhan
                            on hs.MSBN equals bn.MSBN
                            where bn.MSBN == maBN//Lọc theo mã bệnh nhân chỉ định
                            select new
                            {
                                pk.MSPhieuKhamBenh,
                                p.TenPhong,
                                dv.TenLoaiChiTietDV,
                                dl.ThoiGianThucHien,
                                dl.KetQua,
                                dl.MucDoRuiRo
                            };
            //Trả về kết quả truy vấn
            return ds;
        }
        // Tìm lịch nằm viện nhờ tên BN
        public IQueryable TimLichNamVienNhoTenBN(string maBN)
        {
            IQueryable ds = from dl in db.PhanGiuongs//Truy vấn dữ liệu từ bảng PhanGiuong
                            join dv in db.BangGias//Kết thêm bảng BangGia
                            on dl.MaLoaiChiTietDV equals dv.MaLoaiChiTietDV
                            join gb in db.GiuongBenhs//Kết thêm bảng GiuongBenh
                            on dl.MaGiuong equals gb.MaGiuong
                            join p in db.PhongKhams//Kết thêm bảng PhongKham
                            on gb.MSPhong equals p.MSPhong
                            join pk in db.PhieuKhamBenhs//Kết thêm bảng PhieuKhamBenh
                            on dl.MSPhieuKhamBenh equals pk.MSPhieuKhamBenh
                            join hs in db.HoSoBenhAns//Kết thêm bảng HoSoBenhAn
                            on pk.MaHoSoBA equals hs.MaHoSoBA
                            join bn in db.BenhNhans//Kết thêm bảng BenhNhan
                            on hs.MSBN equals bn.MSBN
                            where bn.MSBN == maBN//Lọc dữ liệu theo MaBN
                            select new
                            {
                                pk.MSPhieuKhamBenh,
                                p.TenPhong,
                                dv.TenLoaiChiTietDV,
                                dl.MaGiuong,
                                dl.NgayNhanGiuong,
                                dl.NgayTraGiuong
                            };
            //Trả về kết quả truy vấn
            return ds;
        }

        // Tìm lịch khám nhờ tên BN
        public IQueryable TimLichKhamNhoTenBN(string maBN)
        {
            IQueryable ds = from dl in db.Khams//Truy vấn dữ liệu từ bảng Kham
                            join pkb in db.PhieuKhamBenhs//Truy vấn dữ liệu từ bảng PhieuKhamBenh
                            on dl.MSPhieuKhamBenh equals pkb.MSPhieuKhamBenh
                            join p in db.PhongKhams//Kết thêm bảng PhongKham
                            on dl.MSPhong equals p.MSPhong
                            join nv in db.NhanViens//Kết thêm bảng NhanVien
                            on dl.MaNV equals nv.MaNV
                            join hs in db.HoSoBenhAns//Kết thêm bảng HoSoBenhAn
                            on pkb.MaHoSoBA equals hs.MaHoSoBA
                            join bn in db.BenhNhans//Kết thêm bảng BenhNhan
                            on hs.MSBN equals bn.MSBN
                            where bn.MSBN == maBN//Lọc theo mã bệnh nhân chỉ định
                            select new
                            {
                                pkb.MSPhieuKhamBenh,
                                p.TenPhong,
                                dl.MaNV,
                                dl.MaNguoiYC
                            };
            //Trả về kết quả truy vấn
            return ds;
        }
        //Tìm thông tin nhờ tên BN
        public IQueryable TimTTNhoTenBN(string maBN)
        {
            IQueryable ds = from pkb in db.PhieuKhamBenhs//Truy vấn dữ liệu từ bảng PhieuKhamBenh
                            join hs in db.HoSoBenhAns//Kết thêm bảng HoSoBenhAn
                            on pkb.MaHoSoBA equals hs.MaHoSoBA
                            join bn in db.BenhNhans//Kết thêm bảng BenhNhan
                            on hs.MSBN equals bn.MSBN
                            join cd in db.ChuanDoans//Kết thêm bảng ChuanDoan
                            on pkb.MSPhieuKhamBenh equals cd.MSPhieuKhamBenh
                            join benh in db.BenhLies//Kết thêm bảng BenhLy
                            on cd.MaBenh equals benh.MaBenh
                            join bhyt in db.BHYTs//Kết thêm bảng BHYT
                            on bn.MSBN equals bhyt.MSBN
                            where bn.MSBN == maBN// Lọc theo mã bệnh nhân được chỉ định
                            select new
                            {
                                pkb.MSPhieuKhamBenh,
                                bn.MSBN,
                                bn.TenBN,
                                bn.GioiTinh,
                                bn.DiaChi,
                                bhyt.MaSoBHYT,
                                pkb.TrieuChung,
                                pkb.BenhNen,
                                benh.TenBenh,
                                cd.KetLuan,
                                cd.LoiKhuyen
                            };
            //Trả về kết quả truy vấn
            return ds;
        }
        //Xem danh sách toa thuốc nhờ MaBN
        public IQueryable XemDSToaThuoc(string maBN)
        {
            IQueryable ds = from pkb in db.PhieuKhamBenhs// Truy vấn dữ liệu từ bảng PhieuKhamBenh
                            join tt in db.ToaThuocs//Kết thêm bảng ToaThuoc
                            on pkb.MSPhieuKhamBenh equals tt.MSPhieuKhamBenh
                            join t in db.Thuocs//Kết thêm bảng Thuoc
                            on tt.MSThuoc equals t.MSThuoc
                            join hs in db.HoSoBenhAns//Kết thêm bảng HoSoBenhAn
                            on pkb.MaHoSoBA equals hs.MaHoSoBA
                            join bn in db.BenhNhans//Kết thêm bảng BenhNhan
                            on hs.MSBN equals bn.MSBN
                            where bn.MSBN == maBN//Lọc theo mã bệnh nhân được chỉ định
                            select new { pkb.MSPhieuKhamBenh, tt.MaToaThuoc, t.MSThuoc, t.TenThuoc, tt.SoLuong, tt.GiaTien, tt.HDSuDung, tt.Tien, tt.NgayCap, tt.MaNV };
            //Trả về kết quả truy vấn
            return ds;
        }
    }
}
