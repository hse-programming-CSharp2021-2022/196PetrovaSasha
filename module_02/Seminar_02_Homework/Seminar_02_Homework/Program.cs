using System;
class ConsolePlate
{
    char _plateChar;
    ConsoleColor _plateColor = ConsoleColor.White;
    public ConsolePlate()
    {
        _plateChar = '+';
    }
    public ConsolePlate(char plateChar,ConsoleColor plateColor)
    {
        this._plateChar = plateChar;
        this._plateColor = plateColor;
    }
    public char PlateChar
    {
        set
        {
            if (value > 31)
            {
                _plateChar = value;
            }
            else
            {
                _plateChar = '+';
            }
        }
        get
        {
            return _plateChar;
        }
    }
    public ConsoleColor PlateColor
    {
        set
        {
            _plateColor = value;
        }
        get
        {
            return _plateColor;
        }
    }
}
class Program
{
    static void Main()
    {
        ConsolePlate cp = new ConsolePlate();
        ConsolePlate[] somePlates =
        {
            new ConsolePlate('*',ConsoleColor.Red),
            cp,
            new ConsolePlate((char)12,ConsoleColor.Green)
        };
        foreach(ConsolePlate conPL in somePlates)
        {
            Console.ForegroundColor = conPL.PlateColor;
            Console.Write(conPL.PlateChar);
        }
    }

}