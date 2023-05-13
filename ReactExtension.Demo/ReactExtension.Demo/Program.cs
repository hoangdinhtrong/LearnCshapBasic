namespace ReactExtension.Demo
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //// Observable
            //var evenNumber = new EvenNumberObservable();
            //var consoleObserver = new ConsolelogObserver();
            //evenNumber.Subscribe(consoleObserver);

            // Subject
            var evenNumber = new EvenNumberSubject();
            evenNumber.Run();
            evenNumber.Subcribe(Console.WriteLine);

            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}