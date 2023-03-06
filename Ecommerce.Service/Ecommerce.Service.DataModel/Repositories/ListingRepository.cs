using Ecommerce.Service.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.DataModel.Repositories;
public class ListingRepository : IListingRepository
{
    private readonly EcommerceDbContext _dbcontext;

    public ListingRepository(EcommerceDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public async Task<IList<Listings>> GetListings()
    {
        return await _dbcontext.Listings.ToListAsync();    
    }

    public async Task<int> AddListing(Listings listings) 
    { 
        _dbcontext.Listings.Add(listings);
        return await _dbcontext.SaveChangesAsync();
    }
}
