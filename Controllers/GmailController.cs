using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace MyPortfolio1.Controllers;

public class GmailController : Controller
{
    private readonly DataContext dbContext;

    public GmailController(DataContext dataContext)
    {
        this.dbContext = dataContext;
    }


    public IActionResult Register()
    {
        return View();
    } 

    [HttpPost]
    public IActionResult SendRegister(User odam)
    {
        odam.Link = "fbvcb";
        odam.name = "davcvxc";
        dbContext.Users.Add(odam);
        dbContext.SaveChanges();
        
            List<Claim> claims = new List<Claim>()
        { 
            new Claim(ClaimTypes.NameIdentifier, odam.Mail),
            new Claim("OtherProperties","Example Role")
        };

        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        AuthenticationProperties properties = new AuthenticationProperties()
        { 
            AllowRefresh = true,
            IsPersistent = true
        };
        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);
        return RedirectToAction("Index", "User");
    }

    [HttpGet]
        public IActionResult Email()
    {
        return View();
    }
   [HttpPost]
   public IActionResult SendMail (User odam)
   {
    var user = dbContext.Users.FirstOrDefault(t => t.Mail == odam.Mail && t.Password == odam.Password);
   
    List<Claim> claims = new List<Claim>()
    {
        new Claim(ClaimTypes.Email, user.Mail),
        new Claim("FirstName", user.FirstName),
        new Claim("OtherProperties", "Example Role")
    };
            
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        AuthenticationProperties properties = new AuthenticationProperties()
        { 
            AllowRefresh = true,
            IsPersistent = true
        };
        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);
        
       return RedirectToAction("Index", "User");

   }

}