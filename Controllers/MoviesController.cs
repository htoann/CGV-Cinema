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

    public IActionResult Detail(int id)
    {
      if(id == null || id == 0) {
        return NotFound();
      }
      var obj = _db.Movies.Find(id);
      return View(obj);
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

    // GET Update
    public IActionResult Update(int id)
    {
      if(id == null || id == 0) {
        return NotFound();
      }
      var obj = _db.Movies.Find(id);
      return View(obj);
    }

    // POST Update
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Update(Movie obj)
    {
      _db.Movies.Update(obj);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // POST Delete
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(Movie obj)
    {
      _db.Movies.Remove(obj);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}