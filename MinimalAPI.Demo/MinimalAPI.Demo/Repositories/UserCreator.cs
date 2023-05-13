namespace MinimalAPI.Demo.Repositories;

public class UserCreator : IUserCreator
{
    public bool Create(User user)
    {
        Console.WriteLine($"User with name {user.Name} is created");
        return true;
    }
}
