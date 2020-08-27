using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using DALs;
using System.Data;

namespace BULs
{
    public class Sach_BUL
    {
        Sach_DAL sach_DAL = new Sach_DAL();
        public List<SachHienThi> GetTable_Sach()
        {
            return sach_DAL.GetTable_Sach();
        }
        public bool Them_Sach(Sach s)
        {
            return sach_DAL.Them_Sach(s);
        }
        public bool Sua_Sach(Sach s)
        {
            return sach_DAL.Sua_Sach(s);
        }
        public bool Xoa_Sach(string ma)
        {
            return sach_DAL.Xoa_Sach(ma);
        }
        public SanPham Get_SanPham(string ma, int sl)
        {
            return sach_DAL.Get_SanPham(ma, sl);
        }
        public int SoLuongCon(string ma)
        {
            return sach_DAL.SoLuongCon(ma);
        }
        public bool CapNhatSoLuong(string ma, int sl)
        {
            return sach_DAL.CapNhatSoLuong(ma, sl);
        }
        public SanPham Get_SanPhamNhap(string ma, int sl)
        {
            return sach_DAL.Get_SanPhamNhap(ma, sl);
        }
        public bool CapNhatSoLuongNhap(string ma, int sl)
        {
            return sach_DAL.CapNhatSoLuongNhap(ma, sl);
        }
        public List<SachHienThi> TimKiem_Sach(string key, int position)
        {
            return sach_DAL.TimKiem_Sach(key, position);
        }
    }
}
