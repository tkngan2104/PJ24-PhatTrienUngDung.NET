using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL__LayThongKeBenhCuThe
    {
        // Khai báo biến tĩnh
        private static DAL__LayThongKeBenhCuThe instance;

        public static DAL__LayThongKeBenhCuThe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL__LayThongKeBenhCuThe();
                }
                return instance;
            }
        }
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);

        //Xuất thống kê của 1 bệnh cụ thể
        public List<ET__LayThongKeCuTheBenh> XuatTKCuaBenhCuThe(string maBenh, int nam)
        {
            // Thực thi stored proceduce có tên 'LayTKCuaBenhCuThe', truyền vào mã bệnh và năm.
            var results = db.LayTKCuaBenhCuThe(maBenh, nam);
            // Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__LayThongKeCuTheBenh
            return results.Select(r => new ET__LayThongKeCuTheBenh(
                r.MaBenh,
                r.TenBenh,
                (int)r.SoLuongNam,
                (int)r.SoLuongNu,
                (int)r.TongSoLuong)).ToList();
        }
        // Lấy tình trạng sức khỏe của bệnh nhân
        public List<ET__LayTinhTrangSucKhoe> LayTinhTrangSKCuaBenhNhan(string maBenh, int nam)
        {
            // Thực thi stored proceduce có tên 'LayTinhTrangSKCuaBenhNhan', truyền vào mã bệnh và năm.
            var results = db.LayTinhTrangSKCuaBenhNhan(maBenh, nam);
            // Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__LayTinhTrangSucKhoe
            return results.Select(r => new ET__LayTinhTrangSucKhoe(
                r.MSPhieuKhamBenh,
                r.MSBN,
                r.TenBN,
                r.TenBenh,
                r.TinhTrangPhauThuat,
                r.GioiTinh)).ToList();
        }
        // Xuất thống kê của danh sách bệnh
        public List<ET__LayThongKeCuTheBenh> XuatTKCuaDSBenh(int nam)
        {
            // Thực thi stored proceduce có tên 'LayTinhTrangSKCuaBenhNhan', truyền vào năm.
            var results = db.LayTKCuaDSBenh(nam);
            // Ép kiểu dữ liệu thành một danh sách cụ thể của các đối tượng ET__LayTinhTrangSucKhoe
            return results.Select(r => new ET__LayThongKeCuTheBenh(
                r.MaBenh,
                r.TenBenh,
                (int)r.SoLuongNam,
                (int)r.SoLuongNu,
                (int)r.TongSoLuong)).ToList();
        }
    }
}
