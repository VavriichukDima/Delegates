using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPain
{
    public class B
    {
        private Action<bool> _showHandler;
        private Func<int, int, int> _powHandler;
        public Action<bool> ShowHandler { get; set; }
        public Func<int, int, int> PowHandler { get; set; }

        private static void Show(bool x)
        {
            Console.WriteLine(x);
        }

        private static int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
