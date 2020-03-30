using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Models;

namespace TravelBlog.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationsController : ControllerBase
  {
    private TravelBlogContext _db;
    public DestinationsController(TravelBlogContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Destination>> Get()
    {
      return _db.Destinations.ToList();
    }
    [HttpPost]
    public void Post([FromBody] Destination destination)
    {
      _db.Destinations.Add(destination);
      _db.SaveChanges();
    }
  }
}