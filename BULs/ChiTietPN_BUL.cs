using DALs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class ChiTietPN_BUL
    {
        ChiTietPN_DAL chiTietPN_DAL = new ChiTietPN_DAL();
        public bool Them_CT(string mapn, string masach, int soluong)
        {
            return chiTietPN_DAL.Them_CT(mapn, masach, soluong);
        }
        public bool Xoa_CT_MaPN(string mapn)
        {
            return chiTietPN_DAL.Xoa_CT_MaPN(mapn);
        }
        public DataTable GetTable_CT(string ma)
        {
            return chiTietPN_DAL.GetTable_CT(ma);
        }
        public int TongTien(string ma)
        {
            return chiTietPN_DAL.TongTien(ma);
        }
    }
}
