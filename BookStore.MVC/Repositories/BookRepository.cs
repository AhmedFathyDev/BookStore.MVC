using BookStore.MVC.Database;
using BookStore.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.MVC.Repositories;

public class BookRepository : IBookRepository
{
    private readonly BookStoreContext _bookStoreContext;
    
    public BookRepository(BookStoreContext bookStoreContext)
    {
        _bookStoreContext = bookStoreContext;
    }

    public async Task<List<BookModel>> GetAllAsync()
    {
        return await _bookStoreContext.Books.AsNoTracking().ToListAsync();
    }

    public async Task<BookModel?> GetByIdAsync(int id)
    {
        return await _bookStoreContext.Books.AsNoTracking().SingleOrDefaultAsync(book => book.Id == id);
    }

    public async Task<List<BookModel>> SearchAsync(string title, string author)
    {
        return await _bookStoreContext.Books.AsNoTracking()
            .Where(book => book.Title.Contains(title) && book.Author.Contains(author)).ToListAsync();
    }
}