int price = 10;
if(price <= 5)
{
    Console.WriteLine("Buy");
}
else if(price > 5 && price <= 10)
{
    Console.WriteLine("Bergain");
}
else if(price > 10 && price <= 15)
{
    Console.WriteLine("Think");
}
else
{
    Console.WriteLine("Do not buy");
}

Console.ReadLine();