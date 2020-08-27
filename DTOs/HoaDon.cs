using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class HoaDon
    {
        public string mahd { get; set; }
        public string manv { get; set; }
        public string makh { get; set; }
        public DateTime ngaymua { get; set; }
        public string tennv { get; set; }
        public string tenkh { get; set; }
        public int khachtra { get; set; }
        public HoaDon()
        {

        }
        public HoaDon(string manv, string makh, DateTime ngaymua, int khachtra)
        {
            this.manv = manv;
            this.makh = makh;
            this.ngaymua = ngaymua;
            this.khachtra = khachtra;
        }
        public HoaDon(string mahd, string manv, string makh, DateTime ngaymua, int khachtra)
        {
            this.mahd = mahd;
            this.manv = manv;
            this.makh = makh;
            this.ngaymua = ngaymua;
            this.khachtra = khachtra;
        }
    }
}
