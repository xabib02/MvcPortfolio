using Microsoft.AspNetCore.Mvc;

namespace MvcMyPortfolio1.Controllers;

public class MovieController : Controller
{
    public IActionResult Kino()
    {
        return View();
    }
}