using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlannerWoVM.Domein
{
    public interface IPlanningMethode
    {
        Planning MaakPlanning(string naam,List<Taak> taken);
    }
}
