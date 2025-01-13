using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiBenhAn
    {
        //Khai báo biến tĩnh
        private static DAL_LoaiBenhAn instance;
    

        public static DAL_LoaiBenhAn Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_LoaiBenhAn();
                }
                return instance;
            }
        }
        // Tạo một đối tượng 'db' từ lớp QLBVDataContext
        private QLBVDataContext db = new QLBVDataContext(Connection_DAL.ConnectionString);
        //Xem danh sách loại bệnh án
        public IQueryable XemDSLoaiBenhAn()
        {
            IQueryable ds = from ba in db.LoaiBenhAns
                            select ba;
            return ds;
        }
        //Thêm loại bệnh án
        public bool ThemLoaiBA(ET_LoaiBenhAn etLoaiBA)
        {
            if (db.LoaiBenhAns.Any(ba => ba.MaLoaiBA == etLoaiBA.MaLoaiBA || ba.TenLoaiBA == etLoaiBA.TenLoaiBA))
            {
                return false;
            }
            else
            {
                try
                {
                    LoaiBenhAn ba = new LoaiBenhAn
                    {
                        MaLoaiBA = etLoaiBA.MaLoaiBA,
                        TenLoaiBA = etLoaiBA.TenLoaiBA
                    };
                    db.LoaiBenhAns.InsertOnSubmit(ba);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }
        //Xóa loại bệnh án
        public bool XoaLoaiBenhAn(string maLoaiBA)
        {
            try
            {
                var xoa = from ba in db.LoaiBenhAns
                          where ba.MaLoaiBA == maLoaiBA
                          select ba;
                foreach (var x in xoa)
                {
                    db.LoaiBenhAns.DeleteOnSubmit(x);
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
        //Sửa loại bệnh án 
        public bool SuaLoaiBenhAn(ET_LoaiBenhAn etLoaiBA)
        {
            //var update = db.LoaiBenhAns.Single(ba => ba.MaLoaiBA == etLoaiBA.MaLoaiBA);
            //update.TenLoaiBA = etLoaiBA.TenLoaiBA;
            //db.SubmitChanges();

            if (db.LoaiBenhAns.Any(ba => ba.TenLoaiBA == etLoaiBA.TenLoaiBA))
            {
                return false;
            }
            else
            {
                try
                {
                    var update = db.LoaiBenhAns.Single(ba => ba.MaLoaiBA == etLoaiBA.MaLoaiBA);
                    update.TenLoaiBA = etLoaiBA.TenLoaiBA;
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
