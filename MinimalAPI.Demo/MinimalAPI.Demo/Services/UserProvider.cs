namespace MinimalAPI.Demo.Services;

public class UserProvider : IUserProvider
{
    public IEnumerable<User> Get()
    {
        return new List<User>()
        {
            new User(){ Id = 1, Name = "John Doe"},
            new User(){ Id = 2, Name = "John Doe 2"},
        };
    }
}
