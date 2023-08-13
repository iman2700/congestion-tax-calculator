using congestion.calculator.entity;
using Microsoft.EntityFrameworkCore;
using System;

public class TimeAmountDbContext : DbContext
{
    public DbSet<TimeAmount> TimeAmounts { get; set; }
    public DbSet<FreeDate> FreeDates { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Configure the database connection (replace with your connection string)
            optionsBuilder.UseSqlServer("Server=.;Database=CongestionTax;Trusted_Connection=True;\r\n");
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new TimeAmountSeedData());
        modelBuilder.ApplyConfiguration(new FreeDateSeedData());
    }

     


}
