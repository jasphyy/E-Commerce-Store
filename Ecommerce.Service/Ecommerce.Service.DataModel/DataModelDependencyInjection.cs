using Ecommerce.Service.DataModel.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ecommerce.Service.DataModel;

public static class DataModelDependencyInjection
{
    public static IServiceCollection DataModelConfigureServices(this IServiceCollection services)  
    {
        services.AddDbContext<EcommerceDbContext>(
            options => options.UseSqlServer("name=ConnectionStrings:Server"));

        services.AddTransient<IListingRepository, ListingRepository>();

        return services;
    }
}

