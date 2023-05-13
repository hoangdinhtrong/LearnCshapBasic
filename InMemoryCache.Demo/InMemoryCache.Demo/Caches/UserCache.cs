using Microsoft.Extensions.Caching.Memory;

namespace InMemoryCache.Demo.Caches
{
    public class UserCache : IUserCache
    {
        private readonly IMemoryCache _memoryCache;
        private const string KEY = "USER_CACHE";

        public UserCache(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public void AddToCache(IEnumerable<User> users)
        {
            // options cache
            var options = new MemoryCacheEntryOptions()
            {
                SlidingExpiration = TimeSpan.FromSeconds(10), // refresh cache each 10 seconds
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(30),
            };

            // Get data from a cache
            _memoryCache.Set<IEnumerable<User>>(KEY, users, options);
        }

        public IEnumerable<User> GetCachedUsers()
        {
            List<User>? users = null;
            if (!_memoryCache.TryGetValue(KEY, out users))
            {
                users = new List<User>()
                {
                    new User(){ Name = "User 1", Age = 20},
                    new User(){ Name = "User 2", Age = 21},
                    new User(){ Name = "User 3", Age = 22},
                };
                AddToCache(users);
            }
            return _memoryCache.Get<IEnumerable<User>>(KEY);
        }
    }
}
