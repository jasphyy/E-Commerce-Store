using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Service.Entities.Models;
using MediatR;

namespace Ecommerce.Service.Request.Command;
public class CreateListingCommand : IRequest<ListingsModel>
{
    public CreateListingCommand(string name, float price, string deliveryMethod, string status)
    {
        Name = name;
        Price = price;
        DeliveryMethod = deliveryMethod;
        Status = status;
    }

    public string Name { get; set; }
    public float Price { get; set; }
    public string? Description { get; set; }
    public string DeliveryMethod { get; set; }
    public string Status { get; set; }
}
