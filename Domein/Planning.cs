using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoVM.Domein
{
    public class Planning
    {
        public Planning(string naam, List<Taak> taken)
        {
            Naam = naam;
            Taken = taken;
        }

        public string Naam {  get; set; }
        public List<Taak> Taken { get; set; } = new();
        public override string ToString()
        {
            string taken=string.Join('\n',Taken.ToList());
            return $"{Naam},\n{taken}";
        }
    }
}
