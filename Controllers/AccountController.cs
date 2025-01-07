using Microsoft.AspNetCore.Mvc;
using myapp.Models;

using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MyApp.Models;

public class AccountController : Controller
{
    private readonly CommerceContext _context;

    public AccountController(CommerceContext context)
    {
        _context = context;
    }


    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(RegisterModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        
        var existingUser = _context.Users.FirstOrDefault(u => u.Email == model.Email);
        if (existingUser != null)
        {
            ModelState.AddModelError("", "Email is already registered.");
            return View(model);
        }

      
        var user = new User
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            PasswordHash = model.Password 
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        ViewBag.Message = "Registration successful!";
        return RedirectToAction("Login");
    }

    
    public IActionResult Login()
    {
        return View();
    }

   
    [HttpPost]
    public IActionResult Login(LoginModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var user = _context.Users.FirstOrDefault(u => u.Email == model.Email && u.PasswordHash == model.Password);
        if (user == null)
        {
            ModelState.AddModelError("", "Invalid email or password.");
            return View(model);
        }

        return RedirectToAction("Index", "Home");
    }
}