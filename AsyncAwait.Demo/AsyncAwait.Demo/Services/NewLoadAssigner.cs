namespace AsyncAwait.Demo.Services
{
    internal class NewLoadAssigner : INewLoadAssigner
    {
        public async Task Assign()
        {
            await Task.Delay(5 * 1000);
            Console.WriteLine("Verifier task completed");
        }
    }
}
