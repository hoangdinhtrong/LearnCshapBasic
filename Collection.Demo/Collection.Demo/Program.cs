using Collection.Demo.Models;
using Collection.Demo.Services;

var userManager = new UserManager();
List<User> users = new List<User>();
for(int i = 0; i < 10; i++)
{
    users.Add(new User()
    {
        Name = $"User-{i}",
        Age = i
    });
}

Parallel.For(0, users.Count, i => userManager.AddUser(users[i]));

Parallel.For(0, users.Count, i => 
    Console.WriteLine(userManager.GetUser($"User-{i}").Age));