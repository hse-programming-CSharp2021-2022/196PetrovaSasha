using System;

namespace Homework_4._7
{
    class Program
    {
        static void NodNok(int a, int b,out int Nod,out int Nok)
        {
            int nok = 0;
            int nod = 0;
            bool Nok1 = false;
            for (int i=1; i < a; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    if (Nok1 == false)
                    {
                        nok = i;
                        Nok1 = true;
                    }
                    else
                    {
                        nod = i;
                    }
                }

            }
            Nod = nod;
            Nok = nok;
        } 
        static void Main(string[] args)
        {
            int Nod = 0, Nok = 0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            NodNok(a, b, out Nod, out Nok);
        }
    }
}
