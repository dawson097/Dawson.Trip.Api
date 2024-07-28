using Dawson.Trip.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dawson.Trip.Api.Controllers;

[Route("api/tourist-routes")]
[ApiController]
public class TouristRoutesController : ControllerBase
{
    private readonly ITouristRouteRepository _routeRepository;

    public TouristRoutesController(ITouristRouteRepository routeRepository)
    {
        _routeRepository = routeRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetTouristRoutesAsync()
    {
        return Ok(await _routeRepository.GetAllRoutesAsync());
    }

    [HttpGet("{routeId:guid}")]
    public async Task<IActionResult> GetTouristRouteAsync(Guid routeId)
    {
        return Ok(await _routeRepository.GetRouteByRouteIdAsync(routeId));
    }
}