using MinimalAPIDemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//var connValue = builder.Configuration.GetValue<string>("ConnectionString:NorthwindDB");

string connValue = File.ReadAllText(@"/Revature/221024/Project1/ConnectionStrings/Project1ConnectionString.txt");
builder.Services.AddTransient<CategoryRepository>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");



//https://localhost:7152/categories/
app.MapGet("/categories", (CategoryRepository repo) =>
    repo.GetAll(connValue));

//https://localhost:7152/categories/1
app.MapGet("/categories/{id}", (int id, CategoryRepository repo) =>
    repo.Get(connValue, id));

//https://localhost:7152/categories/
//{
//    "categoryid": 0,
//    "categoryName": "test",
//    "description": "Test"
//}


app.MapPost("/categories", (Category category, CategoryRepository repo) =>
{
    category = repo.Create(connValue, category);
    return Results.Created($"/categories/{category.CategoryId}", category);
});

//https://localhost:7152/categories/14
app.MapPut("/categories/{id}", (int id, Category category, CategoryRepository repo) =>
{
    repo.Update(connValue, id, category);
    return Results.NoContent();
});

//https://localhost:7152/categories/14
app.MapDelete("/categories/{id}", (int id, CategoryRepository repo) =>
{
    repo.Delete(connValue, id);
    return Results.Ok(id);
});




app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}