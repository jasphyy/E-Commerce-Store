using Ecommerce.Service.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.DataModel.EntityConfiguration
{
    public class BaseConfigurationBuilder<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : class
    {
        public BaseConfigurationBuilder()
        {
        }

        public BaseConfigurationBuilder(Type valueGeneratorType) => ValueGeneratorType = valueGeneratorType;

        public BaseConfigurationBuilder(Type valueGeneratorType, IConfiguration configuration)
        {
            ValueGeneratorType = valueGeneratorType;
        }

        public Type ValueGeneratorType { get; }

        public virtual void Configure(EntityTypeBuilder<TEntity> builder) => throw new NotImplementedException();
    }
}
