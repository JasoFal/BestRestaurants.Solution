using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurants.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public RestaurantsController(BestRestaurantsContext db)
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

    public ActionResult Create(Restaurant restaurant)
    {
      if (restaurant.CuisineId == 0)
      {
        return RedirectToAction("Create");
      }
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Restaurant thisRestaurant = _db.Restaurants
        .Include(r => r.Cuisine)
        .FirstOrDefault(r => r.RestaurantId == id);
      return View(thisRestaurant);
    }
  }
}