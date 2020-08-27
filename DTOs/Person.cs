using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class Person
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }

        public Person()
        {

        }
        public Person(string ten, string diachi, string sdt)
        {
            this.ten = ten;
            this.diachi = diachi;
            this.sdt = sdt;
        }
        public Person(string ma,string ten, string diachi, string sdt)
        {
            this.ma = ma;
            this.ten = ten;
            this.diachi = diachi;
            this.sdt = sdt;
        }
    }
}
