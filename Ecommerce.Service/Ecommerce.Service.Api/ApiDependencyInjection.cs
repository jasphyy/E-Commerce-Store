using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Service.Request.Command;
using System.Reflection;


namespace Ecommerce.Service.Api;
public static class ApiDependencyInjection
{
    public static IServiceCollection ApiConfigureServices(this IServiceCollection services)
    {
        services.AddMediatR(typeof(ApiDependencyInjection).Assembly);

        return services;
    }
}
