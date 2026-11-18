using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoVM.Domein
{
    public class PrioriteitsPlanningMethode : IPlanningMethode
    {
        public Planning MaakPlanning(string naam,List<Taak> taken)
        {
            return new Planning(naam, taken.OrderByDescending(x => x.Prioriteit).ToList());
        }
    }
}
