using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class ChiTietHD_DAL
    {
        public bool Them_CT(string mahd,string masach,int soluong)
        {
            string sql = "insert into CHI_TIET_HOA_DON(SoLuong,MaSach,MaHD) values('" + soluong + "', '" + masach + "', '" + mahd + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_CT_MaHD(string mahd)
        {
            string sql = "delete from CHI_TIET_HOA_DON where MaHD='" + mahd + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public DataTable GetTable_CT(string ma)
        {
            DataTable dt;
            string sql = "select TenSach,SoLuong,DonGia,SUM(SoLuong*DonGia) as 'ThanhTien' from CHI_TIET_HOA_DON inner join SACH on CHI_TIET_HOA_DON.MaSach=SACH.MaSach where MaHD='" + ma + "' group by TenSach,SoLuong,DonGia";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public int TongTien(string ma)
        {
            try
            {
                DataTable dt;
                string sql = "select SUM(SoLuong*DonGia) as 'TongTien' from CHI_TIET_HOA_DON inner join SACH on CHI_TIET_HOA_DON.MaSach=SACH.MaSach where MaHD='" + ma + "'";
                dt = XuLy.CreateTable(sql);
                DataRow dr = dt.Rows[0];
                int sum = Convert.ToInt32(dr["TongTien"].ToString());
                return sum;
            }
            catch { return (int)0; }
        }
    }
}
