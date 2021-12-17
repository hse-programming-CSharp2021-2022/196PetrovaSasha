using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Sphere:Shape
    {
        double rad;
        public Sphere(double radius):base(radius)
        {
            rad = radius;
        }
        public override double Square(double rad)
        {
            return 4 * Math.PI * Math.Pow(rad, 2);
        }
        public override double V(double rad)
        {
            return 4 / 3 * Math.PI * Math.Pow(rad, 3);
        }
        public void Getinfo(Sphere sphere)
        {
            Console.WriteLine($"Шар  Радиус {sphere.rad}  площадб поверхности {Square(sphere.rad)} объем {V(sphere.rad)}");
        }
    }
}
