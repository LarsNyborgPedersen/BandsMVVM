using System.Collections.Generic;
using Core.Models;
using Core.Interfaces;

namespace Core.Services
{
    public class BandService : IBandService
    {
        private List<Band> _bands = new List<Band>();
        private List<Person> _people = new List<Person>();

        public void AddBand(Band band)
        {
            _bands.Add(band);
        }

        public void AddPerson(Person person)
        {
            _people.Add(person);
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
