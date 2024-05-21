using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleList_ElkeType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uit klasse Module
            Console.WriteLine("List van de verschillende modules");
            ModuleList<Module> lst3 = new ModuleList<Module>();
            Module m1 = new Module("Programmeren 1 in C#", "PCVO Limburg Campus Hasselt", "2016");
            Module m2 = new Module("Programmeren 2 in C#", "PCVO Limburg Campus MaasMechelen",
            "2017");
            lst3.Add(m1);
            lst3.Add(m2);
            Console.WriteLine(lst3.ToString());
            Console.Read();
        }
    }
}
