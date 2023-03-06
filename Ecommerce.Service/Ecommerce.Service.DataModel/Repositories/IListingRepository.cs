using Ecommerce.Service.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.DataModel.Repositories;
public interface IListingRepository
{
    Task<IList<Listings>> GetListings();

    Task<int> AddListing(Listings listing);
}
