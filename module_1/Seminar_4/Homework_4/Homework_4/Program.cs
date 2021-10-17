using System;

namespace Homework_4
{
    class Program
    {
        /// <summary>
        /// задание 2
        /// </summary>
        /// <param name="args"></param>
        static bool Shift(ref char ch)
        {
            if (ch>=65 && ch <= 90)
            {
                for (int i = 0; i < 4; i++)
                {
                    ch++;
                    if (ch == 91)
                    {
                        ch = (char)65;
                    }
                }
                return true;
            }
            else
            {
                ch = (char)64;
                return false;
            }
        }
        static void Main(string[] args)
        {
            //задание 2
            char n = (char)int.Parse(Console.ReadLine());
            bool res = Shift(ref n);
        }
    }
}
