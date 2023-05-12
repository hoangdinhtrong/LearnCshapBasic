using DILifeTime.Demo.Respositories;
using System.Diagnostics.Metrics;

namespace DILifeTime.Demo.Services
{
    public class FirstCounterService : IFirstCounterService
    {
        private readonly ICounter _counter;

        public FirstCounterService(ICounter counter)
        {
            _counter = counter;
        }

        public int InCrementAndGet()
        {
            _counter.InCrement();
            return _counter.Get();
        }
    }
}
