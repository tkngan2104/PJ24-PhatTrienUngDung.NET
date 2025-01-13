using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Khoa
    {
        //Khai báo biến tĩnh
        private static DAL_Khoa instance;
 

        public static DAL_Khoa Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Khoa();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);

        //Xem danh sách khoa
        public IQueryable XemDSKhoa()
        {
            IQueryable khoa = from k in db.Khoas
                              select k;
            return khoa;
        }
        //Thêm khoa
        public bool ThemKhoa(ET_Khoa etKhoa)
        {
            if (db.Khoas.Any(k => k.MaKhoa == etKhoa.MaKhoa || k.TenKhoa == etKhoa.TenKhoa))
            {
                return false;
            }
            else
            {
                try
                {
                    Khoa k = new Khoa
                    {
                        MaKhoa = etKhoa.MaKhoa,
                        TenKhoa = etKhoa.TenKhoa
                    };
                    db.Khoas.InsertOnSubmit(k);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
        //Xóa khoa
        public bool XoaKhoa(string maKhoa)
        {
            try
            {
                var xoa = from k in db.Khoas
                          where k.MaKhoa == maKhoa
                          select k;
                foreach (var x in xoa)
                {
                    db.Khoas.DeleteOnSubmit(x);
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
        //Sửa khoa
        public bool SuaKhoa(ET_Khoa etKhoa)
        {
            ////updet từ mã khoa.
            //var update = db.Khoas.Single(k => k.MaKhoa == etKhoa.MaKhoa);
            //update.TenKhoa = etKhoa.TenKhoa;
            //db.SubmitChanges();

            var update = db.Khoas.Single(k => k.MaKhoa == etKhoa.MaKhoa || k.TenKhoa == etKhoa.TenKhoa);
            if (update != null)
            {
                update.TenKhoa = etKhoa.TenKhoa;
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
