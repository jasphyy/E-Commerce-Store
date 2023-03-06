using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Service.Entities.Entities
{
    public class Listings
    { 
        public int ListingId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string? Description { get; set; }
        public string DeliveryMethod { get; set; }
        public bool IsActive { get; set; } = true;
        public string Status { get; set; }
        public DateTimeOffset DateCreated { get; set; }
    }
}