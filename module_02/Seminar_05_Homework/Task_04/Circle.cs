using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
     class Circle:Shape
    {
        double rad;
        public Circle(double radius):base(radius)
        {
            rad = radius;

        }
        public override double Square(double rad)
        {
            return  Math.PI * rad*rad;
        }
        public override double Perimetr(double rad)
        {
            return 2 * Math.PI * rad;
        }
        public void Getinfo(Circle circle)
        {
            Console.WriteLine($"Круг  Радиус {circle.rad}  площадб поверхности {Square(circle.rad)} периметр {Perimetr(circle.rad)}");
        }
    }
}
