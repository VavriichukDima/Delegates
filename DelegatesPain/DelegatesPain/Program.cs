using System;

namespace DelegatesPain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = new A();
            var b = new B();
            b.ShowHandler = Show;
            b.ShowHandler(a.Calc(b.Pow, 2, 3).Invoke(2));
        }

        private static void Show(bool res)
        {
            Console.WriteLine(res);
        }
    }
}
