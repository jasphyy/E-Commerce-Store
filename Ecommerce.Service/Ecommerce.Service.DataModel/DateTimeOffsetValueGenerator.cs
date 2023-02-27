using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Ecommerce.Service.DataModel
{
    public class DateTimeOffsetValueGenerator : ValueGenerator<DateTimeOffset>
    {
        public override bool GeneratesTemporaryValues => false;

        public override DateTimeOffset Next(EntityEntry entry)
        {
            if (entry is null)
            {
                throw new ArgumentNullException(nameof(entry));
            }

            return DateTimeOffset.UtcNow;
        }
    }
}
