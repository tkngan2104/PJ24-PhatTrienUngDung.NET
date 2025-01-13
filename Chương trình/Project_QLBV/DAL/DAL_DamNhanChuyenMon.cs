using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DamNhanChuyenMon
    {
        //Khai báo biến tĩnh
        private static DAL_DamNhanChuyenMon instance;
 

        public static DAL_DamNhanChuyenMon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_DamNhanChuyenMon();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xem danh sách đảm nhận
        public IQueryable XemDSDamNhan()
        {
            IQueryable ds = from dn in db.DamNhanChuyenMons
                            select dn;
            return ds;
        }
        //Thêm đảm nhận
        public bool ThemDamNhan(ET_DamNhanChuyenMon etDamNhan)
        {
            if (db.DamNhanChuyenMons.Any(dn => dn.MaChuyenNganh == etDamNhan.MaCN && dn.MaNV == etDamNhan.MaNV))
            {
                return false;
            }
            else
            {
                try
                {
                    DamNhanChuyenMon damNhan = new DamNhanChuyenMon
                    {
                        MaChuyenNganh = etDamNhan.MaCN,
                        MaNV = etDamNhan.MaNV,
                        KinhNghiem = etDamNhan.KinhNghiem
                    };
                    db.DamNhanChuyenMons.InsertOnSubmit(damNhan);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }

        }
        //Xóa đảm nhận
        public bool XoaDamNhan(string maCN, string maNV)
        {
            try
            {
                var xoa = from dn in db.DamNhanChuyenMons
                          where dn.MaChuyenNganh == maCN && dn.MaNV == maNV
                          select dn;
                foreach (var x in xoa)
                {
                    db.DamNhanChuyenMons.DeleteOnSubmit(x);
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
        //Sửa đảm nhận
        public void SuaDamNhan(ET_DamNhanChuyenMon etDamNhan)
        {
            var update = db.DamNhanChuyenMons.Single(t => t.MaChuyenNganh == etDamNhan.MaCN && t.MaNV == etDamNhan.MaNV);
            if (update != null)
            {
                update.KinhNghiem = etDamNhan.KinhNghiem;
                db.SubmitChanges();
            }
        }
        //Lấy danh sách chuyên ngành từ mã nhân viên
        public IQueryable LayDSChuyenNganhNhoMaNV(string maNV)
        {
            string[] excludedKhoa = { "K17", "K30" };
            string maKhoa = db.NhanViens
                .Where(nv => nv.MaNV == maNV && !excludedKhoa.Contains(nv.MaKhoa))
                .Select(nv => nv.MaKhoa)
                .FirstOrDefault();
            IQueryable ds = from cn in db.ChuyenNganhs
                            where cn.MaKhoa == maKhoa
                            select new { cn.MaChuyenNganh, cn.TenChuyenNganh };

            return ds;
        }
        //Lấy danh sách nhân viên trừ khoa K17 VÀ K30
        public IQueryable LayDSNVC()
        {
            IQueryable ds = from dl in db.NhanViens
                            where dl.MaKhoa != "K17" && dl.MaKhoa != "K30"
                            select dl;
            return ds;
        }
        //Tính kinh nghiệm 
        public void HamCapNhapKinhNghiem(DateTime dtpNgayLam, string maNV, string maCN)
        {
            var today = DateTime.Now; // Lấy ngày hiện tại
            var query = from kn in db.DamNhanChuyenMons
                        where kn.MaChuyenNganh == maCN && kn.MaNV == maNV
                        select kn;

            foreach (var kn in query)
            {
                // Tính tháng làm việc từ ngày làm đến hiện tại
                int thangLam = ((today.Year - dtpNgayLam.Year) * 12) + today.Month - dtpNgayLam.Month;

                // Cập nhật năm và tháng làm việc
                if (thangLam >= 12)
                {
                    kn.KinhNghiem = (thangLam / 12) + " Năm " + (thangLam % 12) + " Tháng";
                }
                else
                {
                    kn.KinhNghiem = thangLam + " Tháng";
                }

            }

            // Lưu các thay đổi vào cơ sở dữ liệu
            db.SubmitChanges();
        }
    }
}
