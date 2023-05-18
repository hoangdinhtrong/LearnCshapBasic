
// For Loop
Parallel.For(0, 10, count => Console.WriteLine(count));

// Foreach Loop
var items = new[] { "one", "two", "three", "four" };
await Parallel.ForEachAsync(items, async (x, token) => Console.WriteLine(await GetNameAsync(x)));

async Task<string> GetNameAsync(string name)
{
    return await Task.FromResult($"{name}{Random.Shared.Next(10)}");
}

// Invoke
Parallel.Invoke(() => Console.WriteLine("First"),
    () => Console.WriteLine("Secound"),
    () => Console.WriteLine("Third"),
    () => Console.WriteLine("Fourth")
);

Console.ReadLine();