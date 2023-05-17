namespace Docker.Demo.Services
{
    public class ConsolePrinter : IConsolePrinter
    {
        private readonly IPrintSettingsProvider _printSettingsProvider;

        public ConsolePrinter(IPrintSettingsProvider printSettingsProvider)
        {
            _printSettingsProvider = printSettingsProvider;
        }
        public void Print(int count)
        {
            if (_printSettingsProvider.CanPrint())
            {
                Console.WriteLine($"Current Count {count}");
            }
        }
    }
}
