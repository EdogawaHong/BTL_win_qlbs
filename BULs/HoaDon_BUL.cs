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
    public class HoaDon_BUL
    {
        HoaDon_DAL hoaDon_DAL = new HoaDon_DAL();
        public List<HoaDonHienThi> GetTable_HD()
        {
            return hoaDon_DAL.GetTable_HD();
        }
        public bool Them_HD(HoaDon hd)
        {
            return hoaDon_DAL.Them_HD(hd);
        }
        public bool Xoa_HD(string ma)
        {
            return hoaDon_DAL.Xoa_HD(ma);
        }
        public List<HoaDonHienThi> TimKiem_HD(string key, int position)
        {
            return hoaDon_DAL.TimKiem_HD(key, position);
        }
        public HoaDon Get_HD(string ma)
        {
            return hoaDon_DAL.Get_HD(ma);
        }
    }
}
