using Cshap11.Improvement;

var type = typeof(User);

var customAttributes = type.GetCustomAttributes(false);
foreach (var attribute in customAttributes)
{
    if(attribute is CustomAttribute<string>)
    {
        Console.WriteLine(((CustomAttribute<string>)attribute).CurrentType.Name);
    }
}

Console.ReadLine();