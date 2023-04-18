using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio1.Controllers;
public class InfoController : Controller
{
    public IActionResult Informatsia()
    {
        ViewData["Title"] = "kino ismi";
        ViewData["Time"] = "Reiting";
        ViewData["Tir"] = ".00";
        ViewData["Three"] = "что ты думаешь о филме";
        ViewBag.Ganry = "ganry";
        return View();
    }
}