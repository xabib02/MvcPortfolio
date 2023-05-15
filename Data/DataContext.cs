using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
   public DbSet<User> Users {get; set;}
   public DbSet<Movie> Movies {get; set;}

    public DataContext(DbContextOptions<DataContext> options) : base(options) {}
    // DbSet<Movie> Movies {get; set;} //olish kerak
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}