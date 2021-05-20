using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentialDecay
{
    class AnalyticalSolution
    {
        public void analyticalSolution()
        { 
            double doubleC0 = 0;
            double doubleK = 0;
            double doubleT = 0;
            double Ct = 0;
            bool convertSuccess = false;
            bool exponentialAgain = false;

            Console.WriteLine("Exponential decay solution according to C(t) = C_0 * e^(-kt)");
            while (!convertSuccess)
            {
                Console.WriteLine("Please enter the value of C_0 [Initial concentration]");
                string StringC0 = Console.ReadLine();
                convertSuccess = double.TryParse(StringC0, out doubleC0);
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
                Console.WriteLine("Solve for C(t) at time t for the equation C(t) = {0:F2} e^(-{1:F2} * t)", doubleC0, doubleK);
                double expKT = -doubleK * doubleT;
                Ct = doubleC0 * Math.Pow(Math.E, expKT);
                Console.WriteLine("C(t = {0:F2}) = {1:E4}", doubleT, Ct);
                Console.WriteLine("Solve again? (y/n)");
                string yn = Console.ReadLine().ToLower();
                if (yn != "y") { return; }
                Console.Clear();
            }
        }
    }
}
