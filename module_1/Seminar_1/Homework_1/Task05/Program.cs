using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            double a = double.Parse(a1);
            double b = double.Parse(b1);
            Console.WriteLine(Math.Sqrt((a * a) + (b * b)));
        }
    }
}
