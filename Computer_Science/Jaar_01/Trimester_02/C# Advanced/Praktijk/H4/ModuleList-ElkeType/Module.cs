using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleList_ElkeType
{
    public class Module
    {
        public string Naam {  get; set; }
        public string School { get; set;}
        public string Registratie { get; set;}

        public Module(string name, string school, string regristation) 
        {
            Naam = name;
            School = school;
            Registratie = regristation;
        }

        public override string ToString()
        {
            return $"{Naam} {Registratie} | {School}";
        }
    }
}
