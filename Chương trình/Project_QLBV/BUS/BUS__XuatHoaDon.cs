using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS__XuatHoaDon
    {
        // Khai báo biến tĩnh
        private static BUS__XuatHoaDon instance;
        private DAL__XuatHoaDon dal_xhd = new
           DAL__XuatHoaDon();

        public static BUS__XuatHoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS__XuatHoaDon();
                }
                return instance;
            }
        }
        // Lấy thông tin bệnh nhân của phiếu khám bệnh
        public List<ET__LayThongTinBenhNhan> LayTTBN(string msPKB)
        {
            try
            {
                // Gọi tới singleton instance của DAL__XuatHoaDon và thực hiện phương thức LayTTBenhNhan để lấy thông tin bệnh nhân
                var results = dal_xhd.LayTTBenhNhan(msPKB);
                //Nếu result bị trống hoặc không thấy bệnh nhân đó thì trả về không có dữ liệu nào được tìm thấy
                if (results == null || !results.Any())
                {
                    // Ném ra ngoại lệ mới với thông báo không có dữ liệu
                    throw new Exception("No data returned");

                }
                // Nếu có dữ liệu, trả về danh sách kết quả
                return results;
            }
            catch (Exception ex)
            {
                // Ghi ra console thông báo lỗi cùng với chi tiết lỗi nhận được
                Console.WriteLine($"Error fetching data for PKB {msPKB}: {ex.Message}");
                // Ném ra ngoại lệ cấp cao hơn để xử lý lỗi
                throw new ApplicationException("Error fetching patient data", ex);
            }
        }
        // Trả về danh sách các chi tiết phẫu thuật và xét nghiệm đã được thực hiện cho bệnh nhân nhờ phiếu khám bệnh
        public List<ET__XHDXetNghiemPhauThuat> LayTTPT_XNCC(string msPKB)
        {
            return dal_xhd.XuatTienPT_XNCC(msPKB);
        }
        // Trả về danh sách thông tin giường bệnh đã thực hiện phân giường cho bệnh nhân nhờ phiếu khám bệnh
        public List<ET__XHDGiuongBenh> LayTTGiuongBenh(string msPKB)
        {
            return dal_xhd.XuatTienGB(msPKB);
        }
        // Trả về toa thuốc đã thực hiện cấp phát cho bệnh nhân nhờ phiếu khám bệnh
        public List<ET__XHDToaThuoc> LayToaThuoc(string msPKB)
        {
            return dal_xhd.XuatToaThuoc(msPKB);
        }
        // Trả về danh sách thuốc đã thực hiện cấp phát cho bệnh nhân nhờ mã toa thuốc
        public List<ET__XHDToaThuoc> LayToaThuocNhoMaTT(string maTT)
        {
            return dal_xhd.XuatToaThuocNhoMaTT(maTT);
        }
        // Trả về hóa đơn đã thực hiện cấp phát cho bệnh nhân nhờ mã phiếu khám bệnh
        public List<ET_HoaDon> LayTTHoaDon(string msPKB)
        {
            return dal_xhd.LayTTHD(msPKB);
        }
    }
}
