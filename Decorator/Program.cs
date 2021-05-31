using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Orders orders = new Orders(new Book("Shevchenko", "Kobzar", 5));
            orders.clientOrder("John");
            orders.Output();

            Console.WriteLine("==================");

            Orders video = new Orders(new Video("Fellow", "Ad", 5, 10));
            video.clientOrder("Jack");
            video.Output();
            
        }
    }
}
