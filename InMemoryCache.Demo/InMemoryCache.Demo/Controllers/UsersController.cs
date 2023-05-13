using InMemoryCache.Demo.Caches;
using Microsoft.AspNetCore.Mvc;

namespace InMemoryCache.Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserCache _userCache;

        public UsersController(IUserCache userCache)
        {
            _userCache = userCache;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            var user = _userCache.GetCachedUsers();
            return user;
        }
    }
}