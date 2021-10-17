using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int x;
            x = int.Parse(s);
            Console.WriteLine(Convert.ToChar(x));
        }
    }
}
