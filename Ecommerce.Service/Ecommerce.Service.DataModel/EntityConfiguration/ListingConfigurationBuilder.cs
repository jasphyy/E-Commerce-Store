using Ecommerce.Service.Entities.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.DataModel.EntityConfiguration
{
    internal class ListingConfigurationBuilder : BaseConfigurationBuilder<Listings>
    {
        public ListingConfigurationBuilder(Type valueGeneratorType)
            : base(valueGeneratorType)
        {
        }
        public override void Configure(EntityTypeBuilder<Listings> builder)
        {
            builder
                .Property(x => x.ListingId)
                .IsRequired();

            builder
                .Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired();

            builder
                .Property(x => x.Price)
                .IsRequired();

            builder
                .Property(x => x.Description)
                .HasMaxLength(255);

            builder
                .Property(x => x.DeliveryMethod)
                .IsRequired();

            builder
                .Property(x => x.IsActive)
                .IsRequired();

            builder 
                .Property(x => x.Status)
                .IsRequired();

            builder
                .Property(x => x.DateCreated)
                .HasValueGenerator<DateTimeOffsetValueGenerator>()
                .ValueGeneratedOnAdd();

            builder
                .HasKey(x => x.ListingId);
        }
    }
}
