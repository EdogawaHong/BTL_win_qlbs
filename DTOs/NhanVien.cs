using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class NhanVien:Person,IEquatable<NhanVien>
    {
        public string matkhau { get; set; }

        public NhanVien():base()
        {

        }
        public NhanVien(string sdt,string matkhau)
        {
            this.sdt = sdt;
            this.matkhau = matkhau;
        }
        public NhanVien(string ten, string diachi, string sdt,string matkhau) : base(ten, diachi, sdt)
        {
            this.matkhau = matkhau;
        }
        public NhanVien(string ma,string ten, string diachi, string sdt, string matkhau) : base(ma,ten, diachi, sdt)
        {
            this.matkhau = matkhau;
        }

        public bool Equals(NhanVien other)
        {
            return this.sdt.Equals(other.sdt) && this.matkhau.Equals(other.matkhau);
        }
    }
}
