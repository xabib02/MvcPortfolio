using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio1.Controllers;

public class ActorController : Controller
{
    private readonly DataContext dbContext;
    public ActorController(DataContext dataContext)
    {
        this.dbContext = dataContext;
    }

    public IActionResult Index()
    {
        List<Actor> actors = new List<Actor>();
         actors = dbContext.Actors.ToList();
        return View(actors);
    } 

    [HttpGet]
    public IActionResult Create()
    {
    return View();
    }

    [HttpGet]
    [Route("[controller]/[action]/{id}")]
    public IActionResult Edit(int Id)
    {
        var actor = dbContext.Actors.Find(Id);
        return View(actor);
    }
    
    [HttpPost]
    public IActionResult Update(int id, Actor newActor)
    {
        var oldActor = dbContext.Actors.Find(id);

        oldActor.Name = newActor.Name;
        dbContext.SaveChanges();
        
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Store(Actor actor)
    {
        dbContext.Actors.Add(actor);
        dbContext.SaveChanges();
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    [Route("[controller]/[action]/{Id}")]
    public IActionResult Delete(int Id)
    {
        var actor = dbContext.Actors.Find(Id);
        dbContext.Actors.Remove(actor);
        dbContext.SaveChanges();
        return RedirectToAction("Index");
    }
}
