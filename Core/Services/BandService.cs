using System.Collections.Generic;
using Core.Models;
using Core.Interfaces;

namespace Core.Services
{
    public class BandService : IBandService
    {
        private List<Band> _bands = new List<Band>();
        private List<Person> _people = new List<Person>();

        public Band AddBand(string name)
        {
            Band newBand = new Band(name);

            _bands.Add(newBand);
            return newBand;

        }

        public Person AddPerson(string name)
        {
            Person newPerson = new Person(name);

            _people.Add(newPerson);
            return newPerson;
        }

        public void AssociatePersonToBand(Person person, Band band)
        {
            band.Members.Add(person);
            person.AssociatedBand = band;
        }

        public List<Band> GetAllBands()
        {
            return _bands;
        }
    }
}
