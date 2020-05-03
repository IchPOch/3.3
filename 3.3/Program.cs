using System;

namespace _3._3
{
    class Program
    {
        static double f(double x, out double y)
        {
            if (x >= 0.9) y = 1 / Math.Pow(1 + x, 2);
            else if (x >= 0) y = 0.2 * x + 0.1;
            else y = x * x + 0.2;
            return y;
        }

        static void Main(string[] args)
        {
            double y;
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            if (b < a || h <= 0) Console.WriteLine("Неккоректно введены данные");
            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i,out y));
        }
    }

}
