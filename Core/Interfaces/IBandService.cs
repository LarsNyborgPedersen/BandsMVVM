using System.Collections.Generic;
using Core.Models;

namespace Core.Interfaces
{
    public interface IBandService
    {
        void AddBand(Band band);
        void AddPerson(Person person);
        void AssociatePersonToBand(Person person, Band band);
        List<Band> GetAllBands();
    }
}
