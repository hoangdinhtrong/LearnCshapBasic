using DILifeTime.Demo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DILifeTime.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountsController : ControllerBase
    {
        private readonly IFirstCounterService _firstCounterService;
        private readonly ISecoundCounterService _secoundCounterService;

        public CountsController(IFirstCounterService firstCounterService,
            ISecoundCounterService secoundCounterService)
        {
            _firstCounterService = firstCounterService;
            _secoundCounterService = secoundCounterService;
        }
        [HttpGet]
        public int Get()
        {
            _firstCounterService.InCrementAndGet();
            return _secoundCounterService.InCrementAndGet();
        }
    }
}
