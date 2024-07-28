using Dawson.Trip.Api.Models;

namespace Dawson.Trip.Api.Services.Interfaces;

public interface ITouristRouteRepository
{
    Task<List<TouristRoute>> GetAllRoutesAsync();

    Task<TouristRoute> GetRouteByRouteIdAsync(Guid routeId);
}