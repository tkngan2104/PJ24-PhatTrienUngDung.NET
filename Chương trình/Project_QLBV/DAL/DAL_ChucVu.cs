using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChucVu
    {
        //Khai báo biến tĩnh
        private static DAL_ChucVu instance;


        public static DAL_ChucVu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ChucVu();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Lấy danh sách chức vụ
        public IQueryable ListCV()
        {
            IQueryable cvu = from cv in db.ChucVus
                             select cv;
            return cvu;
        }
        //Thêm chức vụ
        public bool ThemCV(ET_ChucVu etCV)
        {
            if (db.ChucVus.Any(cv => cv.MaCV == etCV.MaCV || cv.TenCV == etCV.TenCV))
            {
                return false;
            }
            try
            {
                ChucVu cv = new ChucVu
                {
                    MaCV = etCV.MaCV,
                    TenCV = etCV.TenCV,
                };
                db.ChucVus.InsertOnSubmit(cv);
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
        //Xóa chức vụ
        public bool XoaCV(string maCV)
        {
            try
            {
                var xoa = from cv in db.ChucVus
                          where cv.MaCV == maCV
                          select cv;
                foreach (var x in xoa)
                {
                    db.ChucVus.DeleteOnSubmit(x);
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
                return false;
            }
        }
        //Sửa chức vụ
        public bool SuaCV(ET_ChucVu etCV)
        {
            if (db.ChucVus.Any(cv => cv.TenCV == etCV.TenCV))
            {
                return false;
            }
            try
            {
                var update = db.ChucVus.Single(cv => cv.MaCV == etCV.MaCV);
                update.TenCV = etCV.TenCV;
                db.SubmitChanges();
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
    }
}
