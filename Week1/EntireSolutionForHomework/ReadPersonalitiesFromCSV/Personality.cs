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
        public int DateOfBirth { get; private set; }
        public int DateOfDeath { get; private set; }

        public Personality(string FirstName, string LastName, int DateOfBirth, int DateOfDeath = 0)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.DateOfDeath = DateOfDeath;
        }
        public Personality(string FirstName, string LastName, int DateOfBirth)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
        }
    }
}
