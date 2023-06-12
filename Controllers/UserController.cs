using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace MvcMyPortfolio1.Controllers;

public class UserController : Controller
{
    private readonly DataContext dbContext;

    public UserController(DataContext dataContext)
    {
        this.dbContext = dataContext;
    }


    public IActionResult Create()
    {  
        return View();
    }

    public IActionResult Kinopoisk()
    {
        return View();
    }

    // [Authorize]
    public IActionResult Index()
    {
 
        List<User> users = new List<User>();
  
        users = dbContext.Users.ToList();
        return View(users);
    }

    [HttpPost]
    public IActionResult Store(User odam)
    {
        odam.Password = "5";
        
        odam.Mail = "3";
        odam.LastName = "2";
        odam.FirstName = "1";
        dbContext.Users.Add(odam);
        dbContext.SaveChanges();
        return RedirectToAction("Index");
    }


    [HttpGet]
    [Route("[controller]/[action]/{id}")]
     public IActionResult Edit(int Id)
     {
        var user = dbContext.Users.Find(Id);
        return View(user);
     }

    
    [HttpPost]
     public IActionResult Update(int id, User newUser)
    {
        var oldUser = dbContext.Users.Find(id);

        oldUser.name = newUser.name;
        oldUser.Mail= newUser.Mail;
        oldUser.PhoneNumber = newUser.PhoneNumber;

        dbContext.SaveChanges();
        
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    [Route("[controller]/[action]/{id}")]
    public IActionResult Delete(int id)
    {
        var odam = dbContext.Users.Find(id);
        dbContext.Users.Remove(odam);
        dbContext.SaveChanges();
        return RedirectToAction("Index");
    }
    }


