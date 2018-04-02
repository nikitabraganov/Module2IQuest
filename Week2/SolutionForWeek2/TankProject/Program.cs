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
            List<Tank> ListOfTanks = new List<Tank>();
            ListOfTanks.Add(new Tank("t-92"));
            ListOfTanks.Add(new Tank("t-52"));
            foreach (var tanks in ListOfTanks)
            {
                Console.WriteLine(tanks.TankModel);
            }

            foreach (var tanks in ListOfTanks)
            {
                tanks.Dispose();
            }
            foreach (var tanks in ListOfTanks)
            {
                Console.WriteLine(tanks.TankModel + " tanks after the Dispose() method is called");
            }
            ListOfTanks.RemoveAt(0);
            foreach (var tanks in ListOfTanks)
            {
                Console.WriteLine(tanks.TankModel + " tanks that are in list after removing one");
            }
            Console.ReadKey();

        }
    }
}
