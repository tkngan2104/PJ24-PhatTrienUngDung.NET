using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoSoBenhAn
    {
        //Khai báo biến tĩnh
        private static DAL_HoSoBenhAn instance;
 

        public static DAL_HoSoBenhAn Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_HoSoBenhAn();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        // Xem danh sách hồ sơ bệnh án
        public IQueryable XemDSHoSoBA()
        {
            IQueryable dsHoSoBA = from ds in db.HoSoBenhAns
                                  select ds;
            return dsHoSoBA;
        }
        // Thêm hồ sơ bệnh án
        public bool ThemHoSoBA(ET_HoSoBenhAn etHoSoBA)
        {
            if (db.HoSoBenhAns.Any(hs => hs.MaHoSoBA == etHoSoBA.MaHoSoBA || hs.MSBN == etHoSoBA.MaBN))
            {
                return false;
            }
            else
            {
                try
                {
                    HoSoBenhAn hs = new HoSoBenhAn
                    {
                        MaHoSoBA = etHoSoBA.MaHoSoBA,
                        MSBN = etHoSoBA.MaBN,
                        NgayTao = etHoSoBA.NgayTao
                    };
                    db.HoSoBenhAns.InsertOnSubmit(hs);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }

        }
        //Xóa hồ sơ bệnh án
        public bool XoaHoSoBA(string maHoSoBA)
        {
            try
            {
                var xoa = from bn in db.HoSoBenhAns
                          where bn.MaHoSoBA == maHoSoBA
                          select bn;
                foreach (var x in xoa)
                {
                    db.HoSoBenhAns.DeleteOnSubmit(x);
                    db.SubmitChanges();
                }
                return true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }
        //Sửa hồ sơ bệnh án
        public void SuaHoSoBA(ET_HoSoBenhAn etHoSoBA)
        {
            var update = db.HoSoBenhAns.Single(t => t.MaHoSoBA == etHoSoBA.MaHoSoBA);
            if (update != null)
            {
                update.MSBN = etHoSoBA.MaBN;
                update.NgayTao = etHoSoBA.NgayTao;
                db.SubmitChanges();
            }
        }
        //Tạo mã hồ sơ bệnh án tự động
        public string GenerateHoSoBenhAnCode(string maBN)
        {
            // Lấy ngày hiện tại với định dạng yyyMMdd
            string datePrefix = DateTime.Now.ToString("yyyyMMdd");

            // Tạo chuỗi query để lấy số lượng hồ sơ với ngày hôm nay
            string query = $"HSBA-{datePrefix}";

            // Đếm số lượng mã hồ sơ bệnh án trong ngày hôm nay
            int countToday = db.HoSoBenhAns.Count(h => h.MaHoSoBA.StartsWith(query));

            // Tạo mã mới
            string newCode = $"BA-{datePrefix}{(countToday + 1).ToString("D4")}-{maBN}";

            return newCode;
        }
    }
}
