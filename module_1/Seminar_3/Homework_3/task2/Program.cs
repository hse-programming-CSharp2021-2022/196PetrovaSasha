using System;

namespace task2
{
    class Program
    {
        static double Oblast(int x,int y)
        {
            if (x>0 & x < y)
            {
                return x + Math.Sin(y);
            }
            else if (x<0 & x > y)
            {
                return y - Math.Cos(x);
            }
            else
            {
                return 0.5 * x * y;
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string c=Console.ReadLine();
            int a = int.Parse(s);
            int b = int.Parse(c);
            Console.WriteLine(Convert.ToString(Oblast(a, b)));

        }
    }
}
