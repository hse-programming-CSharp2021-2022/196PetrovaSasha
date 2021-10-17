using System;

namespace Seminar7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 99;
            int[] mas = new int[n];
            Random rnd = new Random();
            
            for (int i = 0; i < n; i++)
            {
                 int x= rnd.Next(0,100);
                if (Array.Exists(mas, x))
                {
                    mas[i] = x;
                }

            }

            char[] mas1 = new char[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Array.Copy(mas, mas1, n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas1[i]);
            }
            Array.Sort(mas1);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Array.Reverse(mas1);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }
    }
}
