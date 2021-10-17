using System;

namespace Tasks
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            //Задача 1
            string n1 = Console.ReadLine();
            double n = double.Parse(n1);
            double b = (1 + Math.Sqrt(5)) / 2;
            double U = (Math.Pow(b, n) - (Math.Pow(-b, -n))) / (2 * b - 1);

        }
        */
        public static int CalkulateBine(uint n)
        {
            double b = (1 + Math.Sqrt(5));
            double un = (Math.Pow(b, n) - Math.Pow(-b, -n)) / (2 * b - 1);
            return (int)(un + 0.5);


        }
        static void Main()
        {

        }
    }
}
