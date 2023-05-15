using Microsoft.AspNetCore.Mvc;

namespace MvcMyPortfolio1.Controllers;

public class UserController : Controller
{
    public IActionResult Kinopoisk()
    {
   return View();
    }

    public IActionResult User()
    {
            User Shuxrat = new User()
        {
            Id = 1,
            name = "Shuxrat",
            PhoneNumber = 30,
            Password = 657456,
            Link = "https://ru.wikipedia.org/wiki/Шухрат"
        };
         User Botir = new User()
        {
            Id = 2,
            name = "Botir",
            PhoneNumber = 20,
            Password = 53653765,
            Link = "https://uz.wikipedia.org/wiki/Botir_Qodirov"
        };
          User Xabib = new User()
        {
            Id = 3,
            name = "Xabib",
            PhoneNumber = 16,
            Password = 345654,
            Link = "https://uz.wikipedia.org/wiki/Xabib_Nurmagomedov"
        };
          User Ramzidin = new User()
        {
            Id = 4,
            name = "Ramzidin",
            PhoneNumber = 1554653,
            Password = 34654,
            Link = "https://uz.wikipedia.org/wiki/Ramziddin_Saidov"
        };
        
        List<User> users = new List<User>();
          users.Add(Shuxrat);
          users.Add(Botir);
          users.Add(Xabib);
          users.Add(Ramzidin);
          
        return View(users);
    }
    }


