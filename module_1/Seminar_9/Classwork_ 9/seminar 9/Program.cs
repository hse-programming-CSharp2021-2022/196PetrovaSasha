using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace seminar_9
{
    class Program
    {
        static void Sort(string[] s)
        {
            
        }
        static void three(string[] s, ref List<string> name)
        {
             
            for (int i=0;i<(s.Length/2);i++)
            {
                if (s[i] == s[s.Length - 1])
                {
                    name.Add(s[i]);
                }
                
            }
        }
       
        static void Three(string[] mas,ref List<string> name)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (int.Parse(mas[i]) % 3 == 0)
                {
                    name.Add(mas[i]);
                }
            }
        }
        static void Sum(string[] mas,ref List<string> name)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].Length == 4)
                {

                }
            }
        }
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            Random rnd = new Random();
            string[] s = new string[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(1, 1000);
                s[i] = Convert.ToString(mas[i]);

            }
            
        }
    }
}
