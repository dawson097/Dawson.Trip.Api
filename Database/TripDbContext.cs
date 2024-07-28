﻿using Dawson.Trip.Api.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Reflection;

namespace Dawson.Trip.Api.Database;

public class TripDbContext : DbContext
{
    public TripDbContext(DbContextOptions<TripDbContext> options) : base(options)
    {
    }

    public DbSet<TouristRoute> TouristRoutes { get; set; }

    public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var routesData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +
            @"/Database/tourist-routes.json");
        var routes = JsonConvert.DeserializeObject<IList<TouristRoute>>(routesData);
        modelBuilder.Entity<TouristRoute>().HasData(routes);

        var routePicturesData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +
            @"/Database/tourist-route-pictures.json");
        var routePictures = JsonConvert.DeserializeObject<IList<TouristRoutePicture>>(routePicturesData);
        modelBuilder.Entity<TouristRoutePicture>().HasData(routePictures);
    }
}