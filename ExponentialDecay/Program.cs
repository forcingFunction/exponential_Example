using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentialDecay
{
    class Program
    {
        static void Main(string[] args)
        {
            AnalyticalSolution aSol = new AnalyticalSolution();
            IterativeSolution iSol = new IterativeSolution();

            bool goOn = false;
            int modelSelected = 1;

            while (!goOn)
            {
                Console.WriteLine("Select the method for solving the exponential equation dC/dt = -k*C:\n");
                Console.WriteLine("1. Analytical solution to integrated form of the equation [C(t) = C_0 e^(-kt)]");
                Console.WriteLine("2. Iterative solution to dC/dt = -k * t");
                int.TryParse(Console.ReadLine(),out modelSelected);
                if ((modelSelected > 2) || (modelSelected < 1))
                {
                    Console.WriteLine("Unknown model, try again.");
                    goOn = false;
                } else
                {
                    goOn = true;
                }
            }
            switch (modelSelected)
            {
                case 1:                    
                    aSol.analyticalSolution();
                    break;
                case 2:
                    iSol.iterativeSolution();
                    break;
                default:
                    break;
            }
        }
    }
}
