using LinqInternals.Demo.Extensions;

namespace LinqInternals.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExampleWhereLinq();
            Console.ReadLine();
        }

        private static void ExampleWhereLinq()
        {
            var items = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var eventItems = items.NewWhere(x => x % 2 == 0);
            foreach (var item in eventItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}