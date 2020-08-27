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
    public class Sach_DAL
    {
        public List<SachHienThi> GetTable_Sach()
        {
            List<SachHienThi> listS = new List<SachHienThi>();
            XuLy.conn = new SqlConnection(XuLy.strConnection);
            XuLy.conn.Open();
            string sql = "select MaSach,TenSach,TacGia,SoLuongCon,DonGiaNhap,DonGia,TenTL,TenNXB from SACH inner join THE_LOAI on SACH.MaTL=THE_LOAI.MaTL inner join NHA_XUAT_BAN on SACH.MaNXB=NHA_XUAT_BAN.MaNXB";
            XuLy.cmd = new SqlCommand(sql, XuLy.conn);
            SqlDataReader dr = XuLy.cmd.ExecuteReader();
            while (dr.Read())
            {
                SachHienThi s = new SachHienThi(
                    dr["MaSach"].ToString(),
                    dr["TenSach"].ToString(),
                    dr["TacGia"].ToString(),
                    int.Parse(dr["DonGiaNhap"].ToString()),
                    int.Parse(dr["DonGia"].ToString()),
                    int.Parse(dr["SoLuongCon"].ToString()),
                    dr["TenTL"].ToString(),
                    dr["TenNXB"].ToString()
                    );
                listS.Add(s);
            }
            dr.Close();
            XuLy.conn.Close();
            return listS;
        }
        public bool Them_Sach(Sach s)
        {
            string sql = "insert into SACH(TenSach,TacGia,DonGiaNhap,DonGia,SoLuongCon,MaTL,MaNXB) values(N'" + s.tensach + "', N'" + s.tacgia + "', '" + s.dongianhap + "', '" + s.dongia + "','" + s.soluongcon + "', '" + s.matl + "', '" + s.manxb + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Sua_Sach(Sach s)
        {
            string sql = "update SACH set TenSach=N'" + s.tensach + "',TacGia= N'" + s.tacgia + "',DonGiaNhap='" + s.dongianhap + "',DonGia='" + s.dongia + "',MaTL='" + s.matl + "',MaNXB='" + s.manxb + "' where MaSach='" + s.masach + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_Sach(string ma)
        {
            string sql = "delete from SACH where MaSach='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public SanPham Get_SanPham(string ma, int sl)
        {
            SanPham sp = new SanPham();
            XuLy.conn = new SqlConnection(XuLy.strConnection);
            XuLy.conn.Open();
            string sql = "Select * from SACH where MaSach='" + ma + "'";
            XuLy.cmd = new SqlCommand(sql, XuLy.conn);
            SqlDataReader dr = XuLy.cmd.ExecuteReader();
            dr.Read();
            sp.ma = ma;
            sp.ten = dr["TenSach"].ToString();
            sp.soluong = sl;
            sp.dongia = int.Parse(dr["DonGia"].ToString());
            sp.tinhtien = sp.soluong * sp.dongia;
            dr.Close();
            XuLy.conn.Close();
            return sp;
        }
        public int SoLuongCon(string ma)
        {
            try
            {
                DataTable dt;
                string sql = "select SoLuongCon from SACH where MaSach='" + ma + "'";
                dt = XuLy.CreateTable(sql);
                DataRow dr = dt.Rows[0];
                int sum = Convert.ToInt32(dr["SoLuongCon"].ToString());
                return sum;
            }
            catch { return (int)0; }
        }
        public bool CapNhatSoLuong(string ma, int sl)
        {
            string sql = "update SACH set SoLuongCon=SoLuongCon -'" + sl + "' where MaSach='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public SanPham Get_SanPhamNhap(string ma, int sl)
        {
            SanPham sp = new SanPham();
            XuLy.conn = new SqlConnection(XuLy.strConnection);
            XuLy.conn.Open();
            string sql = "Select * from SACH where MaSach='" + ma + "'";
            XuLy.cmd = new SqlCommand(sql, XuLy.conn);
            SqlDataReader dr = XuLy.cmd.ExecuteReader();
            dr.Read();
            sp.ma = ma;
            sp.ten = dr["TenSach"].ToString();
            sp.soluong = sl;
            sp.dongia = int.Parse(dr["DonGiaNhap"].ToString());
            sp.tinhtien = sp.soluong * sp.dongia;
            dr.Close();
            XuLy.conn.Close();
            return sp;
        }
        public bool CapNhatSoLuongNhap(string ma, int sl)
        {
            string sql = "update SACH set SoLuongCon=SoLuongCon +'" + sl + "' where MaSach='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }

        public List<SachHienThi> TimKiem_Sach(string key, int position)
        {
            List<SachHienThi> listS = this.GetTable_Sach();
            List<SachHienThi> listTimKiem = new List<SachHienThi>();
            switch (position)
            {
                case 0:
                    foreach (SachHienThi s in listS)
                    {
                        if (s.masach.Equals(key))
                        {
                            listTimKiem.Add(s);
                            break;
                        }
                    }
                    break;
                case 1:
                    foreach (SachHienThi s in listS)
                    {
                        if (s.tensach.ToUpper().Contains(key.ToUpper()))
                        {
                            listTimKiem.Add(s);
                        }
                    }
                    break;
                case 2:
                    foreach (SachHienThi s in listS)
                    {
                        if (s.tentl.ToUpper().Contains(key.ToUpper()))
                        {
                            listTimKiem.Add(s);
                        }
                    }
                    break;
                case 3:
                    foreach (SachHienThi s in listS)
                    {
                        if (s.tennxb.ToUpper().Contains(key.ToUpper()))
                        {
                            listTimKiem.Add(s);
                        }
                    }
                    break;
                case 4:
                    foreach (SachHienThi s in listS)
                    {
                        if (s.tacgia.ToUpper().Contains(key.ToUpper()))
                        {
                            listTimKiem.Add(s);
                        }
                    }
                    break;
                default: break;
            }
            return listTimKiem;
        }
    }
}
