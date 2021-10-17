using System;

namespace Task2
{
    class Program

    {
        static string Function2(string x)
        {
            
            int a = int.Parse(x);
            int max = -1;
            string c="";
            int i;
            string max1;
            char ind;
            while (c.Length<3)
            {
                max = -1;
                for (i = 0; i <x.Length; i++)
                {
                    if (Convert.ToInt16(x[i]) > max)
                    {
                        max = x[i];
                        ind = Convert.ToChar(i);
                    }

                }
                c = c + Convert.ToString(max);
                max1 = Convert.ToString(max);
                x = x.Replace(max1, "0");
            }
            return c;

        }
        static void Main(string[] args)
        {
            
            while (Console.ReadKey().Key != ConsoleKey.Tab)
            {
                string vhod = Console.ReadLine();
                Console.WriteLine(Function2(vhod));
            }
        }
    }
}
