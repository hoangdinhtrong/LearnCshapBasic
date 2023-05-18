using PatternMatch.Demo;

User user = new User() { Name = "John Doe", Age = 20};

if(user is User { Name: { Length: > 5 } })
{
    Console.WriteLine("Name Matched");
}

if(user is User { Age: > 10 })
{
    Console.WriteLine("Age Matched");
}

if(user.Name is string && (user.Name == "John Doe" | user.Name == "Jane Doe"))
{
    Console.WriteLine("Matched");
}

Console.WriteLine(findMatch(user.Name));

string findMatch(object value) => value switch
{
    int i when i > 0 => "+ve",
    int i => "-ve",
    string str when str.Length < 5 => "short",
    string str => "long",
    _ => "N/A"
};

Console.ReadLine();