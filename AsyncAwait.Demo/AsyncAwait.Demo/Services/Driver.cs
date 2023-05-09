namespace AsyncAwait.Demo.Services
{
    public class Driver : IDriver
    {
        public async Task ReportToBackoffice()
        {
            await Task.Delay(5 * 1000);
            Console.WriteLine("Driver task completed");
        }
    }
}
