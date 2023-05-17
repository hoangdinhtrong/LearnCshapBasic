namespace Docker.Demo.Services
{
    public class PrintSettingsProvider : IPrintSettingsProvider
    {
        public bool CanPrint()
        {
            return true;
        }
    }
}
