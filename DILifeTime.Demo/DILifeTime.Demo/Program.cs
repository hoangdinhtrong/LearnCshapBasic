using DILifeTime.Demo.Respositories;
using DILifeTime.Demo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// Transient always creat new instance
// Singleton run until application finish
// Scoped run until http request finish

builder.Services.AddScoped<ICounter, Counter>();
builder.Services.AddTransient<IFirstCounterService, FirstCounterService>();
builder.Services.AddTransient<ISecoundCounterService, SecoundCounterService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
