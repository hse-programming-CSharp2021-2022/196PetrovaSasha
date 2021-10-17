using System;

namespace Homework_7
{
    class Program
    {
        //задание 1

        static string New(string s)
        {
            bool x = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (x == false && s[i]!=' ') 
                {

                }
                else if (x==false && s[i]==' ')
                {
                    x = true;
                }
                else if (x==true && s[i]==' ')
                {
                    s = s.Remove(i);
                }
                else if (x==true && s[i]!=' ')
                {
                    x = false;
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = New(s);
            Console.WriteLine(s);
        }
    }
}
