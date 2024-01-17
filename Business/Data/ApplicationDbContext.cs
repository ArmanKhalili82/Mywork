using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyProject.Models;

namespace MyProject.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
        
    }
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    IConfigurationRoot configuration = new ConfigurationBuilder()
    //        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    //        .AddJsonFile("appsettings.json")
    //        .Build();
    //    optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    //}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;DataBase=InfoTable;Encrypt=False;Integrated Security=True", 
            Options => Options.EnableRetryOnFailure());
    }

    public DbSet<Info> infos { get; set; }
    //public DbSet<InfoDetails> details { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Info>().HasData(
            new Info
            {
                Id = 1,
                Name = "Iran"
            },

            new Info
            {
                Id = 2,
                Name = "France"
            }
        );

        //modelBuilder.Entity<InfoDetails>().HasData(
        //    new InfoDetails
        //    {
        //        Id = 1,
        //        Title = "Tehran",
        //        Info = new Info { Id = 1, Name = "Iran" }
        //    },

        //    new InfoDetails
        //    {
        //        Id = 2,
        //        Title = "Paris",
        //        Info = new Info { Id = 2, Name = "France" }
        //    }
        //);
    }
}
