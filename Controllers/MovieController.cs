using Microsoft.AspNetCore.Mvc;

namespace MvcMyPortfolio1.Controllers;

public class MovieController : Controller
{
private readonly DataContext dbContext;
    
     public MovieController(DataContext dataContext)
     { 
        this.dbContext = dataContext;
     }
    public IActionResult Kino()
    {
        return View();
    }

       public IActionResult Index()
    {
        List<Movie> movies = new List<Movie>();
         movies = dbContext.Movies.ToList();
        return View(movies);
    } 

     

  public IActionResult Create()
    {  
        return View();
    }

    [HttpPost]
    public IActionResult Store(Movie movie)
    {
        dbContext.Movies.Add(movie);
        dbContext.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpGet]
    [Route("[controller]/[action]/{id}")]
    public IActionResult Delete(int id)
    {
        var movie = dbContext.Movies.Find(id);
        dbContext.Movies.Remove(movie);
        dbContext.SaveChanges();
        return RedirectToAction("Index");
    }
}