namespace InADay.Models.Attractions
{
    public class Attraction
    {
        public Guid Id { get; set; }

        public Guid LocationId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public AttractionType Type { get; set; }

        public decimal Price { get; set; }

        public string? PriceCurrency { get; set; }

        public PriceType PriceType { get; set; }

        public string? BookingUrl { get; set; }

        public TimeSpan? Duration { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }
}
