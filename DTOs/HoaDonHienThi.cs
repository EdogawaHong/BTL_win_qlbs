using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class HoaDonHienThi
    {
        public string mahd { get; set; }
        public string tennv { get; set; }
        public string tenkh { get; set; }
        public DateTime ngaymua { get; set; }
        public HoaDonHienThi()
        {

        }
        public HoaDonHienThi(string mahd, string tennv, string tenkh, DateTime ngaymua)
        {
            this.mahd = mahd;
            this.tennv = tennv;
            this.tenkh = tenkh;
            this.ngaymua = ngaymua;
        }
    }
}
