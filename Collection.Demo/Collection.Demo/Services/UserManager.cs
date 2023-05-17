using Collection.Demo.Models;
using System.Collections.Concurrent;

namespace Collection.Demo.Services
{
    public class UserManager : IUserManager
    {
        private readonly ConcurrentDictionary<string, User> _user = new ConcurrentDictionary<string, User>();

        public void AddUser(User user)
        {
            //_user.TryAdd(user.Name, user);

            _user.AddOrUpdate(user.Name, user, (name, user) => user);
        }

        public User GetUser(string username) => _user[username];
    }
}
