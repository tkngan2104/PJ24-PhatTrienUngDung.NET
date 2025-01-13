using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiKham
    {
        //Khai báo biến tĩnh
        private static DAL_LoaiKham instance;
        

        public static DAL_LoaiKham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_LoaiKham();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);

        //Xem danh sách loại khám
        public IQueryable XemDSLoaiKham()
        {
            IQueryable dsLK = from ds in db.LoaiKhams
                              select ds;
            return dsLK;
        }
        //Thêm loại khám
        public bool ThemLoaiKham(ET_LoaiKham etLoaiKham)
        {
            if (db.LoaiKhams.Any(lk => lk.MaLoaiKham == etLoaiKham.MaLoaiKham || lk.TenLoaiKham == etLoaiKham.TenLoaiKham))
            {
                return false;
            }
            else
            {
                try
                {
                    LoaiKham lk = new LoaiKham
                    {
                        MaLoaiKham = etLoaiKham.MaLoaiKham,
                        TenLoaiKham = etLoaiKham.TenLoaiKham,
                        Gia = etLoaiKham.Gia
                    };
                    db.LoaiKhams.InsertOnSubmit(lk);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
        //Xóa loại khám
        public bool XoaLoaiKham(string maLoaiKham)
        {
            try
            {
                var xoa = from lk in db.LoaiKhams
                          where lk.MaLoaiKham == maLoaiKham
                          select lk;
                foreach (var i in xoa)
                {
                    db.LoaiKhams.DeleteOnSubmit(i);
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
        //Sửa loại khám
        public void SuaLoaiKham(ET_LoaiKham etLoaiKham)
        {
            var update = db.LoaiKhams.Single(lk => lk.MaLoaiKham == etLoaiKham.MaLoaiKham);
            update.TenLoaiKham = etLoaiKham.TenLoaiKham;
            update.Gia = etLoaiKham.Gia;
            db.SubmitChanges();
        }
    }
}
