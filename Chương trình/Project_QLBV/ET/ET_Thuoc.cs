using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_Thuoc
    {
        private string maThuoc, tenThuoc, dangThuoc, donViTinh;
        private float donGia;
        private string xuatXu;

        public ET_Thuoc(string maThuoc, string tenThuoc, string dangThuoc, string donViTinh, float donGia, string xuatXu)
        {
            this.maThuoc = maThuoc;
            this.tenThuoc = tenThuoc;
            this.dangThuoc = dangThuoc;
            this.donViTinh = donViTinh;
            this.donGia = donGia;
            this.xuatXu = xuatXu;
        }

        public string MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public string DangThuoc { get => dangThuoc; set => dangThuoc = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }
    }
}
