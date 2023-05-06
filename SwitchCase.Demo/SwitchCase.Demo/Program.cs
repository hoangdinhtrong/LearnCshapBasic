int price = 10;
int price2 = 15;

// Syntax normal
switch((price, price2))
{
    case ( <= 5, < 5):
        Console.WriteLine("Buy");
        break;
    case ( > 5, >= 10):
        Console.WriteLine("Bergain");
        break;
    default:
        Console.WriteLine("Do not buy");
        break;
}

// Syntax Short
var result = (price, price2) switch
{
    ( <= 5, < 5) => "Buy",
    ( > 5, >= 10) => "Bergain",
    _ => "Do not buy"
};
Console.WriteLine(result);
Console.ReadLine();
