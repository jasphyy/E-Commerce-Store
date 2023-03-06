using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Request.Request;
public class CreateListingRequest
{
    public CreateListingRequest(string name, float price, string? description, string deliveryMethod, string status)
    {
        Name = name;
        Price = price;
        Description = description;
        DeliveryMethod = deliveryMethod;
        Status = status;
    }

    public string Name { get; set; }
    public float Price { get; set; }
    public string? Description { get; set; }
    public string DeliveryMethod { get; set; }
    public string Status { get; set; }
}