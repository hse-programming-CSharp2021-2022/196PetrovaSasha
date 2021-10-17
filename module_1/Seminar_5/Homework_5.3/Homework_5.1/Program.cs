using System;

namespace Homework_5._1
{
    class Program
    {
        static int[] Generate()
        {
            int[] mas = new int[99];
            Random rnd = new Random();
            for (int i = 0; i < 99; i++)
            {
                while (true)
                {


                    int x = rnd.Next(1, 100);
                    for (int j = 0; j < i; j++)
                    {
                        if (mas[j] == x)
                        {

                        }
                        else
                        {
                            mas[i] = x;
                            break;
                        }
                    }
                }
            }
            return mas;
        }
        static int Search(int[] mas)
        {
            for (int i = 1; i < 100; i++)
            {
                bool x = false;
                for (int j = 0; j < mas.Length; j++)
                {
                    if (mas[j] == i) { x = true; }

                }
                if (x == false)
                {
                    return i;
                }
            }
            return 0;
            
        }
        static void Main(string[] args)
        {
            int[] mas = Generate();
            int x = Search(mas);
            Console.WriteLine(x);

        }
    }
}
