using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS__XuatDSLichSuKham
    {
        // Khai báo biến tĩnh
        private static BUS__XuatDSLichSuKham instance;
        private DAL__XuatLichSuKham dal_tk = new
           DAL__XuatLichSuKham();
        public static BUS__XuatDSLichSuKham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS__XuatDSLichSuKham();
                }
                return instance;
            }
        }
        // Lấy danh sách lịch sử khám nhờ phiếu khám bệnh
        public List<ET__LichSuKham> LayDSLichSuKham(string maPKB)
        {
            // Trà về danh sách lịch sử khám 
            return dal_tk.LayDSLichSuKham(maPKB);
        }
        // Lấy danh sách toa thuốc khám nhờ phiếu khám bệnh
        public List<ET__XHDToaThuoc> XuatToaThuocCuaPKB(string maPKB)
        {
            // Trà về danh sách thuốc
            return dal_tk.XuatToaThuocCuaPKB(maPKB);
        }
        // Lấy danh sách lịch sử khám nhờ phiếu khám bệnh
        public List<ET__DSBenhNhanChuaTri> LayDSBNChuaTri(string maPKB)
        {
            // Trà về danh sách bệnh nhân chữa trị
            return dal_tk.LayDSBNChuaTri(maPKB);
        }

        // Lấy tiền viện phí nhờ phiếu khám bệnh
        public List<ET__XHDGiuongBenh> XuatTienGB(string maPKB)
        {
            // Trà về danh sách tiền giường bệnh
            return dal_tk.XuatTienGB(maPKB);
        }
        // Lấy danh sách thuốc nhờ phiếu khám bệnh
        public List<ET__XHDToaThuoc> XuatToaThuoc(string maPKB)
        {
            // Trả về danh sách toa thuốc
            return dal_tk.XuatToaThuoc(maPKB);
        }
        // Lấy tiền làm phẫu thuật_xét nghiệm chụp chiếu nhờ phiếu khám bệnh
        public List<ET__XHDXetNghiemPhauThuat> XuatTienPT_XNCC(string maPKB)
        {
            // Trả về danh sách phẫu thuật_xét nghiệm chụp chiếu
            return dal_tk.XuatTienPT_XNCC(maPKB);
        }
        // Lấy danh sách lịch sử khám nhờ tên bệnh nhân
        public List<ET__LichSuKham> LayDSLichSuKhamNhoTenBN(string maPKB)
        {
            // Trả về danh sách khám nhờ tên bệnh nhân
            return dal_tk.LayDSLichSuKhamNhoTenBN(maPKB);
        }
        // Lấy danh sách bệnh nhân chữa trị nhờ tên bệnh nhân
        public List<ET__DSBenhNhanChuaTri> LayDSBNChuaTriNhoTenBN(string maPKB)
        {
            // Trả về danh sách chữa trị nhờ tên bệnh nhân
            return dal_tk.LayDSBNChuaTriNhoTenBN(maPKB);
        }
    }
}
