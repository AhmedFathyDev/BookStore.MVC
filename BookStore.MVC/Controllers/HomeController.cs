using Microsoft.AspNetCore.Mvc;

namespace BookStore.MVC.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public string Index()
    {
        return "Hello, World!";
    }
}