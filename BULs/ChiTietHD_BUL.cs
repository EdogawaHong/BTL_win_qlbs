using DALs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class ChiTietHD_BUL
    {
        ChiTietHD_DAL chiTietHD_DAL = new ChiTietHD_DAL();
        public bool Them_CT(string mahd, string masach, int soluong)
        {
            return chiTietHD_DAL.Them_CT(mahd, masach, soluong);
        }
        public bool Xoa_CT_MaHD(string mahd)
        {
            return chiTietHD_DAL.Xoa_CT_MaHD(mahd);
        }
        public DataTable GetTable_CT(string ma)
        {
            return chiTietHD_DAL.GetTable_CT(ma);
        }
        public int TongTien(string ma)
        {
            return chiTietHD_DAL.TongTien(ma);
        }
    }
}
