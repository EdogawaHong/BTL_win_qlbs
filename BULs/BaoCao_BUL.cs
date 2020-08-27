using DALs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class BaoCao_BUL
    {
        BaoCao_DAL baoCao_DAL = new BaoCao_DAL();
        public DataTable BaoCao_Ngay(string date)
        {
            return baoCao_DAL.BaoCao_Ngay(date);
        }
        public int BaoCao_TongSL_Ngay(string date)
        {
            return baoCao_DAL.BaoCao_TongSL_Ngay(date);
        }
        public int BaoCao_TongDT_Ngay(string date)
        {
            return baoCao_DAL.BaoCao_TongDT_Ngay(date);
        }
        public DataTable BaoCao_Thang(string month)
        {
            return baoCao_DAL.BaoCao_Thang(month);
        }
        public int BaoCao_TongSL_Thang(string month)
        {
            return baoCao_DAL.BaoCao_TongSL_Thang(month);
        }
        public int BaoCao_TongDT_Thang(string month)
        {
            return baoCao_DAL.BaoCao_TongDT_Thang(month);
        }
        public DataTable BaoCao_Nam(string year)
        {
            return baoCao_DAL.BaoCao_Nam(year);
        }
        public int BaoCao_TongSL_Nam(string year)
        {
            return baoCao_DAL.BaoCao_TongSL_Nam(year);
        }
        public int BaoCao_TongDT_Nam(string year)
        {
            return baoCao_DAL.BaoCao_TongDT_Nam(year);
        }
    }
}
