namespace Cshap11.Improvement;

[Role(Type = "Test Required")]
[Custom<string>()]
public class User
{
    public string? Name { get; set; }
    public required string Address { get; set; }
    public string? Phone { get; set; }
}
