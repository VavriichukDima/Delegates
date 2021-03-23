using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPain
{
    public class A
    {
        private double _powResult;
        public double PowResult { get; set; }

        public Predicate<double> Calc(Func<double, double, double> powHandler, double x, double y)
        {
            _powResult = powHandler(x, y);
            Predicate<double> calcDelega = Result;
            return calcDelega;
        }

        private bool Result(double x)
        {
            return _powResult % x == 0;
        }
    }
}
