using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurants.Controllers
{
  public class CuisineController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public CuisineController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurants.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cuisine cuisine)
    {
      _db.Cuisines.Add(cuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Cuisine thisCuisine = _db.Cuisines
        .Include(c => c.Restaurants)
        .FirstOrDefault(c => c.CuisineId == id);
      return View(thisCuisine);
    }
  }
}