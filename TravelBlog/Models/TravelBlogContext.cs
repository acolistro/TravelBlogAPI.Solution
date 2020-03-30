using Microsoft.EntityFrameworkCore;

namespace TravelBlog.Models
{
  public class TravelBlogContext : DbContext
  {
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Review> Reviews { get; set; }

    public TravelBlogContext(DbContextOptions<TravelBlogContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Destination>()
      .HasData(
        new Destination { DestinationId = 1, Location = "Oregon", Year = 1859 },
        new Destination { DestinationId = 3, Location = "Washington", Year = 1889},
        new Destination { DestinationId = 4, Location = "Idaho", Year = 1890}
      );
    }
  }

} 