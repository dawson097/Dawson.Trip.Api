using Dawson.Trip.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Dawson.Trip.Api.Database;

public class TripDbContext : DbContext
{
    public TripDbContext(DbContextOptions<TripDbContext> options) : base(options)
    {
    }

    public DbSet<TouristRoute> TouristRoutes { get; set; }

    public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }
}