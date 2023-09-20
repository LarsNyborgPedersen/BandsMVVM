using System.Collections.Generic;
using Core.Models;

namespace Core.Interfaces
{
    public interface IBandService
    {
        Band AddBand(string name);
        Person AddPerson(string name);
        void AssociatePersonToBand(Person person, Band band);
        List<Band> GetAllBands();
    }
}
