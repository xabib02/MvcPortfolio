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
            Name = "Shuxrat",
            PhoneNumber = 30,
            Password = 657456,
        };
         User Botir = new User()
        {
            Id = 2,
            Name = "Botir",
            PhoneNumber = 20,
            Password = 53653765,
        };
          User Xabib = new User()
        {
            Id = 3,
            Name = "Xabib",
            PhoneNumber = 16,
            Password = 345654,
        };
          User Ramzidin = new User()
        {
            Id = 4,
            Name = "Ramzidin",
            PhoneNumber = 1554653,
            Password = 34654,
        };
        
        List<User> users = new List<User>();
          users.Add(Shuxrat);
          users.Add(Botir);
          users.Add(Xabib);
          users.Add(Ramzidin);
          
        return View(users);
    }
    }


