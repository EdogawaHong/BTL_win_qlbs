using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class HoaDon_DAL
    {
        public List<HoaDonHienThi> GetTable_HD()
        {
            List<HoaDonHienThi> listHD = new List<HoaDonHienThi>();
            string sql = "select MaHD,TenNV,TenKH,NgayMua from HOA_DON inner join NHAN_VIEN on HOA_DON.MaNV=NHAN_VIEN.MaNV inner join KHACH_HANG on HOA_DON.MaKH=KHACH_HANG.MaKH";
            XuLy.conn = new SqlConnection(XuLy.strConnection);
            XuLy.conn.Open();
            XuLy.cmd = new SqlCommand(sql, XuLy.conn);
            SqlDataReader dr = XuLy.cmd.ExecuteReader();
            while (dr.Read())
            {
                HoaDonHienThi hd = new HoaDonHienThi(
                    dr["MaHD"].ToString(),
                    dr["TenNV"].ToString(),
                    dr["TenKH"].ToString(),
                    DateTime.Parse(dr["NgayMua"].ToString()));
                listHD.Add(hd);
            }
            dr.Close();
            XuLy.conn.Close();
            return listHD;
        }
        public bool Them_HD(HoaDon hd)
        {
            string sql = "insert into HOA_DON(MaNV,MaKH,NgayMua,KhachTra) values('" + hd.manv + "', '" + hd.makh + "', '" + hd.ngaymua + "','" + hd.khachtra + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_HD(string ma)
        {
            string sql = "delete from HOA_DON where MaHD='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public List<HoaDonHienThi> TimKiem_HD(string key, int position)
        {
            List<HoaDonHienThi> listHD = this.GetTable_HD();
            List<HoaDonHienThi> listTimKiem = new List<HoaDonHienThi>();
            switch (position)
            {
                case 0:
                    foreach (HoaDonHienThi hd in listHD)
                    {
                        if (hd.mahd.Equals(key))
                        {
                            listTimKiem.Add(hd);
                            break;
                        }
                    }
                    break;
                case 1:
                    foreach (HoaDonHienThi hd in listHD)
                    {
                        if (hd.tennv.ToUpper().Contains(key.ToUpper()))
                        {
                            listTimKiem.Add(hd);
                        }
                    }
                    break;
                case 2:
                    foreach (HoaDonHienThi hd in listHD)
                    {
                        if (hd.tenkh.ToUpper().Contains(key.ToUpper()))
                        {
                            listTimKiem.Add(hd);
                        }
                    }
                    break;
                default: break;
            }
            return listTimKiem;
        }

        public HoaDon Get_HD(string ma)
        {
            string sql = "select TenNV,TenKH,NgayMua,KhachTra from HOA_DON inner join NHAN_VIEN on HOA_DON.MaNV=NHAN_VIEN.MaNV inner join KHACH_HANG on HOA_DON.MaKH=KHACH_HANG.MaKH where MaHD='" + ma + "'";
            XuLy.conn = new SqlConnection(XuLy.strConnection);
            XuLy.conn.Open();
            XuLy.cmd = new SqlCommand(sql, XuLy.conn);
            SqlDataReader dr = XuLy.cmd.ExecuteReader();
            HoaDon hd = new HoaDon();
            dr.Read();
            try
            {
                hd.mahd = ma;
                hd.tennv = dr["TenNV"].ToString();
                hd.tenkh = dr["TenKH"].ToString();
                hd.ngaymua = DateTime.Parse(dr["NgayMua"].ToString());
                hd.khachtra = int.Parse(dr["KhachTra"].ToString());
                XuLy.conn.Close();
                return hd;
            }
            catch
            {
                XuLy.conn.Close();
                return null;
            }
            
        }
    }
}
