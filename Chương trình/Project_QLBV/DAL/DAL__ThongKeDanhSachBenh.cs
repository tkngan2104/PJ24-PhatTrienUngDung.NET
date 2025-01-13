using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL__ThongKeDanhSachBenh
    {
        // Khai báo biến tĩnh
        private static DAL__ThongKeDanhSachBenh instance;

        public static DAL__ThongKeDanhSachBenh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL__ThongKeDanhSachBenh();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        // Hiển thị danh sách thống kê nhờ mã bệnh
        public IQueryable HienThiDSThongKeNhoTen(string maBenh, DateTime dtpNgay)
        {
            var ds = from dl in db.ChuanDoans// truy vấn dữ liệu từ chuẩn đoán
                     join b in db.BenhLies // Kết Bệnh lý
                     on dl.MaBenh equals b.MaBenh
                     join pk in db.PhieuKhamBenhs//Kết thêm phiếu khám bệnh
                     on dl.MSPhieuKhamBenh equals pk.MSPhieuKhamBenh
                     join hs in db.HoSoBenhAns//Kết thêm hồ sơ bệnh án
                     on pk.MaHoSoBA equals hs.MaHoSoBA
                     join bn in db.BenhNhans// Kết thêm bệnh nhân
                     on hs.MSBN equals bn.MSBN
                     where dl.MaBenh == maBenh && pk.NgayKham.Value.Date.Year == dtpNgay.Date.Year// Lọc dữ liệu theo mã bệnh và năm được cung cấp
                     group bn by new { b.MaBenh, b.TenBenh } into gr// Nhóm theo mã bệnh và tên bệnh
                     select new
                     {
                         MaBenh = gr.Key.MaBenh,
                         TenBenh = gr.Key.TenBenh,
                         TongSoNam = gr.Count(g => g.GioiTinh == "Nam"),
                         TongSoNu = gr.Count(g => g.GioiTinh == "Nữ"),
                         TongSoBenhNhan = gr.Count()
                     };
            // Trả về kết quả truy vấn
            return ds;
        }
        // Hiển thị danh sách thống kê của danh sách bệnh theo năm
        public IQueryable HienThiDSThongKe(DateTime dtpNgay)
        {
            var ds = from dl in db.ChuanDoans//Truy vấn từ ChuanDoan
                     join b in db.BenhLies//Kết bảng BenhLy
                     on dl.MaBenh equals b.MaBenh
                     join pk in db.PhieuKhamBenhs//Kết thêm bảng phiếu khám bệnh
                     on dl.MSPhieuKhamBenh equals pk.MSPhieuKhamBenh
                     join hs in db.HoSoBenhAns//Kết thêm bảng HoSoBenhAn
                     on pk.MaHoSoBA equals hs.MaHoSoBA
                     join bn in db.BenhNhans //Kết thêm bảng BenhNhan
                     on hs.MSBN equals bn.MSBN
                     where pk.NgayKham.Value.Date.Year == dtpNgay.Date.Year//Lọc kết quả theo năm được cung cấp
                     group bn by new { b.MaBenh, b.TenBenh } into gr// Nhóm dữ liệu theo tên bệnh,mã bệnh
                     select new
                     {
                         TenBenh = gr.Key.TenBenh,
                         TongSoNam = gr.Count(g => g.GioiTinh == "Nam"),
                         TongSoNu = gr.Count(g => g.GioiTinh == "Nữ"),
                         TongSoBenhNhan = gr.Count()
                     };

            return ds;
        }
    }
}
