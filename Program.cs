using Dawson.Trip.Api.Database;
using Dawson.Trip.Api.Services;
using Dawson.Trip.Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add web controller support
builder.Services.AddControllers();

builder.Services.AddTransient<ITouristRouteRepository, TouristRouteRepository>();

// Add database context support
builder.Services.AddDbContext<TripDbContext>(option =>
{
    var connectionString = builder.Configuration.GetConnectionString("SqlServer");

    option.UseSqlServer(connectionString);
});

var app = builder.Build();

app.MapControllers();

app.Run();