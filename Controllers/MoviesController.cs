using Microsoft.AspNetCore.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
  public class MoviesController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}