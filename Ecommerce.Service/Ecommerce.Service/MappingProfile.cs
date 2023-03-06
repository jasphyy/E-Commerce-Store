using AutoMapper;
using Ecommerce.Service.Entities;
using Ecommerce.Service.Entities.Entities;
using Ecommerce.Service.Entities.Models;

namespace Ecommerce.Service.Main;
public class MappingProfile : Profile
{
    public MappingProfile() 
    {
        CreateMap<Listings, ListingsModel>();
    }
}
