using InADay.Api.Repositories.Attractions;
using InADay.Api.Repositories.Locations;
using InADay.Models.Attractions;
using InADay.Models.Locations;

namespace InADay.Api.Services.Locations
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        public IAttractionRepository _attractionRepository;

        public LocationService(ILocationRepository locationRepository, IAttractionRepository attractionRepository)
        {
            _locationRepository = locationRepository;
            _attractionRepository = attractionRepository;
        }

        public async Task<IEnumerable<Location>> GetActiveLocations()
        {
            return await _locationRepository.GetActiveLocations();
        }

        public async Task<IEnumerable<Attraction>> GetAttractionsForLocation(Guid locationId)
        {
            return await _attractionRepository.GetAttractionsForLocation(locationId);
        }
}
}
