using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using System.Data.SqlClient;

namespace DALs
{
    public class NhanVien_DAL
    {
        public List<NhanVien> GetList_NV()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            XuLy.conn = new SqlConnection(XuLy.strConnection);
            XuLy.conn.Open();
            string sql = "Select * from NHAN_VIEN";
            XuLy.cmd = new SqlCommand(sql, XuLy.conn);
            SqlDataReader dr = XuLy.cmd.ExecuteReader();
            while (dr.Read())
            {
                NhanVien nv = new NhanVien(
                    dr["MaNV"].ToString(),
                    dr["TenNV"].ToString(),
                    dr["DiaChi"].ToString(),
                    dr["Sdt"].ToString(),
                    dr["MatKhau"].ToString());
                nhanViens.Add(nv);
            }
            dr.Close();
            XuLy.conn.Close();
            return nhanViens;
        }
        public bool Them_NV(NhanVien nv)
        {
            string sql = "insert into NHAN_VIEN(TenNV,DiaChi,Sdt,MatKhau) values( N'" + nv.ten + "', N'" + nv.diachi + "', '" + nv.sdt + "', '" + nv.matkhau + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
    }
}
