using System;

namespace Task03
{
    class Program

    {
        static bool Corni(int a,int b,int c)
        {
            double d = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(d)) / 2 * a;
            double x2 = (-b - Math.Sqrt(d)) / 2 * a;
            Console.WriteLine(Convert.ToString(x1));
            Console.WriteLine(Convert.ToString(x2));
            return true;
        }


        static void Main(string[] args)
        {
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                string a1 = Console.ReadLine();
                string b1 = Console.ReadLine();
                string c1 =Console.ReadLine();
                int a2, b2, c2;
                int.TryParse(a1,out a2);
                int.TryParse(b1,out b2);
                int.TryParse(c1,out c2);
                Corni(a2,b2, c2);
            }

        }
    }
}
