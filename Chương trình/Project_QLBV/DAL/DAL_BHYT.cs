using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BHYT
    {
        //Khai báo biến tĩnh
        private static DAL_BHYT instance;


        public static DAL_BHYT Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_BHYT();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xem danh sách BHYT
        public IQueryable XemBHYT()
        {
            IQueryable dsBHYT = from ds in db.BHYTs
                                select ds;
            //Trả về kết quả truy vấn
            return dsBHYT;
        }
        //Thêm BHYT
        public bool ThemBHYT(ET_BHYT etBHYT)
        {
            if (db.BHYTs.Any(bhyt => bhyt.MSBN == etBHYT.MaBN || bhyt.MaSoBHYT == etBHYT.MaBHYT))
            {
                return false;
            }
            else
            {
                try
                {
                    // Tạo một đối tượng mới của BHYT
                    BHYT baoHiemYTe = new BHYT
                    {
                        MaSoBHYT = etBHYT.MaBHYT,
                        NgayCap = etBHYT.NgayCap,
                        NgayHetHan = etBHYT.NgayHetHan = etBHYT.NgayCap.AddYears(5),
                        MSBN = etBHYT.MaBN
                    };
                    // Thêm BHYT mới vào cơ sở dữ liệu
                    db.BHYTs.InsertOnSubmit(baoHiemYTe);
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
        //Xóa BHYT
        public bool XoaBHYT(string maBHYT)
        {
            try
            {
                // Truy vấn lấy tất cả các bản ghi trong BangGias có MaSoBHYT bằng với maBHYT
                var xoa = from bh in db.BHYTs
                          where bh.MaSoBHYT == maBHYT
                          select bh;
                // Duyệt qua từng bản ghi và xóa chúng khỏi cơ sở dữ liệu
                foreach (var x in xoa)
                {
                    db.BHYTs.DeleteOnSubmit(x);
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
                else
                {
                    return false;
                }
            }
        }
        //Sửa BHYT
        public void SuaBHYT(ET_BHYT etBHYT)
        {
            // Tìm đối tượng BHYT trong cơ sở dữ liệu dựa trên mã dịch vụ
            var update = db.BHYTs.Single(t => t.MaSoBHYT == etBHYT.MaBHYT);
            if (update != null)
            {
                // Cập nhật dịch vụ dựa trên thông tin nhận được
                update.NgayCap = etBHYT.NgayCap;
                update.NgayHetHan = etBHYT.NgayHetHan = etBHYT.NgayCap.AddYears(5);
                update.MSBN = etBHYT.MaBN;
                // Lưu các thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();
            }
        }
        public IQueryable DoDLCBDSBNChuaCoBHYT()
        {
            var ds = from bn in db.BenhNhans
                     join bhyt in db.BHYTs on bn.MSBN equals bhyt.MSBN into bhytGroup
                     from bhyt in bhytGroup.DefaultIfEmpty()
                     where bhyt == null
                     select new { bn.MSBN, bn.TenBN };  // Trả về cả MSBN và TenBN

            return ds;
        }

        //Cập nhập ngày hết hạn
        public void CapNhatNgayHetHan()
        {
            var records = from bhyt in db.BHYTs

                          select bhyt;
            
            foreach (var record in records)
            {
                //Tự cộng thêm 5 năm
                record.NgayHetHan = record.NgayCap.Value.AddYears(5);
            }
            // Lưu các thay đổi vào cơ sở dữ liệu
            db.SubmitChanges();
        }
        //Lấy ngày hết hạn của BHYT
        public DateTime? LayNgayHetHanCuaBHYT(string maBHYT)
        {
            // Ensure the query returns a nullable DateTime directly
            var truyVan = (from dl in db.BHYTs
                           where dl.MaSoBHYT == maBHYT
                           select dl.NgayHetHan.Value.Date).FirstOrDefault();  // This should naturally be DateTime?

            return truyVan;  // This is already a DateTime? from the LINQ query
        }
        //Kiểm tra xem BHYT hết hạn chưa
        public bool KiemTraXemBHYTHetHanChua(string maBHYT)
        {
            if (LayNgayHetHanCuaBHYT(maBHYT) < DateTime.Now.Date)
            {
                return true;
            }
            return false;
        }
    }
}
