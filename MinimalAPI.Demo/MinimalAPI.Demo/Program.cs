var isGreaterThan10 = bool (int x) => x > 10;

Action<string> action = ([Test] x) => Console.WriteLine(x);

action("Hello World!");
Console.WriteLine(isGreaterThan10(11));
Console.ReadLine();