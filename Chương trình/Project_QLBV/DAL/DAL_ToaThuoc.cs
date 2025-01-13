using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ToaThuoc
    {
        //Khai báo biến tĩnh
        private static DAL_ToaThuoc instance;
        

        public static DAL_ToaThuoc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ToaThuoc();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xem danh sách toa thuốc
        public IQueryable XemDSToaThuoc(string maPKB)
        {
            IQueryable ds = from pkb in db.PhieuKhamBenhs
                            join tt in db.ToaThuocs
                            on pkb.MSPhieuKhamBenh equals tt.MSPhieuKhamBenh
                            join t in db.Thuocs
                            on tt.MSThuoc equals t.MSThuoc
                            where pkb.MSPhieuKhamBenh == maPKB
                            select new { tt.MaToaThuoc, t.MSThuoc, t.TenThuoc, tt.SoLuong, tt.GiaTien, tt.HDSuDung, tt.Tien, tt.NgayCap, tt.MaNV };
            return ds;
        }
        //Thêm thuốc vô toa
        public bool ThemThuocVoToa(ET_ToaThuoc etToaThuoc)
        {
            if (db.ToaThuocs.Any(lk => lk.MaToaThuoc == etToaThuoc.MaToaThuoc && lk.MSThuoc == etToaThuoc.MsThuoc))
            {
                return false;
            }
            else
            {
                try
                {
                    ToaThuoc toaThuoc = new ToaThuoc
                    {
                        MaToaThuoc = etToaThuoc.MaToaThuoc,
                        MaChuanDoan = etToaThuoc.MaChuanDoan,
                        MSPhieuKhamBenh = etToaThuoc.MsPhieuKhamBenh,
                        MSThuoc = etToaThuoc.MsThuoc,
                        SoLuong = etToaThuoc.SoLuong,
                        GiaTien = etToaThuoc.GiaTien,
                        NgayCap = etToaThuoc.NgayCap,
                        HDSuDung = etToaThuoc.HuongDanSD,
                        MaNV = etToaThuoc.MaNV,

                    };
                    db.ToaThuocs.InsertOnSubmit(toaThuoc);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }

        //Xóa thuốc khỏi toa
        public bool XoaThuocKhoiToa(string maTT, string maThuoc)
        {
            try
            {
                var xoa = from tt in db.ToaThuocs
                          where tt.MaToaThuoc == maTT && tt.MSThuoc == maThuoc
                          select tt;
                foreach (var i in xoa)
                {
                    db.ToaThuocs.DeleteOnSubmit(i);
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
        //Lấy danh sách thuốc
        public List<string> LayDSThuoc()
        {
            var ds = (from t in db.Thuocs
                      select t.TenThuoc).ToList();
            return ds;
        }
        //Lấy mã thuốc nhờ tên thuốc
        public string LayMaThuocNhoTenThuoc(string tenThuoc)
        {
            var truyVan = (from maThuoc in db.Thuocs
                           where maThuoc.TenThuoc == tenThuoc
                           select maThuoc.MSThuoc).FirstOrDefault();
            return truyVan;
        }
        //Lấy tên thuốc nhờ mã thuốc
        public string LayTenThuocNhoMaThuoc(string maThuoc)
        {
            var truyVan = (from t in db.Thuocs
                           where t.MSThuoc == maThuoc
                           select t.TenThuoc).FirstOrDefault();
            return truyVan;
        }
        //Lấy chuẩn đoán nhờ phiếu khám bệnh
        public string LayMaCDNhoPKB(string maPKB)
        {
            var truyVan = (from t in db.ChuanDoans
                           where t.MSPhieuKhamBenh == maPKB
                           select t.MaChuanDoan).FirstOrDefault();
            return truyVan;
        }
        //Lấy phiếu khám bệnh có chuẩn đoán
        public IQueryable LayPKBCoChuanDoan()
        {
            IQueryable ds = from pkb in db.PhieuKhamBenhs
                            join cd in db.ChuanDoans
                            on pkb.MSPhieuKhamBenh equals cd.MSPhieuKhamBenh
                            select cd;
            return ds;
        }
        // Lấy danh sách giá tiền của thuốc
        public float LayDSGiaTienCuaThuoc(string maThuoc)
        {
            float giaTien = (float)(from t in db.Thuocs
                                    where t.MSThuoc == maThuoc
                                    select t.DonGia).FirstOrDefault();
            return giaTien;
        }
        //Lấy chuẩn đoán của phiếu khám bệnh
        public string LayChuanDoanCuaPKB(string maPKB)
        {
            var truyVan = (from t in db.ChuanDoans
                           join b in db.BenhLies
                           on t.MaBenh equals b.MaBenh
                           where t.MSPhieuKhamBenh == maPKB
                           select b.TenBenh).FirstOrDefault();
            return truyVan;
        }
        //Đổ dữ liệu nhân viên khoa dược lên ComboBox
        public IQueryable DoDLNVKhoaDuocLenCB()
        {
            IQueryable ds = from nv in db.NhanViens
                            where nv.MaKhoa == "K17" && nv.MaCV == "CV04"
                            select nv;
            return ds;
        }
        //Cập nhập tiền của toa thuốc
        public void CapNhapTienCuaTThuoc()
        {
            float tien = 0;
            var dsTT = from ds in db.ToaThuocs
                       select ds;
            foreach (var item in dsTT)
            {
                tien = (float)(item.SoLuong * item.Thuoc.DonGia);
                item.Tien = tien;
            }
            db.SubmitChanges();
        }
        //Cập nhập giá tiền
        public void CapNhapGiaTien()
        {
            var dsTT = from ds in db.ToaThuocs
                       select ds;
            foreach (var item in dsTT)
            {
                if (item.MSThuoc == item.Thuoc.MSThuoc)
                {
                    item.GiaTien = item.Thuoc.DonGia;
                }
            }
            db.SubmitChanges();
        }
        //Tạo mã toa thuốc
        public string GenerateToaThuocCode(string maPK)
        {
            string toaThuocCode = $"TT-{maPK}";
            return toaThuocCode;
        }
    }
}
