using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALs;
using DTOs;

namespace BULs
{
    public class NXB_BUL
    {
        NXB_DAL nXB_DAL = new NXB_DAL();
        public List<Person> GetTable_NXB()
        {
            return nXB_DAL.GetTable_NXB();
        }
        public bool Them_NXB(Person p)
        {
            return nXB_DAL.Them_NXB(p);
        }
        public bool Sua_NXB(Person p)
        {
            return nXB_DAL.Sua_NXB(p);
        }
        public bool Xoa_NXB(string ma)
        {
            return nXB_DAL.Xoa_NXB(ma);
        }
        public List<Person> TimKiem_NXB(string key)
        {
            return nXB_DAL.TimKiem_NXB(key);
        }
    }
}
