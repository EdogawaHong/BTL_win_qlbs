using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PhieuNhapHienThi
    {
        public string mapn { get; set; }
        public string tennv { get; set; }
        public string tenncc { get; set; }
        public DateTime ngaynhap { get; set; }

        public PhieuNhapHienThi()
        {

        }
        
        public PhieuNhapHienThi(string mapn, string tennv, string tenncc, DateTime ngaynhap)
        {
            this.mapn = mapn;
            this.tennv = tennv;
            this.tenncc = tenncc;
            this.ngaynhap = ngaynhap;
        }
    }
}
