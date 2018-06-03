using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsV2.DataTypes
{
    class Clean
    {
        private static String[] illegalList = { "/", "\\", "-", "*", "--", "?", "$" };
        private static String err = "Carater proibido! Não pode usar os carateres ";
        public static bool IsClean(String s, params String[] exceptions)
        {
            String[] tmp = illegalList;
            // Remove exceptions temporarily from the list
            foreach (String x in exceptions)
            {
                bool isNotX(String n)
                {
                    return !n.Equals(x);
                }
                
                tmp = Array.FindAll(tmp, isNotX).ToArray();
            }

            // Testing if there are illegal characters
            foreach (String e in tmp)
            {
                if (s.Contains(e)) return false;
            }
            return true;
        }

        public static String Err()
        {
            String ret = err;
            foreach (String e in illegalList)
            {
                ret += e + " ";
            }
            return ret;
        }
    }
}
