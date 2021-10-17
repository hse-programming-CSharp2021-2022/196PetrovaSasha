using System;

namespace Homework_7._3
{
    class Program
    {
        static int Search(string s)
        {
            string c="АБВГДЕЁЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            int k = 0;
            int j = 0;
            string v = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    v += s[i];
                }
                else
                {
                    if (c.Contains(v[0]))
                    {
                        k += 1;

                    }
                    v = "";
                }
            }
            return k;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(Search(s));
        }
    }
}
