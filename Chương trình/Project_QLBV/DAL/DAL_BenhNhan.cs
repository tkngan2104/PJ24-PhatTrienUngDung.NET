using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BenhNhan
    {
        private static DAL_BenhNhan instance;


        public static DAL_BenhNhan Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_BenhNhan();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xem danh sách bệnh nhân
        public IQueryable XemDSBN()
        {
            IQueryable benhnhan = from bn in db.BenhNhans//Truy vấn dữ liệu từ bảng BenhNhan
                                  orderby bn.MSBN descending
                                  select bn;
            //Trả về kết quả truy vấn
            return benhnhan;
        }
        //Thêm bệnh nhân
        public bool ThemBenhNhan(ET_BenhNhan etBN)
        {
            //Kiểm tra xem có trùng MaSoBN không nếu trùng trả về false
            if (db.BenhNhans.Any(bn => bn.MSBN == etBN.MaSoBN))
            {
                // Nếu tồn tại, trả về false để báo hiệu việc thêm không thành công do trùng lặp
                return false;
            }
            else
            {
                try
                {
                    // Tạo một đối tượng mới của BenhNhan
                    BenhNhan bn = new BenhNhan
                    {
                        MSBN = etBN.MaSoBN,
                        TenBN = etBN.TenBN,
                        GioiTinh = etBN.GioiTinh,
                        NgSinh = etBN.NgaySinh,
                        DiaChi = etBN.DiaChi,
                        NgheNghiep = etBN.NgheNghiep,
                        SDT = etBN.SoDienThoai,
                        CCCD = etBN.Cccd,
                        TTLienHe = etBN.TtLienHe
                    };
                    // Thêm bệnh nhân vào cơ sở dữ liệu
                    db.BenhNhans.InsertOnSubmit(bn);
                }
                finally
                {
                    // Lưu các thay đổi vào cơ sở dữ liệu
                    db.SubmitChanges();
                }
                // Trả về true để báo hiệu việc thêm mới thành công
                return true;
            }
        }
        //Xóa bệnh nhân
        public bool XoaBenhNhan(string msBN)
        {
            try
            {
                // Truy vấn lấy tất cả các bản ghi trong BangGias có MSBN bằng với msBN
                var xoa = from bn in db.BenhNhans
                          where bn.MSBN == msBN
                          select bn;
                // Duyệt qua từng bản ghi và xóa chúng khỏi cơ sở dữ liệu
                foreach (var x in xoa)
                {
                    db.BenhNhans.DeleteOnSubmit(x);
                    db.SubmitChanges();
                }
                // Nếu xóa thành công, trả về true
                return true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                // Xử lý các trường hợp ngoại lệ cụ thể, chẳng hạn liên quan đến ràng buộc khóa ngoại
                if (ex.Number == 547)
                {
                    // Trả về false nếu có lỗi do ràng buộc khóa ngoại
                    return false;
                }
                return false;
            }
        }
        //Sửa bệnh nhân
        public void SuaBenhNhan(ET_BenhNhan etBN)
        {
            // Tìm đối tượng BenhNhans trong cơ sở dữ liệu dựa trên MaSoBN
            var update = db.BenhNhans.Single(bn => bn.MSBN == etBN.MaSoBN);
            // Cập nhật dựa trên thông tin nhận được
            update.TenBN = etBN.TenBN;
            update.GioiTinh = etBN.GioiTinh;
            update.NgSinh = etBN.NgaySinh;
            update.DiaChi = etBN.DiaChi;
            update.NgheNghiep = etBN.NgheNghiep;
            update.SDT = etBN.SoDienThoai;
            update.CCCD = etBN.Cccd;
            update.TTLienHe = etBN.TtLienHe;
            // Lưu các thay đổi vào cơ sở dữ liệu
            db.SubmitChanges();
        }
        //Lấy tên bệnh nhân nhờ mã bệnh nhân
        public string LayTenBNNhoMaBN(string maBN)
        {
            var tenBN = (from bn in db.BenhNhans
                         where bn.MSBN == maBN
                         select bn.TenBN).FirstOrDefault();

            return tenBN;
        }
        //Lấy mã bệnh nhân nhờ kiểm tra có hồ sơ bệnh án chưa
        public bool KiemTraBNCoHSBAChua(string maBN)
        {
           //Trà về true nếu bệnh nhân có rồi
            return db.HoSoBenhAns.Any(hs => hs.MSBN == maBN);
        }
        //Tìm kiếm bệnh nhân
        public IQueryable TimKiemBenhNhan(string tenBN, string sdt, string cccd)
        {
            // Truy vấn bệnh nhân dựa trên tenBN,sdt hay cccd
            IQueryable ds = from dl in db.BenhNhans
                            where (tenBN == null || dl.TenBN == tenBN) ||
                                  (sdt == null || dl.SDT == sdt) ||
                                  (cccd == null || dl.CCCD == cccd)
                            select dl;
            //Trả về kết quả truy vấn
            return ds;
        }
    }
}
