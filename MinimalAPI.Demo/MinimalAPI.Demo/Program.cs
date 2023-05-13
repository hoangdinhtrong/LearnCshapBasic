var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserCreator, UserCreator>();
builder.Services.AddTransient<IUserProvider, UserProvider>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/users", ([FromServices] IUserProvider userProvider) => userProvider.Get());
app.MapPost("/api/users", ([FromServices] IUserCreator userCreator, [FromBody] User user) 
    => userCreator.Create(user) ? Results.Ok() : Results.BadRequest())
    .WithName("Create User")
    .Produces<IEnumerable<User>>(StatusCodes.Status200OK)
    .Produces(StatusCodes.Status400BadRequest);
app.Run();