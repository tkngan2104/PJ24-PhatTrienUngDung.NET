using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BangGia
    {
        //Khai báo biến tĩnh
        private static DAL_BangGia instance;
        

        public static DAL_BangGia Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_BangGia();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Lấy danh sách bảng giá
        public IQueryable XemDSBangGia()
        {
            IQueryable ds = from dv in db.BangGias//Truy vấn dữ liệu từ bảng BangGia
                            select dv;
            //Trả về kết quả truy vấn
            return ds;
        }
        //Thêm dịch vụ
        public bool ThemDichVu(ET_BangGia etBangGia)
        {
            //Kiểm tra xem có trùng MaLoaiChiTietDV hay TenLoaiChiTietDV không nếu trùng trả về false
            if (db.BangGias.Any(dv => dv.MaLoaiChiTietDV == etBangGia.MaDV || dv.TenLoaiChiTietDV == etBangGia.TenDV))
            {
                // Nếu tồn tại, trả về false để báo hiệu việc thêm không thành công do trùng lặp
                return false;
            }
            else
            {
                try
                {
                    // Tạo một đối tượng mới của BangGia

                    BangGia bangGia = new BangGia
                    {
                        MaLoaiChiTietDV = etBangGia.MaDV,
                        TenLoaiChiTietDV = etBangGia.TenDV,
                        Gia = etBangGia.Gia,
                        MaKhoa = etBangGia.MaKhoa,
                        LoaiPT_XNCC = etBangGia.LoaiPT_XNCC
                    };
                    // Thêm dịch vụ mới vào cơ sở dữ liệu
                    db.BangGias.InsertOnSubmit(bangGia);
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
        //  Xóa bảng giá
        public bool XoaBangGia(string maBangGia)
        {
            try
            {
                // Truy vấn lấy tất cả các bản ghi trong BangGias có MaLoaiChiTietDV bằng với maBangGia
                var xoa = from dv in db.BangGias//Truy vấn dữ liệu từ BangGia
                          where dv.MaLoaiChiTietDV == maBangGia//Lọc theo maDV được chỉ định
                          select dv;
                // Duyệt qua từng bản ghi và xóa chúng khỏi cơ sở dữ liệu
                foreach (var x in xoa)
                {
                    db.BangGias.DeleteOnSubmit(x);
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
        //Sửa dịch vụ
        public void SuaDichVu(ET_BangGia etBangGia)
        {
            // Tìm đối tượng BangGia trong cơ sở dữ liệu dựa trên mã dịch vụ
            var update = db.BangGias.Single(t => t.MaLoaiChiTietDV == etBangGia.MaDV);
            // Cập nhật tên và giá cho dịch vụ dựa trên thông tin nhận được
            update.TenLoaiChiTietDV = etBangGia.TenDV;
            update.Gia = etBangGia.Gia;
            // Tìm khoa mới từ cơ sở dữ liệu nếu mã khoa được cập nhật
            var khoaMoi = db.Khoas.SingleOrDefault(k => k.MaKhoa == etBangGia.MaKhoa);
            // Nếu tìm thấy khoa mới, cập nhật khoa cho dịch vụ
            if (khoaMoi != null)
            {
                update.Khoa = khoaMoi;
            }
            // Tìm loại PT_XNCC mới từ cơ sở dữ liệu nếu loại PT_XNCC được cập nhật
            var loaiPT_XNCCMoi = db.LoaiPT_XNCCs.SingleOrDefault(loai => loai.LoaiPT_XNCC1 == etBangGia.LoaiPT_XNCC);
            // Nếu tìm thấy loại PT_XNCC mới, cập nhật loại PT_XNCC cho dịch vụ
            if (loaiPT_XNCCMoi != null)
            {
                update.LoaiPT_XNCC1 = loaiPT_XNCCMoi;
            }
            // Lưu các thay đổi vào cơ sở dữ liệu
            db.SubmitChanges();
        }
    }
}
