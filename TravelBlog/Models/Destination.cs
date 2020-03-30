using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelBlog.Models
{
  public class Destination
  {
   public int DestinationId { get; set; }
   [Required]
   public string Location { get; set; }
   [Required]
   public int Year { get; set; }
   [Required]
   public virtual ICollection<Review> Reviews { get; set; }
  }
}