using Dawson.Trip.Api.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add web controller support
builder.Services.AddControllers();

// Add database context support
builder.Services.AddDbContext<TripDbContext>(option =>
{
    var connectionString = builder.Configuration.GetConnectionString("SqlServer");

    option.UseSqlServer(connectionString);
});

var app = builder.Build();

app.MapControllers();

app.Run();