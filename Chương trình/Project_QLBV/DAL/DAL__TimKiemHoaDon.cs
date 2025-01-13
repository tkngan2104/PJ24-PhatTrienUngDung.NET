using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL__TimKiemHoaDon
    {
        //Khai báo biến tĩnh
        private static DAL__TimKiemHoaDon instance;

        public static DAL__TimKiemHoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL__TimKiemHoaDon();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Lấy hóa đơn nhờ phiếu khám bệnh
        public IQueryable TimKiemHoaDonNhoMaPKB(string maPKB)
        {
            IQueryable ds = from dl in db.HoaDons//Truy vấn dữ liệu từ bảng HoaDon
                            where dl.MSPhieuKhamBenh == maPKB//Lọc theo maPKB
                            select dl;
            //Trà về kết quả truy vấn
            return ds;
        }


        //Lấy Danh sách bệnh nhân nhờ tên bệnh nhân
        public IQueryable LayDSBenhNhan(string tenBN)
        {
            IQueryable ds = from dl in db.BenhNhans//Truy vấn dữ liệu từ bảng BenhNhan
                            where dl.TenBN == tenBN//Lọc theo tên BN
                            select dl;
            //Trả về kết quả truy vấn
            return ds;
        }
        //Lấy DS phiếu khám bệnh
        public IQueryable LayDSPKB(string maBN)
        {
            IQueryable ds = from dl in db.PhieuKhamBenhs//Truy vấn dữ liệu từ bảng PhieuKhamBenh
                            join hs in db.HoSoBenhAns//Kết thêm bảng HoSoBenhAn
                            on dl.MaHoSoBA equals hs.MaHoSoBA
                            where hs.MSBN == maBN//Lọc theo mã bệnh nhân được chỉ định
                            select dl;
            // Trả về kết quả truy vấn
            return ds;
        }
    }
}
