using System;

namespace Task4
{
    class Program
    {
        static string Por(string s)
        {
            int i;
            string c="";
            for (i=3; i >= 0; i--)
            {
                c=c+ Convert.ToString(s[i]);

            }
            return c;
        }
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            Console.WriteLine(Por(x));
        }
    }
}
