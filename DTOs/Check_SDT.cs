using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class Check_SDT
    {
        public static bool Check(string sdt)
        {
            if (sdt.Length != 10) return false;
            else
            {
                try
                {
                    int i = int.Parse(sdt);
                    string c = sdt.Substring(0, 2);
                    if (c.Equals("08") || c.Equals("09") || c.Equals("03") || c.Equals("07") || c.Equals("04"))
                        return true;
                    else return false;
                }
                catch { return false; }
            }
        }
    }
}
