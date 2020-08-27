using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class SachHienThi
    {
        public string masach { get; set; }
        public string tensach { get; set; }
        public string tacgia { get; set; }
        public int dongianhap { get; set; }
        public int dongia { get; set; }
        public int soluongcon { get; set; }
        public string tentl { get; set; }
        public string tennxb { get; set; }
        public SachHienThi()
        {

        }
        public SachHienThi(string masach, string tensach, string tacgia, int dongianhap, int dongia, int soluongcon, string tentl, string tennxb)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.tacgia = tacgia;
            this.dongianhap = dongianhap;
            this.dongia = dongia;
            this.soluongcon = soluongcon;
            this.tentl = tentl;
            this.tennxb = tennxb;
        }
    }
}
