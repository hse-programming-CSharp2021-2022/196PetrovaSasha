using System;

namespace Recursia
{
    class Program
    {
        static double Rec(double m,double n)
        {
            if (m == 0)
            {
                return n++;
            }
            else if (m>0 && n == 0)
            {
                return Rec(m - 1,1);
            }
            else if (m>0 && n > 0)
            {
                return Rec(m - 1, Rec(m, n - 1));
            }
            else
            {
                return -1;
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string c = Console.ReadLine();
            double x = double.Parse(s);
            double y = double.Parse(c);
            Console.WriteLine(Convert.ToString(Rec(x, y)));
        }
    }
}
