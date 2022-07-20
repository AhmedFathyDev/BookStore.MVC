using BookStore.MVC.Models;

namespace BookStore.MVC.Repositories;

public interface IBookRepository
{
    Task<List<BookModel>> GetAllAsync();
    Task<BookModel?> GetByIdAsync(int id);
    Task<List<BookModel>> SearchAsync(string title, string author);
}