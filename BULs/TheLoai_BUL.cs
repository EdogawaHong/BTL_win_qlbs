using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using DALs;

namespace BULs
{
    public class TheLoai_BUL
    {
        TheLoai_DAL theLoai_DAL = new TheLoai_DAL();
        public List<TheLoai> GetTable_TL()
        {
            return theLoai_DAL.GetTable_TL();
        }
        public bool Them_TL(TheLoai tl)
        {
            return theLoai_DAL.Them_TL(tl);
        }
        public bool Sua_TL(TheLoai tl)
        {
            return theLoai_DAL.Sua_TL(tl);
        }
        public bool Xoa_TL(string ma)
        {
            return theLoai_DAL.Xoa_TL(ma);
        }
        public List<TheLoai> TimKiem_NXB(string key)
        {
            return theLoai_DAL.TimKiem_NXB(key);
        }
    }
}
