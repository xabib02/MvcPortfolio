using Microsoft.AspNetCore.Mvc;

namespace MvcMyPortfolio1.Controllers;

public class UserController : Controller
{
    public IActionResult Kinopoisk()
    {
      User user = new User()
        {
            Id = 1,
            Name = "piter parker",
            Year = 16,
            Country = "sbgfbgfg",
        };

        return View(user);
    }
}