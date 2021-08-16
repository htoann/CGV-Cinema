using Microsoft.AspNetCore.Mvc;
using Cinema.Data;
using Cinema.Models;

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

    public IActionResult Add()
    {
      return View();
    }
  }
}