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
    }
}
