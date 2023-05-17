using Microsoft.Extensions.DependencyInjection;

namespace Docker.Demo
{
    internal class Program
    {
        private static readonly AutoResetEvent _closingEvent = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var serviceProvider = ContainerConfiguration.Configure();
            serviceProvider.GetService<ContinuousRunningProcessor>()?.Process();
        }
    }
}