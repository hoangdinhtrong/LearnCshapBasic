using Collection.Demo.Models;

namespace Collection.Demo.Services
{
    public class UserManager : IUserManager
    {
        private readonly Object _lock = new object();
        private readonly IDictionary<string, User> _user = new Dictionary<string, User>();

        public void AddUser(User user)
        {
            lock (_lock)
            {
                _user.Add(user.Name, user);
            }
        }

        public User GetUser(string username) => _user[username];
    }
}
