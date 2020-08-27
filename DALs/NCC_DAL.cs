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
    public class NCC_DAL
    {
        public List<Person> GetTable_NCC()
        {
            List<Person> people = new List<Person>();
            XuLy.conn = new SqlConnection(XuLy.strConnection);
            XuLy.conn.Open();
            string sql = "Select * from NHA_CUNG_CAP";
            XuLy.cmd = new SqlCommand(sql, XuLy.conn);
            SqlDataReader dr = XuLy.cmd.ExecuteReader();
            while (dr.Read())
            {
                Person p = new Person(
                    dr["MaNCC"].ToString(),
                    dr["TenNCC"].ToString(),
                    dr["DiaChi"].ToString(),
                    dr["Sdt"].ToString());
                people.Add(p);
            }
            dr.Close();
            XuLy.conn.Close();
            return people;
        }
        public bool Them_NCC(Person p)
        {
            string sql = "insert into NHA_CUNG_CAP(TenNCC,DiaChi,Sdt) values(N'" + p.ten + "', N'" + p.diachi + "', '" + p.sdt + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Sua_NCC(Person p)
        {
            string sql = "update NHA_CUNG_CAP set TenNCC=N'" + p.ten + "',DiaChi=N'" + p.diachi + "',Sdt='" + p.sdt + "' where MaNCC='" + p.ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_NCC(string ma)
        {
            string sql = "delete from NHA_CUNG_CAP where MaNCC='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public List<Person> TimKiem_NCC(string key)
        {
            List<Person> people = this.GetTable_NCC();
            List<Person> listNCC = new List<Person>();
            try
            {
                int k = int.Parse(key);
                foreach (Person p in people)
                {
                    if (p.ma.Equals(key))
                    {
                        listNCC.Add(p);
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
                        listNCC.Add(p);
                    }
                }
            }
            return listNCC;
        }
    }
}
