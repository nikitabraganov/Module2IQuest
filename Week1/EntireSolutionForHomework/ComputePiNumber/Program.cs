using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputePiNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compute the pi number");
            Console.WriteLine("Enter the number of iterations");
            try
            {
                int NumberOfIterations = int.Parse(Console.ReadLine());
                Console.WriteLine("The pi computed to: " + CalculatePiGregoryLeibniza(NumberOfIterations));
                Console.WriteLine(Math.PI);
            }
            catch (OverflowException e) {
                if (e.Source != null) {
                    Console.WriteLine("OverflowException source: {0}", e.Source);
                    throw;
                }
            }
            Console.ReadKey();
        }

        private static decimal CalculatePiGregoryLeibniza(int iterations)
        {
            // π = (4/1) - (4/3) + (4/5) - (4/7) + (4/9) - (4/11) + (4/13) - (4/15) + (4/17) - (4/19) ...

            decimal pi = 0;
            decimal SignForNextOperation = 1;

            for (int i = 1; i < iterations; i += 2)
            {
                pi = pi + SignForNextOperation * (4M / i);
                SignForNextOperation = -SignForNextOperation;
            }

            return pi;
        }
    }
}
