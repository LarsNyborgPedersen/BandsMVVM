using System;
using System.Collections.Generic;

namespace Core.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> Members { get; set; } = new List<Person>();
        public Band(string BandName)
        {
            Name = BandName;
        }
    }
}
