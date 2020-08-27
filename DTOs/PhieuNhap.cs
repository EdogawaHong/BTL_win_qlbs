using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PhieuNhap
    {
        public string mapn { get; set; }
        public string manv { get; set; }
        public string mancc { get; set; }
        public string tennv { get; set; }
        public string tenncc { get; set; }
        public DateTime ngaynhap { get; set; }

        public PhieuNhap()
        {

        }
        public PhieuNhap(string manv,string mancc,DateTime ngaynhap)
        {
            this.manv = manv;
            this.mancc = mancc;
            this.ngaynhap = ngaynhap;
        }
        public PhieuNhap(string mapn,string manv, string mancc, DateTime ngaynhap)
        {
            this.mapn = mapn;
            this.manv = manv;
            this.mancc = mancc;
            this.ngaynhap = ngaynhap;
        }
    }
}
