using Microsoft.AspNetCore.Mvc;

namespace BookStore.MVC.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public ViewResult Index()
    {
        return View();
    }
    
    [HttpGet]
    public ViewResult AboutUs()
    {
        return View();
    }
    
    [HttpGet]
    public ViewResult ContactUs()
    {
        return View();
    }
}