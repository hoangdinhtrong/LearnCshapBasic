using Cshap11.Improvement;
//// Required member

//var user = new User() { Address = "123 Street", Name = "John Doe"};
//// End Required member
///

// string literals
string body = "Body text";

var content = $""""
              This is a test "string" """{body}""", 
                and this is in next line 
              """";

Console.WriteLine(content);

// End string literals

// File scopes
var userProvider = new UserProvider();
Console.WriteLine(userProvider.Name);
// End File Scopes

Console.ReadLine();