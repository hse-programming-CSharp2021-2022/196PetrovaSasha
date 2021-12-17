using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Task_04
{
    public abstract class Shape
    {
        double rad;
        public Shape(double radius)
        {
            rad = radius;
        }
        public virtual double Square(double rad)
        {
            return rad;
        }
        public virtual double Perimetr(double rad)
        {
            return rad;
        }
        public virtual double V(double rad)
        {
            return 1;
        }
        public virtual void Getinfo(Shape shape)
        {
            Console.WriteLine(rad);
        }

    }
}