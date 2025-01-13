using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiPTXN
    {
        //Khai báo biến tĩnh
        private static DAL_LoaiPTXN instance;
        

        public static DAL_LoaiPTXN Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_LoaiPTXN();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        public IQueryable XemDSLoaiPT_XNCC()
        {
            IQueryable ds = from loai in db.LoaiPT_XNCCs
                            select loai;
            return ds;
        }
        //Thêm loại PT_XNCC
        public bool ThemLoaiPT_XNCC(ET_LoaiPTXN etLoaiPT_XNCC)
        {
            if (db.LoaiPT_XNCCs.Any(dv => dv.LoaiPT_XNCC1 == etLoaiPT_XNCC.Loai || dv.Ten == etLoaiPT_XNCC.Ten))
            {
                return false;
            }
            else
            {
                try
                {
                    LoaiPT_XNCC loai = new LoaiPT_XNCC
                    {
                        LoaiPT_XNCC1 = etLoaiPT_XNCC.Loai,
                        Ten = etLoaiPT_XNCC.Ten
                    };
                    db.LoaiPT_XNCCs.InsertOnSubmit(loai);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
        //Xóa loại PT_XNCC
        public bool XoaLoaiPT_XNCC(string maLoaiPT_XNCC)
        {
            try
            {
                var xoa = from lptxncc in db.LoaiPT_XNCCs
                          where lptxncc.LoaiPT_XNCC1 == maLoaiPT_XNCC
                          select lptxncc;
                foreach (var i in xoa)
                {
                    db.LoaiPT_XNCCs.DeleteOnSubmit(i);
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
                else
                {
                    return false;
                }
            }
        }
        //Sửa loại PT_XNCC
        public bool SuaLoaiPT_XNCC(ET_LoaiPTXN etLoaiPTXNCC)
        {
            //var update = db.LoaiPT_XNCCs.Single(lk => lk.LoaiPT_XNCC1 == etLoaiPTXNCC.Loai);
            //update.Ten = etLoaiPTXNCC.Ten;
            //db.SubmitChanges();

            if (db.LoaiPT_XNCCs.Any(dv => dv.Ten == etLoaiPTXNCC.Ten))
            {
                return false;
            }
            else
            {
                try
                {
                    var update = db.LoaiPT_XNCCs.Single(lk => lk.LoaiPT_XNCC1 == etLoaiPTXNCC.Loai);
                    update.Ten = etLoaiPTXNCC.Ten;
                    db.SubmitChanges();
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
    }
}
