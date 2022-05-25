namespace InADay.Models.Locations
{
    public class Location
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public LocationStatus Status { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }
}