using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Ecommerce.Service.Request;
using Ecommerce.Service.Request.Command;
using Ecommerce.Service.DataModel.Repositories;
using Ecommerce.Service.Entities.Entities;
using Ecommerce.Service.Entities.Models;

namespace Ecommerce.Service.Api.ListingsCommandHandler;
public class GetAllListingCommandHandler : IRequestHandler<GetAllListingCommand, IList<ListingsModel>>
{
    private readonly IListingRepository _listingRepository;
    private readonly IMapper _mapper;

    public GetAllListingCommandHandler(
        IListingRepository listingRepository,
        IMapper mapper) 
    { 
        _listingRepository = listingRepository;
        _mapper = mapper;
    }

    public async Task<IList<ListingsModel>> Handle(GetAllListingCommand command, CancellationToken cancellationToken)
    {
        var listings = await _listingRepository.GetListings();
        var model = _mapper.Map<IList<Listings>, IList<ListingsModel>>(listings);
        return model;
    }
}
