using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentialDecay
{
    class IterativeSolution
    {
        public void iterativeSolution()
        {
            double doubleK = 0;
            double doubleT = 0;
            double simT = 0;
            double dCdt = 0;
            double Ct = 0;
            double dt = 0.1;
            bool convertSuccess = false;
            bool exponentialAgain = false;

            Console.WriteLine("Iterative solution to exponential decay differential equation dC/dt = - kC");
            while (!convertSuccess)
            {
                Console.WriteLine("Please enter the value of C_0 [Initial concentration]");
                string StringC0 = Console.ReadLine();
                convertSuccess = double.TryParse(StringC0, out Ct);
                if (!convertSuccess)
                {
                    Console.WriteLine("Conversion not successful, retry");
                }
            }
            convertSuccess = false;
            while (!convertSuccess)
            {
                Console.WriteLine("Please enter the value of k [rate constant]");
                string StringK = Console.ReadLine();
                convertSuccess = double.TryParse(StringK, out doubleK);
                if (!convertSuccess)
                {
                    Console.WriteLine("Conversion not successful, retry");
                }
            }

            while (!exponentialAgain)
            {
                simT = 0;
                convertSuccess = false;
                while (!convertSuccess)
                {
                    Console.WriteLine("What value of t should we solve the equation for?");
                    string StringT = Console.ReadLine();
                    convertSuccess = double.TryParse(StringT, out doubleT);
                    if (!convertSuccess)
                    {
                        Console.WriteLine("Conversion not successful, retry");
                    }
                }
                while(doubleT >= simT)
                {
                    dCdt = -doubleK * Ct;
                    Ct = Ct + dCdt * dt;
                    simT += dt;
                    Console.WriteLine("C(t = {0:E2}) = {1:E4}", simT, Ct);                    
                }
                
                Console.WriteLine("Solve again? (y/n)");
                string yn = Console.ReadLine().ToLower();
                if (yn != "y") { return; }
                Console.Clear();
            }
        }
    }
}
