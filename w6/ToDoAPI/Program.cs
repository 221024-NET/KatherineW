using Microsoft.EntityFrameworkCore;
using ToDoAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the DbContext class
builder.Services.AddDbContext<ToDoContext>(opt => opt.UseInMemoryDatabase("ToDoList"));

// Add Cache
builder.Services.AddMemoryCache();

// Add Cors (Cross-Origin Resource Sharing)
var ToDoOrigins = "_todoOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: ToDoOrigins,
        policy =>
        policy.WithOrigins("http://localhost:4200") // Only this url can make calls to the API - default Angular location is 4200
        .AllowAnyHeader()
        .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// Add Cors
app.UseCors(ToDoOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
