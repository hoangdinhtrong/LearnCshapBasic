namespace AsyncAwait.Demo.Services
{
    public interface ILoadVerifier
    {
        Task<bool> Verify();
    }
}
