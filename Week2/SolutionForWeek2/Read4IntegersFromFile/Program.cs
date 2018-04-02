using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read4IntegersFromFile
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter integers to be writed in file");
            int FirstInteger = int.Parse(Console.ReadLine());
            int SecondInteger = int.Parse(Console.ReadLine());
            int ThirdInteger = int.Parse(Console.ReadLine());
            int FourthInteger = int.Parse(Console.ReadLine());

            StreamWriter writer = File.CreateText("FourIntegers.txt");
            writer.Write(FirstInteger); writer.Write(SecondInteger); writer.Write(ThirdInteger); writer.Write(FourthInteger);
            writer.Close();

            StreamReader reader = File.OpenText("FourIntegers.txt");
            string contentsOfTheFile = reader.ReadLine();
            Console.WriteLine("Last 2 numbers are: {0} {1}", contentsOfTheFile[2], contentsOfTheFile[3]);
            reader.Close();

            Console.ReadKey();
        }
    }
}
