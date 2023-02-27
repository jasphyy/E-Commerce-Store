using Ecommerce.Service.DataModel.EntityConfiguration;
using Ecommerce.Service.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace Ecommerce.Service.DataModel;
public class EcommerceDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    public DbSet<Listings> Listings { get; set; }

    public EcommerceDbContext(IConfiguration configuration)
        : base()
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    { 
        base.OnConfiguring(options);
        var connectionString = _configuration["ConnectionStrings:Server"];
        options.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new ListingConfigurationBuilder(typeof(Listings)));
    }
}