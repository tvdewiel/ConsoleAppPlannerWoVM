using ConsoleAppPlannerWoVM.Domein;

namespace ConsoleAppPlannerWoVM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            

            Console.WriteLine("Hoe plannen (prioriteit,duur):");
            string planningsmethode=Console.ReadLine();
            IPlanningMethode planningMethode=null;
            if (planningsmethode =="prioriteit")
            {
                planningMethode = new PrioriteitsPlanningMethode();
            }
            else if (planningsmethode == "duur")
            {
                planningMethode = new DuurPlanningsMethode();
            }
            Planner planner = new Planner(planningMethode);
            //planner.PlanningsMethode = planningMethode;
            Planning planning = planner.MaakPLanning("woensdagplanning");
            Console.WriteLine(planning);
        }
    }
}
