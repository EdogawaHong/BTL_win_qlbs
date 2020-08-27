using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class BaoCao_DAL
    {
        public DataTable BaoCao_Ngay(string date)
        {
            DataTable dt;
            string sql = "select TenSach,SUM(SoLuong)as 'SoLuongBan',DonGia,SUM(SoLuong*DonGia) as 'ThanhTien' " +
                "from SACH inner join CHI_TIET_HOA_DON on SACH.MaSach = CHI_TIET_HOA_DON.MaSach " +
                "inner join HOA_DON on CHI_TIET_HOA_DON.MaHD = HOA_DON.MaHD " +
                "where CONVERT(NVARCHAR(10), NgayMua, 120) = '" + date + "' " +
                "group by TenSach,DonGia order by SoLuongBan DESC";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public int BaoCao_TongSL_Ngay(string date)
        {
            try
            {
                DataTable dt;
                string sql = "select SUM(SoLuong)as 'TongSoLuongBan' " +
                    "from CHI_TIET_HOA_DON inner join HOA_DON on CHI_TIET_HOA_DON.MaHD=HOA_DON.MaHD " +
                    "where CONVERT(NVARCHAR(10), NgayMua, 120) = '" + date + "'";
                dt = XuLy.CreateTable(sql);
                DataRow dr = dt.Rows[0];
                int sum = Convert.ToInt32(dr["TongSoLuongBan"].ToString());
                return sum;
            }
            catch { return (int)0; }
        }
        public int BaoCao_TongDT_Ngay(string date)
        {
            try
            {
                DataTable dt;
                string sql = "select SUM(SoLuong * DonGia) as 'TongTien' " +
                    "from CHI_TIET_HOA_DON inner join SACH on CHI_TIET_HOA_DON.MaSach = SACH.MaSach " +
                    "inner join HOA_DON on CHI_TIET_HOA_DON.MaHD = HOA_DON.MaHD " +
                    "where CONVERT(NVARCHAR(10), NgayMua, 120) = '" + date + "'";
                dt = XuLy.CreateTable(sql);
                DataRow dr = dt.Rows[0];
                int sum = Convert.ToInt32(dr["TongTien"].ToString());
                return sum;
            }
            catch { return (int)0; }
        }
        public DataTable BaoCao_Thang(string month)
        {
            DataTable dt;
            string sql = "select TenSach,SUM(SoLuong)as 'SoLuongBan',DonGia,SUM(SoLuong*DonGia) as 'ThanhTien' " +
                "from SACH inner join CHI_TIET_HOA_DON on SACH.MaSach = CHI_TIET_HOA_DON.MaSach " +
                "inner join HOA_DON on CHI_TIET_HOA_DON.MaHD = HOA_DON.MaHD " +
                "where CONVERT(NVARCHAR(7), NgayMua, 120) = '" + month + "' " +
                "group by TenSach,DonGia order by SoLuongBan DESC";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public int BaoCao_TongSL_Thang(string month)
        {
            try
            {
                DataTable dt;
                string sql = "select SUM(SoLuong)as 'TongSoLuongBan' " +
                    "from CHI_TIET_HOA_DON inner join HOA_DON on CHI_TIET_HOA_DON.MaHD=HOA_DON.MaHD " +
                    "where CONVERT(NVARCHAR(7), NgayMua, 120) = '" + month + "'";
                dt = XuLy.CreateTable(sql);
                DataRow dr = dt.Rows[0];
                int sum = Convert.ToInt32(dr["TongSoLuongBan"].ToString());
                return sum;
            }
            catch { return (int)0; }
        }
        public int BaoCao_TongDT_Thang(string month)
        {
            try
            {
                DataTable dt;
                string sql = "select SUM(SoLuong * DonGia) as 'TongTien' " +
                    "from CHI_TIET_HOA_DON inner join SACH on CHI_TIET_HOA_DON.MaSach = SACH.MaSach " +
                    "inner join HOA_DON on CHI_TIET_HOA_DON.MaHD = HOA_DON.MaHD " +
                    "where CONVERT(NVARCHAR(7), NgayMua, 120) = '" + month + "'";
                dt = XuLy.CreateTable(sql);
                DataRow dr = dt.Rows[0];
                int sum = Convert.ToInt32(dr["TongTien"].ToString());
                return sum;
            }
            catch { return (int)0; }
        }
        public DataTable BaoCao_Nam(string year)
        {
            DataTable dt;
            string sql = "select TenSach,SUM(SoLuong)as 'SoLuongBan',DonGia,SUM(SoLuong*DonGia) as 'ThanhTien' " +
                "from SACH inner join CHI_TIET_HOA_DON on SACH.MaSach = CHI_TIET_HOA_DON.MaSach " +
                "inner join HOA_DON on CHI_TIET_HOA_DON.MaHD = HOA_DON.MaHD " +
                "where YEAR(NgayMua) = '" + year + "' " +
                "group by TenSach,DonGia order by SoLuongBan DESC";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public int BaoCao_TongSL_Nam(string year)
        {
            try
            {
                DataTable dt;
                string sql = "select SUM(SoLuong)as 'TongSoLuongBan' " +
                    "from CHI_TIET_HOA_DON inner join HOA_DON on CHI_TIET_HOA_DON.MaHD=HOA_DON.MaHD " +
                    "where YEAR(NgayMua) = '" + year + "'";
                dt = XuLy.CreateTable(sql);
                DataRow dr = dt.Rows[0];
                int sum = Convert.ToInt32(dr["TongSoLuongBan"].ToString());
                return sum;
            }
            catch { return (int)0; }
        }
        public int BaoCao_TongDT_Nam(string year)
        {
            try
            {
                DataTable dt;
                string sql = "select SUM(SoLuong * DonGia) as 'TongTien' " +
                    "from CHI_TIET_HOA_DON inner join SACH on CHI_TIET_HOA_DON.MaSach = SACH.MaSach " +
                    "inner join HOA_DON on CHI_TIET_HOA_DON.MaHD = HOA_DON.MaHD " +
                    "where YEAR(NgayMua) = '" + year + "'";
                dt = XuLy.CreateTable(sql);
                DataRow dr = dt.Rows[0];
                int sum = Convert.ToInt32(dr["TongTien"].ToString());
                return sum;
            }
            catch { return (int)0; }
        }
    }
}
