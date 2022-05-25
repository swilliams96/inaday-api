using InADay.Api.Services.Locations;
using InADay.Models.Attractions;
using InADay.Models.Locations;
using Microsoft.AspNetCore.Mvc;

namespace InADay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;
        private readonly ILogger<LocationsController> _logger;

        public LocationsController(ILocationService locationService, ILogger<LocationsController> logger)
        {
            _locationService = locationService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Location>> Get()
        {
            return await _locationService.GetActiveLocations();
        }

        [HttpGet("{id}/attractions")]
        public async Task<IEnumerable<Attraction>> GetAttractionsForLocation([FromRoute] Guid id)
        {
            return await _locationService.GetAttractionsForLocation(id);
        }
    }
}