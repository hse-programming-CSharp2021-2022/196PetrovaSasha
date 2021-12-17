using System;
class Creature
{
    public string name;
    public int speed;
    public Creature(string Name,int Speed)
    {
        if (Name != null)
        {
            name = Name;
        }
        else
        {
            throw new ArgumentException("Пумтое имя");
        }
        if (Speed > 0)
        {
            speed = Speed;
        }
        else
        {
            throw new ArgumentException("Некорректная скорость");
        }
    }
    public string Run(Creature creature)
    {
        return $"I am run with speed {this.speed}";
    }
    public override string ToString()
    {
        return $"I am run with speed {this.speed}. My name is {this.name}" ;
    }

}
class Draft : Creature
{
    int strength;
    Random rnd = new Random();
    public Draft(string Name,int Speed,int Strength) : base(Name, Speed)
    {
        if (1 <= Strength  & Strength <= 20)
        {
            strength = Strength;
        }
        else
        {
            strength = rnd.Next(1, 21);
        }
    }
    public string Run(Draft draft)
    {
        return $"I am run with speed {this.speed}, my strength is {this.strength}";
    }
    static void MakeNewStaf()
    {
        Console.WriteLine("I create a new staf");
    }
}
class Elf : Creature
{
    public int age;
    Random rnd = new Random();
    public Elf(string Name, int Speed) : base(Name, Speed)
    {
        age = rnd.Next(100, 201);
    }
    public string Run(Elf elf)
    {
        return $"I am run with speed {(this.speed+this.age)/77}, my age is {this.age}";
    }
}
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int n = Console.Read();
        Creature[] creat =new Creature[n];
        for (int i = 0; i < creat.Length; i++)
        {
            int len = rnd.Next(3, 9);
            string name = "";
            for (int j = 0; j <= len; j++)
            {
                char res = (char)rnd.Next(97, 122);
                name += res.ToString();
            }
            int speed = rnd.Next(10, 19);
            int f = rnd.Next(1, 4);
            if (f == 1)
            {
                Creature cr = new Creature(name, speed);
                creat[i] = cr;
                Console.WriteLine(cr.Run(cr));
            }
            else if (f == 2)
            {
                Draft dr = new Draft(name, speed, rnd.Next(-50, 51));
                creat[i] = dr;
                Console.WriteLine(dr.Run(dr));
            }
            else
            {
               
                Elf elf = new Elf(name, speed);
                creat[i] = elf;
                Console.WriteLine(elf.Run(elf));
            }
            
        }
    }
}