using InADay.Models.Attractions;
using InADay.Models.Locations;

namespace InADay.Api.Services.Locations
{
    public interface ILocationService
    {
        public Task<IEnumerable<Location>> GetActiveLocations();

        public Task<IEnumerable<Attraction>> GetAttractionsForLocation(Guid id);
    }
}
