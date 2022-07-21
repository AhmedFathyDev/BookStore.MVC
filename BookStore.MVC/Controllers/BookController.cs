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
    public async Task<ViewResult> GetAll()
    {
        return View(await _bookRepository.GetAllAsync());
    }

    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
        var book = await _bookRepository.GetByIdAsync(id);
        return book is null ? NotFound() : Ok(book);
    }

    [HttpGet]
    public async Task<IActionResult> Search(string title, string author)
    {
        return Ok(await _bookRepository.SearchAsync(title, author));
    }
}