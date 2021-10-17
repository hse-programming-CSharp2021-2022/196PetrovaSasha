using System;

namespace Task4
{
    class Program
    {
        static double Fun(double x)
        {
            if (x <= 0.5)
            {
                return Math.Sin(Math.PI / 2);
            }
            else if (x > 0.5)
            {
                return Math.Sin(Math.PI * (x - 1) / 2);
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double a = double.Parse(s);
            Console.WriteLine(Convert.ToString(Fun(a)));
        }
    }
}
