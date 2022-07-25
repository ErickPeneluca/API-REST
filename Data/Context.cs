using Microsoft.EntityFrameworkCore;
using TestePaulo.Models;

namespace TestePaulo.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<User> Users { get; set; }
}