using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL__XuatDSKhamTheoTime
    {
        //Khai báo biến tĩnh
        private static DAL__XuatDSKhamTheoTime instance;


        public static DAL__XuatDSKhamTheoTime Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL__XuatDSKhamTheoTime();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Lấy danh sách lịch sử khám theo ngày/tháng/năm
        public List<ET__XDSKhamTheoTime> LayDSLichSuKham(DateTime dtpNgay)
        {
            // Thực thi stored proceduce có tên 'XuatDSSoLuongTheoNgay', truyền vào ngày,tháng,năm
            var results = db.XuatDSSoLuongTheoNgay(dtpNgay);
            // Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XDSKhamTheoTime
            return results.Select(r => new ET__XDSKhamTheoTime(
              r.MSPhong, r.TenPhong, r.TenKhoa,
              r.MSBN, r.TenBN, r.MSPhieuKhamBenh, r.NgayKham ?? DateTime.Now)).ToList();
        }
        //Lấy danh sách lịch sử khám theo tháng và năm
        public List<ET__XDSKhamTheoTime> LayDSKhamTheoThang(int thang, int nam)
        {
            // Thực thi stored proceduce có tên 'XuatDSSoLuongTheoThangNam', truyền vào tháng,năm
            var results = db.XuatDSSoLuongTheoThangNam(thang, nam);
            // Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XDSKhamTheoTime
            return results.Select(r => new ET__XDSKhamTheoTime(
              r.MSPhong, r.TenPhong, r.TenKhoa,
              r.MSBN, r.TenBN, r.MSPhieuKhamBenh, r.NgayKham ?? DateTime.Now)).ToList();
        }
        // Lấy danh sách lịch sử khám theo năm
        public List<ET__XDSKhamTheoTime> LayDSKhamTheoNam(int nam)
        {
            // Thực thi stored proceduce có tên 'XuatDSSoLuongTheoNam', truyền vào năm
            var results = db.XuatDSSoLuongTheoNam(nam);
            // Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__XDSKhamTheoTime
            return results.Select(r => new ET__XDSKhamTheoTime(
              r.MSPhong, r.TenPhong, r.TenKhoa,
              r.MSBN, r.TenBN, r.MSPhieuKhamBenh, r.NgayKham ?? DateTime.Now)).ToList();
        }
    }
}
