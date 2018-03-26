using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadPersonalitiesFromCSV
{
    public class PersonalityCollection : IEnumerable<Personality>
    {
        public List<Personality> PersonalitiesCollection = new List<Personality>();

        public IEnumerator<Personality> GetEnumerator()
        {
            return PersonalitiesCollection.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void AddPersonalitiesToCollection(Personality newPersonality)
        {
            PersonalitiesCollection.Add(newPersonality);
        }
    }
}
