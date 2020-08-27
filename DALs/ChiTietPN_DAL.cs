using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class ChiTietPN_DAL
    {
        public bool Them_CT(string mapn, string masach, int soluong)
        {
            string sql = "insert into CHI_TIET_PHIEU_NHAP(SoLuong,MaSach,MaPN) values('" + soluong + "', '" + masach + "', '" + mapn + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_CT_MaPN(string mapn)
        {
            string sql = "delete from CHI_TIET_PHIEU_NHAP where MaPN='" + mapn + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public DataTable GetTable_CT(string ma)
        {
            DataTable dt;
            string sql = "select TenSach,SoLuong,DonGiaNhap,SUM(SoLuong*DonGiaNhap) as 'ThanhTien' from CHI_TIET_PHIEU_NHAP inner join SACH on CHI_TIET_PHIEU_NHAP.MaSach=SACH.MaSach where MaPN='" + ma + "' group by TenSach,SoLuong,DonGiaNhap";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public int TongTien(string ma)
        {
            try
            {
                DataTable dt;
                string sql = "select SUM(SoLuong*DonGiaNhap) as 'TongTien' from CHI_TIET_PHIEU_NHAP inner join SACH on CHI_TIET_PHIEU_NHAP.MaSach=SACH.MaSach where MaPN='" + ma + "'";
                dt = XuLy.CreateTable(sql);
                DataRow dr = dt.Rows[0];
                int sum = Convert.ToInt32(dr["TongTien"].ToString());
                return sum;
            }
            catch { return (int)0; }
        }
    }
}
