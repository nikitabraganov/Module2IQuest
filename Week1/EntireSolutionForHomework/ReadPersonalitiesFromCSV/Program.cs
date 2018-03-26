using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadPersonalitiesFromCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            var Personalities = new PersonalityCollection();
            string fileName = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\iQURL_M2_Week1_homework_inputData.csv.xls");
            var path = Path.Combine(Directory.GetCurrentDirectory(), "\\iQURL_M2_Week1_homework_inputData.csv.xls");
            var allLines = File.ReadAllLines(fileName);
            foreach (var line in allLines)
            {
                var splittedLines = line.Split(separator: ',');
                if (splittedLines != null && splittedLines.Any())
                {
                    if (splittedLines.Length > 3)
                    {
                        Personalities.AddPersonalitiesToCollection(new Personality(splittedLines[0], splittedLines[1], int.Parse(splittedLines[2]), int.Parse(splittedLines[3])));

                    }
                    else
                    {
                        Personalities.AddPersonalitiesToCollection(new Personality(splittedLines[0], splittedLines[1], int.Parse(splittedLines[2])));
                    }
                }
            }
            int NumberOfPersonality = 0;
            foreach (var person in Personalities)
            {
                Console.Write(++NumberOfPersonality + " " + person.FirstName + " ");
                Console.Write(person.LastName + " ");
                Console.Write(person.DateOfBirth + " ");
                Console.Write(person.DateOfDeath + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
