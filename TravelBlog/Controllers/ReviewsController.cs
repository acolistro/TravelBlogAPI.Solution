using Microsoft.AspNetCore.Mvc;
using TravelBlog.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System; 

namespace TravelBlog.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsController : Controller
  {
    private readonly TravelBlogContext _db;

    public ReviewsController(TravelBlogContext db)
    {
      _db = db;
    } 

    [HttpGet]
    public ActionResult<ICollection<Review>> Get(int destinationId, string title, int rating)
    {
      var query = _db.Reviews.AsQueryable();

      if (destinationId != 0)
      {
        query = query.Where(entry => entry.DestinationId == destinationId);
      }

      if (title != null)
      {
        query = query.Where(entry => entry.Title == title);
      }

      // if (description != null)
      // {
      //   query = query.Where(entry => entry.Description.Contains ;
      // }

      if (rating != 0)
      {
        query = query.Where(entry => entry.Rating == rating);
      }
      
      return query.ToList();
    }
    public ActionResult Index()
    {
      return View();
    }
    
    public ActionResult Create()
    {
      ViewBag.DestinationId = new SelectList(_db.Destinations, "DestinationId", "Location");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}