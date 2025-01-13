using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GiuongBenh
    {
        //Khai báo biến tĩnh
        private static DAL_GiuongBenh instance;


        public static DAL_GiuongBenh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_GiuongBenh();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xem danh sách giường bệnh
        public IQueryable XemDSGiuongBenh(string maPhong)
        {
            IQueryable giuongBenh = from gb in db.GiuongBenhs
                                    where gb.MSPhong == maPhong
                                    select gb;
            return giuongBenh;
        }
        //Lấy danh sách phòng bệnh
        public IQueryable LayDSPhongBenh()
        {
            IQueryable phongBenh = from pb in db.PhongKhams
                                   where pb.Loai == "Phòng bệnh"
                                   select pb;
            return phongBenh;
        }
        //Kiểm tra xem có vượt quá số lượng giới hạn không
        public bool KiemTraSoGiuong(string maPB)
        {
            int soLuongGioiHan = (from pb in db.PhongKhams
                                  where pb.MSPhong == maPB
                                  select Convert.ToInt32(pb.SoGiuong)).FirstOrDefault();
            int soGiuong = (from gb in db.GiuongBenhs
                            where gb.MSPhong == maPB
                            select Convert.ToInt32(gb.SoGiuongBenh)).Count();
            if (soGiuong >= soLuongGioiHan)
            {
                return false;
            }
            return true;
        }
        //Thêm giường bệnh
        public bool ThemGiuongBenh(ET_GiuongBenh etGB)
        {
            if (db.GiuongBenhs.Any(gb => gb.MaGiuong == etGB.MaGiuong && gb.MSPhong == etGB.MsPhong && gb.SoGiuongBenh == etGB.SoGiuong))
            {
                return false;
            }
            try
            {
                GiuongBenh gb = new GiuongBenh
                {
                    MaGiuong = etGB.MaGiuong,
                    SoGiuongBenh = etGB.SoGiuong,
                    MSPhong = etGB.MsPhong
                };
                db.GiuongBenhs.InsertOnSubmit(gb);
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
        //Xóa giường bệnh
        public bool XoaGiuongBenh(string maGiuongBenh)
        {
            try
            {
                var xoa = from gb in db.GiuongBenhs
                          where gb.MaGiuong == maGiuongBenh
                          select gb;
                foreach (var x in xoa)
                {
                    db.GiuongBenhs.DeleteOnSubmit(x);
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
        //Sửa giường bệnh
        public void SuaGiuongBenh(ET_GiuongBenh etGB)
        {
            var capNhap = db.GiuongBenhs.Single(gb => gb.MaGiuong == etGB.MaGiuong);
            capNhap.SoGiuongBenh = etGB.SoGiuong;

            // Lấy đối tượng Phòng mới, đảm bảo rằng nó tồn tại.
            var phongMoi = db.PhongKhams.SingleOrDefault(p => p.MSPhong == etGB.MsPhong);
            if (phongMoi != null)
            {
                // Cập nhật tham chiếu đối tượng Phòng
                capNhap.PhongKham = phongMoi;
            }
            else
            {
                throw new Exception("Phòng không tồn tại.");
            }
            db.SubmitChanges();
        }
    }
}
