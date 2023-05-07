using Attribute.Demo;

var attributes = typeof(AttributeExample).GetCustomAttributes(true);
foreach(var att in attributes)
{
    if(att is TestAttribute)
    {
        var attValue = (TestAttribute)att;
        Console.WriteLine($"Name: {attValue.Name}, Quantity: {attValue.Quantity}");
    }
}

Console.ReadLine();
