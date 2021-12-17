using System;
class MyComplex
{
    public double re, im;
    public MyComplex(double xre,double xim)
    {
        re = xre;im = xim;
    }
    public static MyComplex operator --(MyComplex mc)
    {
        return new MyComplex(mc.re - 1, mc.im - 1);
    }
    public double Mod()
    {
        return Math.Abs(re * re + im * im);
    }
    static public bool operator true(MyComplex mc)
    {
        if (mc.Mod() > 1.0) return true;
        else
            return false;
    }
    public static bool operator false(MyComplex mc)
    {
        if (mc.Mod() <= 1.0)
        {
            return true;
        }
        else
            return false;
    } 
    public static MyComplex operator +(MyComplex mc,MyComplex mc1)
    {
        return new MyComplex(mc.re + mc1.re, mc.im + mc1.im);
    }
    public static MyComplex operator *(MyComplex mc,MyComplex mc1)
    {
        return new MyComplex(mc.re * mc1.re - mc.im * mc1.im, mc.im * mc1.re + mc.re * mc1.im);
    }
    public static MyComplex operator -(MyComplex mc, MyComplex mc1)
    {
        return new MyComplex(mc.re - mc1.re, mc.im - mc1.im);
    }
    public static MyComplex operator /(MyComplex mc, MyComplex mc1)
    {
        return new MyComplex((mc.re * mc1.re + mc.im * mc1.re) / (mc1.re * mc1.re + mc1.im * mc1.im), (mc1.re * mc.im - mc.re * mc1.im) / (mc1.re * mc1.re + mc1.im * mc1.im));
    }

}
class Program
{
    static void Display(MyComplex cs)
    {
        Console.WriteLine($"real={cs.re}   image={cs.im}");
    }
    static void Main()
    {
        MyComplex c1 = new MyComplex(4, 3.3);
        Console.WriteLine($"Модуль исходного числа равен {c1.Mod} ");
        while (c1)
        {
            Console.Write("c1=>");
            Display(c1);
            c1--;
        }
        Console.WriteLine($"Модуль полученного числа равен {c1.Mod}");
        MyComplex c2 = new MyComplex(2, 2);
        MyComplex plus = c1 + c2;
        Console.WriteLine("результат сложения");
        Display(plus);
        MyComplex minus = c1 - c2;
        Console.WriteLine("результат вычетания");
        Display(minus);
        MyComplex umn = c1 * c2;
        Console.WriteLine("результат умножения");
        Display(umn);
        MyComplex del = c1 * c2;
        Console.WriteLine("результат деления");
        Display(del);
    }
}
