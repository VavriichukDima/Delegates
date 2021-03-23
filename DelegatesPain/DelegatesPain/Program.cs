using System;

namespace DelegatesPain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = new A();
            var b = new B();
            b.ShowHandler = B.Show;
            b.ShowHandler(a.Calc1(b.PowHandler 1, 2, 3).Invoke(2));
        }
    }
}
