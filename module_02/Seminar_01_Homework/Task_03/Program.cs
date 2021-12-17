using System;
public class Polygon
{
    int numb;
    double radius;
    public Polygon(int n=3,double r = 1)
    {
        numb = n;
        radius = r;
    }
    public double Perimetr
    {
        get
        {
            return 2 * numb * radius * (Math.Tan(Math.PI / numb));
        }
    }
    public double Area
    {
        get
        {
            return Perimetr * radius / 2;
        }
    }
    public string PolygonData()
    {
        return $"{numb} {radius} {Perimetr} {Area}";
    }
}
public class Programm
{
    static void Main()
    {
        Polygon polygon = new Polygon();
        object polygonData = polygon.PolygonData;
        Console.WriteLine(polygonData);
        double radius;
        int number;
        while (Console.ReadKey(true).Key == ConsoleKey.Escape)
        {
            while(int.TryParse(Console.ReadLine(),out number) & number >= 3)
            {
                Console.WriteLine("Введите число сторон");
            }
            while(double.TryParse(Console.ReadLine(),out radius) & radius > 0)
            {
                Console.WriteLine("Введите радиус");
            }
            polygon = new Polygon(number, radius);
            Console.WriteLine("***");
            Console.WriteLine(polygon.PolygonData());
            Console.WriteLine("Для выхода нажмите Escape");
        }
    }
}