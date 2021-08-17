using Cinema.Data;
using Cinema.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
  public class MoviesController : Controller
  {

    private readonly ApplicationDbContext _db;

    public MoviesController(ApplicationDbContext db)
    {
      _db = db;
    }

    public IActionResult Index()
    {
      IEnumerable<Movie> objList = _db.Movies;
      return View(objList);
    }

    // GET Add
    public IActionResult Add()
    {
      return View();
    }

    // POST Add
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Add(Movie obj)
    {
      _db.Movies.Add(obj);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}