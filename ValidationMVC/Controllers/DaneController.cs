using Microsoft.AspNetCore.Mvc;
using ValidationMVC.Models;

namespace ValidationMVC.Controllers;

public class DaneController : Controller
{
    [HttpGet]
    public IActionResult Form()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Form(Dane dane)
    {
        if(ModelState.IsValid)
        {
            return View("Wynik", dane);
        }
        return View("Wynik", dane);
    }
    
    public IActionResult Wynik(Dane dane)
    {

        return View(dane);
    }
}