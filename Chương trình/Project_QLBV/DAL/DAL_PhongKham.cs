using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhongKham
    {
        //Khai báo biến tĩnh
        private static DAL_PhongKham instance;
        

        public static DAL_PhongKham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_PhongKham();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xem danh sách phòng khám
        public IQueryable XemDSPhongKham(string maKhoa)
        {
            IQueryable ds = from pk in db.PhongKhams
                            where pk.MaKhoa == maKhoa
                            select pk;
            return ds;
        }
        //Thêm phòng khám
        public bool ThemPhongKham(ET_PhongKham etPhongKham)
        {
            if (db.PhongKhams.Any(pk => pk.MSPhong == etPhongKham.MsPhong))
            {
                return false;
            }
            try
            {
                PhongKham pk = new PhongKham
                {
                    MSPhong = etPhongKham.MsPhong,
                    TenPhong = etPhongKham.TenPhong,
                    DiaDiem = etPhongKham.DiaDiem,
                    MaKhoa = etPhongKham.MaKhoa,
                    SoGiuong = etPhongKham.SoGiuong,
                    Loai = etPhongKham.Loai
                };
                db.PhongKhams.InsertOnSubmit(pk);
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
        //Xóa phòng khám
        public bool XoaPhongKham(string maPK)
        {
            try
            {
                var xoa = from pk in db.PhongKhams
                          where pk.MSPhong == maPK
                          select pk;
                foreach (var x in xoa)
                {
                    db.PhongKhams.DeleteOnSubmit(x);
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
        //Sửa phòng khám
        public void SuaPhongKham(ET_PhongKham etPK)
        {
            var update = db.PhongKhams.Single(pk => pk.MSPhong == etPK.MsPhong);
            update.TenPhong = etPK.TenPhong;
            update.DiaDiem = etPK.DiaDiem;
            update.MaKhoa = etPK.MaKhoa;
            update.SoGiuong = etPK.SoGiuong;
            update.Loai = etPK.Loai;
            db.SubmitChanges();
        }
    }
}
