using InADay.Api.Repositories.Attractions;
using InADay.Api.Repositories.Locations;
using InADay.Api.Services.Locations;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
RegisterServices();

builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

builder.Services.AddControllers().AddJsonOptions(x =>
{
    x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

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


void RegisterServices()
{
    builder.Services.AddTransient<ILocationService, LocationService>();
    builder.Services.AddTransient<ILocationRepository, InMemoryLocationRepository>();
    builder.Services.AddTransient<IAttractionRepository, InMemoryAttractionRepository>();
}