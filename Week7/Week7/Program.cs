using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week7
{
    public class OddNumbersThreading
    {
        static long firstPrimeNumber, secondPrimeNumber, thirdPrimeNumber, sum;
        static void Main(string[] args)
        {
            Console.WriteLine("Parrallel method: ");
            Console.WriteLine();
            var sw = new Stopwatch();
            sw.Start();
            var threads = new List<Thread> { new Thread(FirstPrimeBasic), new Thread(SecondPrimeBasic), new Thread(ThirdPrimeBasic) };
            threads.ForEach(thread => thread.Start());
            threads.ForEach(thread => thread.Join());
            sw.Stop();
            Console.WriteLine($"The sum is {sum}, the prime numbers are {firstPrimeNumber}, {secondPrimeNumber}, {thirdPrimeNumber}");
            Console.WriteLine($"Prime numbers and the sum found in {sw.ElapsedMilliseconds} milliseconds.");
            Console.WriteLine();

            Console.WriteLine("Basic method: ");
            Console.WriteLine();
            sw.Reset();
            sw.Start();
            sum = 0;
            FirstPrimeBasic();
            SecondPrimeBasic();
            ThirdPrimeBasic();
            sw.Stop();
            Console.WriteLine($"The sum is {sum}, the prime numbers are {firstPrimeNumber}, {secondPrimeNumber}, {thirdPrimeNumber}");
            Console.WriteLine($"Prime numbers and the sum found in {sw.ElapsedMilliseconds} milliseconds.");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static long PrimesInRangeBasic(long start)
        {
            long result = 0;
            for (var number = start; number < int.MaxValue; number++)
            {
                if (IsPrime(number))
                {
                    result = number;
                    break;
                }
            }
            return result;
        }

        public static void FirstPrimeBasic()
        {
            firstPrimeNumber = PrimesInRangeBasic(0);
            int increment = 0;
            while (firstPrimeNumber < 100)
            {
                firstPrimeNumber = PrimesInRangeBasic(increment++);
            }
            sum += firstPrimeNumber;
        }
        public static void SecondPrimeBasic()
        {
            secondPrimeNumber = PrimesInRangeBasic(0);
            int increment = 0;
            while (secondPrimeNumber < 200)
            {
                secondPrimeNumber = PrimesInRangeBasic(increment++);
            }
            sum += secondPrimeNumber;
        }
        public static void ThirdPrimeBasic()
        {
            thirdPrimeNumber = PrimesInRangeBasic(0);
            int increment = 0;
            while (thirdPrimeNumber < 300)
            {
                thirdPrimeNumber = PrimesInRangeBasic(increment++);
            }
            sum += thirdPrimeNumber;
        }

        static bool IsPrime(long number)
        {
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (long divisor = 3; divisor < (number / 2); divisor += 2)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
