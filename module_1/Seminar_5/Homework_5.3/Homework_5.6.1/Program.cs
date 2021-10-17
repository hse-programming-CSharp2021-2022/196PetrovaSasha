using System;

namespace Homework_5._6._1
{
    
    class Program
    {
        
        static int[] resize(int[] mas)
        {
            int i = 0;
            int[] result = new int[mas.Length];
            result[0] = mas[0];
            for (int j = 1; j < mas.Length; j++)
            {
                if ((mas[j] + result[i]) / 3 == 0)
                {
                    result[i] = result[i] * mas[j];
                    i += 1;
                }
                else
                {
                    result[i] = mas[j];
                    i += 1;
                }
            }
            Array.Resize(ref result, i + 1);
            return result;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(1, 100);
            }
            int[] result = resize(mas);
            for (int j = 0; j < result.Length; j++)
            {
                Console.WriteLine(result[j] + "\n");
            }
        }
    }
}
