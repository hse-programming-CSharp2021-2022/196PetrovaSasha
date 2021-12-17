using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Cylinder:Shape
    {
        double rad;
        double h;
        public Cylinder(double radius,double H) : base(radius)
        {
            rad = radius;
            h = H;
        }
        public double Square(double rad,double h)
        {
            return 2 * Math.PI * h * rad + 2 * Math.PI * rad * rad;
        }
        public double V(double rad,double h)
        {
            return Math.PI * Math.Pow(rad, 2)*h;
        }
        public void Getinfo(Cylinder cylinder)
        {
            Console.WriteLine($"Цилиндр  Радиус {cylinder.rad}  площадь поверхности {Square(cylinder.rad,h)} объем {V(cylinder.rad,cylinder.h)}");
        }
    }
}
