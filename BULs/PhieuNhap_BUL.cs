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
    public class PhieuNhap_BUL
    {
        PhieuNhap_DAL phieuNhap_DAL = new PhieuNhap_DAL();
        public bool Them_PN(PhieuNhap pn)
        {
            return phieuNhap_DAL.Them_PN(pn);
        }
        public List<PhieuNhapHienThi> GetTable_PN()
        {
            return phieuNhap_DAL.GetTable_PN();
        }
        public List<PhieuNhapHienThi> TimKiem_PN(string key, int position)
        {
            return phieuNhap_DAL.TimKiem_PN(key,position);
        }
        public bool Xoa_PN(string ma)
        {
            return phieuNhap_DAL.Xoa_PN(ma);
        }
        public PhieuNhap Get_PN(string ma)
        {
            return phieuNhap_DAL.Get_PN(ma);
        }
    }
}
