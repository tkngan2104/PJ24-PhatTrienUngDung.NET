using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BenhLy
    {
        //Khai báo biến tĩnh
        private static DAL_BenhLy instance;


        public static DAL_BenhLy Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_BenhLy();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Lấy danh sách bệnh lý
        public IQueryable XemDSBenhLy()
        {
            
            IQueryable dsBenh = from ds in db.BenhLies//Truy vấn dữ liệu từ bảng BenhLy
                                select ds;
            //Trả về kết quả truy vấn
            return dsBenh;
        }

        public bool ThemBenhLy(ET_BenhLy etBenhLy)
        {
            //Kiểm tra xem có trùng MaBenh hay TenBenh không nếu trùng trả về false
            if (db.BenhLies.Any(bl => bl.MaBenh == etBenhLy.MaBenh || bl.TenBenh == etBenhLy.TenBenh))
            {
                // Nếu tồn tại, trả về false để báo hiệu việc thêm không thành công do trùng lặp
                return false;
            }
            else
            {
                try
                {
                    // Tạo một đối tượng mới của BenhLy
                    BenhLy benhLy = new BenhLy
                    {
                        MaBenh = etBenhLy.MaBenh,
                        TenBenh = etBenhLy.TenBenh
                    };
                    // Thêm bệnh mới vào cơ sở dữ liệu
                    db.BenhLies.InsertOnSubmit(benhLy);
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
        //Xóa bệnh lý
        public bool XoaBenhLy(string maBenh)
        {
            try
            {
                // Truy vấn lấy tất cả các bản ghi trong BenhLies có MaBenh bằng với maBenh
                var xoa = from bl in db.BenhLies
                          where bl.MaBenh == maBenh
                          select bl;
                // Duyệt qua từng bản ghi và xóa chúng khỏi cơ sở dữ liệu
                foreach (var x in xoa)
                {
                    db.BenhLies.DeleteOnSubmit(x);
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
        //Sửa bệnh lý
        public void SuaBenhLy(ET_BenhLy etBenhLy)
        {
            // Tìm đối tượng BenhLies trong cơ sở dữ liệu dựa trên mã bệnh
            var update = db.BenhLies.Single(t => t.MaBenh == etBenhLy.MaBenh);
            if (update != null)
            {
                // Cập nhật dựa trên thông tin nhận được
                update.TenBenh = etBenhLy.TenBenh;
                // Lưu các thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();
            }
        }
    }
}
