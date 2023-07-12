using Microsoft.OpenApi.Models;
using AtisStore.Db;

// Create the builder.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",
        new OpenApiInfo { Title = "Atis API", Description = "Get ATIS information for airports.", Version = "v1" });
});
builder.Services.AddHttpClient();

// Build the app.
var app = builder.Build();

// Configure Swagger.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ATIS API V1");
});

IAtisRepository repository = new LocalRepository();

// Configure the endpoints.
app.MapGet("/", () => "Hello World!");
app.MapGet("/atis/{icao}", (string icao) => repository.GetAtis(icao));

app.Run();
