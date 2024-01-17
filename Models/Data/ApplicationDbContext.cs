using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace Models.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>().HasData(
            new Country
            {
                Id = 1,
                Name = "Iran"
            },
            new Country
            {
                Id = 2,
                Name = "France"
            },
            new Country
            {
                Id = 3,
                Name = "US"
            }
        );

        modelBuilder.Entity<City>().HasData(
            new City
            {
                Id = 1,
                Name = "Tehran",
                CountryId = 1
            },
            new City
            {
                Id = 2,
                Name = "Shiraz",
                CountryId = 1
            },
            new City
            {
                Id = 3,
                Name = "Tabriz",
                CountryId = 1
            },
            new City
            {
                Id = 4,
                Name = "Paris",
                CountryId = 2
            },
            new City
            {
                Id = 5,
                Name = "Lyon",
                CountryId = 2
            },
            new City
            {
                Id = 6,
                Name = "NewYork",
                CountryId = 3
            },
            new City
            {
                Id = 7,
                Name = "Washington DC",
                CountryId = 3
            }
        );
    }
}
