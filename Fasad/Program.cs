using System;

namespace fasad
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer = new Programmer();
            VisualStudioFasade fasade = new VisualStudioFasade();
            programmer.CreateApplication(fasade);
        }
    }
}
