using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class SanPham:IEquatable<SanPham>
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public int soluong { get; set; }
        public int dongia { get; set; }
        public long tinhtien { get; set; }

        public SanPham()
        {

        }
        public SanPham(string ma, string ten, int soluong, int dongia)
        {
            this.ma = ma;
            this.ten = ten;
            this.soluong = soluong;
            this.dongia = dongia;
            this.tinhtien = soluong * dongia;
        }

        public bool Equals(SanPham other)
        {
            return this.ma.Equals(other.ma);
        }
    }
}
