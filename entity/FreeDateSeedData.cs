using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion.calculator.entity
{
    public class FreeDateSeedData: IEntityTypeConfiguration<FreeDate>
    {
        public void Configure(EntityTypeBuilder<FreeDate> builder)
        {

            List<FreeDate> seedData = new List<FreeDate>
    {
        new FreeDate { Id = 1, Date = new DateTime(2013, 1, 1) },
        new FreeDate { Id = 2, Date = new DateTime(2013, 3, 28) },
        new FreeDate { Id = 3, Date = new DateTime(2013, 3, 29) },
        new FreeDate { Id = 4, Date = new DateTime(2013, 4, 1) },
        new FreeDate { Id = 5, Date = new DateTime(2013, 4, 29) },
        new FreeDate { Id = 6, Date = new DateTime(2013, 5, 1) },
        new FreeDate { Id = 7, Date = new DateTime(2013, 5, 8) },
        new FreeDate { Id = 8, Date = new DateTime(2013, 5, 9) },
        new FreeDate { Id = 9, Date = new DateTime(2013, 6, 5) },
        new FreeDate { Id = 10, Date = new DateTime(2013, 6, 6) },
        new FreeDate { Id = 11, Date = new DateTime(2013, 6, 21) },
        new FreeDate { Id = 12, Date = new DateTime(2013, 11, 1) },
        new FreeDate { Id = 13, Date = new DateTime(2013, 12, 24) },
        new FreeDate { Id = 14, Date = new DateTime(2013, 12, 25) },
        new FreeDate { Id = 15, Date = new DateTime(2013, 12, 26) },
        new FreeDate { Id = 16, Date = new DateTime(2013, 12, 31) }
    };

            builder.HasData(seedData);
        }
    }
}
