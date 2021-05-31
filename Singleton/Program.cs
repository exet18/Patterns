using System;

namespace Odinak
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Launch("Linux");
            computer.Launch("Windows");

        }
    }
}
