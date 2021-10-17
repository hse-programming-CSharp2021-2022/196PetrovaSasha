using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string U = Console.ReadLine();
            string R = Console.ReadLine();
            double I,P;
            double U1 = double.Parse(U);
            double R1 = double.Parse(R);
            I = U1 / R1;
            P = (U1 * U1) / R1;
            Console.WriteLine(I);
            Console.WriteLine(P);
        }
    }
}
