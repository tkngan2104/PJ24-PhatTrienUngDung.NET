using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChuanDoan
    {
        private string maCD, maYC, maBenh, msPhieuKhamBenh, msNV, ketLuan, loiKhuyen, maLoaiBA;

        public ET_ChuanDoan(string maCD, string maYC, string maBenh, string msPhieuKhamBenh, string msNV, string ketLuan, string loiKhuyen, string maLoaiBA)
        {
            this.maCD = maCD;
            this.maYC = maYC;
            this.maBenh = maBenh;
            this.msPhieuKhamBenh = msPhieuKhamBenh;
            this.msNV = msNV;
            this.ketLuan = ketLuan;
            this.loiKhuyen = loiKhuyen;
            this.maLoaiBA = maLoaiBA;
        }

        public string MaCD { get => maCD; set => maCD = value; }
        public string MaYC { get => maYC; set => maYC = value; }
        public string MaBenh { get => maBenh; set => maBenh = value; }
        public string MsPhieuKhamBenh { get => msPhieuKhamBenh; set => msPhieuKhamBenh = value; }
        public string MsNV { get => msNV; set => msNV = value; }
        public string KetLuan { get => ketLuan; set => ketLuan = value; }
        public string LoiKhuyen { get => loiKhuyen; set => loiKhuyen = value; }
        public string MaLoaiBA { get => maLoaiBA; set => maLoaiBA = value; }
    }
}
