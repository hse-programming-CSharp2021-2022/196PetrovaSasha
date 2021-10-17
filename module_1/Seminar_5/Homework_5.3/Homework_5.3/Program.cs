using System;

namespace Homework_5._3
{
    class Program
    {

        static decimal[] Sin(int x,int n)
        {
            decimal[] sin = new decimal[n];
            int s = 3;
            int f = 6;
            sin[0] = x;
            for (int i = 1; i < sin.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sin[i] = (decimal)((Math.Pow(x, s) / f)*(-1));
                }
                else
                {
                    sin[i] = (decimal)((Math.Pow(x, s) / f));
                }
                s += 2;
                f = f * s;
            }
            return sin;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int x = int.Parse(Console.ReadLine());
            decimal[] sin1= Sin(1,  n);
            decimal[] sinx = Sin(x, n);
            for (int i = 0; i < sin1.Length; i++)
            {
                Console.WriteLine(sin1[i] + "\n");
            }
            for (int i = 0; i < sin1.Length; i++)
            {
                Console.WriteLine(sinx[i] + "\n");
            }
        }
    }
}
