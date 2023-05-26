using Microsoft.AspNetCore.Mvc;

namespace MvcMyPortfolio1.Controllers;

public class UserController : Controller
{
    private readonly DataContext dbContext;

    public UserController(DataContext dataContext)
    {
        this.dbContext = dataContext;
    }


    public IActionResult Kinopoisk()
    {
   return View();
    }

    public IActionResult Index()
    {
 
        List<User> users = new List<User>();
  
        users = dbContext.Users.ToList();
        return View(users);
    }
      [HttpPost]
    public IActionResult Store(User odam)
    {
        odam.Link = "fbvcb";
        odam.name = "davcvxc";
        dbContext.Users.Add(odam);
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


