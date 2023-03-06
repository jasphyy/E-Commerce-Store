using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Entities.Models;
public class ListingsModel
{
    public int ListingId { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
    public string Description { get; set; }
    public string DeliveryMethod { get; set; }
    public bool IsActive { get; set; }
    public string Status { get; set; }
    public DateTimeOffset DateCreated { get; set; }
}
