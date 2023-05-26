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

    public IActionResult Email()
    {
        return View();
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
}