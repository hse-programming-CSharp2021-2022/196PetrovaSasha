using System;

namespace Tasks
{
    class Program
    {
        static int Function1(int x)
        {
            int step = 1;
            int Fx = 0;
            do
            {
                if (step == 1)
                {
                    Fx += (x + x);
                }
                else if (step == 2)
                {
                    Fx += -(x + x + x);
                }
                else if (step == 3)
                {
                    Fx += (x + x + x + x + x + x + x + x + x);
                }
                else if (step == 4)
                {
                    Fx += (x + x + x + x + x + x + x + x + x + x + x + x);
                }
                x = x * x;
                step++;

            } while (step <= 4);
            return Fx;

        }
        static void Main(string[] args)
        {

            while (Console.ReadKey().Key!=ConsoleKey.Enter)
            {
                string s = Console.ReadLine();
                int x1 = int.Parse(s);
                Console.WriteLine(Function1(x1));

            }

        }
    }
}
