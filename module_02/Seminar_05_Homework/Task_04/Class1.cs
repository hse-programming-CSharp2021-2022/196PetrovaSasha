using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Class1
    {
        static void Main()
        {
            Random rnd = new Random();
            Shape[] figures = new Shape[rnd.Next(3, 5+1)];
            for (int i=0;  i<figures.Length; i++)
            {
                int f = rnd.Next(1, 4);
                if (f == 1)
                {
                    Circle c = new Circle(rnd.Next(2, 10));
                    figures[i] = c;
                    c.Getinfo(c);
                }
                else if (f == 2)
                {
                    Sphere s = new Sphere(rnd.Next(2, 10));
                    figures[i] =s;
                    s.Getinfo(s);
                }
                else
                {
                    Cylinder cyl = new Cylinder(rnd.Next(2, 10), rnd.Next(2, 10));
                    figures[i] = cyl;
                    cyl.Getinfo(cyl);
                }
            }
           
            
        }
    }
}
