using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL__XuatDSBNNoiTru
    {
        //Khai báo biến tĩnh
        private static DAL__XuatDSBNNoiTru instance;


        public static DAL__XuatDSBNNoiTru Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL__XuatDSBNNoiTru();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xuất danh sách bệnh nhân nội trú theo ngày
        public List<ET__XDSBenhNhanNoiTru> XuatDSBNTheoNgay(DateTime dtpNgay)
        {
            // Thực thi stored proceduce có tên 'LayDSBNNoiTruTheoNgay', truyền vào ngày,tháng,năm
            var results = db.LayDSBNNoiTruTheoNgay(dtpNgay);
            //Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XDSBenhNhanNoiTru
            return results.Select(r => new ET__XDSBenhNhanNoiTru(
             r.MSBN, r.TenBN, r.GioiTinh, r.NgSinh, r.SDT, r.MaSoBHYT, r.NgayNhanGiuong ?? DateTime.Now,
             r.NgayTraGiuong ?? DateTime.Now, r.TenBenh, r.TenPhong, r.MaGiuong, r.BenhNen,
             r.TrangThaiXuatVien, (int)r.TongSoCa, r.MaNV, r.MSPhieuKhamBenh)).ToList();
        }
        //Xuất danh sách bệnh nhân nội trú theo tháng
        public List<ET__XDSBenhNhanNoiTru> XuatDSBNTheoThang(int thang, int nam)
        {

            // Thực thi stored proceduce có tên 'LayDSBNNoiTruTheoNgay', truyền vào tháng,năm
            var results = db.LayDSBNNoiTruTheoThang(thang, nam);
            //Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XDSBenhNhanNoiTru
            return results.Select(r => new ET__XDSBenhNhanNoiTru(
             r.MSBN, r.TenBN, r.GioiTinh, r.NgSinh, r.SDT, r.MaSoBHYT, r.NgayNhanGiuong ?? DateTime.Now,
             r.NgayTraGiuong ?? DateTime.Now, r.TenBenh, r.TenPhong, r.MaGiuong, r.BenhNen,
             r.TrangThaiXuatVien, (int)r.TongSoCa, r.MaNV, r.MSPhieuKhamBenh)).ToList();
        }
        //Xuất danh sách bệnh nhân nội trú theo năm
        public List<ET__XDSBenhNhanNoiTru> XuatDSBNTheoNam(int nam)
        {
            // Thực thi stored proceduce có tên 'LayDSBNNoiTruTheoNgay', truyền vào năm
            var results = db.LayDSBNNoiTruTheoNam(nam);
            //Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XDSBenhNhanNoiTru
            return results.Select(r => new ET__XDSBenhNhanNoiTru(
             r.MSBN, r.TenBN, r.GioiTinh, r.NgSinh, r.SDT, r.MaSoBHYT, r.NgayNhanGiuong ?? DateTime.Now,
             r.NgayTraGiuong ?? DateTime.Now, r.TenBenh, r.TenPhong, r.MaGiuong, r.BenhNen,
             r.TrangThaiXuatVien, (int)r.TongSoCa, r.MaNV, r.MSPhieuKhamBenh)).ToList();
        }

        public List<ET__XDSBenhNhanNoiTru> XuatDSBNTheoKhoangThoiGian(DateTime tuNgay, DateTime denNgay)
        {
            var results = db.LayDSBNNoiTruTrongKhoangThoiGian(tuNgay, denNgay);
            return results.Select(r => new ET__XDSBenhNhanNoiTru(
             r.MSBN, r.TenBN, r.GioiTinh, r.NgSinh, r.SDT, r.MaSoBHYT, r.NgayNhanGiuong ?? DateTime.Now,
             r.NgayTraGiuong ?? DateTime.Now, r.TenBenh, r.TenPhong, r.MaGiuong, r.BenhNen,
             r.TrangThaiXuatVien, (int)r.TongSoCa, r.MaNV, r.MSPhieuKhamBenh)).ToList();
        }
    }
}
