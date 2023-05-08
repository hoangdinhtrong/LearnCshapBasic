using LinqInternals.Demo.Enums;

namespace LinqInternals.Demo.Models
{
    public class Phone
    {
        public string Number { get; set; } = null!;
        public PhoneType PhoneType { get; set; }
    }
}
