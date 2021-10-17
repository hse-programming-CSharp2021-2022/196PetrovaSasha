using System;

namespace Homework_7._2
{
    class Program
    {
        /*
         * Задание 2​

Дана строка (вводится пользователем), состоящая из русских слов, разделенных пробелами (одним или несколькими). Вывести количество слов, состоящих более чем из четырех букв.​
        */
        static int MoreThenFour(string s)
        {
            int k = 0;
            int j=0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]!=' ')
                {
                    j+=1;
                }
                else
                {
                    if (j > 4)
                    {
                        k += 1;

                    }
                    j = 0;
                }
            }
            return k;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(MoreThenFour(s));

        }
    }
}
