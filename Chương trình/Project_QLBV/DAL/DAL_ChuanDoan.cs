using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChuanDoan
    {
        //Khai báo biến tĩnh
        private static DAL_ChuanDoan instance;
 

        public static DAL_ChuanDoan Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ChuanDoan();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Lấy danh sách chuẩn đoán
        public IQueryable XemDSChuanDoan(DateTime dtp)
        {
            IQueryable ds = from cd in db.ChuanDoans
                            join pk in db.PhieuKhamBenhs
                            on cd.MSPhieuKhamBenh equals pk.MSPhieuKhamBenh
                            where pk.NgayKham.Value.Date == dtp.Date//Lọc theo ngày,tháng và năm được chỉ định
                            select cd;
            //Trả về kết quả truy vấn
            return ds;
        }
        //Thêm chuẩn đoán
        public bool ThemChuanDoan(ET_ChuanDoan etCD)
        {
            //Kiểm tra xem có trùng MaChuanDoan không nếu trùng trả về false
            if (db.ChuanDoans.Any(cd => cd.MaChuanDoan == etCD.MaCD && cd.MSPhieuKhamBenh == etCD.MsPhieuKhamBenh))
            {
                // Nếu tồn tại, trả về false để báo hiệu việc thêm không thành công do trùng lặp
                return false;
            }
            else
            {
                try
                {
                    // Tạo một đối tượng mới của ChuanDoan
                    ChuanDoan cd = new ChuanDoan
                    {
                        MaChuanDoan = etCD.MaCD,
                        MaYeuCau = etCD.MaYC,
                        MaBenh = etCD.MaBenh,
                        MSPhieuKhamBenh = etCD.MsPhieuKhamBenh,
                        MaNV = etCD.MsNV,
                        KetLuan = etCD.KetLuan,
                        LoiKhuyen = etCD.LoiKhuyen,
                        MaLoaiBA = etCD.MaLoaiBA
                    };
                    // Thêm chuẩn đoán mới vào cơ sở dữ liệu
                    db.ChuanDoans.InsertOnSubmit(cd);
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
        //Xóa chuẩn đoán
        public bool XoaChuanDoan(string maCD)
        {
            try
            {
                // Truy vấn lấy tất cả các bản ghi trong ChuanDoans có MaChuanDoan bằng với maCD
                var xoa = from cd in db.ChuanDoans
                          where cd.MaChuanDoan == maCD
                          select cd;
                // Duyệt qua từng bản ghi và xóa chúng khỏi cơ sở dữ liệu
                foreach (var x in xoa)
                {
                    db.ChuanDoans.DeleteOnSubmit(x);
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
        //Sửa chuẩn đoán
        public void SuaChuanDoan(ET_ChuanDoan etCD)
        {
            // Tìm đối tượng ChuanDoan trong cơ sở dữ liệu dựa trên mã chuẩn đoán
            var update = db.ChuanDoans.Single(cd => cd.MaChuanDoan == etCD.MaCD);
            // Tìm yêu cầu mới từ cơ sở dữ liệu nếu mã yêu cầu được cập nhật
            var yeuCauMoi = db.Khams.SingleOrDefault(kh => kh.MaYeuCau == etCD.MaYC);
            if (yeuCauMoi != null)
            {
                // Cập nhật dựa trên thông tin nhận được
                update.Kham = yeuCauMoi;
            }
            // Tìm bệnh mới từ cơ sở dữ liệu nếu mã bệnh được cập nhật
            var benhMoi = db.BenhLies.SingleOrDefault(kh => kh.MaBenh == etCD.MaBenh);
            if (benhMoi != null)
            {
                update.BenhLy = benhMoi;
            }
            // Tìm phiếu khám bệnh từ cơ sở dữ liệu nếu mã phiếu khám bệnh được cập nhật
            var phieuKhamBenhMoi = db.PhieuKhamBenhs.SingleOrDefault(kh => kh.MSPhieuKhamBenh == etCD.MsPhieuKhamBenh);
            if (phieuKhamBenhMoi != null)
            {
                update.PhieuKhamBenh = phieuKhamBenhMoi;
            }
            // Tìm nhân viên mới từ cơ sở dữ liệu nếu mã nhân viên được cập nhật
            var nhanVienMoi = db.NhanViens.SingleOrDefault(kh => kh.MaNV == etCD.MsNV);
            if (nhanVienMoi != null)
            {
                update.NhanVien = nhanVienMoi;
            }
            update.KetLuan = etCD.KetLuan;
            update.LoiKhuyen = etCD.LoiKhuyen;
            // Tìm bệnh án mới từ cơ sở dữ liệu nếu mã loại bệnh án được cập nhật
            var benhAnMoi = db.LoaiBenhAns.SingleOrDefault(kh => kh.MaLoaiBA == etCD.MaLoaiBA);
            if (benhAnMoi != null)
            {
                update.LoaiBenhAn = benhAnMoi;
            }
            // Lưu các thay đổi vào cơ sở dữ liệu
            db.SubmitChanges();
        }
        //Lấy mã bệnh nhân nhờ mã yêu cầu
        public string LayMaNVNhoMaYeuCau(string maYC)
        {
            var maNV = (from dl in db.Khams
                        where dl.MaYeuCau == maYC
                        select dl.MaNV).FirstOrDefault();
            return maNV;
        }
        //Lấy tên phòng nhờ mã yêu cầu
        public string LayTenPhongNhoMaYeuCau(string maYC)
        {
            var tenPhong = (from dl in db.Khams
                            join p in db.PhongKhams
                            on dl.MSPhong equals p.MSPhong
                            where dl.MaYeuCau == maYC
                            select p.TenPhong).FirstOrDefault();
            return tenPhong;
        }
        //Kiểm tra trạng thái
        public bool KiemTraTrangThai(string msPhieuKhamBenh, string maNV)
        {
            return db.Khams.Any(kh => kh.MSPhieuKhamBenh == msPhieuKhamBenh && kh.MaNV == maNV);
        }
        //Kiểm tra lần khám nhờ phiếu khám bệnh
        public IQueryable LayLanKhamNhoPhieuKhamBenh(string msPhieuKhamBenh)
        {
            var ds = from dl in db.Khams
                     where dl.MSPhieuKhamBenh == msPhieuKhamBenh
                     select dl;
            return ds;
        }
        //Kiểm tra lấy danh sách phiếu khám bệnh
        public IQueryable LayDSPhieuKhamBenh()
        {
            var ds = from dl in db.PhieuKhamBenhs
                     select dl;
            return ds;
        }
        //Lấy danh sách bệnh lý
        public List<string> LayDSBenhLy()
        {
            var ds = (from p in db.BenhLies
                      select p.TenBenh).ToList();
            return ds;
        }
        //Lấy tên bệnh nhờ mã bệnh
        public string layTenBenhNhoMaBenh(string maBenh)
        {
            var ds = (from p in db.BenhLies
                      where p.MaBenh == maBenh
                      select p.TenBenh).FirstOrDefault();
            return ds;
        }
        //Lấy mã bệnh nhờ tên bệnh
        public string layMaBenhNhoTenBenh(string tenBenh)
        {
            var ds = (from p in db.BenhLies
                      where p.TenBenh == tenBenh
                      select p.MaBenh).FirstOrDefault();
            return ds;
        }
        //Tạo mã chuẩn đoán tự động
        public string GenerateChuanDoanCode(string maPK)
        {
            // Lấy ngày hiện tại với định dạng yyyMMdd
            string datePrefix = maPK;

            // Tạo chuỗi query để lấy số lượng hồ sơ với ngày hôm nay
            string query = $"CD-{datePrefix}";

            // Đếm số lượng mã hồ sơ bệnh án trong ngày hôm nay
            int countToday = db.PhieuKhamBenhs.Count(h => h.MSPhieuKhamBenh.StartsWith(query));

            // Tạo mã mới
            string newCode = $"CD{datePrefix}{(countToday + 1)}";

            return newCode;
        }
        //Tìm danh sách chưa có toa thuốc
        public IQueryable TimDSChuaToaThuoc(DateTime dtpNgay)
        {
            IQueryable ds = from pk in db.PhieuKhamBenhs
                            join cd in db.ChuanDoans
                            on pk.MSPhieuKhamBenh equals cd.MSPhieuKhamBenh
                            where pk.NgayKham.Value.Date == dtpNgay.Date
                                  && !db.ToaThuocs.Any(t => t.MSPhieuKhamBenh == pk.MSPhieuKhamBenh)
                            select pk;
            return ds;
        }
        //Tìm danh sách có toa thuốc
        public IQueryable TimDSCoToaThuoc(DateTime dtpNgay)
        {
            IQueryable ds = from pk in db.PhieuKhamBenhs
                            join cd in db.ChuanDoans
                            on pk.MSPhieuKhamBenh equals cd.MSPhieuKhamBenh
                            where pk.NgayKham.Value.Date == dtpNgay.Date
                                  && db.ToaThuocs.Any(t => t.MSPhieuKhamBenh == pk.MSPhieuKhamBenh)
                            select pk;
            return ds;
        }
    }
}
