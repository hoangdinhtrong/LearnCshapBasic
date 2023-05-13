namespace InMemoryCache.Demo.Caches
{
    public interface IUserCache
    {
        void AddToCache(IEnumerable<User> users);
        IEnumerable<User> GetCachedUsers();
    }
}