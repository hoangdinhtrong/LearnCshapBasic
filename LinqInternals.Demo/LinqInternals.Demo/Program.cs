using LinqInternals.Demo.Extensions;
using LinqInternals.Demo.Models;

namespace LinqInternals.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// EXAMPLE ABOUT WHERE
            // ExampleWhereLinq();

            //// EXAMPLE ABOUT SELECT
            // ExampleSelectLinq();

            //// EXAMPLE ABOUT SELECT MANY
            //ExampleSelectManyLinq();

            // EXAMPLE ABOUT JOIN 
            ExampleJoinLinq();
            Console.ReadLine();
        }

        private static List<Customer> GetCustomers() 
        {
            return new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    Name = "Test",
                    Phones = new List<Phone>()
                    {
                        new Phone() { Number = "123", PhoneType = Enums.PhoneType.Home },
                        new Phone() { Number = "456", PhoneType = Enums.PhoneType.Cell },
                    }
                },
                new Customer()
                {
                    Id = 2,
                    Name = "Test 2",
                    Phones = new List<Phone>()
                    {
                        new Phone(){Number = "345-345-3456", PhoneType= Enums.PhoneType.Cell},
                        new Phone(){Number = "456-456-6789", PhoneType= Enums.PhoneType.Home},
                    }
                }
            };
        }

        private static List<Address> GetAddresses()
        {
            return new List<Address>()
            {
                new Address(){Id = 1, CustomerId = 2, Street="123 Street", City="City 1"},
                new Address(){Id = 2, CustomerId = 2, Street="456 Street", City="City 2"},
            };
        }

        private static void ExampleJoinLinq()
        {
            var customers = GetCustomers();
            if (customers != null && customers.Count > 0)
            {
                var addresses = GetAddresses();
                var customerInfos = customers.NewJoin(addresses,
                    c => c.Id,
                    ad => ad.CustomerId,
                    (c, ad) => new
                    {
                        c.Name,
                        ad.Street,
                        ad.City,
                    });

                foreach (var item in customerInfos)
                {
                    Console.WriteLine($"{item.Name} - {item.Street} - {item.City}");
                }
            }
        }

        private static void ExampleSelectManyLinq()
        {
            var customers = GetCustomers();
            if (customers != null && customers.Count > 0)
            {
                var customerPhones = customers.NewSelectMany(x => x.Phones);
                foreach (var item in customerPhones)
                {
                    if(item == null) continue;
                    Console.WriteLine($"{item.Number} - {item.PhoneType}");
                }
            }
        }

        private static void ExampleSelectLinq()
        {
            var customers = GetCustomers();
            if(customers != null && customers.Count > 0)
            {
                var customerNames = customers.NewSelect(x => x.Name);
                foreach (var name in customerNames)
                {
                    Console.WriteLine(name);
                }
            }
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