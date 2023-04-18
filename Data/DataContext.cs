using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    DbSet<User> Users {get; set;}
    DbSet<Movie> Movies {get; set;}

    public DataContext(DbContextOptions<DataContext> options) : base(options) {}
    // DbSet<Movie> Movies {get; set;}
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}