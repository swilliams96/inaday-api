using InADay.Api.Repositories.Attractions;
using InADay.Api.Repositories.Locations;
using InADay.Api.Services.Locations;
using InADay.Models.Attractions;
using InADay.Models.Locations;
using Moq;

namespace InADay.Api.UnitTests.Services
{
    public class LocationServiceTests
    {
        private readonly Mock<ILocationRepository> _mockLocationRepository = new();
        private readonly Mock<IAttractionRepository> _mockAttractionRepository = new();

        private readonly LocationService _sut;

        public LocationServiceTests()
        {
            _sut = new LocationService(_mockLocationRepository.Object, _mockAttractionRepository.Object);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(5)]
        public async Task GetActiveLocations_LocationRepositoryResultsAreReturnedDirectly(int locationsCount)
        {
            // Arrange
            var locations = Enumerable.Range(0, locationsCount).Select(x => new Location() { Id = Guid.NewGuid() }).ToList();

            _mockLocationRepository.Setup(x => x.GetActiveLocations())
                .ReturnsAsync(locations);

            // Act
            var result = await _sut.GetActiveLocations();

            // Assert
            result.Should().HaveCount(locations.Count);
            result.Should().Equal(locations);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(5)]
        public async Task GetAttractionsForLocation_AttractionRepositoryResultsAreReturnedDirectly(int attractionsCount)
        {
            // Arrange
            Guid locationId = Guid.NewGuid();

            var attractions = Enumerable.Range(0, attractionsCount).Select(x => new Attraction() { Id = Guid.NewGuid() }).ToList();

            _mockAttractionRepository.Setup(x => x.GetAttractionsForLocation(locationId))
                .ReturnsAsync(attractions);

            // Act
            var result = await _sut.GetAttractionsForLocation(locationId);

            // Assert
            result.Should().HaveCount(attractions.Count);
            result.Should().Equal(attractions);
        }
    }
}
