using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL__TimKiemToaThuoc
    {
        //Khai báo biến tĩnh
        private static DAL__TimKiemToaThuoc instance;

        public static DAL__TimKiemToaThuoc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL__TimKiemToaThuoc();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Tìm toa thuốc nhờ mã toa
        public IQueryable XemDSToaThuocNhoMaToaThuoc(string maToaThuoc)
        {
            IQueryable ds = from dl in db.ToaThuocs//Truy vấn dữ liệu từ bảng ToaThuoc
                            where dl.MaToaThuoc == maToaThuoc//Lọc theo mã toa thuốc được chỉ định
                            select dl;
            //Trả về kết quả truy vấn
            return ds;
        }
        //Lấy danh sách toa thuốc nhờ mã phiếu khám bệnh
        public IQueryable XemDSToaThuocNhoMaPKB(string maPKB)
        {
            IQueryable ds = from dl in db.ToaThuocs//Truy vấn dữ liệu từ bảng ToaThuoc
                            where dl.MSPhieuKhamBenh == maPKB//Lọc theo mã phiếu khám bệnh được chỉ định
                            select dl;
            //Trả về kết quả truy vấn
            return ds;
        }
 
        public IQueryable XemDSToaThuocNhoPKB(string maPKB)
        {
            IQueryable ds = from dl in db.ToaThuocs
                            join pk in db.PhieuKhamBenhs
                            on dl.MSPhieuKhamBenh equals pk.MSPhieuKhamBenh
                            where pk.MSPhieuKhamBenh == maPKB
                            select dl;
            return ds;
        }
    }
}
