namespace LinqInternals.Demo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Phone> Phones { get; set; } = new List<Phone>();
    }
}
