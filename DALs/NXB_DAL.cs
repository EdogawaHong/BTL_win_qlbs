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
    public class NXB_DAL
    {
        public List<Person> GetTable_NXB()
        {
            List<Person> people = new List<Person>();
            XuLy.conn = new SqlConnection(XuLy.strConnection);
            XuLy.conn.Open();
            string sql = "Select * from NHA_XUAT_BAN";
            XuLy.cmd = new SqlCommand(sql, XuLy.conn);
            SqlDataReader dr = XuLy.cmd.ExecuteReader();
            while (dr.Read())
            {
                Person p = new Person(
                    dr["MaNXB"].ToString(),
                    dr["TenNXB"].ToString(),
                    dr["DiaChi"].ToString(),
                    dr["Sdt"].ToString());
                people.Add(p);
            }
            dr.Close();
            XuLy.conn.Close();
            return people;
        }
        public bool Them_NXB(Person p)
        {
            string sql = "insert into NHA_XUAT_BAN(TenNXB,DiaChi,Sdt) values(N'" + p.ten + "', N'" + p.diachi + "', '" + p.sdt + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Sua_NXB(Person p)
        {
            string sql = "update NHA_XUAT_BAN set TenNXB=N'" + p.ten + "',DiaChi=N'" + p.diachi + "',Sdt='" + p.sdt + "' where MaNXB='" + p.ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_NXB(string ma)
        {
            string sql = "delete from NHA_XUAT_BAN where MaNXB='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public List<Person> TimKiem_NXB(string key)
        {
            List<Person> people = this.GetTable_NXB();
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
            catch {
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
