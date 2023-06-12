using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio1.Controllers;

public class GenreController : Controller
{
 private readonly DataContext dbContext;

    public GenreController(DataContext dataContext)
    {
        this.dbContext = dataContext;
    }
     public IActionResult Create()
     {
        return View();
     }

       public IActionResult Index()
    {
        List<Genre> genres = new List<Genre>();
         genres = dbContext.Genres.ToList();
        return View(genres);
    } 
        [HttpGet]
    [Route("[controller]/[action]/{id}")]
     public IActionResult Edit(int Id)
     {
        var genre = dbContext.Genres.Find(Id);
        return View(genre);
     }

    
    [HttpPost]
     public IActionResult Update(int id, Genre newGenre)
    {
        var oldGenre = dbContext.Genres.Find(id);

        oldGenre.Name = newGenre.Name;
        dbContext.SaveChanges();
        
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Store(Genre genre)
    {
        dbContext.Genres.Add(genre);
        dbContext.SaveChanges();
        return RedirectToAction("Index");
    }
    
    [Route("[controller]/[action]/{Id}")]
    public IActionResult Delete(int Id)
    {
        var genre = dbContext.Genres.Find(Id);
        dbContext.Genres.Remove(genre);
        dbContext.SaveChanges();
        return RedirectToAction("Index");
    }
}




