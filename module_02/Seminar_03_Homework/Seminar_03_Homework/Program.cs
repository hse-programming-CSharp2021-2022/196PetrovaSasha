using System;
class VideoFile
{
    string name;
    int duration;
    int quality;
    public VideoFile(string Name, int Dur,int Qual)
    {
        name = Name;
        duration = Dur;
        quality = Qual;
    }
    int Size
    {
        get
        {
            return duration * quality;
        }
    }
    public override string ToString()
    {
        return $"Имя файла {name} Размер файла {duration} качество {quality}";
    }

}
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int n = rnd.Next(5, 15);
        VideoFile[] files = new VideoFile[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($" Для файла под номером {i + 1}");
            int Dur = rnd.Next(60, 360);
            Console.WriteLine($" длинна файла {Dur}");
            int qual = rnd.Next(100, 1000);
            Console.WriteLine($"качество файла {qual}");
            int len = rnd.Next(2, 9);
            string name="";
            for (int j = 0; j <= len; j++)
            {
                char res = (char)rnd.Next(97, 122);
                name += res.ToString();
            }
            Console.WriteLine($"Имя файла {name}");
            VideoFile f = new VideoFile(name, Dur, qual);
            Console.WriteLine("Полная информация о файле");
            Console.WriteLine(f.ToString());
        }

    }
}