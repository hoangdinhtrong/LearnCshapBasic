namespace LinqInternals.Demo.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
