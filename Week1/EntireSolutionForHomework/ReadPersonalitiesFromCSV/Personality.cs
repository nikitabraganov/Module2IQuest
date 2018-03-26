using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadPersonalitiesFromCSV
{
    public class Personality
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public DateTime DateOfDeath { get; private set; }

        public Personality(string FirstName, string LastName, DateTime DateOfBirth, DateTime DateOfDeath)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.DateOfDeath = DateOfDeath;
        }
    }
}
