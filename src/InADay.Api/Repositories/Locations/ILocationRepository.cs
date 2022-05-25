using InADay.Models.Locations;

namespace InADay.Api.Repositories.Locations
{
    public interface ILocationRepository
    {
        public Task<IEnumerable<Location>> GetAllLocations();

        public Task<IEnumerable<Location>> GetActiveLocations();
    }
}
