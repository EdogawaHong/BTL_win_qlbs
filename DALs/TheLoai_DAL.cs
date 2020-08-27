using DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class TheLoai_DAL
    {
        public List<TheLoai> GetTable_TL()
        {
            List<TheLoai> listTL = new List<TheLoai>();
            XuLy.conn = new SqlConnection(XuLy.strConnection);
            XuLy.conn.Open();
            string sql = "Select * from THE_LOAI";
            XuLy.cmd = new SqlCommand(sql, XuLy.conn);
            SqlDataReader dr = XuLy.cmd.ExecuteReader();
            while (dr.Read())
            {
                TheLoai tl = new TheLoai(
                    dr["MaTL"].ToString(),
                    dr["TenTL"].ToString());
                listTL.Add(tl);
            }
            dr.Close();
            XuLy.conn.Close();
            return listTL;
        }
        public bool Them_TL(TheLoai tl)
        {
            string sql = "insert into THE_LOAI(TenTL) values(N'" + tl.ten + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Sua_TL(TheLoai tl)
        {
            string sql = "update THE_LOAI set TenTL=N'" + tl.ten + "' where MaTL='" + tl.ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_TL(string ma)
        {
            string sql = "delete from THE_LOAI where MaTL='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public List<TheLoai> TimKiem_NXB(string key)
        {
            List<TheLoai> listTL = this.GetTable_TL();
            List<TheLoai> list = new List<TheLoai>();
            try
            {
                int k = int.Parse(key);
                foreach (TheLoai tl in listTL)
                {
                    if (tl.ma.Equals(key))
                    {
                        list.Add(tl);
                        break;
                    }
                }
            }
            catch
            {
                foreach (TheLoai tl in listTL)
                {
                    if (tl.ten.ToUpper().Contains(key.ToUpper()))
                    {
                        list.Add(tl);
                    }
                }
            }
            return list;
        }
    }
}
