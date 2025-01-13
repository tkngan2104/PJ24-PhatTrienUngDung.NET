using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Thuoc
    {
        //Khai báo biến tĩnh
        private static DAL_Thuoc instance;
        

        public static DAL_Thuoc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Thuoc();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xem danh sách thuốc
        public IQueryable ListTHUOC()
        {
            IQueryable thuoc = from t in db.Thuocs
                               select t;
            return thuoc;
        }
        //Thêm thuốc
        public bool ThemThuoc(ET_Thuoc etThuoc)
        {
            if (db.Thuocs.Any(t => t.MSThuoc == etThuoc.MaThuoc))
            {
                return false;
            }
            else
            {
                try
                {
                    Thuoc t = new Thuoc
                    {
                        MSThuoc = etThuoc.MaThuoc,
                        TenThuoc = etThuoc.TenThuoc,
                        DangThuoc = etThuoc.DangThuoc,
                        DonViTinh = etThuoc.DonViTinh,
                        DonGia = etThuoc.DonGia,
                        Xuatxu = etThuoc.XuatXu,
                    };
                    db.Thuocs.InsertOnSubmit(t);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
        //Xóa thuốc
        public bool XoaThuoc(string maThuoc)
        {
            try
            {
                var xoa = from t in db.Thuocs
                          where t.MSThuoc == maThuoc
                          select t;
                foreach (var x in xoa)
                {
                    db.Thuocs.DeleteOnSubmit(x);
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
        //Sửa thuốc
        public void SuaThuoc(ET_Thuoc etThuoc)
        {
            //update từ mã thuốc.
            var update = db.Thuocs.Single(t => t.MSThuoc == etThuoc.MaThuoc);
            update.TenThuoc = etThuoc.TenThuoc;
            update.DangThuoc = etThuoc.DangThuoc;
            update.DonViTinh = etThuoc.DonViTinh;
            update.Xuatxu = etThuoc.XuatXu;
            update.DonGia = etThuoc.DonGia;
            db.SubmitChanges();
        }
    }
}
