using InADay.Models.Attractions;

namespace InADay.Api.Repositories.Attractions
{
    public interface IAttractionRepository
    {
        public Task<IEnumerable<Attraction>> GetAttractionsForLocation(Guid locationId);
    }
}
