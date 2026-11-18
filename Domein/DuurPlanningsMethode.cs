using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoVM.Domein
{
    public class DuurPlanningsMethode : IPlanningMethode
    {
        public Planning MaakPlanning(string naam,List<Taak> taken)
        {
            List<Taak> takenSort = taken.OrderBy(x => x.Duur).ToList();
            Planning p = new Planning(naam,takenSort);    
            return p;
        }
    }
}
