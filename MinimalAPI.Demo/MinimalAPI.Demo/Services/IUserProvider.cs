namespace MinimalAPI.Demo.Services
{
    public interface IUserProvider
    {
        IEnumerable<User> Get();
    }
}