using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPain
{
    public class A
    {
        public Predicate<int> Predicate { get; set; }
        public static int Calc()
        {
            
        }

        public static bool Result(int z)
        {
            if ((B.PowHandler % z) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
