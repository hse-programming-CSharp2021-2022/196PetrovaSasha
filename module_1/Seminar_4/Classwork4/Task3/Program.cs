using System;

namespace Task3
{
    class Program
    {
        static double Integral( int A,int delta)
        {
            double S = 0;
            delta = 0;
            while (delta < A)
            {
                if (A - delta > delta)
                {
                    S += (delta * delta + (2 * Math.Pow(delta, 2))) / 2 * delta;
                    delta += delta;
                }
                else
                {
                    S += (delta * delta + (2 * Math.Pow(A, 2))) / 2 * (A - delta);
                    break;
                }
            }
            return S;
        }
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string d = Console.ReadLine();
            int a = int.Parse(x);
            int b = int.Parse(d);
            Console.WriteLine(Convert.ToString(Integral(a,b)))

        }
    }
}
