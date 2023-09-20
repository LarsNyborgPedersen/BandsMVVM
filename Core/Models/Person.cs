namespace Core.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Band AssociatedBand { get; set; }
    }
}
