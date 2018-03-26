using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the last number to be printed");
            int LastNumberParsed = int.Parse(Console.ReadLine());
            for (int i = 1; i <= LastNumberParsed; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + "-PRIME, ");
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
            Console.ReadKey();
        }

        private static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i * i <= number; i += 2)
                if (number % i == 0) return false;
            return true;
        }
    }
}
