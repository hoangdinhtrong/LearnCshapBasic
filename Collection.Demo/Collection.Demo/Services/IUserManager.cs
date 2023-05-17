using Collection.Demo.Models;

namespace Collection.Demo.Services
{
    public interface IUserManager
    {
        void AddUser(User user);
        User GetUser(string username);
    }
}