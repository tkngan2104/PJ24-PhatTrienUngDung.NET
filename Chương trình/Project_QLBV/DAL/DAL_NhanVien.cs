using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        //Khai báo biến tĩnh
        private static DAL_NhanVien instance;
       

        public static DAL_NhanVien Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_NhanVien();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xem Danh sách nhân viên
        public IQueryable XemDSNhanVien()
        {
            IQueryable dsNV = from nv in db.NhanViens
                              select nv;
            return dsNV;
        }
        // Thêm nhân viên
        public bool ThemNhanVien(ET_NhanVien etNhanVien)
        {
            if (db.NhanViens.Any(nv => nv.MaNV == etNhanVien.MaNV))
            {
                return false;
            }
            else
            {
                try
                {
                    NhanVien nv = new NhanVien
                    {
                        MaNV = etNhanVien.MaNV,
                        TenNV = etNhanVien.TenNV,
                        GioiTinh = etNhanVien.GioiTinh,
                        SDT = etNhanVien.SoDT,
                        Email = etNhanVien.Email,
                        NgayBatDauLam = etNhanVien.NgayBatDauLam,
                        MaKhoa = etNhanVien.MaKhoa,
                        MaCV = etNhanVien.MaCV
                    };
                    db.NhanViens.InsertOnSubmit(nv);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
        //Xóa nhân viên
        public bool XoaNhanVien(string maNV)
        {
            try
            {
                var xoa = from nv in db.NhanViens
                          where nv.MaNV == maNV
                          select nv;
                foreach (var x in xoa)
                {
                    db.NhanViens.DeleteOnSubmit(x);
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
        //Sửa nhân viên
        public void SuaNhanVien(ET_NhanVien etNhanVien)
        {
            var update = db.NhanViens.Single(t => t.MaNV == etNhanVien.MaNV);
            update.TenNV = etNhanVien.TenNV;
            update.GioiTinh = etNhanVien.GioiTinh;
            update.SDT = etNhanVien.SoDT;
            update.Email = etNhanVien.Email;
            update.NgayBatDauLam = etNhanVien.NgayBatDauLam;
            var khoaMoi = db.Khoas.SingleOrDefault(k => k.MaKhoa == etNhanVien.MaKhoa);
            if (khoaMoi != null)
            {
                update.Khoa = khoaMoi;
            }
            var chucVuMoi = db.ChucVus.SingleOrDefault(k => k.MaCV == etNhanVien.MaCV);
            if (chucVuMoi != null)
            {
                update.ChucVu = chucVuMoi;
            }
            db.SubmitChanges();
        }
    }
}
