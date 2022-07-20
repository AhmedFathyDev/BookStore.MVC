using BookStore.MVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.MVC.Controllers;

public class BookController : Controller
{
    private readonly IBookRepository _bookRepository;
    
    public BookController(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }
    
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return Ok(await _bookRepository.GetAllAsync());
    }

    [HttpGet]
    public async Task<IActionResult> Index(int id)
    {
        var book = await _bookRepository.GetByIdAsync(id);
        return book is null ? NotFound() : Ok(book);
    }
}