using System.Threading.Channels;

// Declare Bounded
var channelBound = Channel.CreateBounded<string>(new BoundedChannelOptions(100)
{
    FullMode = BoundedChannelFullMode.DropOldest,
}, (item) => Console.WriteLine(item));

// Declare UnBounded
var channelUnBound = Channel.CreateUnbounded<string>(new UnboundedChannelOptions()
{
     AllowSynchronousContinuations = true,
     SingleReader = true,
     SingleWriter = true,
});

var writer = channelBound.Writer;
var reader = channelBound.Reader;

var readerTask = Task.Factory.StartNew(async () =>
{
    while (!reader.Completion.IsCompleted)
    {
        var response = await reader.ReadAsync();
        Console.WriteLine(response);
    }
});

for(int i = 0; i < 10; i++)
{
    await writer.WriteAsync($"item {i}");
}

await readerTask;

Console.ReadLine();
