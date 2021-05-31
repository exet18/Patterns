using System;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Roadster roadster = new Roadster();
            Director director = new Director();
            director.Create(roadster);
            Console.WriteLine(roadster.comp.ToString());
            Console.WriteLine("======================");
            Anigilator anigilator = new Anigilator();
            Director director1 = new Director();
            director1.Create(anigilator);
            Console.WriteLine(anigilator.comp.ToString());
        }
    }
}
