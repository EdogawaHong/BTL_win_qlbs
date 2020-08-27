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
    public class KhachHang_DAL
    {
        public List<Person> GetTable_KH()
        {
            List<Person> people = new List<Person>();
            XuLy.conn = new SqlConnection(XuLy.strConnection);
            XuLy.conn.Open();
            string sql = "Select * from KHACH_HANG";
            XuLy.cmd = new SqlCommand(sql, XuLy.conn);
            SqlDataReader dr = XuLy.cmd.ExecuteReader();
            while (dr.Read())
            {
                Person p = new Person(
                    dr["MaKH"].ToString(),
                    dr["TenKH"].ToString(),
                    dr["DiaChi"].ToString(),
                    dr["Sdt"].ToString());
                people.Add(p);
            }
            dr.Close();
            XuLy.conn.Close();
            return people;
        }
        public bool Them_KH(Person p)
        {
            string sql = "insert into KHACH_HANG(TenKH,DiaChi,Sdt) values(N'" + p.ten + "', N'" + p.diachi + "', '" + p.sdt + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Sua_KH(Person p)
        {
            string sql = "update KHACH_HANG set TenKH=N'" + p.ten + "',DiaChi=N'" + p.diachi + "',Sdt='" + p.sdt + "' where MaKH='" + p.ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_KH(string ma)
        {
            string sql = "delete from KHACH_HANG where MaKH='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public List<Person> TimKiem_KH(string key)
        {
            List<Person> people = this.GetTable_KH();
            List<Person> listNXB = new List<Person>();
            try
            {
                int k = int.Parse(key);
                foreach (Person p in people)
                {
                    if (p.ma.Equals(key))
                    {
                        listNXB.Add(p);
                        break;
                    }
                }
            }
            catch
            {
                foreach (Person p in people)
                {
                    if (p.ten.ToUpper().Contains(key.ToUpper()))
                    {
                        listNXB.Add(p);
                    }
                }
            }
            return listNXB;
        }
    }
}
