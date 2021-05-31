using System;

namespace fabric_metod
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer panelDev = new PanelDeveloper("PanelCompany");
            panelDev.Create();
            Console.WriteLine(panelDev.Name);
            Developer woodDev = new WoodDeveloper("WoodCompany");
            woodDev.Create();
            Console.WriteLine(woodDev.Name);
        }
    }
}
