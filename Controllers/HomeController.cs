using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMyPortfolio.Models;

namespace MvcMyPortfolio.Controllers;

public class HomeController : Controller
{
    private HttpContext httpContext;

     

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["user"] = HttpContext.Request.Headers.UserAgent.ToString();
        ViewData["ip"] = HttpContext.Connection.RemoteIpAddress.ToString(); 
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
