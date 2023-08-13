using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion.calculator.entity
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;

    public class TimeAmountSeedData : IEntityTypeConfiguration<TimeAmount>
    {
        public void Configure(EntityTypeBuilder<TimeAmount> builder)
        {
            builder.HasData(
                new TimeAmount { Id = 1, StartTime = TimeSpan.Parse("06:00"), EndTime = TimeSpan.Parse("06:29"), Currency = "SEK", Amount = 8 },
                new TimeAmount { Id = 2, StartTime = TimeSpan.Parse("06:30"), EndTime = TimeSpan.Parse("06:59"), Currency = "SEK", Amount = 13 },
                new TimeAmount { Id = 3, StartTime = TimeSpan.Parse("07:00"), EndTime = TimeSpan.Parse("07:59"), Currency = "SEK", Amount = 18 },
                new TimeAmount { Id = 4, StartTime = TimeSpan.Parse("08:00"), EndTime = TimeSpan.Parse("08:29"), Currency = "SEK", Amount = 13 },
                new TimeAmount { Id = 5, StartTime = TimeSpan.Parse("08:30"), EndTime = TimeSpan.Parse("14:59"), Currency = "SEK", Amount = 8 },
                new TimeAmount { Id = 6, StartTime = TimeSpan.Parse("15:00"), EndTime = TimeSpan.Parse("15:29"), Currency = "SEK", Amount = 13 },
                new TimeAmount { Id = 7, StartTime = TimeSpan.Parse("15:30"), EndTime = TimeSpan.Parse("16:59"), Currency = "SEK", Amount = 18 },
                new TimeAmount { Id = 8, StartTime = TimeSpan.Parse("17:00"), EndTime = TimeSpan.Parse("17:59"), Currency = "SEK", Amount = 13 },
                new TimeAmount { Id = 9, StartTime = TimeSpan.Parse("18:00"), EndTime = TimeSpan.Parse("18:29"), Currency = "SEK", Amount = 8 },
                new TimeAmount { Id = 10, StartTime = TimeSpan.Parse("18:30"), EndTime = TimeSpan.Parse("23:59"), Currency = "SEK", Amount = 0 },
                new TimeAmount { Id = 11, StartTime = TimeSpan.Parse("00:00"), EndTime = TimeSpan.Parse("05:59"), Currency = "SEK", Amount = 0 }
            );
        }
    }
}
