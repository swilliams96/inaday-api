using InADay.Models.Locations;

namespace InADay.Api.Repositories.Locations
{
    public class InMemoryLocationRepository : ILocationRepository
    {
        public static List<Location> Data = new()
        {
            new Location()
            {
                Id = Guid.NewGuid(),
                Name = "Rome",
                Status = LocationStatus.Active,
                Latitude = 41.902782m,
                Longitude = 12.496365m
            },
            new Location()
            {
                Id = Guid.NewGuid(),
                Name = "Porto",
                Status = LocationStatus.Active,
                Latitude = 41.157944m,
                Longitude = -8.629105m
            },
            new Location()
            {
                Id = Guid.NewGuid(),
                Name = "Prague",
                Status = LocationStatus.Inactive,
                Latitude = 50.075539m,
                Longitude = 14.437800m
            }
        };

        public Task<IEnumerable<Location>> GetAllLocations()
        {
            return Task.FromResult(Data.ToArray() as IEnumerable<Location>);
        }

        public Task<IEnumerable<Location>> GetActiveLocations()
        {
            return Task.FromResult(Data.Where(x => x.Status == LocationStatus.Active).ToArray() as IEnumerable<Location>);
        }
    }
}
