using Microsoft.EntityFrameworkCore;
using TestePaulo.Models;

namespace TestePaulo.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(
                "User Id=postgres; Password=8481; Host=localhost; Port=5432; Database=dbpaulo"
                );
                
        }
    }
    
    public DbSet<Item> Items { get;  }
    public DbSet<User> Users { get;  }
}