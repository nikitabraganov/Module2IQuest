using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank myTank = new Tank();
            myTank.ammunition.Push(1);
            myTank.ammunition.Push(1);
            myTank.ammunition.Push(1);
            myTank.ammunition.Push(1);
            Console.WriteLine(myTank.ammunition.Count);
            myTank.Dispose();
            Console.WriteLine(myTank.ammunition.Count);
            Console.ReadKey();

        }
    }
}
