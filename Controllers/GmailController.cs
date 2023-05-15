using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio1.Controllers;

public class GmailController : Controller
{
    public IActionResult Email()
    {
        return View();
    }
}