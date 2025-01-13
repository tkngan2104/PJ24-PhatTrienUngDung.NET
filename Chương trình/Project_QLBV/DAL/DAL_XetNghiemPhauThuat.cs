using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_XetNghiemPhauThuat
    {
        //Khai báo biến tĩnh
        private static DAL_XetNghiemPhauThuat instance;
        

        public static DAL_XetNghiemPhauThuat Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_XetNghiemPhauThuat();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Lấy danh sách làm phẫu thuật_xncc
        public IQueryable XemDSLamPTXNCC()
        {
            IQueryable ds = from dl in db.LamPhauThuat_XNCCs
                            select dl;
            return ds;
        }

        //Kiểm tra phẫu thuật
        public bool KiemTraPhauThuat(string msPKB)
        {
            return db.ChuanDoans.Any(dl => dl.MSPhieuKhamBenh == msPKB);
        }
        //Thêm danh sách LamPT_XNCC
        public bool ThemDSPTXNCC(ET_XetNghiemPhauThuat et)
        {
            if (db.LamPhauThuat_XNCCs.Any(ds => ds.MSPhieuKhamBenh == et.MsPhieuKhamBenh && ds.MaYeuCau == et.MaYC))
            {
                return false;
            }
            try
            {
                LamPhauThuat_XNCC dl = new LamPhauThuat_XNCC
                {
                    MSPhieuKhamBenh = et.MsPhieuKhamBenh,
                    MaYeuCau = et.MaYC,
                    MaNV = et.MaNV,
                    MSPhong = et.MsPhong,
                    MaLoaiChiTietDV = et.MaLoaiChiTietDV,
                    ThoiGianThucHien = et.ThoiGianThucHien,
                    KetQua = et.KetQua,
                    MucDoRuiRo = et.MucDoRuiRo,
                    Loai = et.Loai,
                    MaLoaiBA = et.MaLoaiBA
                };
                db.LamPhauThuat_XNCCs.InsertOnSubmit(dl);
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
        }
        //Sửa làm PT_XNCC
        public void SuaDSLamPTXNCC(ET_XetNghiemPhauThuat et)
        {
            var update = db.LamPhauThuat_XNCCs.Single(dl => dl.MaYeuCau == et.MaYC && dl.MSPhieuKhamBenh == et.MsPhieuKhamBenh);
            var nhanVienMoi = db.NhanViens.SingleOrDefault(nv => nv.MaNV == et.MaNV);
            if (nhanVienMoi != null)
            {
                update.NhanVien = nhanVienMoi;
            }

            var phongMoi = db.PhongKhams.SingleOrDefault(p => p.MSPhong == et.MsPhong);
            if (phongMoi != null)
            {
                update.PhongKham = phongMoi;
            }

            var loaiChiTietDV = db.BangGias.SingleOrDefault(dv => dv.MaLoaiChiTietDV == et.MaLoaiChiTietDV);
            if (loaiChiTietDV != null)
            {
                update.BangGia = loaiChiTietDV;
            }

            update.ThoiGianThucHien = et.ThoiGianThucHien;
            update.KetQua = et.KetQua;
            update.MucDoRuiRo = et.MucDoRuiRo;
            update.Loai = et.Loai;

            var loaiBA = db.LoaiBenhAns.SingleOrDefault(ba => ba.MaLoaiBA == et.MaLoaiBA);
            if (loaiBA != null)
            {
                update.LoaiBenhAn = loaiBA;
            }

            db.SubmitChanges();
        }
        //Xem danh sách dịch vụ
        public List<string> XemDSDichVu(string tenDS)
        {
            var query = from service in db.BangGias // Giả sử bảng các dịch vụ là `Service`
                        where service.TenLoaiChiTietDV.ToLower().Contains(tenDS.Trim().ToLower()) // Tìm kiếm không phân biệt chữ hoa chữ thường
                        select service.TenLoaiChiTietDV;

            return query.ToList();
        }
        //Phiếu khám bệnh
        public string layMSPhieuKhamBenh(string maYC)
        {
            var truyVan = (from dl in db.Khams
                           where dl.MaYeuCau == maYC
                           select dl.MSPhieuKhamBenh).FirstOrDefault();
            return truyVan;
        }
        //Lấy mã phòng từ mã yêu cầu
        public string layMaPhongCuaYC(string maYC)
        {
            var truyVan = (from dl in db.Khams
                           where dl.MaYeuCau == maYC
                           select dl.MSPhong).FirstOrDefault();
            return truyVan;
        }
        //Lấy mã nhân viên của mã yêu cầu
        public string layMaNVCuaYC(string maYC)
        {
            var truyVan = (from dl in db.Khams
                           where dl.MaYeuCau == maYC
                           select dl.MaNV).FirstOrDefault();

            return truyVan;

        }
        //Lấy mã dịch vụ 
        public string layMaDVTuTenDV(string tenDV)
        {
            var truyVan = (from dl in db.BangGias
                           where dl.TenLoaiChiTietDV == tenDV
                           select dl.MaLoaiChiTietDV).FirstOrDefault();
            return truyVan;
        }
        //Lấy tên dịch vụ từ mã dịch vụ
        public string layTenTuMaDV(string maDV)
        {
            var truyVan = (from dl in db.BangGias
                           where dl.MaLoaiChiTietDV == maDV
                           select dl.TenLoaiChiTietDV).FirstOrDefault();
            return truyVan;
        }
    }
}
