using Microsoft.AspNetCore.Mvc;

namespace Cinema.Controllers;

public class AboutController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
}
