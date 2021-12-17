using System;
class Point
{
    public double X { get; set; }
    public double Y { get; set; }
    public Point(double x,double y)
    {
        X = x;
        Y = y;
    }
    public Point() : this(0, 0) { }
    public double Ro
    {
        get
        {
            return X * X + Y * Y;
        }
        set { }
    }
    public double Fi
    {
        get
        {
            if (X>0 & Y >= 0)
            {
                return 1/(Math.Atan(Y / X));
            }
            else if (X>0 & Y<0)
            {
                return 1 / (Math.Atan(Y / X)) + 2 * Math.PI;
            }
            else if (X < 0)
            {
                return 1 / (Math.Atan(Y / X)) + Math.PI;
            }
            else if (X==0 & Y > 0)
            {
                return Math.PI / 2;
            }
            else if (X==0 & Y < 0)
            {
                return 3 * Math.PI / 2;
            }
            else
            {
                return 0;
            }
        }
        set { }
    }
    public string PointData
    {
        get
        {
            //return string.Format("X={0:F2};Y={1:F2};Fi={2;F2};Ro={3:F2}", X, Y, Fi, Ro);
            return $"{X} {Y} {Ro} {Fi}";
        }
    }

}
class Programm
{
    static void Main()
    {
        Point a, b, c;
        a = new Point(5, 4);
        Console.WriteLine(a.PointData);
        b = new Point(2, 5);
        Console.WriteLine(b.PointData);
        c = new Point();
        double x = 0, y = 0;
        while(x==0 & y == 0)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
           
        }
        c.X = x;
        c.Y = y;
        Console.WriteLine(c.PointData);
        Console.WriteLine("****");
        List<Point> points = new List<Point>();
        points.Add(c);
        points.Add(b);
        points.Add(a);
        PointsComparer res= new PointsComparer();
        points.Sort(new PointsComparer());
        foreach(Point point in points)
        {
            Console.WriteLine(point.PointData);
        }
    }
    
    public class PointsComparer : IComparer<Point>
    {
        public int Compare(Point a, Point b)
        {
            
            if ((a.Ro == b.Ro))
                return 0;
            if ((a.Ro < b.Ro))
                return -1;

            return 1;
        }
    }
}