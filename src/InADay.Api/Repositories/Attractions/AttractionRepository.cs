using InADay.Models.Attractions;

namespace InADay.Api.Repositories.Attractions
{
    public class InMemoryAttractionRepository : IAttractionRepository
    {
        public static List<Attraction> Data = new()
        {
            new Attraction()
            {
                Id = Guid.NewGuid(),
                LocationId = Locations.InMemoryLocationRepository.Data.First(x => x.Name == "Porto").Id,
                Name = "Six Bridges Cruise (Living Tours)",
                Type = AttractionType.Tour,
                Description = "A 50-minute tour along the Douro river taking you under 6 of the city's famous bridges. A great way to see the city of Porto from a different perspective.",
                PriceType = PriceType.Cheap,
                Price = 15.00m,
                PriceCurrency = "EUR",
                Duration = TimeSpan.FromMinutes(50),
                BookingUrl = "https://www.tripadvisor.co.uk/AttractionProductReview-g189180-d11461214-Oporto_Six_Bridges_Cruise-Porto_Porto_District_Northern_Portugal.html",
                Latitude = 41.140332m,
                Longitude = -8.613107m,
            }
        };

        public Task<IEnumerable<Attraction>> GetAttractionsForLocation(Guid locationId)
        {
            return Task.FromResult(Data.Where(x => x.LocationId == locationId).ToArray() as IEnumerable<Attraction>);
        }
    }
}
