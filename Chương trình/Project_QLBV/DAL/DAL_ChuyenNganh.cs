using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChuyenNganh
    {
        private static DAL_ChuyenNganh instance;


        public static DAL_ChuyenNganh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ChuyenNganh();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Lấy danh sách chuyên ngành
        public IQueryable ListCN()
        {
            IQueryable cnganh = from cn in db.ChuyenNganhs
                                select cn;
            return cnganh;
        }
        //Thêm chuyên ngành
        public bool ThemCN(ET_ChuyenNganh etCN)
        {
            if (db.ChuyenNganhs.Any(cn => cn.MaChuyenNganh == etCN.MaCN))
            {
                return false;
            }
            else
            {
                try
                {
                    ChuyenNganh cn = new ChuyenNganh
                    {
                        MaChuyenNganh = etCN.MaCN,
                        TenChuyenNganh = etCN.TenCN,
                        MaKhoa = etCN.MaKhoa,
                    };
                    db.ChuyenNganhs.InsertOnSubmit(cn);

                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
        //Xóa chuyên ngành
        public bool XoaCN(string maCN)
        {
            try
            {
                var xoa = from cn in db.ChuyenNganhs
                          where cn.MaChuyenNganh == maCN
                          select cn;
                foreach (var x in xoa)
                {
                    db.ChuyenNganhs.DeleteOnSubmit(x);
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
        //Sửa chuyên ngành
        public void SuaCN(ET_ChuyenNganh etCN)
        {
            //update từ mã khoa.
            var update = db.ChuyenNganhs.Single(cn => cn.MaChuyenNganh == etCN.MaCN);
            update.TenChuyenNganh = etCN.TenCN;
            update.MaKhoa = etCN.MaKhoa;
            db.SubmitChanges();
        }
    }
}
