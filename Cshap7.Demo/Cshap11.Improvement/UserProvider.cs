namespace Cshap11.Improvement;

file class User
{
    public string Name => "Test name";
}
public class UserProvider
{
    public string Name => new User().Name;
}
