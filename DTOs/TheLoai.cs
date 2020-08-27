using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class TheLoai
    {
        public string ma { get; set; }
        public string ten { get; set; }

        public TheLoai()
        {

        }
        public TheLoai(string ten)
        {
            this.ten = ten;
        }
        public TheLoai(string ma,string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }
    }
}
