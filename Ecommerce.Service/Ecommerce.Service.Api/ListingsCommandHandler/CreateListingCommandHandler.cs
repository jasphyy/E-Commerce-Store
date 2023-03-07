using AutoMapper;
using Ecommerce.Service.DataModel.Repositories;
using Ecommerce.Service.Entities.Entities;
using Ecommerce.Service.Entities.Models;
using Ecommerce.Service.Request.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Api.ListingsCommandHandler;
public class CreateListingCommandHandler : IRequestHandler<CreateListingCommand, ListingsModel>
{
    private readonly IListingRepository _listingRepository;
    private readonly IMapper _mapper;

    public CreateListingCommandHandler(
        IListingRepository listingRepository,
        IMapper mapper)
    {
        _listingRepository = listingRepository;
        _mapper = mapper;
    }

    public async Task<ListingsModel> Handle(CreateListingCommand command, CancellationToken cancellationToken)
    {
        var listing = new Listings()
        {
            Name = command.Name,
            Price = command.Price,
            DeliveryMethod = command.DeliveryMethod,
            Description = command.Description,
            Status = command.Status,
        };

        await _listingRepository.AddListing(listing);

        var model = _mapper.Map<Listings, ListingsModel>(listing);
        return model;
    }
}
