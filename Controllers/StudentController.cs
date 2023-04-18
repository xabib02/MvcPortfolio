using Microsoft.AspNetCore.Mvc;

namespace MvcMyPortfolio.Controllers;

public class StudentController : Controller 
{
    public IActionResult Index()
    {
        return View();
    }
}