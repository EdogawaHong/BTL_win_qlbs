using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class NCC_BUL
    {
        NCC_DAL nCC_DAL = new NCC_DAL();
        public List<Person> GetTable_NCC()
        {
            return nCC_DAL.GetTable_NCC();
        }
        public bool Them_NCC(Person p)
        {
            return nCC_DAL.Them_NCC(p);
        }
        public bool Sua_NCC(Person p)
        {
            return nCC_DAL.Sua_NCC(p);
        }
        public bool Xoa_NCC(string ma)
        {
            return nCC_DAL.Xoa_NCC(ma);
        }
        public List<Person> TimKiem_NCC(string key)
        {
            return nCC_DAL.TimKiem_NCC(key);
        }
    }
}
