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
        new Destination { DestinationId = 6, Location = "Oregon", Year = 1859 },
        new Destination { DestinationId = 7, Location = "Washington", Year = 1889},
        new Destination { DestinationId = 8, Location = "Idaho", Year = 1890}
      );
      builder.Entity<Review>()
      .HasData(
        new Review { ReviewId = 1, DestinationId = 6, Title = "Oregon", Description = "It was wonderful", Rating = 5 },
        new Review { ReviewId = 2, DestinationId = 7, Title = "Washington", Description = "It was wonderful", Rating = 4},
        new Review { ReviewId = 3, DestinationId = 8, Title = "Idaho",  Description = "It was wonderful", Rating = 3}
      );
    }
  }

} 