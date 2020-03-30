using System.Collections.Generic;

namespace TravelBlog.Models
{
  public class Destination
  {
   public int DestinationId { get; set; }
   public string Location { get; set; }
   public int Year { get; set; }
   public virtual ICollection<Review> Reviews { get; }
  }
}