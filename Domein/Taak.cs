using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoVM.Domein
{
    public class Taak
    {
        public Taak(int id, DateTime deadline, int prioriteit, string naam, int duur, Medewerker medewerker)
        {
            Id = id;
            Deadline = deadline;
            Prioriteit = prioriteit;
            Naam = naam;
            Duur = duur;
            Medewerker = medewerker;
        }

        public int Id { get; set; }
        public DateTime Deadline { get; set; }
        public int Prioriteit {  get; set; }
        public string Naam { get; set; }
        public int Duur {  get; set; }

        public Medewerker Medewerker { get; set; }
        public override string ToString()
        {
            return $"{Id},{Prioriteit},{Naam},{Duur}";
        }
    }
}
