using System;
using Microsoft.EntityFrameworkCore;
using WebApiCore.Data.Models;

namespace WebApiCore.Data.Context
{
    public class WebApiCoreContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        public DbSet<CurrentWeather> Weathers { get; set; }

        public WebApiCoreContext(DbContextOptions<WebApiCoreContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder moduleBuilder)
        {
            moduleBuilder.Entity<Customer>().HasData(new Customer {Id = Guid.NewGuid(), Name="Nick", BirtDate = new DateTime(2000, 01 , 01)});
            moduleBuilder.Entity<Customer>().HasData(new Customer {Id = Guid.NewGuid(), Name="Nick", BirtDate = new DateTime(1998, 01 , 01)});
        }

    }
}