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
    public class PhieuNhap_DAL
    {
        public List<PhieuNhapHienThi> GetTable_PN()
        {
            string sql = "select MaPN,TenNV,TenNCC,NgayNhap from PHIEU_NHAP inner join NHAN_VIEN on PHIEU_NHAP.MaNV=NHAN_VIEN.MaNV inner join NHA_CUNG_CAP on NHA_CUNG_CAP.MaNCC=PHIEU_NHAP.MaNCC";
            List<PhieuNhapHienThi> listPN = new List<PhieuNhapHienThi>();
            XuLy.conn = new SqlConnection(XuLy.strConnection);
            XuLy.conn.Open();
            XuLy.cmd = new SqlCommand(sql, XuLy.conn);
            SqlDataReader dr = XuLy.cmd.ExecuteReader();
            while (dr.Read())
            {
                PhieuNhapHienThi pn = new PhieuNhapHienThi(
                    dr["MaPN"].ToString(),
                    dr["TenNV"].ToString(),
                    dr["TenNCC"].ToString(),
                    DateTime.Parse(dr["NgayNhap"].ToString()));
                listPN.Add(pn);
            }
            dr.Close();
            XuLy.conn.Close();
            return listPN;
        }
        public bool Them_PN(PhieuNhap pn)
        {
            string sql = "insert into PHIEU_NHAP(MaNV,MaNCC,NgayNhap) values('" +pn.manv + "', '" + pn.mancc + "', '" + pn.ngaynhap + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_PN(string ma)
        {
            string sql = "delete from PHIEU_NHAP where MaPN='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public List<PhieuNhapHienThi> TimKiem_PN(string key, int position)
        {
            List<PhieuNhapHienThi> listPN = this.GetTable_PN();
            List<PhieuNhapHienThi> listTimKiem = new List<PhieuNhapHienThi>();
            switch (position)
            {
                case 0:
                    foreach (PhieuNhapHienThi pn in listPN)
                    {
                        if (pn.mapn.Equals(key))
                        {
                            listTimKiem.Add(pn);
                            break;
                        }
                    }
                    break;
                case 1:
                    foreach (PhieuNhapHienThi pn in listPN)
                    {
                        if (pn.tennv.ToUpper().Contains(key.ToUpper()))
                        {
                            listTimKiem.Add(pn);
                        }
                    }
                    break;
                case 2:
                    foreach (PhieuNhapHienThi pn in listPN)
                    {
                        if (pn.tenncc.ToUpper().Contains(key.ToUpper()))
                        {
                            listTimKiem.Add(pn);
                        }
                    }
                    break;
                default: break;
            }
            return listTimKiem;
        }
        public PhieuNhap Get_PN(string ma)
        {
            string sql = "select TenNV,TenNCC,NgayNhap from PHIEU_NHAP inner join NHAN_VIEN on PHIEU_NHAP.MaNV=NHAN_VIEN.MaNV inner join NHA_CUNG_CAP on PHIEU_NHAP.MaNCC=NHA_CUNG_CAP.MaNCC where MaPN='" + ma + "'";
            XuLy.conn = new SqlConnection(XuLy.strConnection);
            XuLy.conn.Open();
            XuLy.cmd = new SqlCommand(sql, XuLy.conn);
            SqlDataReader dr = XuLy.cmd.ExecuteReader();
            PhieuNhap pn = new PhieuNhap();
            dr.Read();
            try
            {
                pn.mapn = ma;
                pn.tennv = dr["TenNV"].ToString();
                pn.tenncc = dr["TenNCC"].ToString();
                pn.ngaynhap = DateTime.Parse(dr["NgayNhap"].ToString());
                XuLy.conn.Close();
                return pn;
            }
            catch
            {
                XuLy.conn.Close();
                return null;
            }

        }
    }
}
