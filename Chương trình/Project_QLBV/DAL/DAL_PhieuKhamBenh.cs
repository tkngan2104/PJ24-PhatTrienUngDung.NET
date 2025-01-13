using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhieuKhamBenh
    {
        //Khai báo biến tĩnh
        private static DAL_PhieuKhamBenh instance;
        

        public static DAL_PhieuKhamBenh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_PhieuKhamBenh();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xem danh sách phiếu khám bệnh
        public IQueryable XemDSPhieuKhamBenh(string maHoSoBA)
        {
            IQueryable ds = from pkb in db.PhieuKhamBenhs
                            where pkb.MaHoSoBA == maHoSoBA
                            select pkb;
            return ds;
        }
        //Kiểm tra bệnh nhân có hồ sơ bệnh án chưa
        public bool KiemTraHoSoBACuaBN(string maBN)
        {
            if (db.HoSoBenhAns.Any(bn => bn.MSBN == maBN) == true)
            {
                return true;
            }
            return false;
        }
        //Thêm phiếu khám bệnh
        public bool ThemPhieuKhamBenh(ET_PhieuKhamBenh etPKB)
        {
            if (db.PhieuKhamBenhs.Any(pkb => pkb.MSPhieuKhamBenh == etPKB.MaSoPhieuKhamBenh && pkb.MaHoSoBA == etPKB.MaHoSoBA))
            {
                return false;
            }
            else
            {
                try
                {
                    PhieuKhamBenh pkb = new PhieuKhamBenh
                    {
                        MSPhieuKhamBenh = etPKB.MaSoPhieuKhamBenh,
                        NgayKham = etPKB.NgayKham,
                        MaHoSoBA = etPKB.MaHoSoBA,
                        TrieuChung = etPKB.TrieuChung,
                        BenhNen = etPKB.BenhNen,
                        MaLoaiKham = etPKB.MaLoaiKham
                    };
                    db.PhieuKhamBenhs.InsertOnSubmit(pkb);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
        //Xóa phiếu khám bệnh
        public bool XoaPhieuKhamBenh(string maSoPhieuKhamBenh)
        {
            try
            {
                var xoa = from ds in db.PhieuKhamBenhs
                          where ds.MSPhieuKhamBenh == maSoPhieuKhamBenh
                          select ds;
                foreach (var x in xoa)
                {
                    db.PhieuKhamBenhs.DeleteOnSubmit(x);
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
        //Sửa phiếu khám bệnh
        public void SuaPhieuKhamBenh(ET_PhieuKhamBenh etPKB)
        {
            var update = db.PhieuKhamBenhs.Single(t => t.MSPhieuKhamBenh == etPKB.MaSoPhieuKhamBenh);
            if (update != null)
            {
                update.NgayKham = etPKB.NgayKham;
                update.MaHoSoBA = etPKB.MaHoSoBA;
                update.TrieuChung = etPKB.TrieuChung;
                update.BenhNen = etPKB.BenhNen;
                update.MaLoaiKham = etPKB.MaLoaiKham;
                db.SubmitChanges();
            }
        }
        //Lấy mã hồ sơ bệnh án nhờ mã bệnh nhân
        public string layMaHoSoBANhoMaBN(string maBN)
        {
            var maBA = (from hs in db.HoSoBenhAns
                        where hs.MSBN == maBN
                        select hs.MaHoSoBA).FirstOrDefault();
            return maBA;
        }
        //Tạo mã phiếu khám bệnh tự động
        public string GeneratePhieuKhamBenhCode(string maBN)
        {
            // Lấy ngày hiện tại với định dạng yyyMMdd
            string datePrefix = DateTime.Now.ToString("yyyyMMdd");

            // Tạo chuỗi query để lấy số lượng hồ sơ với ngày hôm nay
            string query = $"PKB-{datePrefix}";

            // Đếm số lượng mã hồ sơ bệnh án trong ngày hôm nay
            int countToday = db.PhieuKhamBenhs.Count(h => h.MSPhieuKhamBenh.StartsWith(query));

            // Tạo mã mới
            string newCode = $"PKB{datePrefix}{(countToday + 1).ToString("D1")}-{maBN}";

            return newCode;
        }
    }
}
