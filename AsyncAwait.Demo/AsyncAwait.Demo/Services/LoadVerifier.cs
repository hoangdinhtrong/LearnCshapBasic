namespace AsyncAwait.Demo.Services
{
    public class LoadVerifier : ILoadVerifier
    {
        public async Task<bool> Verify()
        {
            await Task.Delay(5 * 1000);
            Console.WriteLine("Verifier task completed");
            return true;
        }
    }
}
