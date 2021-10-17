using System;

namespace Task5
{
    class Program
    {
        static int Num(string a, string b, string c)
        {
            string a1 = Convert.ToString(a[1]) + Convert.ToString(a[2]);

            string b1 = Convert.ToString(b[1]) + Convert.ToString(b[2]);
            string c1 = Convert.ToString(c[1]) + Convert.ToString(c[2]) ;
            int a2 = int.Parse(a1);
            int b2 = int.Parse(b1);
            int c2 = int.Parse(c1);
            int[] A = new int[] { a2, b2, c2 };
            int min = 10000;
            foreach (int i in A)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;

        }

        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string w = Console.ReadLine();
            Console.WriteLine(Convert.ToString(Num(x, y, w)));
        }
    }
}
