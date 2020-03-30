using Microsoft.EntityFrameworkCore;

namespace TravelBlog.Models
{
  public class TravelBlogContext : DbContext
  {
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Review> Reviews { get; set; }

    public TravelBlogContext(DbContextOptions<TravelBlogContext> options) : base(options) { }
  }
}