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
            string fileName = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\Personalities.txt");
            var path = Path.Combine(Directory.GetCurrentDirectory(), "\\Personalities.txt");
            var allLines = File.ReadAllLines(fileName);
            foreach (var line in allLines)
            {
                var splittedLines = line.Split(separator: ',');
                if (splittedLines != null && splittedLines.Any())
                {
                    Personalities.AddPersonalitiesToCollection(new Personality(splittedLines[0], splittedLines[1], DateTime.Parse(splittedLines[2]), DateTime.Parse(splittedLines[3])));
                }
            }
            int NumberOfPersonality = 0;
            foreach (var person in Personalities)
            {
                Console.Write(++NumberOfPersonality + " " + person.FirstName + " ");
                Console.Write(person.LastName + " ");
                Console.Write(person.DateOfBirth.ToString("dd/MM/yyyy") + " ");
                Console.Write(person.DateOfDeath.ToString("dd/MM/yyyy") + " ");
            }
            Console.ReadKey();
        }
    }
}
