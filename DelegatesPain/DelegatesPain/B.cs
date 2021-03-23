using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPain
{
    public class B
    {
        public Action<bool> ShowHandler { get; set; }
        public double Pow(double x, double y)
        {
            return x * y;
        }
    }
}
