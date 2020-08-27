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
    public class KhachHang_BUL
    {
        KhachHang_DAL khachHang_DAL = new KhachHang_DAL();
        public List<Person> GetTable_KH()
        {
            return khachHang_DAL.GetTable_KH();
        }
        public bool Them_KH(Person p)
        {
            return khachHang_DAL.Them_KH(p);
        }
        public bool Sua_KH(Person p)
        {
            return khachHang_DAL.Sua_KH(p);
        }
        public bool Xoa_KH(string ma)
        {
            return khachHang_DAL.Xoa_KH(ma);
        }
        public List<Person> TimKiem_KH(string key)
        {
            return khachHang_DAL.TimKiem_KH(key);
        }
    }
}
