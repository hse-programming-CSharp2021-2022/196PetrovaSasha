using System;

namespace Seminar5
{
    class Program
    { 
        static void Replace( int[] m1,int index)
        {
            int i;
            for (i=m1.Length-1; i >= index; i--)
            {
                m1[i] = m1[i = 1];
            }
            m1[m1.Length] = m1[m1.Length - 1];

        }
        static void Main(string[] args)
        {
        int n = 10;
        Random r = new Random();
        int[] mas = new int[n];
            for (int i=0; i<mas.Length; i++)
            {
                mas[i] = r.Next(-10,10);


            }
            Console.WriteLine(mas);
            for (int p=0; p <= mas.Length; p++)
            {
                int ind;
                if (mas[p] % 2 == 0)
                {
                    ind = p;
                    Replace(mas, ind);
                }
            }
            Console.WriteLine(mas);
        }
    }
}
