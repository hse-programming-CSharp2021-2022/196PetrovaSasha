using System;
using System.IO;
class Exeptions
{
    static void Main()
    {
        Console.WriteLine("1");
        int x = 0;
        try
        {
            double z = 19 / x;
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("2");
        int[] tr = new int[1];
        try
        {
            int j = tr[2];
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("3");
        string c = "f";
        try
        {
            double d = double.Parse(c);
        }
        catch(FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("4");
        var list = new List<string>();
        try
        {
            Console.WriteLine( list[0]);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("5");
        int number1 = 3000;
        int number2 = 0;
        try
        {
            Console.WriteLine(number1 / number2);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("6");
        static void SomeFunction()
        {
            throw new NotImplementedException();
        }
        try
        {
            SomeFunction();
        }
        catch (NotImplementedException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("7");
        MemoryStream ms = new MemoryStream(16);
        ms.Close();
        try
        {
            ms.ReadByte();
        }
        catch (ObjectDisposedException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("8");
        byte value = 241;
        try
        {
            sbyte newValue = (sbyte)value;
            Console.WriteLine("Converted the {0} value {1} to the {2} value {3}.",
                     value.GetType().Name, value,
                     newValue.GetType().Name,newValue);
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("9");
        try
        {
            StreamReader f = new StreamReader(@"C:\Users\vgfuyg.txt");
        }
        catch(FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("10");
        try
        {

            string dir = @"c:\78fe9lk";
            Directory.SetCurrentDirectory(dir);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }

}