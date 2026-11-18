using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoVM.Domein
{
    public class Planner
    {
        public List<Medewerker> Medewerkers = new List<Medewerker>();
        public List<Taak> Taken = new();
        public List<Planning> Planningen = new();

        public Planner(IPlanningMethode planningsMethode)
        {
            PlanningsMethode = planningsMethode;
            Medewerkers.Add(new Medewerker("jos"));
            Taken.Add(new Taak(10, DateTime.Now, 5, "Vloer leggen", 120, Medewerkers[0]));
            Taken.Add(new Taak(11, DateTime.Now, 2, "Lamp vervangen", 20, Medewerkers[0]));
            Taken.Add(new Taak(12, DateTime.Now, 1, "Stopcontact vervangen", 50, Medewerkers[0]));
        }

        public IPlanningMethode PlanningsMethode { get; set; }
        public Planning MaakPLanning(string naam)
        {
            return PlanningsMethode.MaakPlanning(naam,Taken);
        }
    }
}
