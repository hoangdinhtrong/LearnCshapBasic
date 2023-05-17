using Docker.Demo.Services;
using Microsoft.Extensions.Logging;
using System.Threading;

namespace Docker.Demo
{
    internal class ContinuousRunningProcessor
    {
        private static readonly AutoResetEvent _closingEvent = new AutoResetEvent(false);
        private readonly IConsolePrinter _consolePrinter;
        private readonly ILogger<ContinuousRunningProcessor> _logger;

        public ContinuousRunningProcessor(IConsolePrinter consolePrinter, ILogger<ContinuousRunningProcessor> logger)
        {
            _consolePrinter = consolePrinter;
            _logger = logger;
        }

        public void Process()
        {
            var count = 0;
            Task.Factory.StartNew(() =>
            {
                _logger.LogInformation("Proccess started!");
                while (true)
                {
                    _consolePrinter.Print(++count);
                    Thread.Sleep(1000);
                }
            });

            _closingEvent.WaitOne();

            Console.WriteLine("Press Ctrl + C to cancel!");
            Console.CancelKeyPress += ((sender, e) =>
            {
                Console.WriteLine("Bye!");
                _closingEvent.Set();
            });

        }
    }
}
