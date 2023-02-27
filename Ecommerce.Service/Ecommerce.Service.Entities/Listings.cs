namespace Ecommerce.Service.Entities
{
    public class Listings
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Name { get; set; }
        public string? Price { get; set; }
    }
}