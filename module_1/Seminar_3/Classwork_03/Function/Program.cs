using System;

namespace Function
{
    class Program

    {
        public static bool Function(bool p,bool q)
        {
            return !(p && q) && !(p || !q);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
