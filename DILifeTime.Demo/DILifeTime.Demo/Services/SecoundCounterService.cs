using DILifeTime.Demo.Respositories;

namespace DILifeTime.Demo.Services
{
    public class SecoundCounterService : ISecoundCounterService
    {
        private readonly ICounter _counter;

        public SecoundCounterService(ICounter counter)
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
